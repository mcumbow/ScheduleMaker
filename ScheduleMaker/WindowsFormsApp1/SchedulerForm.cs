using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleMaker
{
    public partial class SchedulerForm : Form
    {
        AddEmployeesForm addEmployeesForm = new AddEmployeesForm();

        public SchedulerForm()
        {
            InitializeComponent();
        }

        private void m_btnAddEmployee_Click(object sender, EventArgs e)
        {
            addEmployeesForm.ShowDialog();
        }

        private void SchedulerForm_Activated(object sender, EventArgs e)
        {
            if (addEmployeesForm != null)
            {
                m_lbEmployees.Items.Clear();
               foreach(Employee emp in addEmployeesForm.employeesList)
                {
                    m_lbEmployees.Items.Add(emp.m_FirstName);
                }
            }
                    
        }
    }
}
