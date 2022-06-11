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
        EmployeeData emp;
        bool modified = false;

        public SchedulerForm()
        {
            modified = true;
            InitializeComponent();
        }

        private void m_btnAddEmployee_Click(object sender, EventArgs e)
        {
            modified = true;
            addEmployeesForm.ClearAll();
            addEmployeesForm.ShowDialog();
        }

        private void SchedulerForm_Activated(object sender, EventArgs e)
        {
            if (modified)
            {
                UpdateList();
                modified = false;
            }           
        }

        private void SchedulerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            emp = new EmployeeData();
            emp.SaveToStream(addEmployeesForm.employeesList);
        }

        private void m_btnEditEmployee_Click(object sender, EventArgs e)
        {
            modified = true;
            if (m_lbEmployees.SelectedItem == null)
                MessageBox.Show("You must select an employee");
            else
            {
                string emp1 = m_lbEmployees.SelectedItem.ToString();
                String[] EmployeeSplit = emp1.Split(' ');
                foreach (String emp2 in EmployeeSplit)
                {
                    if (addEmployeesForm.EmployeeDataMap.ContainsKey(emp2))
                        addEmployeesForm.PopulateEmployee(addEmployeesForm.employeesList[addEmployeesForm.EmployeeDataMap[emp2]]);
                }
                addEmployeesForm.IsEditMode();
                addEmployeesForm.ShowDialog();
            }
        }
        /*
         * Next thing I want to do
         * -chang some of this to use linq and clean up the code
         * -add a gridcontrol out from the employee box for the days employee works
         */

        private void m_DeleteEmployee_Click(object sender, EventArgs e)
        {
            modified = true;
            if (m_lbEmployees.SelectedItem == null)
                MessageBox.Show("You must select an employee");
            else
            {
                string emp1 = m_lbEmployees.SelectedItem.ToString();
                String[] EmployeeSplit = emp1.Split(' ');
                foreach (string emp2 in EmployeeSplit)
                {
                    if (addEmployeesForm.EmployeeDataMap.ContainsKey(emp2))
                    {
                        int index = addEmployeesForm.EmployeeDataMap[emp2];
                        MessageBox.Show(addEmployeesForm.employeesList[index].m_FirstName + " " + addEmployeesForm.employeesList[index].m_LastName + " Deleted!");
                        addEmployeesForm.employeesList.RemoveAt(index);
                        addEmployeesForm.mapEmployeeData();
                        break;
                    }
                } 
            }
            UpdateList();
        }

        //Updates the listbox of employees using search bar
        private void UpdateList()
        {
            m_lbEmployees.Items.Clear();
            foreach (EmployeeData emp in addEmployeesForm.employeesList)
                m_lbEmployees.Items.Add(emp.m_Id.ToString() + ' ' + emp.m_LastName + ' ' + emp.m_FirstName);
        }

        private void m_txtNameSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (addEmployeesForm.EmployeeDataMap.ContainsKey(m_txtNameSearch.Text))
            {
                int index = addEmployeesForm.EmployeeDataMap[m_txtNameSearch.Text];
                m_lbEmployees.Items.Clear();
                m_lbEmployees.Items.Add(addEmployeesForm.employeesList[index].m_Id+ " " + addEmployeesForm.employeesList[index].m_LastName + " " + addEmployeesForm.employeesList[index].m_FirstName);
            }
            else if (m_txtNameSearch.Text != "")
            {
                m_lbEmployees.Items.Clear();
                foreach (EmployeeData emp in addEmployeesForm.employeesList)
                {
                    if (m_txtNameSearch.Text.ToLower().Contains(emp.m_FirstName.ToLower()) || m_txtNameSearch.Text.ToLower().Contains(emp.m_LastName.ToLower()))
                        m_lbEmployees.Items.Add(emp.m_Id + " " + emp.m_LastName + " " + emp.m_FirstName);
                }
            }
            else
            {
                m_lbEmployees.Items.Clear();
                foreach (EmployeeData emp in addEmployeesForm.employeesList)
                {
                    m_lbEmployees.Items.Add(emp.m_Id + " " + emp.m_LastName + " " + emp.m_FirstName);
                }
            }
        }

        private void m_btnClear_Click(object sender, EventArgs e)
        {
            m_txtNameSearch.Text = "";
            UpdateList();
        }
    }
}
