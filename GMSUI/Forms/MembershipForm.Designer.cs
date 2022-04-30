namespace GMSUI.Forms;

partial class MembershipForm {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MemberNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StartingDatePicker = new System.Windows.Forms.DateTimePicker();
            this.Terminateutton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ExpirationDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.PlansComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TrainersCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MembershipsDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsExpired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MembershipsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MemberNameTextBox
            // 
            this.MemberNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MemberNameTextBox.Location = new System.Drawing.Point(81, 92);
            this.MemberNameTextBox.Name = "MemberNameTextBox";
            this.MemberNameTextBox.ReadOnly = true;
            this.MemberNameTextBox.Size = new System.Drawing.Size(179, 29);
            this.MemberNameTextBox.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(746, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 84;
            this.label4.Text = "Starting Date";
            // 
            // StartingDatePicker
            // 
            this.StartingDatePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartingDatePicker.Location = new System.Drawing.Point(746, 92);
            this.StartingDatePicker.Name = "StartingDatePicker";
            this.StartingDatePicker.Size = new System.Drawing.Size(200, 29);
            this.StartingDatePicker.TabIndex = 4;
            // 
            // Terminateutton
            // 
            this.Terminateutton.Location = new System.Drawing.Point(342, 290);
            this.Terminateutton.Name = "Terminateutton";
            this.Terminateutton.Size = new System.Drawing.Size(159, 46);
            this.Terminateutton.TabIndex = 8;
            this.Terminateutton.Text = "Terminate";
            this.Terminateutton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(177, 290);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(159, 46);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(12, 290);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(159, 46);
            this.UpdateButton.TabIndex = 6;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(746, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 79;
            this.label3.Text = "Expiration Date";
            // 
            // ExpirationDatePicker
            // 
            this.ExpirationDatePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExpirationDatePicker.Location = new System.Drawing.Point(746, 157);
            this.ExpirationDatePicker.Name = "ExpirationDatePicker";
            this.ExpirationDatePicker.Size = new System.Drawing.Size(200, 29);
            this.ExpirationDatePicker.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(280, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 77;
            this.label2.Text = "Membership Type";
            // 
            // PlansComboBox
            // 
            this.PlansComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlansComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlansComboBox.FormattingEnabled = true;
            this.PlansComboBox.Location = new System.Drawing.Point(280, 92);
            this.PlansComboBox.Name = "PlansComboBox";
            this.PlansComboBox.Size = new System.Drawing.Size(207, 29);
            this.PlansComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(81, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 75;
            this.label1.Text = "Member";
            // 
            // TrainersCheckedListBox
            // 
            this.TrainersCheckedListBox.CheckOnClick = true;
            this.TrainersCheckedListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TrainersCheckedListBox.FormattingEnabled = true;
            this.TrainersCheckedListBox.Location = new System.Drawing.Point(493, 92);
            this.TrainersCheckedListBox.Name = "TrainersCheckedListBox";
            this.TrainersCheckedListBox.Size = new System.Drawing.Size(245, 172);
            this.TrainersCheckedListBox.TabIndex = 3;
            this.TrainersCheckedListBox.Leave += new System.EventHandler(this.TrainersCheckedListBox_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(493, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 21);
            this.label10.TabIndex = 72;
            this.label10.Text = "Trainers";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(81, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 32);
            this.label8.TabIndex = 55;
            this.label8.Text = "Memberships";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.MembershipsDataGridView);
            this.panel1.Location = new System.Drawing.Point(12, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 164);
            this.panel1.TabIndex = 68;
            // 
            // MembershipsDataGridView
            // 
            this.MembershipsDataGridView.AllowUserToAddRows = false;
            this.MembershipsDataGridView.AllowUserToDeleteRows = false;
            this.MembershipsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MembershipsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MembershipsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.MemberId,
            this.MemberName,
            this.TrainerName,
            this.PlanId,
            this.PlanName,
            this.StartingDate,
            this.ExpirationDate,
            this.IsExpired,
            this.UserId});
            this.MembershipsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MembershipsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.MembershipsDataGridView.MultiSelect = false;
            this.MembershipsDataGridView.Name = "MembershipsDataGridView";
            this.MembershipsDataGridView.ReadOnly = true;
            this.MembershipsDataGridView.RowTemplate.Height = 25;
            this.MembershipsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MembershipsDataGridView.Size = new System.Drawing.Size(995, 164);
            this.MembershipsDataGridView.TabIndex = 0;
            this.MembershipsDataGridView.TabStop = false;
            this.MembershipsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MembershipsDataGridView_CellClick);
            // 
            // Id
            // 
            dataGridViewCellStyle4.Format = "d";
            this.Id.DefaultCellStyle = dataGridViewCellStyle4;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // MemberId
            // 
            this.MemberId.HeaderText = "MemberId";
            this.MemberId.Name = "MemberId";
            this.MemberId.ReadOnly = true;
            this.MemberId.Visible = false;
            // 
            // MemberName
            // 
            this.MemberName.HeaderText = "Member";
            this.MemberName.Name = "MemberName";
            this.MemberName.ReadOnly = true;
            // 
            // TrainerName
            // 
            this.TrainerName.HeaderText = "Trainers";
            this.TrainerName.Name = "TrainerName";
            this.TrainerName.ReadOnly = true;
            // 
            // PlanId
            // 
            this.PlanId.HeaderText = "PlanId";
            this.PlanId.Name = "PlanId";
            this.PlanId.ReadOnly = true;
            this.PlanId.Visible = false;
            // 
            // PlanName
            // 
            this.PlanName.HeaderText = "Plan";
            this.PlanName.Name = "PlanName";
            this.PlanName.ReadOnly = true;
            // 
            // StartingDate
            // 
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.StartingDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.StartingDate.HeaderText = "Starting Date";
            this.StartingDate.Name = "StartingDate";
            this.StartingDate.ReadOnly = true;
            // 
            // ExpirationDate
            // 
            dataGridViewCellStyle6.Format = "d";
            this.ExpirationDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.ExpirationDate.HeaderText = "Expiration Date";
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.ReadOnly = true;
            // 
            // IsExpired
            // 
            this.IsExpired.HeaderText = "Is Expired";
            this.IsExpired.Name = "IsExpired";
            this.IsExpired.ReadOnly = true;
            // 
            // UserId
            // 
            this.UserId.HeaderText = "Added By";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(787, 290);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(159, 46);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeButton.Image = global::GMSUI.Properties.Resources.home_60x60;
            this.HomeButton.Location = new System.Drawing.Point(12, 12);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(63, 58);
            this.HomeButton.TabIndex = 86;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintButton.Location = new System.Drawing.Point(848, 512);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(159, 48);
            this.PrintButton.TabIndex = 87;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // MembershipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 572);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.MemberNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.StartingDatePicker);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Terminateutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.TrainersCheckedListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExpirationDatePicker);
            this.Controls.Add(this.PlansComboBox);
            this.Controls.Add(this.label2);
            this.Name = "MembershipForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MembershipForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MembershipsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private CheckedListBox TrainersCheckedListBox;
    private Label label10;
    private Label label8;
    private Panel panel1;
    private DataGridView MembershipsDataGridView;
    private Button AddButton;
    private Label label1;
    private Label label3;
    private DateTimePicker ExpirationDatePicker;
    private Label label2;
    private ComboBox PlansComboBox;
    private Button Terminateutton;
    private Button DeleteButton;
    private Button UpdateButton;
    private Label label4;
    private DateTimePicker StartingDatePicker;
    private TextBox MemberNameTextBox;
    private Button HomeButton;
    private Button PrintButton;
    private DataGridViewTextBoxColumn Id;
    private DataGridViewTextBoxColumn MemberId;
    private DataGridViewTextBoxColumn MemberName;
    private DataGridViewTextBoxColumn TrainerName;
    private DataGridViewTextBoxColumn PlanId;
    private DataGridViewTextBoxColumn PlanName;
    private DataGridViewTextBoxColumn StartingDate;
    private DataGridViewTextBoxColumn ExpirationDate;
    private DataGridViewTextBoxColumn IsExpired;
    private DataGridViewTextBoxColumn UserId;
}
