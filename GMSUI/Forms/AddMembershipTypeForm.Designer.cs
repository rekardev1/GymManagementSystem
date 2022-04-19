namespace GMSUI.Forms;

partial class AddMembershipTypeForm {
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
            this.label4 = new System.Windows.Forms.Label();
            this.FeeTextBox = new System.Windows.Forms.TextBox();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddMembershipTypeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(527, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 21);
            this.label4.TabIndex = 59;
            this.label4.Text = "Fee";
            // 
            // FeeTextBox
            // 
            this.FeeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FeeTextBox.Location = new System.Drawing.Point(527, 58);
            this.FeeTextBox.Name = "FeeTextBox";
            this.FeeTextBox.Size = new System.Drawing.Size(159, 29);
            this.FeeTextBox.TabIndex = 4;
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EndTimePicker.Location = new System.Drawing.Point(364, 58);
            this.EndTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.Size = new System.Drawing.Size(157, 29);
            this.EndTimePicker.TabIndex = 3;
            this.EndTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartTimePicker.Location = new System.Drawing.Point(177, 58);
            this.StartTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.Size = new System.Drawing.Size(181, 29);
            this.StartTimePicker.TabIndex = 2;
            this.StartTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 55;
            this.label1.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTextBox.Location = new System.Drawing.Point(12, 58);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(159, 29);
            this.NameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(177, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 56;
            this.label2.Text = "Starting Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(364, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 57;
            this.label3.Text = "Ending Time";
            // 
            // AddMembershipTypeButton
            // 
            this.AddMembershipTypeButton.Location = new System.Drawing.Point(527, 112);
            this.AddMembershipTypeButton.Name = "AddMembershipTypeButton";
            this.AddMembershipTypeButton.Size = new System.Drawing.Size(159, 48);
            this.AddMembershipTypeButton.TabIndex = 5;
            this.AddMembershipTypeButton.Text = "Add Membership";
            this.AddMembershipTypeButton.UseVisualStyleBackColor = true;
            this.AddMembershipTypeButton.Click += new System.EventHandler(this.AddMembershipTypeButton_Click);
            // 
            // AddMembershipTypeForm
            // 
            this.AcceptButton = this.AddMembershipTypeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 450);
            this.Controls.Add(this.AddMembershipTypeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FeeTextBox);
            this.Controls.Add(this.EndTimePicker);
            this.Controls.Add(this.StartTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "AddMembershipTypeForm";
            this.Text = "AddMembershipTypeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label label4;
    private TextBox FeeTextBox;
    private DateTimePicker EndTimePicker;
    private DateTimePicker StartTimePicker;
    private Label label1;
    private TextBox NameTextBox;
    private Label label2;
    private Label label3;
    private Button AddMembershipTypeButton;
}
