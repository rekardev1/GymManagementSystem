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

    EmployeeModel LoggedInUser;

    public HomeForm() {
        InitializeComponent();


    }

    override protected void OnLoad(EventArgs e) {

        Hide();

        LoginForm frm = new LoginForm(this);
        frm.ShowDialog();

    }

    private void MembersButton_Click(object sender, EventArgs e) {

    }

    private void EmployeesButton_Click(object sender, EventArgs e) {
        
        EmployeeForm employeeForm = new EmployeeForm(this);
        employeeForm.Show();

    }
}
