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
        bool boolEdit = false;
        EmployeeData m_Employee;
        int CurrentID;

        public Dictionary<int, EmployeeData> Employees = new Dictionary<int, EmployeeData>();

        public AddEmployeesForm()
        {
            InitializeComponent();
            m_Employee = new EmployeeData();
            m_Employee.ReadFromStream(Employees);
            EmptyValueCheck("firstname");
            EmptyValueCheck("lastname");
            EmptyValueCheck("id");
        }

        private void m_btnSaveEmployee_Click(object sender, EventArgs e)
        {
            if (EmptyValueCheck("firstname") == true && EmptyValueCheck("lastname") == true && EmptyValueCheck("id") == true)
            {
                EmployeeData newEmployee = new EmployeeData(GetID(), m_txtFirstName.Text, m_txtLastName.Text, GetDate(), UnionCheck(), ShiftCheck(), TeamCheck());
                if (boolEdit)
                {
                    if (Employees.ContainsKey(CurrentID))
                    {
                        Employees[CurrentID] = newEmployee;
                        m_Employee.SaveToStream(Employees);
                    }
                    boolEdit = false;
                    Close();
                    MessageBox.Show(m_txtFirstName.Text + " " + m_txtLastName.Text + " " + m_txtID.Text + " Was Updated Successfully!");
                }
                else if (Employees.ContainsKey(GetID()))
                {
                    MessageBox.Show("Employee ID already Exist");
                }
                else
                {
                    Employees.Add(GetID(), newEmployee);
                }
                ClearAll();
            }
            else
                MessageBox.Show("You cannot leave anything blank");
        }

        public void ClearAll()
        {
            m_txtID.Clear();
            m_txtFirstName.Clear();
            m_txtLastName.Clear();
            m_ckUnion.Checked = false;
            m_rb12HrShift.Checked = false;
            m_rb8HrShift.Checked = false;
            m_rbSalary.Checked = false;
            m_rbTeam1.Checked = false;
            m_rbTeam2.Checked = false;
            m_rbTeam3.Checked = false;
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

        public int GetID()
        {
            int id = 0;
            if (m_txtID.Text == string.Empty)
                m_btnSaveEmployee.Enabled = false;
            else
                id = Convert.ToInt32(m_txtID.Text);
            return id;
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

        public String GetDate()
        {
            return m_dateTimePicker.Value.ToShortDateString();    
        }

        private void m_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void PopulateEmployee(EmployeeData employee)
        {
            CurrentID = employee.m_Id;

            if (employee.m_Union == 'y')
                m_ckUnion.Checked = true;
            else
                m_ckUnion.Checked = false;
            
            if (employee.m_HrlyShift == 8)
                m_rb8HrShift.Checked = true;
            if (employee.m_HrlyShift == 12)
                m_rb12HrShift.Checked = true;
            if (employee.m_HrlyShift == 24)
                m_rbSalary.Checked = true;
            if (employee.m_Team == 1)
                m_rbTeam1.Checked = true;
            if (employee.m_Team == 2)
                m_rbTeam2.Checked = true;
            if (employee.m_Team == 3)
                m_rbTeam3.Checked = true;
            m_txtID.Text = employee.m_Id.ToString();
            m_txtFirstName.Text = employee.m_FirstName;
            m_txtLastName.Text = employee.m_LastName;
            m_dateTimePicker.Text = employee.m_Date;
        }

        public void IsEditMode()
        {
            boolEdit = true;
        }

        public bool EmptyValueCheck(String field)
        {
            bool flag = false;
            if (field == "firstname")
            {
                if (m_txtFirstName.Text == String.Empty)
                {
                    m_txtFirstName.BackColor = Color.LightPink;
                    flag = false;
                }
                else
                {
                    m_txtFirstName.BackColor = Color.White;
                    flag = true;
                }
            }

            if (field == "lastname")
            {
                if (m_txtLastName.Text == String.Empty)
                {
                    m_txtLastName.BackColor = Color.LightPink;
                    flag = false;
                }
                else
                {
                    m_txtLastName.BackColor = Color.White;
                    flag = true;
                }
            }

            if (field == "id")
            {
                if (m_txtID.Text == String.Empty)
                {
                    m_txtID.BackColor = Color.LightPink;
                    flag = false;
                }
                else
                {
                    m_txtID.BackColor = Color.White;
                    flag = true;
                }
            }
            return flag;
        }

        private void m_txtFirstName_TextChanged(object sender, EventArgs e)
        {
            EmptyValueCheck("firstname");
        }

        private void m_txtLastName_TextChanged(object sender, EventArgs e)
        {
            EmptyValueCheck("lastname");
        }

        private void m_txtID_TextChanged(object sender, EventArgs e)
        {
            EmptyValueCheck("id");
        }

        public void AddEmployeeToList(EmployeeData employee, int id)
        {
            Employees.Add(id, employee);
        }
    }
}
