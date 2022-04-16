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
    public partial class Scheduler : Form
    {
        private AddEmployees addEmployeesForm;

        public Scheduler()
        {
            InitializeComponent();
        }

        private void m_btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployees addEmployeeForm = new AddEmployees();
            addEmployeeForm.ShowDialog();
        }
    }
}
