namespace GMSUI.Forms
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EmployeesDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.PhoneNumber2TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumber1TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.HomeButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.AllRadioButton = new System.Windows.Forms.RadioButton();
            this.TrainerOnlyRadioButton = new System.Windows.Forms.RadioButton();
            this.StaffOnlyRadioButton = new System.Windows.Forms.RadioButton();
            this.JobTypeComboBox = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmployeeLabel.Location = new System.Drawing.Point(81, 22);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(136, 32);
            this.EmployeeLabel.TabIndex = 0;
            this.EmployeeLabel.Text = "Employees";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.EmployeesDataGridView);
            this.panel2.Location = new System.Drawing.Point(12, 316);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 294);
            this.panel2.TabIndex = 16;
            // 
            // EmployeesDataGridView
            // 
            this.EmployeesDataGridView.AllowUserToAddRows = false;
            this.EmployeesDataGridView.AllowUserToDeleteRows = false;
            this.EmployeesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EmployeeName,
            this.Address,
            this.Salary,
            this.JobType,
            this.PhoneNumber1,
            this.PhoneNumber2});
            this.EmployeesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.EmployeesDataGridView.Name = "EmployeesDataGridView";
            this.EmployeesDataGridView.ReadOnly = true;
            this.EmployeesDataGridView.RowTemplate.Height = 25;
            this.EmployeesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeesDataGridView.Size = new System.Drawing.Size(1011, 294);
            this.EmployeesDataGridView.TabIndex = 11;
            this.EmployeesDataGridView.TabStop = false;
            this.EmployeesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeesDataGridView_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "EmployeeName";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // JobType
            // 
            this.JobType.HeaderText = "Job Type";
            this.JobType.Name = "JobType";
            this.JobType.ReadOnly = true;
            // 
            // PhoneNumber1
            // 
            this.PhoneNumber1.HeaderText = "Phone Number 1";
            this.PhoneNumber1.Name = "PhoneNumber1";
            this.PhoneNumber1.ReadOnly = true;
            // 
            // PhoneNumber2
            // 
            this.PhoneNumber2.HeaderText = "Phone Number 2";
            this.PhoneNumber2.Name = "PhoneNumber2";
            this.PhoneNumber2.ReadOnly = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(246, 237);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(159, 48);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(414, 237);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(159, 48);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(81, 237);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(159, 48);
            this.AddEmployeeButton.TabIndex = 7;
            this.AddEmployeeButton.Text = "Add Employee";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PhoneNumber2TextBox
            // 
            this.PhoneNumber2TextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumber2TextBox.Location = new System.Drawing.Point(414, 178);
            this.PhoneNumber2TextBox.Name = "PhoneNumber2TextBox";
            this.PhoneNumber2TextBox.Size = new System.Drawing.Size(159, 29);
            this.PhoneNumber2TextBox.TabIndex = 6;
            this.PhoneNumber2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumber2TextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(81, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(414, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Phone Number 2";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTextBox.Location = new System.Drawing.Point(81, 104);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(159, 29);
            this.NameTextBox.TabIndex = 1;
            // 
            // PhoneNumber1TextBox
            // 
            this.PhoneNumber1TextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumber1TextBox.Location = new System.Drawing.Point(249, 178);
            this.PhoneNumber1TextBox.Name = "PhoneNumber1TextBox";
            this.PhoneNumber1TextBox.Size = new System.Drawing.Size(159, 29);
            this.PhoneNumber1TextBox.TabIndex = 5;
            this.PhoneNumber1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumber1TextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(246, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(249, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone Number 1";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddressTextBox.Location = new System.Drawing.Point(246, 104);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(159, 29);
            this.AddressTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(411, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(81, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Job Type";
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalaryTextBox.Location = new System.Drawing.Point(411, 104);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(159, 29);
            this.SalaryTextBox.TabIndex = 3;
            this.SalaryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalaryTextBox_KeyPress);
            // 
            // HomeButton
            // 
            this.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeButton.Image = global::GMSUI.Properties.Resources.home_60x60;
            this.HomeButton.Location = new System.Drawing.Point(12, 11);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(63, 58);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintButton.Location = new System.Drawing.Point(864, 616);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(159, 48);
            this.PrintButton.TabIndex = 12;
            this.PrintButton.TabStop = false;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // AllRadioButton
            // 
            this.AllRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AllRadioButton.AutoSize = true;
            this.AllRadioButton.Checked = true;
            this.AllRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AllRadioButton.Location = new System.Drawing.Point(898, 223);
            this.AllRadioButton.Name = "AllRadioButton";
            this.AllRadioButton.Size = new System.Drawing.Size(46, 25);
            this.AllRadioButton.TabIndex = 10;
            this.AllRadioButton.TabStop = true;
            this.AllRadioButton.Text = "All";
            this.AllRadioButton.UseVisualStyleBackColor = true;
            this.AllRadioButton.CheckedChanged += new System.EventHandler(this.AllRadioButton_CheckedChanged);
            // 
            // TrainerOnlyRadioButton
            // 
            this.TrainerOnlyRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TrainerOnlyRadioButton.AutoSize = true;
            this.TrainerOnlyRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TrainerOnlyRadioButton.Location = new System.Drawing.Point(898, 254);
            this.TrainerOnlyRadioButton.Name = "TrainerOnlyRadioButton";
            this.TrainerOnlyRadioButton.Size = new System.Drawing.Size(113, 25);
            this.TrainerOnlyRadioButton.TabIndex = 11;
            this.TrainerOnlyRadioButton.Text = "Trainer Only";
            this.TrainerOnlyRadioButton.UseVisualStyleBackColor = true;
            this.TrainerOnlyRadioButton.CheckedChanged += new System.EventHandler(this.TrainerOnlyRadioButton_CheckedChanged);
            // 
            // StaffOnlyRadioButton
            // 
            this.StaffOnlyRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StaffOnlyRadioButton.AutoSize = true;
            this.StaffOnlyRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StaffOnlyRadioButton.Location = new System.Drawing.Point(898, 285);
            this.StaffOnlyRadioButton.Name = "StaffOnlyRadioButton";
            this.StaffOnlyRadioButton.Size = new System.Drawing.Size(96, 25);
            this.StaffOnlyRadioButton.TabIndex = 12;
            this.StaffOnlyRadioButton.Text = "Staff Only";
            this.StaffOnlyRadioButton.UseVisualStyleBackColor = true;
            this.StaffOnlyRadioButton.CheckedChanged += new System.EventHandler(this.StaffOnlyRadioButton_CheckedChanged);
            // 
            // JobTypeComboBox
            // 
            this.JobTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.JobTypeComboBox.FormattingEnabled = true;
            this.JobTypeComboBox.Items.AddRange(new object[] {
            "Staff",
            "Trainer"});
            this.JobTypeComboBox.Location = new System.Drawing.Point(81, 178);
            this.JobTypeComboBox.Name = "JobTypeComboBox";
            this.JobTypeComboBox.Size = new System.Drawing.Size(159, 29);
            this.JobTypeComboBox.TabIndex = 4;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1035, 676);
            this.Controls.Add(this.JobTypeComboBox);
            this.Controls.Add(this.StaffOnlyRadioButton);
            this.Controls.Add(this.TrainerOnlyRadioButton);
            this.Controls.Add(this.AllRadioButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.EmployeeLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PhoneNumber2TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PhoneNumber1TextBox);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label EmployeeLabel;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button AddEmployeeButton;
        private Panel panel2;
        private TextBox PhoneNumber2TextBox;
        private Label label1;
        private Label label6;
        private TextBox NameTextBox;
        private TextBox PhoneNumber1TextBox;
        private Label label2;
        private Label label5;
        private TextBox AddressTextBox;
        private Label label3;
        private Label label4;
        private TextBox SalaryTextBox;
        private Button HomeButton;
        private Button PrintButton;
        private DataGridView EmployeesDataGridView;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Salary;
        private DataGridViewTextBoxColumn JobType;
        private DataGridViewTextBoxColumn PhoneNumber1;
        private DataGridViewTextBoxColumn PhoneNumber2;
        private RadioButton AllRadioButton;
        private RadioButton TrainerOnlyRadioButton;
        private RadioButton StaffOnlyRadioButton;
        private ComboBox JobTypeComboBox;
    }
}