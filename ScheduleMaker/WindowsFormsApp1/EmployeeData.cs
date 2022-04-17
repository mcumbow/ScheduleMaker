using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleMaker
{
    public class EmployeeData
    {
        public string m_FirstName { get; set; }
        public string m_LastName { get; set; }
        public DateTime m_Date { get; set; }
        private char m_Union { get; set; }
        private int m_HrlyShift { get; set; }
        public int m_Team { get; set; }

        public EmployeeData()
        {
            //default constructor
        }

        public EmployeeData(String FirstName, String LastName, DateTime date, char union, int HrlyShift, int team)
        {
            m_FirstName = FirstName;
            m_LastName = LastName;
            m_Date = date;
            m_Union = union;
            m_HrlyShift = HrlyShift;
            m_Team = team;
        }
    }
}
