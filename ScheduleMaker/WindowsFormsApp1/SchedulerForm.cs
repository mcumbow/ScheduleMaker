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

        private AddEmployeesForm addEmployeesForm;
        private List<Employee> employees { get; }

        public SchedulerForm()
        {
            InitializeComponent();
        }

        private void m_btnAddEmployee_Click(object sender, EventArgs e)
        {
            addEmployeesForm = new AddEmployeesForm();
            addEmployeesForm.ShowDialog();
        }

        public void UpdateEmployeesToListBox(List<Employee> list)
        {
            foreach(Employee emp in list)
            {
                m_lbEmployees.Items.Add(emp.m_FirstName);
            }
        }
    }
}
