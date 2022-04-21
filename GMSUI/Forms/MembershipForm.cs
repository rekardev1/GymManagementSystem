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
public partial class MembershipForm : Form {

    private SqlConnector _sqlConnector = new SqlConnector();
    private List<EmployeeModel> _trainers = new List<EmployeeModel>();
    private List<MembershipTypeModel> _membershipTypes = new List<MembershipTypeModel>();
    private List<MembershipModel> _memberships = new List<MembershipModel>();
    public MembershipForm() {
        InitializeComponent();

        //StartingDatePicker.Format = DateTimePickerFormat.Custom;
        //StartingDatePicker.CustomFormat = "dd/MM/yyyy";

        //ExpirationDatePicker.Format = DateTimePickerFormat.Custom;
        //ExpirationDatePicker.CustomFormat = "dd/MM/yyyy";

    }

    override protected async void OnLoad(EventArgs e) {
        
        await LoadTrainers();

        await LoadMembershipTypes();

        await LoadMemberships();
    }

    private async Task LoadMemberships() {
        _memberships = await _sqlConnector.GetMemberships();
    }

    private async Task LoadMembershipTypes() {

        _membershipTypes = await _sqlConnector.GetMembershipTypes();

        MembershipTypesComboBox.DataSource = _membershipTypes;
    }

    private async Task LoadTrainers() {
        _trainers = await _sqlConnector.GetTrainers();

        TrainersCheckedListBox.DisplayMember = "Display";
        TrainersCheckedListBox.Items.Clear();

        foreach (var t in _trainers) {
            TrainersCheckedListBox.Items.Add(t);
        }

    }
}
