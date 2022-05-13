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
public partial class LoginForm : Form {
    
    public event EventHandler LoggedIn;

    private readonly ShellForm _shell;
    SqlConnector _sqlConnector = new SqlConnector();

    public LoginForm(ShellForm shell) {

        InitializeComponent();

        _shell = shell;
        
    }

    private async void LogInButton_Click(object sender, EventArgs e) {
        
        bool success = await _sqlConnector.LogIn(NameTextBox.Text, PasswordTextBox.Text);

        if (success) {

            UserModel user = await _sqlConnector.GetUserByName(NameTextBox.Text);

            _shell.LoggedInUser = user;

            LoggedIn?.Invoke(this, EventArgs.Empty);

            

        } else {
            MessageBox.Show("Username and password mismatch!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            PasswordTextBox.Text = "";
        }

    }

    private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e) {
        
        if (ShowPasswordCheckBox.Checked) {
            PasswordTextBox.PasswordChar = '\0';
            PasswordTextBox.Focus();
        } else {
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Focus();
        }
    }

}
