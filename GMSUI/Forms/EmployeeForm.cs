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

namespace GMSUI.Forms {
    public partial class EmployeeForm : Form {

        private readonly ShellForm _shell;
        private SqlConnector _sqlConnector = new SqlConnector();
        private List<EmployeeModel> _employees;
        private DataGridViewRow _selectedRow;

        public EmployeeForm(ShellForm shell) {
            InitializeComponent();

            _shell = shell;
        }

        protected async override void OnLoad(EventArgs e) {

            await LoadEmployees("All");

        }

        internal async Task LoadEmployees(string fetchType) {

            _employees = await _sqlConnector.GetEmployees(fetchType);

            EmployeesDataGridView.Rows.Clear();

            foreach (var e in _employees) {
                EmployeesDataGridView.Rows.Add(
                    e.Id,
                    e.Name,
                    e.Address,
                    e.Salary,
                    e.JobType,
                    e.PhoneNumber1,
                    e.PhoneNumber2);
            }
            
            EmployeesDataGridView.ClearSelection();
        }

        private async void AddButton_Click(object sender, EventArgs e) {

            if (ValidateForm()) {

                EmployeeModel model = new EmployeeModel();

                model.Name = NameTextBox.Text;
                model.Address = AddressTextBox.Text;
                model.Salary = int.Parse(SalaryTextBox.Text);
                model.JobType = JobTypeTextBox.Text;
                model.PhoneNumber1 = PhoneNumber1TextBox.Text;
                model.PhoneNumber2 = PhoneNumber2TextBox.Text;

                try {
                    await _sqlConnector.AddEmployee(model);

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

            } else if (string.IsNullOrEmpty(AddressTextBox.Text)) {
                output = false;

            } else if (string.IsNullOrEmpty(SalaryTextBox.Text)) {
                output = false;

            } else if (string.IsNullOrEmpty(JobTypeTextBox.Text)) {
                output = false;

            } else if (string.IsNullOrEmpty(PhoneNumber1TextBox.Text)) {
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

            EmployeeModel model = new EmployeeModel();

            model.Id = int.Parse(_selectedRow.Cells[0].Value.ToString());
            model.Name = NameTextBox.Text;
            model.Address = AddressTextBox.Text;
            model.Salary = int.Parse(SalaryTextBox.Text);
            model.JobType = JobTypeTextBox.Text;
            model.PhoneNumber1 = PhoneNumber1TextBox.Text;
            model.PhoneNumber2 = PhoneNumber2TextBox.Text;

            try {
                await _sqlConnector.UpdateEmployee(model);

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
                await _sqlConnector.DeleteEmployee(id);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            await ResetForm();
        }

        private async Task ResetForm() {

            NameTextBox.Text = "";
            AddressTextBox.Text = "";
            SalaryTextBox.Text = "";
            JobTypeTextBox.Text = "";
            PhoneNumber1TextBox.Text = "";
            PhoneNumber2TextBox.Text = "";
            
            _selectedRow = null;

            await LoadEmployees(FetchType());

        }

        private string FetchType() {

            if (AllRadioButton.Checked) {
                return "All";

            }else if (TrainerOnlyRadioButton.Checked) {
                return "Trainer";

            } else {
                return "Staff";

            }

        }

        private void SalaryTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void PhoneNumber1TextBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void PhoneNumber2TextBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void HomeButton_Click(object sender, EventArgs e) {
            _shell.OpenHomeForm();
        }

        private void PrintButton_Click(object sender, EventArgs e) {
            
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Employees Report";
            printer.SubTitle = $"{DateTime.Now}";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = $"Total Employees: {_employees.Count} | Total salary: {TotalSalary(_employees)}";
            printer.FooterSpacing = 15;

            EmployeesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;

            printer.PrintDataGridView(EmployeesDataGridView);

            EmployeesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private int TotalSalary(List<EmployeeModel> employees) {

            return employees.Sum(x => x.Salary);

        }

        private void EmployeesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            
            if (e.RowIndex < 0) {
                return;
            }

            _selectedRow = EmployeesDataGridView.Rows[e.RowIndex];

            NameTextBox.Text = _selectedRow.Cells[1].Value.ToString();
            AddressTextBox.Text = _selectedRow.Cells[2].Value.ToString();
            SalaryTextBox.Text = _selectedRow.Cells[3].Value.ToString();
            JobTypeTextBox.Text = _selectedRow.Cells[4].Value.ToString();
            PhoneNumber1TextBox.Text = _selectedRow.Cells[5].Value.ToString();
            PhoneNumber2TextBox.Text = _selectedRow.Cells[6].Value.ToString();

        }

        private async void TrainerOnlyRadioButton_CheckedChanged(object sender, EventArgs e) {
            await LoadEmployees(FetchType());
        }

        private async void StaffOnlyRadioButton_CheckedChanged(object sender, EventArgs e) {
            await LoadEmployees(FetchType());
        }

        private async void AllRadioButton_CheckedChanged(object sender, EventArgs e) {
            await LoadEmployees(FetchType());
        }
    }
}
