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
public partial class HomeForm : Form {

    public UserModel LoggedInUser { get; set; }

    public HomeForm() {
        InitializeComponent();

    }

    override protected void OnLoad(EventArgs e) {

        Hide();

        LoginForm frm = new LoginForm(this);
        frm.LoggedIn += Frm_LoggedIn;
        frm.ShowDialog();

    }

    private void Frm_LoggedIn(object? sender, EventArgs e) {


        if (LoggedInUser.RoleLevel == 1) {

            UsersButton.Visible = true;

        }

    }

    private void MembersButton_Click(object sender, EventArgs e) {

    }

    private void EmployeesButton_Click(object sender, EventArgs e) {

        EmployeeForm employeeForm = new EmployeeForm(this);
        employeeForm.Show();

    }

    private void UsersButton_Click(object sender, EventArgs e) {
        UserForm employeeForm = new UserForm(this);
        employeeForm.Show();
    }

    private void MembershipsButton_Click(object sender, EventArgs e) {
        MembershipForm membershipForm = new MembershipForm(this);
        membershipForm.Show();
    }
}
