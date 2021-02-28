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
        private int _employeeId;
        private Employee _employee;

        private FileHelper<List<Employee>> _fileHelper =
            new FileHelper<List<Employee>>(Program.FilePath);

        public AddEmployee(int id = 0)
        {
            InitializeComponent();
            _employeeId = id;

            GetEmployeeData();
            tbFirstName.Select();
        }

        private void GetEmployeeData()
        {
            if (_employeeId != 0)
            {
                Text = "Edytowanie danych pracownika";

                var employees = _fileHelper.DeserializeFromFile();
                _employee = employees.FirstOrDefault(x => x.Id == _employeeId);

                if (_employee == null)
                {
                    throw new Exception("Brak użytkownika o podanym Id");
                }

                FillTextBoxes();

            }
        }

        private void FillTextBoxes()
        {
            tbId.Text = _employee.Id.ToString();
            tbFirstName.Text = _employee.FirstName;
            tbLastName.Text = _employee.LastName;
            dtpStartOccupation.Value = _employee.StartDate;
            
            if (_employee.EndDate == null)
            {
                dtpEndOccupation.Visible = false;
                cbHired.Checked = true;
            }
            else
            {
                cbHired.Checked = false;

                try
                {
                    dtpEndOccupation.Value = (DateTime)_employee.EndDate;
                }
                catch
                {
                    return;
                }
                
            }

            tbSalary.Text = _employee.Salary.ToString();
            rtbComments.Text = _employee.Comments;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var employees = _fileHelper.DeserializeFromFile();

            if (_employeeId != 0)
            {
                employees.RemoveAll(x => x.Id == _employeeId);
            }
            else
            {
                var employeeWithHighestId = employees.OrderByDescending(x => x.Id).FirstOrDefault();

                _employeeId = employeeWithHighestId == null ? 1 : employeeWithHighestId.Id + 1;
            }

            decimal _salary = 0;

            if (tbSalary.Text == null)
            {
                _salary = 0;
            }
            else
            {
                try
                {
                    _salary = Convert.ToDecimal(tbSalary.Text);
                }
                catch
                {
                    MessageBox.Show("Proszę podać wartośc liczbową w polu zarobków");
                    return;
                }
            }


            var employee = new Employee
            {
                Id = _employeeId,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                StartDate = dtpStartOccupation.Value,
                EndDate = dtpEndOccupation.Value,
                Salary = _salary,
                Comments = rtbComments.Text,
                Hired = cbHired.Checked

            };

            if (employee.Hired)
            {
                employee.EndDate = default;
            
            }


            employees.Add(employee);
            _fileHelper.SerializeToFile(employees);



            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbHired_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHired.Checked)
            {
                dtpEndOccupation.Visible = false;
                lbDateEnd.Visible = false;
            }
            else
            {
                dtpEndOccupation.Visible = true;
                lbDateEnd.Visible = true;
            }
        }
    }
}
