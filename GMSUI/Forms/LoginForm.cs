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
    
    private readonly HomeForm _home;
    SqlConnector _sqlConnector = new SqlConnector();

    public LoginForm(HomeForm home) {

        InitializeComponent();
        
        _home=home;
        
    }

    private async void LogInButton_Click(object sender, EventArgs e) {
        
        bool success = await _sqlConnector.LogIn(NameTextBox.Text, PasswordTextBox.Text);

        if (success) {

            this.Hide();
            _home.Show();

        } else {
            
            PasswordTextBox.Text = "";
        }

    }
}
