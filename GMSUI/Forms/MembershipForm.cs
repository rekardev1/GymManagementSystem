using GMSDataAccess.DataAccess;
using GMSDataAccess.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMSUI.Forms;
public partial class MembershipForm : Form {

    private SqlConnector _sqlConnector = new SqlConnector();
    private List<EmployeeModel> _trainers = new List<EmployeeModel>();
    private List<MembershipTypeModel> _membershipTypes = new List<MembershipTypeModel>();
    private List<MembershipModel> _memberships = new List<MembershipModel>();
    private DataGridViewRow _selectedRow;
    private readonly ShellForm _shell;

    public MembershipForm(ShellForm shell) {
        InitializeComponent();

        StartingDatePicker.Format = DateTimePickerFormat.Custom;
        StartingDatePicker.CustomFormat = "dd/MM/yyyy";
        StartingDatePicker.Value = DateTime.Today;

        ExpirationDatePicker.Format = DateTimePickerFormat.Custom;
        ExpirationDatePicker.CustomFormat = "dd/MM/yyyy";
        ExpirationDatePicker.Value = DateTime.Today.AddDays(30);
        _shell = shell;
    }

    override protected async void OnLoad(EventArgs e) {

        await LoadTrainers();

        await LoadMembershipTypes();

        await LoadMembers();

        await LoadMemberships();
    }

    private async Task LoadMemberships() {

        _memberships = await _sqlConnector.GetMemberships();

        MembershipsDataGridView.Rows.Clear();

        foreach (var membership in _memberships) {
            MembershipsDataGridView.Rows.Add(
                membership.Id,
                membership.MemberId,
                membership.MemberName,
                GetNames(membership.Trainers),
                membership.MembershipTypeId,
                membership.MembershipTypeName,
                membership.StartingDate,
                membership.ExpirationDate,
                membership.UserName);
        }

        MembershipsDataGridView.ClearSelection();

    }

    private string GetNames(List<EmployeeModel> model) {

        List<string> names = new List<string>();

        foreach (var m in model) {
            names.Add(m.Name);
        }

        StringBuilder sb = new StringBuilder();

        sb.AppendJoin(", ", names);

        return sb.ToString();
    }

    private async Task LoadMembershipTypes() {

        _membershipTypes = await _sqlConnector.GetMembershipTypes();
        MembershipTypeComboBox.DataSource = _membershipTypes;
        MembershipTypeComboBox.DisplayMember = "Display";

    }
    private async Task LoadMembers() {


    }

    private async Task LoadTrainers() {

        _trainers = await _sqlConnector.GetTrainers();

        TrainersCheckedListBox.DisplayMember = "Display";
        TrainersCheckedListBox.Items.Clear();

        foreach (var t in _trainers) {
            TrainersCheckedListBox.Items.Add(t);
        }

    }

    private async void AddButton_Click(object sender, EventArgs e) {
        
        AddMembershipForm addMembershipForm = new AddMembershipForm(_shell);
        addMembershipForm.ShowDialog();

        await ResetForm();

    }

    private async Task ResetForm() {

        for (int i = 0; i < TrainersCheckedListBox.Items.Count; i++) {
            TrainersCheckedListBox.SetItemChecked(i, false);
        }

        StartingDatePicker.Value = DateTime.Today;
        ExpirationDatePicker.Value = DateTime.Today.AddDays(30);

        
        _selectedRow = null;

        await LoadMemberships();
    }

    

    private void MembershipsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
        
        if (e.RowIndex < 0) {
            return;
        }

        _selectedRow = MembershipsDataGridView.Rows[e.RowIndex];

        MembershipTypeComboBox.Text = _selectedRow.Cells[2].Value.ToString();

        MemberNameTextBox.Text= _selectedRow.Cells[2].Value.ToString();

        MembershipTypeComboBox.Text = _selectedRow.Cells[5].Value.ToString();

        string[] names = _selectedRow.Cells[3].Value.ToString().Split(',').Select(p => p.Trim()).Where(p => !string.IsNullOrWhiteSpace(p)).ToArray();

        for (int i = 0; i < TrainersCheckedListBox.Items.Count; i++) {
            TrainersCheckedListBox.SetItemChecked(i, false);
        }

        foreach (var n in names) {

            int index = TrainersCheckedListBox.Items.IndexOf(_trainers.FirstOrDefault(x => x.Name == n));

            if (index != -1) {
                TrainersCheckedListBox.SetItemChecked(index, true);
            }
        }

        StartingDatePicker.Value = (DateTime)_selectedRow.Cells[6].Value;
        ExpirationDatePicker.Value = (DateTime)_selectedRow.Cells[7].Value;

    }

    private bool ValidateForm() {
        bool output = true;

        if (string.IsNullOrEmpty(MemberNameTextBox.Text)) {
            output = false;

        } else if (TrainersCheckedListBox.CheckedItems.Count == 0 ) {
            output = false;

        } else if (ExpirationDatePicker.Value < DateTime.Today) {
            output = false;

        }

        return output;
    }

    private async void UpdateButton_Click(object sender, EventArgs e) {
        
        if (_selectedRow == null) {
            MessageBox.Show("Please Select a row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!ValidateForm()) {
            MessageBox.Show("Please enter all required information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        MembershipModel model = new MembershipModel();

        model.Id = int.Parse(_selectedRow.Cells[0].Value.ToString());
        model.MembershipTypeId = _membershipTypes.Where(x => x.Display == MembershipTypeComboBox.Text).First().Id;

        model.StartingDate = StartingDatePicker.Value;
        model.ExpirationDate = ExpirationDatePicker.Value;

        var trainers = TrainersCheckedListBox.CheckedItems;

        foreach (var t in trainers) {
            model.Trainers.Add((EmployeeModel)t);
        }



        try {
            await _sqlConnector.UpdateMembership(model);

        } catch (Exception ex) {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        await ResetForm();
    }

    private void TrainersCheckedListBox_Leave(object sender, EventArgs e) {
        TrainersCheckedListBox.ClearSelected();
    }

    private void HomeButton_Click(object sender, EventArgs e) {
        _shell.OpenHomeForm();
    }
}
