namespace GMSUI.Forms;

partial class HomeForm {
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
            this.MembersButton = new System.Windows.Forms.Button();
            this.EmployeesButton = new System.Windows.Forms.Button();
            this.PlansButton = new System.Windows.Forms.Button();
            this.MembershipsButton = new System.Windows.Forms.Button();
            this.UsersButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(200, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gym Management System";
            // 
            // MembersButton
            // 
            this.MembersButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MembersButton.Location = new System.Drawing.Point(186, 174);
            this.MembersButton.Name = "MembersButton";
            this.MembersButton.Size = new System.Drawing.Size(201, 107);
            this.MembersButton.TabIndex = 1;
            this.MembersButton.Text = "Members";
            this.MembersButton.UseVisualStyleBackColor = true;
            this.MembersButton.Click += new System.EventHandler(this.MembersButton_Click);
            // 
            // EmployeesButton
            // 
            this.EmployeesButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmployeesButton.Location = new System.Drawing.Point(393, 174);
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.Size = new System.Drawing.Size(201, 107);
            this.EmployeesButton.TabIndex = 2;
            this.EmployeesButton.Text = "Employees";
            this.EmployeesButton.UseVisualStyleBackColor = true;
            this.EmployeesButton.Click += new System.EventHandler(this.EmployeesButton_Click);
            // 
            // PlansButton
            // 
            this.PlansButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlansButton.Location = new System.Drawing.Point(600, 174);
            this.PlansButton.Name = "PlansButton";
            this.PlansButton.Size = new System.Drawing.Size(201, 107);
            this.PlansButton.TabIndex = 3;
            this.PlansButton.Text = "Plans";
            this.PlansButton.UseVisualStyleBackColor = true;
            this.PlansButton.Click += new System.EventHandler(this.PlansButton_Click);
            // 
            // MembershipsButton
            // 
            this.MembershipsButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MembershipsButton.Location = new System.Drawing.Point(186, 287);
            this.MembershipsButton.Name = "MembershipsButton";
            this.MembershipsButton.Size = new System.Drawing.Size(201, 107);
            this.MembershipsButton.TabIndex = 5;
            this.MembershipsButton.Text = "Memberships";
            this.MembershipsButton.UseVisualStyleBackColor = true;
            this.MembershipsButton.Click += new System.EventHandler(this.MembershipsButton_Click);
            // 
            // UsersButton
            // 
            this.UsersButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UsersButton.Location = new System.Drawing.Point(600, 287);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(201, 107);
            this.UsersButton.TabIndex = 4;
            this.UsersButton.Text = "Users";
            this.UsersButton.UseVisualStyleBackColor = true;
            this.UsersButton.Visible = false;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.EmployeesButton);
            this.panel1.Controls.Add(this.MembershipsButton);
            this.panel1.Controls.Add(this.UsersButton);
            this.panel1.Controls.Add(this.MembersButton);
            this.panel1.Controls.Add(this.PlansButton);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 555);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(393, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 107);
            this.button1.TabIndex = 6;
            this.button1.Text = "Backup/Restore Database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BackupRestoreDatabaseButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1019, 572);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HomeForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private Label label1;
    private Button MembersButton;
    private Button EmployeesButton;
    private Button PlansButton;
    private Button UsersButton;
    private Button MembershipsButton;
    private Panel panel1;
    private Button button1;
}
