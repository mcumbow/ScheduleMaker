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
    public partial class AddEmployeesForm : Form
    {
        public List<Employee> employeesList = new List<Employee>();
        public AddEmployeesForm()
        {
            InitializeComponent();  
        }

        private void m_btnSaveEmployee_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee(m_txtFirstName.Text, m_txtLastName.Text, GetDate(), UnionCheck(), ShiftCheck(), TeamCheck());
            employeesList.Add(newEmployee);
            ClearAll();
        }

        public void ClearAll()
        {
            m_ckUnion.Checked = false;
            m_rb12HrShift.Checked = false;
            m_rb8HrShift.Checked = false;
            m_rbSalary.Checked = false;
            m_rbTeam1.Checked = false;
            m_rbTeam2.Checked = false;
            m_rbTeam3.Checked = false;
            m_txtFirstName.Text = string.Empty;
            m_txtLastName.Text = string.Empty;
        }
        public int ShiftCheck()
        {
            int shift = 0;

            if (m_rb8HrShift.Checked)
                shift = 8;
            if (m_rb12HrShift.Checked)
                shift = 12;
            if (m_rbSalary.Checked)
                shift = 24;
            return shift;
        }

        public int TeamCheck()
        {
            int team = 0;

            if (m_rbTeam1.Checked)
                team = 1;
            if (m_rbTeam2.Checked)
                team = 2;
            if (m_rbTeam3.Checked)
                team = 3;
            return team;
        }

        public char UnionCheck()
        {
            if (m_ckUnion.Checked)
                return 'y';
            return 'n';
        }

        public DateTime GetDate()
        {
            return dateTimePicker.Value.Date;       
        }

        private void m_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
