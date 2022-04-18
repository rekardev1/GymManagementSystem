using GMSDataAccess.DataAccess;
using GMSDataAccess.Model;
using GMSUI.Helper;
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
public partial class AddUserForm : Form {

    private SqlConnector _sqlConnector = new SqlConnector();
    private readonly UserForm _userForm;

    public AddUserForm(UserForm userForm) {
        InitializeComponent();
        _userForm = userForm;

        ComboBoxItem<int> item1 = new ComboBoxItem<int>();
        item1.Label = "Admin";
        item1.Value = 1;

        ComboBoxItem<int> item2 = new ComboBoxItem<int>();
        item2.Label = "Manager";
        item2.Value = 2;

        List<ComboBoxItem<int>> items = new List<ComboBoxItem<int>>();
        items.Add(item1);
        items.Add(item2);

        RoleLevelComboBox.DataSource = items;
        RoleLevelComboBox.DisplayMember = "Label";
    }

    private async void AddButton_Click(object sender, EventArgs e) {
        
        if (ValidateForm()) {

            UserModel model = new UserModel();

            model.Name = NameTextBox.Text;
            model.RoleLevel = int.Parse(RoleLevelComboBox.SelectedItem.ToString());
            model.Address = AddressTextBox.Text;
            model.Salary = decimal.Parse(SalaryTextBox.Text);
            model.PhoneNumber1 = PhoneNumber1TextBox.Text;
            model.PhoneNumber2 = PhoneNumber2TextBox.Text;

            try {
                await _sqlConnector.AddUser(model, PasswordTextBox.Text);
                _userForm?.LoadUsers();
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

        } else if (string.IsNullOrEmpty(PasswordTextBox.Text)) {
            output = false;

        } else if (string.IsNullOrEmpty(PhoneNumber1TextBox.Text)) {
            output = false;
        }

        return output;
    }

    private void RoleLevelextBox_KeyPress(object sender, KeyPressEventArgs e) {
        e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
