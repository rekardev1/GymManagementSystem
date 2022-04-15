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

        private readonly HomeForm _home;
        private SqlConnector _sqlConnector = new SqlConnector();
        private BindingList<EmployeeModel> _employees;
        private DataGridViewRow _selectedRow;

        public EmployeeForm(HomeForm home) {
            InitializeComponent();

            _home = home;

        }

        protected async override void OnLoad(EventArgs e) {

            await LoadEmployees();

        }

        private async Task LoadEmployees() {

            var em = await _sqlConnector.GetEmployees();

            _employees = new BindingList<EmployeeModel>(em);

            EmployeesGridView.DataSource = _employees;
        }

        private async void AddButton_Click(object sender, EventArgs e) {

            if (ValidateForm()) {

                EmployeeModel model = new EmployeeModel();

                model.Name = NameTextBox.Text;
                model.Address = AddressTextBox.Text;
                model.Salary = decimal.Parse(SalaryTextBox.Text);
                model.JobType = JobTypeTextBox.Text;
                model.PhoneNumber1 = PhoneNumber1TextBox.Text;
                model.PhoneNumber2 = PhoneNumber2TextBox.Text;

                try {
                    await _sqlConnector.AddEmployee(model);

                } catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                await ResetForm();

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
            model.Salary = decimal.Parse(SalaryTextBox.Text);
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

            await LoadEmployees();
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

        private void EmployeesGridView_CellClick(object sender, DataGridViewCellEventArgs e) {

            if (e.RowIndex < 0) {
                return;
            }

            _selectedRow = EmployeesGridView.Rows[e.RowIndex];

            NameTextBox.Text = _selectedRow.Cells[1].Value.ToString();
            AddressTextBox.Text = _selectedRow.Cells[2].Value.ToString();
            SalaryTextBox.Text = _selectedRow.Cells[3].Value.ToString();
            JobTypeTextBox.Text = _selectedRow.Cells[4].Value.ToString();
            PhoneNumber1TextBox.Text = _selectedRow.Cells[5].Value.ToString();
            PhoneNumber2TextBox.Text = _selectedRow.Cells[6].Value.ToString();

        }

    }
}
