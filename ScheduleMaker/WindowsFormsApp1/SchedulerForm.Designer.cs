namespace ScheduleMaker
{
    partial class SchedulerForm
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
            this.m_lbEmployees = new System.Windows.Forms.ListBox();
            this.m_txtNameSearch = new System.Windows.Forms.TextBox();
            this.m_btnClear = new System.Windows.Forms.Button();
            this.m_btnAddEmployee = new System.Windows.Forms.Button();
            this.m_btnEditEmployee = new System.Windows.Forms.Button();
            this.m_DeleteEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_lbEmployees
            // 
            this.m_lbEmployees.FormattingEnabled = true;
            this.m_lbEmployees.Location = new System.Drawing.Point(12, 56);
            this.m_lbEmployees.Name = "m_lbEmployees";
            this.m_lbEmployees.Size = new System.Drawing.Size(249, 316);
            this.m_lbEmployees.TabIndex = 0;
            // 
            // m_txtNameSearch
            // 
            this.m_txtNameSearch.Location = new System.Drawing.Point(12, 30);
            this.m_txtNameSearch.Name = "m_txtNameSearch";
            this.m_txtNameSearch.Size = new System.Drawing.Size(168, 20);
            this.m_txtNameSearch.TabIndex = 1;
            // 
            // m_btnClear
            // 
            this.m_btnClear.Location = new System.Drawing.Point(186, 30);
            this.m_btnClear.Name = "m_btnClear";
            this.m_btnClear.Size = new System.Drawing.Size(75, 23);
            this.m_btnClear.TabIndex = 2;
            this.m_btnClear.Text = "Clear";
            this.m_btnClear.UseVisualStyleBackColor = true;
            // 
            // m_btnAddEmployee
            // 
            this.m_btnAddEmployee.Location = new System.Drawing.Point(12, 378);
            this.m_btnAddEmployee.Name = "m_btnAddEmployee";
            this.m_btnAddEmployee.Size = new System.Drawing.Size(97, 23);
            this.m_btnAddEmployee.TabIndex = 3;
            this.m_btnAddEmployee.Text = "Add Employee";
            this.m_btnAddEmployee.UseVisualStyleBackColor = true;
            this.m_btnAddEmployee.Click += new System.EventHandler(this.m_btnAddEmployee_Click);
            // 
            // m_btnEditEmployee
            // 
            this.m_btnEditEmployee.Location = new System.Drawing.Point(115, 378);
            this.m_btnEditEmployee.Name = "m_btnEditEmployee";
            this.m_btnEditEmployee.Size = new System.Drawing.Size(42, 23);
            this.m_btnEditEmployee.TabIndex = 4;
            this.m_btnEditEmployee.Text = "Edit";
            this.m_btnEditEmployee.UseVisualStyleBackColor = true;
            // 
            // m_DeleteEmployee
            // 
            this.m_DeleteEmployee.Location = new System.Drawing.Point(163, 378);
            this.m_DeleteEmployee.Name = "m_DeleteEmployee";
            this.m_DeleteEmployee.Size = new System.Drawing.Size(98, 23);
            this.m_DeleteEmployee.TabIndex = 5;
            this.m_DeleteEmployee.Text = "Delete Employee";
            this.m_DeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // SchedulerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 719);
            this.Controls.Add(this.m_DeleteEmployee);
            this.Controls.Add(this.m_btnEditEmployee);
            this.Controls.Add(this.m_btnAddEmployee);
            this.Controls.Add(this.m_btnClear);
            this.Controls.Add(this.m_txtNameSearch);
            this.Controls.Add(this.m_lbEmployees);
            this.Name = "SchedulerForm";
            this.Text = "Scheduler";
            this.Activated += new System.EventHandler(this.SchedulerForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox m_lbEmployees;
        private System.Windows.Forms.TextBox m_txtNameSearch;
        private System.Windows.Forms.Button m_btnClear;
        private System.Windows.Forms.Button m_btnAddEmployee;
        private System.Windows.Forms.Button m_btnEditEmployee;
        private System.Windows.Forms.Button m_DeleteEmployee;
    }
}

