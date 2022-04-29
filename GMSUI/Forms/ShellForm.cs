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
public partial class ShellForm : Form {

    private Form activeForm;
    internal HomeForm homeForm;
    public UserModel LoggedInUser { get; set; }

    public ShellForm() {
        InitializeComponent();
    }

    internal void OpenChildForm(Form childForm, string ChildFormTitle) {

        if (activeForm != null && activeForm != homeForm) {

            activeForm.Close();
        }

        activeForm = childForm;
        activeForm.TopLevel = false;
        activeForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;
        MainPanel.Controls.Add(activeForm);
        MainPanel.Tag = childForm;
        childForm.BringToFront();
        childForm.Show();
        ChildFormTitleLabel.Text = ChildFormTitle;

    }

    override protected void OnLoad(EventArgs e) {
        
        LoginForm frm = new LoginForm(this);
        frm.LoggedIn += Frm_LoggedIn;
        OpenChildForm(frm, "Login");
    }

    private void Frm_LoggedIn(object? sender, EventArgs e) {

        homeForm = new HomeForm(this);
        OpenChildForm(homeForm, "Home");

    }

    public void OpenHomeForm() {
        OpenChildForm(homeForm, "Home");
    }

}
