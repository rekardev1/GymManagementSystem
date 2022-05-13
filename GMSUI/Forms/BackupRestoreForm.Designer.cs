namespace GMSUI.Forms;

partial class BackupRestoreForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backupDestinationTextBox = new System.Windows.Forms.TextBox();
            this.backupBrowseButton = new System.Windows.Forms.Button();
            this.backupFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.backupButton = new System.Windows.Forms.Button();
            this.backupFileNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.restoreBrowseButton = new System.Windows.Forms.Button();
            this.restoreFilePathTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.restoreButton = new System.Windows.Forms.Button();
            this.AppendDateTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(81, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backup Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Backup Destination";
            // 
            // backupDestinationTextBox
            // 
            this.backupDestinationTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backupDestinationTextBox.Location = new System.Drawing.Point(12, 179);
            this.backupDestinationTextBox.Name = "backupDestinationTextBox";
            this.backupDestinationTextBox.Size = new System.Drawing.Size(229, 29);
            this.backupDestinationTextBox.TabIndex = 3;
            this.backupDestinationTextBox.TabStop = false;
            // 
            // backupBrowseButton
            // 
            this.backupBrowseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backupBrowseButton.Location = new System.Drawing.Point(247, 179);
            this.backupBrowseButton.Name = "backupBrowseButton";
            this.backupBrowseButton.Size = new System.Drawing.Size(81, 29);
            this.backupBrowseButton.TabIndex = 4;
            this.backupBrowseButton.Text = "Browse";
            this.backupBrowseButton.UseVisualStyleBackColor = true;
            this.backupBrowseButton.Click += new System.EventHandler(this.backupBrowseButton_Click);
            // 
            // backupButton
            // 
            this.backupButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backupButton.Location = new System.Drawing.Point(12, 230);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(123, 29);
            this.backupButton.TabIndex = 5;
            this.backupButton.Text = "Backup Now";
            this.backupButton.UseVisualStyleBackColor = true;
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // backupFileNameTextBox
            // 
            this.backupFileNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backupFileNameTextBox.Location = new System.Drawing.Point(12, 110);
            this.backupFileNameTextBox.Name = "backupFileNameTextBox";
            this.backupFileNameTextBox.Size = new System.Drawing.Size(229, 29);
            this.backupFileNameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Backup Name";
            // 
            // HomeButton
            // 
            this.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeButton.Image = global::GMSUI.Properties.Resources.home_60x60;
            this.HomeButton.Location = new System.Drawing.Point(12, 6);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(63, 58);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "Restore Database";
            // 
            // restoreBrowseButton
            // 
            this.restoreBrowseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.restoreBrowseButton.Location = new System.Drawing.Point(247, 394);
            this.restoreBrowseButton.Name = "restoreBrowseButton";
            this.restoreBrowseButton.Size = new System.Drawing.Size(81, 29);
            this.restoreBrowseButton.TabIndex = 7;
            this.restoreBrowseButton.Text = "Browse";
            this.restoreBrowseButton.UseVisualStyleBackColor = true;
            this.restoreBrowseButton.Click += new System.EventHandler(this.restoreBrowseButton_Click);
            // 
            // restoreFilePathTextBox
            // 
            this.restoreFilePathTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.restoreFilePathTextBox.Location = new System.Drawing.Point(12, 394);
            this.restoreFilePathTextBox.Name = "restoreFilePathTextBox";
            this.restoreFilePathTextBox.Size = new System.Drawing.Size(229, 29);
            this.restoreFilePathTextBox.TabIndex = 6;
            this.restoreFilePathTextBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Backup file";
            // 
            // restoreButton
            // 
            this.restoreButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.restoreButton.Location = new System.Drawing.Point(12, 447);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(123, 29);
            this.restoreButton.TabIndex = 8;
            this.restoreButton.Text = "Restore";
            this.restoreButton.UseVisualStyleBackColor = true;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // AppendDateTimeCheckBox
            // 
            this.AppendDateTimeCheckBox.AutoSize = true;
            this.AppendDateTimeCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AppendDateTimeCheckBox.Location = new System.Drawing.Point(247, 114);
            this.AppendDateTimeCheckBox.Name = "AppendDateTimeCheckBox";
            this.AppendDateTimeCheckBox.Size = new System.Drawing.Size(153, 25);
            this.AppendDateTimeCheckBox.TabIndex = 2;
            this.AppendDateTimeCheckBox.Text = "Append DateTime";
            this.AppendDateTimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // BackupRestoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 676);
            this.Controls.Add(this.AppendDateTimeCheckBox);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.restoreBrowseButton);
            this.Controls.Add(this.restoreFilePathTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backupFileNameTextBox);
            this.Controls.Add(this.backupButton);
            this.Controls.Add(this.backupBrowseButton);
            this.Controls.Add(this.backupDestinationTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BackupRestoreForm";
            this.Text = "BackupRestoreForm";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox backupDestinationTextBox;
    private Button backupBrowseButton;
    private FolderBrowserDialog backupFolderBrowserDialog;
    private Button backupButton;
    private TextBox backupFileNameTextBox;
    private Label label3;
    private Button HomeButton;
    private Label label4;
    private Button restoreBrowseButton;
    private TextBox restoreFilePathTextBox;
    private Label label5;
    private Button restoreButton;
    private CheckBox AppendDateTimeCheckBox;
}
