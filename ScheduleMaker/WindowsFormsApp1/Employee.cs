using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleMaker
{
    internal class Employee
    {
        private List<Employee> employeesList = new List<Employee>();
        private string m_FirstName { get; set; }
        private string m_LastName { get; set; }
        private DateTime m_Date { get; set; }
        private char m_Union { get; set; }
        private int m_HrlyShift { get; set; }
        private int m_Team { get; set; }

        public Employee()
        {
            //default constructor
        }

        public Employee(String FirstName, String LastName, DateTime date, char union, int HrlyShift, int team)
        {
            m_FirstName = FirstName;
            m_LastName = LastName;
            m_Date = date;
            m_Union = union;
            m_HrlyShift = HrlyShift;
            m_Team = team;
        }

        public void AddEmployee(Employee employee)
        {
            employeesList.Add(employee);
        }

        public List<Employee> EmployeesList
        {
            get { return employeesList; }
        }
    }
}
