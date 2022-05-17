using DGVPrinterHelper;
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
    private List<PlanModel> _plans = new List<PlanModel>();
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

        await LoadPlans();

        await LoadMemberships("All");
    }

    private async Task LoadMemberships(string fetchType) {

        _memberships = await _sqlConnector.GetMemberships(fetchType);

        MembershipsDataGridView.Rows.Clear();

        foreach (var membership in _memberships) {
            
            MembershipsDataGridView.Rows.Add(
                membership.Id,
                membership.MemberId,
                membership.MemberName,
                GetNames(membership.Trainers),
                membership.PlanId,
                membership.PlanName,
                membership.StartingDate,
                membership.ExpirationDate,
                membership.IsExpired ? "Yes" : "No",
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

    private async Task LoadPlans() {

        _plans = await _sqlConnector.GetPlans();
        PlansComboBox.DataSource = _plans;
        PlansComboBox.DisplayMember = "Display";

    }

    private async Task LoadTrainers() {

        _trainers = await _sqlConnector.GetEmployees("Trainer");

        TrainersCheckedListBox.DisplayMember = "Name";
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

        await LoadMemberships(FetchType());
    }

    private void MembershipsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {

        if (e.RowIndex < 0) {
            return;
        }

        _selectedRow = MembershipsDataGridView.Rows[e.RowIndex];

        PlansComboBox.Text = _selectedRow.Cells[2].Value.ToString();

        MemberNameTextBox.Text= _selectedRow.Cells[2].Value.ToString();

        PlansComboBox.Text = _selectedRow.Cells[5].Value.ToString();

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
        model.PlanId = _plans.Where(x => x.Display == PlansComboBox.Text).First().Id;

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

    private void PrintButton_Click(object sender, EventArgs e) {

        DGVPrinter printer = new DGVPrinter();
        printer.Title = "Memberships Report";
        printer.SubTitle = $"{DateTime.Now}";
        printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
        printer.PageNumbers = true;
        printer.PageNumberInHeader = false;
        printer.PorportionalColumns = true;
        printer.HeaderCellAlignment = StringAlignment.Near;
        printer.Footer = $"Total MemberShips: {_memberships.Count}";

        if (!ExpiredOnlyRadioButton.Checked) {
            printer.Footer += $" | Total Income: {TotalIncome(_memberships)}";
        }
        printer.FooterSpacing = 15;

        MembershipsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;

        printer.PrintDataGridView(MembershipsDataGridView);

        MembershipsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    private int TotalIncome(List<MembershipModel> memberships) {

        int total = 0;

        foreach (var m in memberships.Where(x => x.IsExpired == false)) {

            total += _plans.Where(x => x.Name == m.PlanName).First().Fee;
        }

        return total;
    }

    private async void AllRadioButton_CheckedChanged(object sender, EventArgs e) {
        await LoadMemberships(FetchType());
    }

    private async void ActiveOnlyRadioButton_CheckedChanged(object sender, EventArgs e) {
        await LoadMemberships(FetchType());
    }

    private async void StaffOnlyRadioButton_CheckedChanged(object sender, EventArgs e) {
        await LoadMemberships(FetchType());
    }

    private string FetchType() {
        if (AllRadioButton.Checked) {
            return "All";
        } else if (ActiveOnlyRadioButton.Checked) {
            return "Active";
        } else {
            return "Expired";
        }
    }

    private async void DeleteButton_Click(object sender, EventArgs e) {
        if (_selectedRow == null) {
            MessageBox.Show("Please Select a row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        MembershipModel model = new MembershipModel();

        model.Id = int.Parse(_selectedRow.Cells[0].Value.ToString());

        var trainers = TrainersCheckedListBox.CheckedItems;

        try {
            await _sqlConnector.DeleteMembership(model.Id);

        } catch (Exception ex) {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        await ResetForm();
    }

}
