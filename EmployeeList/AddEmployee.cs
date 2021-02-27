using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace EmployeeList
{
    public partial class AddEmployee : Form
    {
        private string _filePath =
            Path.Combine(Environment.CurrentDirectory, "Employees.txt");
        private int _employeeId;

        public AddEmployee(int id = 0)
        {
            InitializeComponent();
            _employeeId = id;

            if (id != 0)
            {
                var employees = DeserializeFromFile();
                var employee = employees.FirstOrDefault(x => x.Id == id);

                if (employee == null)
                {
                    throw new Exception("Brak użytkownika o podanym Id");
                }

                tbId.Text = employee.Id.ToString();
                tbFirstName.Text = employee.FirstName;
                tbLastName.Text = employee.LastName;
                dtpStartOccupation.Value = employee.StartDate;
                dtpEndOccupation.Value = employee.EndDate;
                tbSalary.Text = employee.Salary.ToString();
                rtbComments.Text = employee.Comments;
            }


        }

        public void SerializeToFile(List<Employee> employees)
        {
            var serializer = new XmlSerializer(typeof(List<Employee>));

            using (var streamWriter = new StreamWriter(_filePath))
            {
                serializer.Serialize(streamWriter, employees);
                streamWriter.Close();
            }
        }

        public List<Employee> DeserializeFromFile()
        {
            if (!File.Exists(_filePath))
                return new List<Employee>();

            var serializer = new XmlSerializer(typeof(List<Employee>));

            using (var streamReader = new StreamReader(_filePath))
            {
                var employees = (List<Employee>)serializer.Deserialize(streamReader);
                streamReader.Close();
                return employees;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var employees = DeserializeFromFile();

            if (_employeeId != 0)
            {
                employees.RemoveAll(x => x.Id == _employeeId);
            }
            else
            {
                var employeeWithHighestId = employees.OrderByDescending(x => x.Id).FirstOrDefault();

                _employeeId = employeeWithHighestId == null ? 1 : employeeWithHighestId.Id + 1;
            }

            var employee = new Employee
            {
                Id = _employeeId,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                StartDate = dtpStartOccupation.Value,
                EndDate = dtpEndOccupation.Value,
                Salary = Convert.ToInt32(tbSalary.Text),
                Comments = rtbComments.Text
            };

            employees.Add(employee);
            SerializeToFile(employees);

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
