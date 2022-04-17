namespace ScheduleMaker
{
    partial class AddEmployeesForm
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
            this.m_txtFirstName = new System.Windows.Forms.TextBox();
            this.m_txtLastName = new System.Windows.Forms.TextBox();
            this.m_lblFirstName = new System.Windows.Forms.Label();
            this.m_lblLastName = new System.Windows.Forms.Label();
            this.m_lblHireDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.m_lblUnion = new System.Windows.Forms.Label();
            this.m_ckUnion = new System.Windows.Forms.CheckBox();
            this.m_btnSaveEmployee = new System.Windows.Forms.Button();
            this.m_gbShift = new System.Windows.Forms.GroupBox();
            this.m_rbSalary = new System.Windows.Forms.RadioButton();
            this.m_rb12HrShift = new System.Windows.Forms.RadioButton();
            this.m_rb8HrShift = new System.Windows.Forms.RadioButton();
            this.m_gbTeam = new System.Windows.Forms.GroupBox();
            this.m_rbTeam3 = new System.Windows.Forms.RadioButton();
            this.m_rbTeam2 = new System.Windows.Forms.RadioButton();
            this.m_rbTeam1 = new System.Windows.Forms.RadioButton();
            this.m_btnClose = new System.Windows.Forms.Button();
            this.m_gbShift.SuspendLayout();
            this.m_gbTeam.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_txtFirstName
            // 
            this.m_txtFirstName.Location = new System.Drawing.Point(75, 33);
            this.m_txtFirstName.Name = "m_txtFirstName";
            this.m_txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.m_txtFirstName.TabIndex = 0;
            // 
            // m_txtLastName
            // 
            this.m_txtLastName.Location = new System.Drawing.Point(75, 59);
            this.m_txtLastName.Name = "m_txtLastName";
            this.m_txtLastName.Size = new System.Drawing.Size(100, 20);
            this.m_txtLastName.TabIndex = 1;
            // 
            // m_lblFirstName
            // 
            this.m_lblFirstName.AutoSize = true;
            this.m_lblFirstName.Location = new System.Drawing.Point(12, 40);
            this.m_lblFirstName.Name = "m_lblFirstName";
            this.m_lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.m_lblFirstName.TabIndex = 2;
            this.m_lblFirstName.Text = "First Name:";
            // 
            // m_lblLastName
            // 
            this.m_lblLastName.AutoSize = true;
            this.m_lblLastName.Location = new System.Drawing.Point(12, 66);
            this.m_lblLastName.Name = "m_lblLastName";
            this.m_lblLastName.Size = new System.Drawing.Size(61, 13);
            this.m_lblLastName.TabIndex = 3;
            this.m_lblLastName.Text = "Last Name:";
            // 
            // m_lblHireDate
            // 
            this.m_lblHireDate.AutoSize = true;
            this.m_lblHireDate.Location = new System.Drawing.Point(17, 92);
            this.m_lblHireDate.Name = "m_lblHireDate";
            this.m_lblHireDate.Size = new System.Drawing.Size(55, 13);
            this.m_lblHireDate.TabIndex = 5;
            this.m_lblHireDate.Text = "Hire Date:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(75, 86);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker.TabIndex = 6;
            // 
            // m_lblUnion
            // 
            this.m_lblUnion.AutoSize = true;
            this.m_lblUnion.Location = new System.Drawing.Point(34, 116);
            this.m_lblUnion.Name = "m_lblUnion";
            this.m_lblUnion.Size = new System.Drawing.Size(38, 13);
            this.m_lblUnion.TabIndex = 7;
            this.m_lblUnion.Text = "Union:";
            // 
            // m_ckUnion
            // 
            this.m_ckUnion.AutoSize = true;
            this.m_ckUnion.Location = new System.Drawing.Point(76, 116);
            this.m_ckUnion.Name = "m_ckUnion";
            this.m_ckUnion.Size = new System.Drawing.Size(117, 17);
            this.m_ckUnion.TabIndex = 8;
            this.m_ckUnion.Text = "Is employee union?";
            this.m_ckUnion.UseVisualStyleBackColor = true;
            // 
            // m_btnSaveEmployee
            // 
            this.m_btnSaveEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnSaveEmployee.Location = new System.Drawing.Point(126, 241);
            this.m_btnSaveEmployee.Name = "m_btnSaveEmployee";
            this.m_btnSaveEmployee.Size = new System.Drawing.Size(75, 23);
            this.m_btnSaveEmployee.TabIndex = 17;
            this.m_btnSaveEmployee.Text = "Save";
            this.m_btnSaveEmployee.UseVisualStyleBackColor = true;
            this.m_btnSaveEmployee.Click += new System.EventHandler(this.m_btnSaveEmployee_Click);
            // 
            // m_gbShift
            // 
            this.m_gbShift.Controls.Add(this.m_rbSalary);
            this.m_gbShift.Controls.Add(this.m_rb12HrShift);
            this.m_gbShift.Controls.Add(this.m_rb8HrShift);
            this.m_gbShift.Location = new System.Drawing.Point(12, 144);
            this.m_gbShift.Name = "m_gbShift";
            this.m_gbShift.Size = new System.Drawing.Size(138, 91);
            this.m_gbShift.TabIndex = 18;
            this.m_gbShift.TabStop = false;
            this.m_gbShift.Text = "Shift:";
            // 
            // m_rbSalary
            // 
            this.m_rbSalary.AutoSize = true;
            this.m_rbSalary.Location = new System.Drawing.Point(39, 65);
            this.m_rbSalary.Name = "m_rbSalary";
            this.m_rbSalary.Size = new System.Drawing.Size(54, 17);
            this.m_rbSalary.TabIndex = 16;
            this.m_rbSalary.TabStop = true;
            this.m_rbSalary.Text = "Salary";
            this.m_rbSalary.UseVisualStyleBackColor = true;
            // 
            // m_rb12HrShift
            // 
            this.m_rb12HrShift.AutoSize = true;
            this.m_rb12HrShift.Location = new System.Drawing.Point(39, 42);
            this.m_rb12HrShift.Name = "m_rb12HrShift";
            this.m_rb12HrShift.Size = new System.Drawing.Size(75, 17);
            this.m_rb12HrShift.TabIndex = 15;
            this.m_rb12HrShift.TabStop = true;
            this.m_rb12HrShift.Text = "12 Hr Shift";
            this.m_rb12HrShift.UseVisualStyleBackColor = true;
            // 
            // m_rb8HrShift
            // 
            this.m_rb8HrShift.AutoSize = true;
            this.m_rb8HrShift.Location = new System.Drawing.Point(39, 19);
            this.m_rb8HrShift.Name = "m_rb8HrShift";
            this.m_rb8HrShift.Size = new System.Drawing.Size(69, 17);
            this.m_rb8HrShift.TabIndex = 14;
            this.m_rb8HrShift.TabStop = true;
            this.m_rb8HrShift.Text = "8 Hr Shift";
            this.m_rb8HrShift.UseVisualStyleBackColor = true;
            // 
            // m_gbTeam
            // 
            this.m_gbTeam.Controls.Add(this.m_rbTeam3);
            this.m_gbTeam.Controls.Add(this.m_rbTeam2);
            this.m_gbTeam.Controls.Add(this.m_rbTeam1);
            this.m_gbTeam.Location = new System.Drawing.Point(156, 149);
            this.m_gbTeam.Name = "m_gbTeam";
            this.m_gbTeam.Size = new System.Drawing.Size(126, 86);
            this.m_gbTeam.TabIndex = 19;
            this.m_gbTeam.TabStop = false;
            this.m_gbTeam.Text = "Team:";
            // 
            // m_rbTeam3
            // 
            this.m_rbTeam3.AutoSize = true;
            this.m_rbTeam3.Location = new System.Drawing.Point(39, 63);
            this.m_rbTeam3.Name = "m_rbTeam3";
            this.m_rbTeam3.Size = new System.Drawing.Size(61, 17);
            this.m_rbTeam3.TabIndex = 19;
            this.m_rbTeam3.TabStop = true;
            this.m_rbTeam3.Text = "Team 3";
            this.m_rbTeam3.UseVisualStyleBackColor = true;
            // 
            // m_rbTeam2
            // 
            this.m_rbTeam2.AutoSize = true;
            this.m_rbTeam2.Location = new System.Drawing.Point(39, 40);
            this.m_rbTeam2.Name = "m_rbTeam2";
            this.m_rbTeam2.Size = new System.Drawing.Size(61, 17);
            this.m_rbTeam2.TabIndex = 18;
            this.m_rbTeam2.TabStop = true;
            this.m_rbTeam2.Text = "Team 2";
            this.m_rbTeam2.UseVisualStyleBackColor = true;
            // 
            // m_rbTeam1
            // 
            this.m_rbTeam1.AutoSize = true;
            this.m_rbTeam1.Location = new System.Drawing.Point(39, 17);
            this.m_rbTeam1.Name = "m_rbTeam1";
            this.m_rbTeam1.Size = new System.Drawing.Size(61, 17);
            this.m_rbTeam1.TabIndex = 17;
            this.m_rbTeam1.TabStop = true;
            this.m_rbTeam1.Text = "Team 1";
            this.m_rbTeam1.UseVisualStyleBackColor = true;
            // 
            // m_btnClose
            // 
            this.m_btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnClose.Location = new System.Drawing.Point(207, 241);
            this.m_btnClose.Name = "m_btnClose";
            this.m_btnClose.Size = new System.Drawing.Size(75, 23);
            this.m_btnClose.TabIndex = 20;
            this.m_btnClose.Text = "Close";
            this.m_btnClose.UseVisualStyleBackColor = true;
            this.m_btnClose.Click += new System.EventHandler(this.m_btnClose_Click);
            // 
            // AddEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(294, 277);
            this.Controls.Add(this.m_btnClose);
            this.Controls.Add(this.m_gbTeam);
            this.Controls.Add(this.m_gbShift);
            this.Controls.Add(this.m_btnSaveEmployee);
            this.Controls.Add(this.m_ckUnion);
            this.Controls.Add(this.m_lblUnion);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.m_lblHireDate);
            this.Controls.Add(this.m_lblLastName);
            this.Controls.Add(this.m_lblFirstName);
            this.Controls.Add(this.m_txtLastName);
            this.Controls.Add(this.m_txtFirstName);
            this.Name = "AddEmployeesForm";
            this.Text = "AddEmployees";
            this.m_gbShift.ResumeLayout(false);
            this.m_gbShift.PerformLayout();
            this.m_gbTeam.ResumeLayout(false);
            this.m_gbTeam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_txtFirstName;
        private System.Windows.Forms.TextBox m_txtLastName;
        private System.Windows.Forms.Label m_lblFirstName;
        private System.Windows.Forms.Label m_lblLastName;
        private System.Windows.Forms.Label m_lblHireDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label m_lblUnion;
        private System.Windows.Forms.CheckBox m_ckUnion;
        private System.Windows.Forms.Button m_btnSaveEmployee;
        private System.Windows.Forms.GroupBox m_gbShift;
        private System.Windows.Forms.RadioButton m_rbSalary;
        private System.Windows.Forms.RadioButton m_rb12HrShift;
        private System.Windows.Forms.RadioButton m_rb8HrShift;
        private System.Windows.Forms.GroupBox m_gbTeam;
        private System.Windows.Forms.RadioButton m_rbTeam3;
        private System.Windows.Forms.RadioButton m_rbTeam2;
        private System.Windows.Forms.RadioButton m_rbTeam1;
        private System.Windows.Forms.Button m_btnClose;
    }
}