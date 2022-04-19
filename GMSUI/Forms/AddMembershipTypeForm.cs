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
public partial class AddMembershipTypeForm : Form {

    private readonly MembershipForm _membershipForm;
    private SqlConnector _sqlConnector = new SqlConnector();

    public AddMembershipTypeForm(MembershipForm membershipForm) {
        InitializeComponent();
        _membershipForm = membershipForm;

        StartTimePicker.Format = DateTimePickerFormat.Time;
        StartTimePicker.ShowUpDown = true;

        EndTimePicker.Format = DateTimePickerFormat.Time;
        EndTimePicker.ShowUpDown = true;
    }

    private async void AddMembershipTypeButton_Click(object sender, EventArgs e) {
        
        if (ValidateForm()) {

            MembershipTypeModel model = new MembershipTypeModel();

            model.Name = NameTextBox.Text;
            model.Start = StartTimePicker.Value;
            model.End = EndTimePicker.Value;
            model.Fee = decimal.Parse(FeeTextBox.Text);


            try {
                await _sqlConnector.AddMembershipType(model);
                _membershipForm?.LoadMembershipTypes();
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

        } else if (string.IsNullOrEmpty(FeeTextBox.Text)) {
            output = false;

        }

        return output;
    }
}
