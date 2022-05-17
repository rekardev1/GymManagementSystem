using DGVPrinterHelper;
using GMSDataAccess.DataAccess;
using GMSDataAccess.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMSUI.Forms;
public partial class MemberForm : Form {

    private SqlConnector _sqlConnector = new SqlConnector();
    private List<MemberModel> _members = new List<MemberModel>();
    private DataGridViewRow _selectedRow;
    private readonly ShellForm _shell;

    public MemberForm(ShellForm shell) {
        InitializeComponent();

        BirthDatePicker.Format = DateTimePickerFormat.Custom;
        BirthDatePicker.CustomFormat = "dd/MM/yyyy";
        BirthDatePicker.Value = DateTime.Today;
        _shell = shell;

    }

    override async protected void OnLoad(EventArgs e) {

        await LoadMembers();
        FirstNameTextBox.Focus();
    }

    private async Task LoadMembers() {

        _members = await _sqlConnector.GetMembers();

        MembersDataGridView.DataSource = _members;
        MembersDataGridView.ClearSelection();
    }

    private async void AddButton_Click(object sender, EventArgs e) {

        if (ValidateForm()) {

            MemberModel model = new MemberModel();

            model.FirstName= FirstNameTextBox.Text;
            model.LastName = LastNameTextBox.Text;
            model.Address = AddressTextBox.Text;
            model.Gender = GenderComboBox.Text;
            model.BirthDate = BirthDatePicker.Value;
            model.PhoneNumber1 = PhoneNumber1TextBox.Text;
            model.PhoneNumber2 = PhoneNumber2TextBox.Text;

            try {
                await _sqlConnector.AddMember(model);

                await ResetForm();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        } else {
            MessageBox.Show("Please enter all required information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task ResetForm() {

        FirstNameTextBox.Text = "";
        LastNameTextBox.Text = "";
        AddressTextBox.Text = "";
        GenderComboBox.Text = "";
        BirthDatePicker.Value = DateTime.Today;
        PhoneNumber1TextBox.Text = "";
        PhoneNumber2TextBox.Text = "";

        _selectedRow = null;

        await LoadMembers();
    }

    private bool ValidateForm() {
        bool output = true;

        if (string.IsNullOrEmpty(FirstNameTextBox.Text)) {
            output = false;

        } else if (string.IsNullOrEmpty(LastNameTextBox.Text)) {
            output = false;

        } else if (string.IsNullOrEmpty(GenderComboBox.Text)) {
            output = false;

        } else if (BirthDatePicker.Value > DateTime.Now) {
            output = false;

        } else if (string.IsNullOrEmpty(AddressTextBox.Text)) {
            output = false;

        } else if (string.IsNullOrEmpty(PhoneNumber1TextBox.Text)) {
            output = false;

        }

        return output;
    }

    private void MembersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {

        if (e.RowIndex < 0) {
            return;
        }

        _selectedRow = MembersDataGridView.Rows[e.RowIndex];

        FirstNameTextBox.Text = _selectedRow.Cells[1].Value.ToString();
        LastNameTextBox.Text = _selectedRow.Cells[2].Value.ToString();
        BirthDatePicker.Value= (DateTime)_selectedRow.Cells[3].Value;
        GenderComboBox.Text = _selectedRow.Cells[4].Value.ToString();
        AddressTextBox.Text = _selectedRow.Cells[5].Value.ToString();
        PhoneNumber1TextBox.Text = _selectedRow.Cells[6].Value.ToString();
        PhoneNumber2TextBox.Text = _selectedRow.Cells[7].Value.ToString();
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

        MemberModel model = new MemberModel();

        model.Id = int.Parse(_selectedRow.Cells[0].Value.ToString());
        model.FirstName= FirstNameTextBox.Text;
        model.LastName = LastNameTextBox.Text;
        model.Address = AddressTextBox.Text;
        model.Gender = GenderComboBox.Text;
        model.BirthDate = BirthDatePicker.Value;
        model.PhoneNumber1 = PhoneNumber1TextBox.Text;
        model.PhoneNumber2 = PhoneNumber2TextBox.Text;

        try {
            await _sqlConnector.UpdateMember(model);

        } catch (Exception ex) {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        await ResetForm();
    }

    private async void DeleteButton_Click(object sender, EventArgs e) {

        if (_selectedRow == null) {
            MessageBox.Show("Please Select a row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        int id = int.Parse(_selectedRow.Cells[0].Value.ToString());

        try {
            await _sqlConnector.DeleteMember(id);

        }catch (SqlException ex) {

            if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint \"FK_Membership_Member\"")) {
                MessageBox.Show("This member has a membership, can not be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        } catch (Exception ex) {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        await ResetForm();
    }

    private void HomeButton_Click(object sender, EventArgs e) {
        _shell.OpenHomeForm();
    }

    private void PrintButton_Click(object sender, EventArgs e) {

        DGVPrinter printer = new DGVPrinter();
        printer.Title = "Members Report";
        printer.SubTitle = $"{DateTime.Now}";
        printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
        printer.PageNumbers = true;
        printer.PageNumberInHeader = false;
        printer.PorportionalColumns = true;
        printer.HeaderCellAlignment = StringAlignment.Near;
        printer.Footer = $"Total Members: {_members.Count}";
        printer.FooterSpacing = 15;

        MembersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;

        printer.PrintDataGridView(MembersDataGridView);

        MembersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


    }

    private void AddMembershipButton_Click(object sender, EventArgs e) {

        AddMembershipForm addMembershipForm = new AddMembershipForm(_shell);
        addMembershipForm.ShowDialog();

    }
}
