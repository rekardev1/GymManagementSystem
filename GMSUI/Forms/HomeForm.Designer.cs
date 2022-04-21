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
            this.MembershipsButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UsersButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(83, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(778, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gym Management System";
            // 
            // MembersButton
            // 
            this.MembersButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MembersButton.Location = new System.Drawing.Point(166, 164);
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
            this.EmployeesButton.Location = new System.Drawing.Point(373, 164);
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.Size = new System.Drawing.Size(201, 107);
            this.EmployeesButton.TabIndex = 2;
            this.EmployeesButton.Text = "Employees";
            this.EmployeesButton.UseVisualStyleBackColor = true;
            this.EmployeesButton.Click += new System.EventHandler(this.EmployeesButton_Click);
            // 
            // MembershipsButton
            // 
            this.MembershipsButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MembershipsButton.Location = new System.Drawing.Point(580, 164);
            this.MembershipsButton.Name = "MembershipsButton";
            this.MembershipsButton.Size = new System.Drawing.Size(201, 107);
            this.MembershipsButton.TabIndex = 3;
            this.MembershipsButton.Text = "Memberships Types";
            this.MembershipsButton.UseVisualStyleBackColor = true;
            this.MembershipsButton.Click += new System.EventHandler(this.MembershipsButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.UsersButton);
            this.panel1.Controls.Add(this.EmployeesButton);
            this.panel1.Controls.Add(this.MembershipsButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MembersButton);
            this.panel1.Location = new System.Drawing.Point(66, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 488);
            this.panel1.TabIndex = 4;
            // 
            // UsersButton
            // 
            this.UsersButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UsersButton.Location = new System.Drawing.Point(166, 277);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(201, 107);
            this.UsersButton.TabIndex = 4;
            this.UsersButton.Text = "Users";
            this.UsersButton.UseVisualStyleBackColor = true;
            this.UsersButton.Visible = false;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 749);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private Label label1;
    private Button MembersButton;
    private Button EmployeesButton;
    private Button MembershipsButton;
    private Panel panel1;
    private Button UsersButton;
}
