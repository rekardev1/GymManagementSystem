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
public partial class AddEmployeeForm : Form {
    
    private readonly HomeForm _home;
    private readonly EmployeeForm _employeeForm;
    private SqlConnector _sqlConnector = new SqlConnector();

    public AddEmployeeForm(HomeForm home, EmployeeForm employeeForm) {
        InitializeComponent();
        
        _home = home;
        _employeeForm = employeeForm;
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
                _employeeForm?.LoadEmployees();
                this.Close();

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

    private void SalaryTextBox_KeyPress(object sender, KeyPressEventArgs e) {
        e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
    }

    private void PhoneNumber1TextBox_KeyPress(object sender, KeyPressEventArgs e) {
        e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
    }

    private void PhoneNumber2TextBox_KeyPress(object sender, KeyPressEventArgs e) {
        e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
    }
}
