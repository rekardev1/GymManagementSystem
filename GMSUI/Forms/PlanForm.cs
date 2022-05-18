using DGVPrinterHelper;
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
public partial class PlanForm : Form {

    private readonly ShellForm _shell;
    private SqlConnector _sqlConnector = new SqlConnector();
    private List<PlanModel> _plans;
    private DataGridViewRow _selectedRow;

    public PlanForm(ShellForm shell) {
        InitializeComponent();

        StartTimePicker.Format = DateTimePickerFormat.Time;
        StartTimePicker.ShowUpDown = true;

        EndTimePicker.Format = DateTimePickerFormat.Time;
        EndTimePicker.ShowUpDown = true;


        _shell = shell;
    }

    protected async override void OnLoad(EventArgs e) {

        await LoadPlans();
        
    }

    internal async Task LoadPlans() {

        PlansDataGridView.Rows.Clear();
        _plans = await _sqlConnector.GetPlans();

        foreach (var p in _plans) {
            PlansDataGridView.Rows.Add(
                p.Id,
                p.Name,
                p.Start,
                p.End,
                p.Fee
                );
        }

        PlansDataGridView.ClearSelection();
        NameTextBox.Focus();

        PlansDataGridView.Columns["Start"].DefaultCellStyle.Format = "t";
        PlansDataGridView.Columns["End"].DefaultCellStyle.Format = "t";
    }

    private async void UpdateButton_Click(object sender, EventArgs e) {

        if (_selectedRow == null) {
            MessageBox.Show("Please Select a row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!ValidateForm()) {
            MessageBox.Show("Please enter all required information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        PlanModel model = new PlanModel();

        model.Id = int.Parse(_selectedRow.Cells[0].Value.ToString());

        model.Name = NameTextBox.Text;
        model.Start = StartTimePicker.Value;
        model.End = EndTimePicker.Value;
        model.Fee = int.Parse(FeeTextBox.Text);

        try {
            await _sqlConnector.UpdatePlan(model);

        } catch (Exception ex) {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        await ResetForm();
    }

    private async Task ResetForm() {

        NameTextBox.Text = "";
        FeeTextBox.Text = "";

        _selectedRow = null;

        await LoadPlans();
    }

    private void FeeTextBox_KeyPress(object sender, KeyPressEventArgs e) {
        e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
    }

    private void PlansDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
        if (e.RowIndex < 0) {
            return;
        }

        _selectedRow = PlansDataGridView.Rows[e.RowIndex];

        NameTextBox.Text = _selectedRow.Cells[1].Value.ToString();
        StartTimePicker.Text = _selectedRow.Cells[2].Value.ToString();
        EndTimePicker.Text = _selectedRow.Cells[3].Value.ToString();
        FeeTextBox.Text = _selectedRow.Cells[4].Value.ToString();

    }

    private async void AddButton_Click(object sender, EventArgs e) {
        if (ValidateForm()) {

            PlanModel model = new PlanModel();

            model.Name = NameTextBox.Text;
            model.Start = StartTimePicker.Value;
            model.End = EndTimePicker.Value;
            model.Fee = int.Parse(FeeTextBox.Text);


            try {
                await _sqlConnector.AddPlan(model);
                await ResetForm();


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

    private async void DeleteButton_Click(object sender, EventArgs e) {

        if (_selectedRow == null) {
            MessageBox.Show("Please Select a row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        int id = int.Parse(_selectedRow.Cells[0].Value.ToString());

        try {

            var result = MessageBox.Show("Are you sure to delete this plan?", "Delteing Plan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {

                await _sqlConnector.DeletePlan(id);

                await ResetForm();
            }

        } catch (Exception ex) {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void HomeButton_Click(object sender, EventArgs e) {
        _shell.OpenHomeForm();
    }

    private void PrintButton_Click(object sender, EventArgs e) {

        DGVPrinter printer = new DGVPrinter();
        printer.Title = "Plans Report";
        printer.SubTitle = $"{DateTime.Now}";
        printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
        printer.PageNumbers = true;
        printer.PageNumberInHeader = false;
        printer.PorportionalColumns = true;
        printer.Footer = $"Total Number of Plans: {_plans.Count}";
        printer.HeaderCellAlignment = StringAlignment.Near;

        printer.FooterSpacing = 15;

        PlansDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;

        printer.PrintDataGridView(PlansDataGridView);

        PlansDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

    }
}
