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
public partial class AddMembershipForm : Form {
    private readonly HomeForm _home;
    private List<MemberModel> _members = new List<MemberModel>();
    private List<MembershipTypeModel> _membershipTypes = new List<MembershipTypeModel>();
    private List<EmployeeModel> _trainers = new List<EmployeeModel>();
    private SqlConnector _sqlConnector = new SqlConnector();


    public AddMembershipForm(HomeForm home) {
        InitializeComponent();
        _home = home;

        StartingDatePicker.Format = DateTimePickerFormat.Custom;
        StartingDatePicker.CustomFormat = "dd/MM/yyyy";
        StartingDatePicker.Value = DateTime.Today;

        ExpirationDatePicker.Format = DateTimePickerFormat.Custom;
        ExpirationDatePicker.CustomFormat = "dd/MM/yyyy";
        ExpirationDatePicker.Value = DateTime.Today.AddDays(30);
    }

    override async protected void OnLoad(EventArgs e) {
        
        await LoadMembershipTypes();

        await LoadMembers();

        await LoadTrainers();
    }

    private async Task LoadMembershipTypes() {

        _membershipTypes = await _sqlConnector.GetMembershipTypes();
        MembershipTypeComboBox.DataSource = _membershipTypes;
        MembershipTypeComboBox.DisplayMember = "Display";

    }
    private async Task LoadMembers() {

        _members = await _sqlConnector.GetMembers();

        MemberComboBox.DataSource = _members;
        MemberComboBox.DisplayMember = "FullName";
    }

    private async Task LoadTrainers() {

        _trainers = await _sqlConnector.GetTrainers();

        TrainersCheckedListBox.DisplayMember = "Display";
        TrainersCheckedListBox.Items.Clear();

        foreach (var t in _trainers) {
            TrainersCheckedListBox.Items.Add(t);
        }

    }

    private async void AddButton_Click(object sender, EventArgs e) {
        
        if (ValidateForm()) {

            try {
                MembershipModel model = new MembershipModel();

                model.MemberId = _members.Where(x => x.FullName == MemberComboBox.Text).First().Id;
                model.MembershipTypeId = _membershipTypes.Where(x => x.Display == MembershipTypeComboBox.Text).First().Id;

                foreach (var item in TrainersCheckedListBox.CheckedItems) {
                    model.Trainers.Add((EmployeeModel)item);
                }
                
                model.StartingDate = StartingDatePicker.Value;
                model.ExpirationDate = ExpirationDatePicker.Value;
                model.UserId = _home.LoggedInUser.Id;


                await _sqlConnector.AddMembership(model);

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

        if (MemberComboBox.SelectedItem == null) {
            output = false;

        } else if (TrainersCheckedListBox.CheckedItems.Count == 0) {
            output = false;

        } else if (ExpirationDatePicker.Value < DateTime.Today) {
            output = false;

        }

        return output;
    }
}
