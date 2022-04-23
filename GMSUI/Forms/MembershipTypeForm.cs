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
public partial class MembershipTypeForm : Form {

    private readonly HomeForm _home;
    private SqlConnector _sqlConnector = new SqlConnector();
    private BindingList<MembershipTypeModel> _membershipTypes;
    private DataGridViewRow _selectedRow;

    public MembershipTypeForm(HomeForm homeForm) {
        InitializeComponent();

        StartTimePicker.Format = DateTimePickerFormat.Time;
        StartTimePicker.ShowUpDown = true;

        EndTimePicker.Format = DateTimePickerFormat.Time;
        EndTimePicker.ShowUpDown = true;


        _home = homeForm;
    }

    protected async override void OnLoad(EventArgs e) {


        await LoadMembershipTypes();

    }

    internal async Task LoadMembershipTypes() {

        var m = await _sqlConnector.GetMembershipTypes();

        _membershipTypes = new BindingList<MembershipTypeModel>(m);

        MembershipsDataGridView.DataSource = _membershipTypes;
        MembershipsDataGridView.ClearSelection();

        if (_membershipTypes.Count > 0) {

            MembershipsDataGridView.Columns["Start"].DefaultCellStyle.Format = "t";
            MembershipsDataGridView.Columns["End"].DefaultCellStyle.Format = "t";

        }
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

        MembershipTypeModel model = new MembershipTypeModel();

        model.Id = int.Parse(_selectedRow.Cells[0].Value.ToString());

        model.Name = NameTextBox.Text;
        model.Start = StartTimePicker.Value;
        model.End = EndTimePicker.Value;
        model.Fee = int.Parse(FeeTextBox.Text);

        try {
            await _sqlConnector.UpdateMembershipType(model);

        } catch (Exception ex) {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        await ResetForm();
    }

    private async Task ResetForm() {

        NameTextBox.Text = "";
        FeeTextBox.Text = "";

        _selectedRow = null;

        await LoadMembershipTypes();
    }

    private void FeeTextBox_KeyPress(object sender, KeyPressEventArgs e) {
        e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
    }

    private void MembershipsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
        if (e.RowIndex < 0) {
            return;
        }

        _selectedRow = MembershipsDataGridView.Rows[e.RowIndex];

        NameTextBox.Text = _selectedRow.Cells[1].Value.ToString();
        StartTimePicker.Text = _selectedRow.Cells[2].Value.ToString();
        EndTimePicker.Text = _selectedRow.Cells[3].Value.ToString();
        FeeTextBox.Text = _selectedRow.Cells[4].Value.ToString();

    }

    private async void AddMembershipTypeButton_Click(object sender, EventArgs e) {
        if (ValidateForm()) {

            MembershipTypeModel model = new MembershipTypeModel();

            model.Name = NameTextBox.Text;
            model.Start = StartTimePicker.Value;
            model.End = EndTimePicker.Value;
            model.Fee = int.Parse(FeeTextBox.Text);


            try {
                await _sqlConnector.AddMembershipType(model);
                await ResetForm();
                

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        } else {
            MessageBox.Show("Please enter all required information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private bool ValidateForm() {
        bool output = true;

        if (string.IsNullOrEmpty(NameTextBox.Text)) {
            output = false;

        } else if (string.IsNullOrEmpty(FeeTextBox.Text)) {
            output = false;

        }

        return output;
    }

    private async void DeleteButton_Click(object sender, EventArgs e) {

        if (_selectedRow == null) {
            MessageBox.Show("Please Select a row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        int id = int.Parse(_selectedRow.Cells[0].Value.ToString());

        try {
            await _sqlConnector.DeleteMembershipType(id);

        } catch (Exception ex) {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        await ResetForm();
    }
}
