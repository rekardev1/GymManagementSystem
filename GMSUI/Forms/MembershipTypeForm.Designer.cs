namespace GMSUI.Forms;

partial class MembershipTypeForm {
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
            this.MembershipLabel = new System.Windows.Forms.Label();
            this.AddMembershipTypeButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MembershipsDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.FeeTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MembershipsDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MembershipLabel
            // 
            this.MembershipLabel.AutoSize = true;
            this.MembershipLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MembershipLabel.Location = new System.Drawing.Point(3, 0);
            this.MembershipLabel.Name = "MembershipLabel";
            this.MembershipLabel.Size = new System.Drawing.Size(240, 32);
            this.MembershipLabel.TabIndex = 1;
            this.MembershipLabel.Text = "Memberships Types";
            // 
            // AddMembershipTypeButton
            // 
            this.AddMembershipTypeButton.Location = new System.Drawing.Point(3, 151);
            this.AddMembershipTypeButton.Name = "AddMembershipTypeButton";
            this.AddMembershipTypeButton.Size = new System.Drawing.Size(159, 48);
            this.AddMembershipTypeButton.TabIndex = 7;
            this.AddMembershipTypeButton.Text = "Add Membership";
            this.AddMembershipTypeButton.UseVisualStyleBackColor = true;
            this.AddMembershipTypeButton.Click += new System.EventHandler(this.AddMembershipTypeButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(168, 151);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(159, 48);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTextBox.Location = new System.Drawing.Point(3, 93);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(159, 29);
            this.NameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(168, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 47;
            this.label2.Text = "Starting Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(355, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "Ending Time";
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartTimePicker.Location = new System.Drawing.Point(168, 93);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.Size = new System.Drawing.Size(181, 29);
            this.StartTimePicker.TabIndex = 2;
            this.StartTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EndTimePicker.Location = new System.Drawing.Point(355, 93);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.Size = new System.Drawing.Size(157, 29);
            this.EndTimePicker.TabIndex = 3;
            this.EndTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(333, 151);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(159, 48);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.MembershipsDataGridView);
            this.panel1.Location = new System.Drawing.Point(3, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 308);
            this.panel1.TabIndex = 49;
            // 
            // MembershipsDataGridView
            // 
            this.MembershipsDataGridView.AllowUserToAddRows = false;
            this.MembershipsDataGridView.AllowUserToDeleteRows = false;
            this.MembershipsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MembershipsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MembershipsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MembershipsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.MembershipsDataGridView.MultiSelect = false;
            this.MembershipsDataGridView.Name = "MembershipsDataGridView";
            this.MembershipsDataGridView.ReadOnly = true;
            this.MembershipsDataGridView.RowTemplate.Height = 25;
            this.MembershipsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MembershipsDataGridView.Size = new System.Drawing.Size(835, 308);
            this.MembershipsDataGridView.TabIndex = 0;
            this.MembershipsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MembershipsDataGridView_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(518, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 21);
            this.label4.TabIndex = 51;
            this.label4.Text = "Fee";
            // 
            // FeeTextBox
            // 
            this.FeeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FeeTextBox.Location = new System.Drawing.Point(518, 93);
            this.FeeTextBox.Name = "FeeTextBox";
            this.FeeTextBox.Size = new System.Drawing.Size(159, 29);
            this.FeeTextBox.TabIndex = 4;
            this.FeeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FeeTextBox_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.MembershipLabel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.AddMembershipTypeButton);
            this.panel2.Controls.Add(this.FeeTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.DeleteButton);
            this.panel2.Controls.Add(this.NameTextBox);
            this.panel2.Controls.Add(this.EndTimePicker);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.StartTimePicker);
            this.panel2.Controls.Add(this.UpdateButton);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 516);
            this.panel2.TabIndex = 52;
            // 
            // MembershipTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 540);
            this.Controls.Add(this.panel2);
            this.Name = "MembershipTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MembershipForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MembershipsDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private Label MembershipLabel;
    private Button AddMembershipTypeButton;
    private Button UpdateButton;
    private Label label1;
    private TextBox NameTextBox;
    private Label label2;
    private Label label3;
    private DateTimePicker StartTimePicker;
    private DateTimePicker EndTimePicker;
    private Button DeleteButton;
    private Panel panel1;
    private Label label4;
    private TextBox FeeTextBox;
    private DataGridView MembershipsDataGridView;
    private Panel panel2;
}
