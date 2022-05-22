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

        public SchedulerForm()
        {
            InitializeComponent();
        }

        private void m_btnAddEmployee_Click(object sender, EventArgs e)
        {
            addEmployeesForm.ClearAll();
            addEmployeesForm.ShowDialog();
        }

        private void SchedulerForm_Activated(object sender, EventArgs e)
        {
            m_lbEmployees.Items.Clear();
            foreach(EmployeeData emp in addEmployeesForm.employeesList)
            {
                m_lbEmployees.Items.Add(emp.m_Id.ToString() + ' ' + emp.m_LastName + ' ' + emp.m_FirstName);
            }          
        }

        private void SchedulerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            emp = new EmployeeData();
            emp.SaveToStream(addEmployeesForm.employeesList);
        }

        private void m_btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (m_lbEmployees.SelectedItem == null)
                MessageBox.Show("You must select an employee");
            else
            {
                string emp1 = m_lbEmployees.SelectedItem.ToString();
                String[] EmployeeSplit = emp1.Split(' ');
                foreach (EmployeeData emp in addEmployeesForm.employeesList)
                {
                    bool ID = false;
                    foreach (String emp2 in EmployeeSplit)
                    {
                        if (emp.m_Id.ToString() == emp2)
                            ID = true;
                    }
                    if (ID)
                        addEmployeesForm.PopulateEmployee((EmployeeData)emp);
                }
                addEmployeesForm.IsEditMode();
                addEmployeesForm.ShowDialog();
            }
        }

        private void m_DeleteEmployee_Click(object sender, EventArgs e)
        {
            bool finished = false;
            if (m_lbEmployees.SelectedItem == null)
                MessageBox.Show("You must select an employee");
            else
            {
                string emp1 = m_lbEmployees.SelectedItem.ToString();
                String[] EmployeeSplit = emp1.Split(' ');
                foreach (EmployeeData emp in addEmployeesForm.employeesList)
                {
                    foreach (String emp2 in EmployeeSplit)
                    {
                        if (emp.m_Id.ToString() == emp2)
                        {
                            addEmployeesForm.employeesList.Remove(emp);
                            emp.SaveToStream(addEmployeesForm.employeesList);
                            MessageBox.Show(emp.m_FirstName + " " + emp.m_LastName + " "+ emp.m_Id + " Deleted!");
                            finished = true;
                        } 
                    }
                    if (finished)
                        break;
                } 
            }
        }
    }
}
