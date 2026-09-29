using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FILLONE_DSAL01E_CPE301
{
    public partial class ex3_sequential_search_algorithm : Form
    {
        public ex3_sequential_search_algorithm()
        {
            InitializeComponent();
        }

        private void ex3_sequential_search_algorithm_Load(object sender, EventArgs e)
        {
            // create datagridview columns
            dataGridView1.Columns.Add("EmployeeID", "Employee ID");
            dataGridView1.Columns.Add("EmployeeName", "Employee Name");
            dataGridView1.Columns.Add("Department", "Department");
            dataGridView1.Columns.Add("Position", "Position");

            // add sample data
            dataGridView1.Rows.Add("1001", "Juan Dela Cruz", "CEA", "Executive Director");
            dataGridView1.Rows.Add("1002", "Maria Santos", "CBA", "President");
            dataGridView1.Rows.Add("1003", "Pedro Reyes", "CAMS", "CEO");
            dataGridView1.Rows.Add("1004", "Ana Garcia", "CON", "Employee");
            dataGridView1.Rows.Add("1005", "Claire Mendoza", "CITHM", "Manager");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchEmployeeName = txtSearch.Text.Trim();
            bool found = false;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].IsNewRow)
                    continue;

                string employeeName = dataGridView1.Rows[i].Cells["EmployeeName"].Value?.ToString() ?? "";

                if (employeeName.Equals(searchEmployeeName, StringComparison.OrdinalIgnoreCase))
                {
                    string id = dataGridView1.Rows[i].Cells["EmployeeID"].Value?.ToString() ?? "";

                    string department = dataGridView1.Rows[i].Cells["Department"].Value?.ToString() ?? "";

                    string position = dataGridView1.Rows[i].Cells["Position"].Value?.ToString() ?? "";

                    MessageBox.Show(
                        "Employee Found \n\n" + "ID: " + id + "\nName: " + employeeName + "\nDepartment: " + department + "\nPosition: " + position);

                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[i].Selected = true;

                    found = true;
                    break;

                }
            }

            if (!found)
                MessageBox.Show("Employee not found.");
        }
    }
}
