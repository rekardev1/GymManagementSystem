using GMSDataAccess.DataAccess;
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
public partial class BackupRestoreForm : Form {

    private SqlConnector _sqlConnector = new SqlConnector();
    private readonly ShellForm _shell;

    public BackupRestoreForm(ShellForm shell) {
        InitializeComponent();
        _shell = shell;
        
    }

    override protected void OnLoad(EventArgs e) {
        backupFileNameTextBox.Focus();
    }

    private void backupBrowseButton_Click(object sender, EventArgs e) {
        if (backupFolderBrowserDialog.ShowDialog() == DialogResult.OK) {
            backupDestinationTextBox.Text = backupFolderBrowserDialog.SelectedPath;
        }
    }

    private async void backupButton_Click(object sender, EventArgs e) {
        
        if (ValidateBackup()) {
            try {

                string name;

                if (backupFileNameTextBox.Text != "") {
                    name = backupFileNameTextBox.Text;
                } else {
                    name = "backup";
                }

                if (AppendDateTimeCheckBox.Checked) {

                    name += $"_{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}";
                }

                await _sqlConnector.BackupDatabase(backupDestinationTextBox.Text, name);
                MessageBox.Show("The database successfully backed up.", "Backup Database Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);


            } catch (Exception ex) {

                MessageBox.Show(ex.Message, "Backup Database Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        } else {
            MessageBox.Show("Invalid path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private bool ValidateBackup() {

        if (Directory.Exists(backupDestinationTextBox.Text)) {
            return true;
        }
        return false;
    }

    private void restoreBrowseButton_Click(object sender, EventArgs e) {

        OpenFileDialog openFileDialog = new OpenFileDialog();

        if (openFileDialog.ShowDialog() == DialogResult.OK) {
            if (Path.GetExtension(openFileDialog.FileName) == ".bak") {

                restoreFilePathTextBox.Text = openFileDialog.FileName;
            } else {
                MessageBox.Show("Invalid file! please select a file with .bak extension.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                restoreFilePathTextBox.Text = "";
            }
        }

    }

    private async void restoreButton_Click(object sender, EventArgs e) {
        
        if (ValidateRestore()) {
            try {

                await _sqlConnector.RestoreDatabase(restoreFilePathTextBox.Text);
                MessageBox.Show("The database successfully restored.", "Restore Database Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);


            } catch (Exception ex) {

                MessageBox.Show(ex.Message, "Restore Database Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        } else {
            MessageBox.Show("Invalid path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            restoreFilePathTextBox.Text = "";
        }
    }

    private bool ValidateRestore() {
        if (File.Exists(restoreFilePathTextBox.Text) && Path.GetExtension(restoreFilePathTextBox.Text) == ".bak") {
            return true;
        }
        return false;
    }

    private void HomeButton_Click(object sender, EventArgs e) {
        _shell.OpenHomeForm();
    }
}
