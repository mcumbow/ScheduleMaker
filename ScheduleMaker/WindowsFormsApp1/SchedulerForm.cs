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
            emp.SaveToStream(addEmployeesForm.Employees);
        }

        private void m_btnEditEmployee_Click(object sender, EventArgs e)
        {
            modified = true;
            if (m_lbEmployees.SelectedItem == null)
                MessageBox.Show("You must select an employee");
            else
            {
                addEmployeesForm.IsEditMode();
                string emp1 = m_lbEmployees.SelectedItem.ToString();
                String[] EmployeeSplit = emp1.Split(' ');
                foreach (String emp2 in EmployeeSplit)
                {
                    int id;
                    bool isNumber = int.TryParse(emp2, out id);
                    if (isNumber == true && addEmployeesForm.Employees.ContainsKey(id))
                        addEmployeesForm.PopulateEmployee(addEmployeesForm.Employees[id]);
                }
                addEmployeesForm.ShowDialog();
            }
        }

        /*
        * Next thing I want to do
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
                    int id;
                    bool isNumber = int.TryParse(emp2, out id);
                    if (isNumber == true && addEmployeesForm.Employees.ContainsKey(id))
                    {
                        MessageBox.Show(addEmployeesForm.Employees[id].m_FirstName + " " + addEmployeesForm.Employees[id].m_LastName + " Deleted!");
                        addEmployeesForm.Employees.Remove(id);
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
            foreach (KeyValuePair<int, EmployeeData> emp in addEmployeesForm.Employees)
                m_lbEmployees.Items.Add(emp.Value.m_Id.ToString() + ' ' + emp.Value.m_LastName + ' ' + emp.Value.m_FirstName);
        }

        //Allows you to search by ID number, First name or last name, ignore case
        private void m_txtNameSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            int id;
            bool isNumber = int.TryParse(m_txtNameSearch.Text, out id);
            if (isNumber == true && addEmployeesForm.Employees.ContainsKey(id))
            {
                m_lbEmployees.Items.Clear();
                m_lbEmployees.Items.Add(addEmployeesForm.Employees[id].m_Id+ " " + addEmployeesForm.Employees[id].m_LastName + " " + addEmployeesForm.Employees[id].m_FirstName);
            }
            else if (m_txtNameSearch.Text != "")
            {
                m_lbEmployees.Items.Clear();
                foreach (KeyValuePair<int, EmployeeData> emp in addEmployeesForm.Employees)
                {
                    if (m_txtNameSearch.Text.ToLower().Contains(emp.Value.m_FirstName.ToLower()) || m_txtNameSearch.Text.ToLower().Contains(emp.Value.m_LastName.ToLower()))
                        m_lbEmployees.Items.Add(emp.Value.m_Id + " " + emp.Value.m_LastName + " " + emp.Value.m_FirstName);
                }
            }
            else
            {
                m_lbEmployees.Items.Clear();
                foreach (KeyValuePair<int, EmployeeData> emp in addEmployeesForm.Employees)
                {
                    m_lbEmployees.Items.Add(emp.Value.m_Id + " " + emp.Value.m_LastName + " " + emp.Value.m_FirstName);
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
