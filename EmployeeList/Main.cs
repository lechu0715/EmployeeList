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
        private FileHelper<List<Employee>> _fileHelper = 
            new FileHelper<List<Employee>>(Program.FilePath);

        public Main()
        {
            InitializeComponent();
            RefreshDiary();
            SetColumnsHeader();
        }

        private void RefreshDiary()
        {
            var employees = _fileHelper.DeserializeFromFile();
            var employeesDescending = employees.OrderBy(x => x.Id).ToList();
            dgvEmployeeList.DataSource = employeesDescending;
        }

        private void SetColumnsHeader()
        {
            dgvEmployeeList.Columns[0].HeaderText = "Numer";
            dgvEmployeeList.Columns[1].HeaderText = "Imię";
            dgvEmployeeList.Columns[2].HeaderText = "Nazwisko";
            dgvEmployeeList.Columns[3].HeaderText = "Data Zatrudnienia";
            dgvEmployeeList.Columns[4].HeaderText = "Data Zwolnienia";
            dgvEmployeeList.Columns[5].HeaderText = "Zarobki";
            dgvEmployeeList.Columns[6].HeaderText = "Uwagi";
            dgvEmployeeList.Columns[7].Visible = false;
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


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDiary();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                RefreshDiary();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                var employees = _fileHelper.DeserializeFromFile();
                var activeEmployee = employees.Where(x => x.EndDate == default).ToList();

                var employeesDescending = activeEmployee.OrderBy(x => x.Id).ToList();
                dgvEmployeeList.DataSource = employeesDescending;
            }
            else
            {
                var employees = _fileHelper.DeserializeFromFile();
                var activeEmployee = employees.Where(x => x.EndDate != default).ToList();

                var employeesDescending = activeEmployee.OrderBy(x => x.Id).ToList();
                dgvEmployeeList.DataSource = employeesDescending;
            }
        }
    }
}
