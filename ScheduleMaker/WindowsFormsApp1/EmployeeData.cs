using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ScheduleMaker
{
    public class EmployeeData
    {
        public int m_Id { get; set; }
        public string m_FirstName { get; set; }
        public string m_LastName { get; set; }
        public string m_Date { get; set; }
        public char m_Union { get; set; }
        public int m_HrlyShift { get; set; }
        public int m_Team { get; set; }

        public EmployeeData()
        {
            //default constructor
        }

        public EmployeeData(int ID, String FirstName, String LastName, String date, char union, int HrlyShift, int team)
        {
            m_Id = ID;
            m_FirstName = FirstName;
            m_LastName = LastName;
            m_Date = date;
            m_Union = union;
            m_HrlyShift = HrlyShift;
            m_Team = team;
        }

        public String AddEmployeeFormNullCheck()
        {
            if (m_Id < 0)
            {
                return "m_id";
            }
            return "true";
        }

        public void SaveToStream(Dictionary<int, EmployeeData> Employee)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                XmlNode rootNode = doc.CreateElement("Employees");
                doc.AppendChild(rootNode);
                foreach (KeyValuePair<int, EmployeeData> emp in Employee)
                {
                    XmlNode userNode = doc.CreateElement("Employees");
                    XmlAttribute ID = doc.CreateAttribute("ID");
                    ID.Value = emp.Value.m_Id.ToString();
                    userNode.Attributes.Append(ID);
                    XmlAttribute fname = doc.CreateAttribute("FirstName");
                    fname.Value = emp.Value.m_FirstName;
                    userNode.Attributes.Append(fname);
                    XmlAttribute lname = doc.CreateAttribute("LastName");
                    lname.Value = emp.Value.m_LastName;
                    userNode.Attributes.Append(lname);
                    XmlAttribute date = doc.CreateAttribute("HireDate");
                    date.Value = emp.Value.m_Date.ToString();
                    userNode.Attributes.Append(date);
                    XmlAttribute union = doc.CreateAttribute("Union");
                    union.Value = emp.Value.m_Union.ToString();
                    userNode.Attributes.Append(union);
                    XmlAttribute HrlyShift = doc.CreateAttribute("HrlyShift");
                    HrlyShift.Value = emp.Value.m_HrlyShift.ToString();
                    userNode.Attributes.Append(HrlyShift);
                    XmlAttribute team = doc.CreateAttribute("Team");
                    team.Value = emp.Value.m_Team.ToString();
                    userNode.Attributes.Append(team);
                    rootNode.AppendChild(userNode);     
                }
                doc.Save("EmployeeList.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void ReadFromStream(Dictionary<int, EmployeeData> Employee)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load("EmployeeList.xml");
            XmlNodeList userNode = doc.SelectNodes("//Employees/Employees");
            foreach(XmlNode employee in userNode)
            {
                EmployeeData emp = new EmployeeData(Convert.ToInt32(employee.Attributes["ID"].Value), employee.Attributes["FirstName"].Value, employee.Attributes["LastName"].Value, employee.Attributes["HireDate"].Value, Convert.ToChar(employee.Attributes["Union"].Value), Convert.ToInt32(employee.Attributes["HrlyShift"].Value), Convert.ToInt32(employee.Attributes["Team"].Value));
                Employee.Add(emp.m_Id, emp);
            }

            doc.Save("EmployeeList.xml");
        }
    }
}
