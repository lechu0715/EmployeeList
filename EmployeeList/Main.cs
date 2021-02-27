using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace EmployeeList
{
    public partial class Main : Form
    {
        private string _filePath = 
            Path.Combine(Environment.CurrentDirectory, "Employees.txt");

        //private FileHelper<List<Employee>> _fileHelper = new FileHelper<List<Employee>>(Program.FilePath);

        public Main()
        {
            InitializeComponent();

            var employees = DeserializeFromFile();

            dgvEmployeeList.DataSource = employees;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addEmployee = new AddEmployee();
            addEmployee.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployeeList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Prosze zaznacz pracownika którego dane chcesz edytować");
                return;
            }

            var addEmployee = new AddEmployee(
                Convert.ToInt32(dgvEmployeeList.SelectedRows[0].Cells[0].Value));
            addEmployee.ShowDialog();
        }

        private void btnFired_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var employees = DeserializeFromFile();
            dgvEmployeeList.DataSource = employees;
        }
    }
}
