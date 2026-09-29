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
    public partial class ex6_sequential_search_algorithm : Form
    {
        public ex6_sequential_search_algorithm()
        {
            InitializeComponent();
        }

        private void ex6_sequential_search_algorithm_Load(object sender, EventArgs e)
        {
            // create datagridview columns
            dataGridView1.Columns.Add("ID", "Student ID");
            dataGridView1.Columns.Add("Name", "Student Name");
            dataGridView1.Columns.Add("Course", "Course");
            dataGridView1.Columns.Add("Year", "Year");

            // add sample data
            dataGridView1.Rows.Add("1001", "Juan Cruz", "BSIT", "1");
            dataGridView1.Rows.Add("1002", "Maria Santos", "BSCS", "2");
            dataGridView1.Rows.Add("1003", "Carlo Reyes", "BSIT", "3");
            dataGridView1.Rows.Add("1004", "Tine Pasobillo", "BSIT", "3");
            dataGridView1.Rows.Add("1005", "Reign Abesia", "BSCE", "3");
            dataGridView1.Rows.Add("1006", "Shaun Mathew", "BSCpE", "3");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchCourse = txtSearch.Text.Trim();
            int count = 0;

            dataGridView1.ClearSelection();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].IsNewRow)
                    continue;

                string course = dataGridView1.Rows[i].Cells["Course"].Value?.ToString() ?? "";

                if (course.Equals(searchCourse, StringComparison.OrdinalIgnoreCase))
                {
                    dataGridView1.Rows[i].Selected = true;
                    count++;
                }
            }

            if (count > 0)
            {
                MessageBox.Show(
                    count + " matching record(s) found. ");
            }

            else
            {
                MessageBox.Show("No matching records found.");
            }
        }
    }
}
