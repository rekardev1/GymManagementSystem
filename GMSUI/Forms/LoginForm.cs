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

    private readonly HomeForm _home;
    SqlConnector _sqlConnector = new SqlConnector();

    public LoginForm(HomeForm home) {

        InitializeComponent();
        
        _home = home;
        
    }

    private async void LogInButton_Click(object sender, EventArgs e) {
        
        bool success = await _sqlConnector.LogIn(NameTextBox.Text, PasswordTextBox.Text);

        if (success) {

            UserModel user = await _sqlConnector.GetUserByName(NameTextBox.Text);

            _home.LoggedInUser = user;

            LoggedIn?.Invoke(this, EventArgs.Empty);

            this.Hide();
            _home.Show();

        } else {
            
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

    private void LoginForm_FormClosed(object sender, FormClosedEventArgs e) {
        _home.Close();
    }
}
