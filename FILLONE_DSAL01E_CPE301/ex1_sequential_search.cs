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
    public partial class ex1_sequential_search : Form
    {
        public ex1_sequential_search()
        {
            InitializeComponent();
        }

        private void Sequential_search_Load(object sender, EventArgs e)
        {
            // create datagridview columns
            dataGridView1.Columns.Add("ID", "Student ID");
            dataGridView1.Columns.Add("Name", "Student Name");
            dataGridView1.Columns.Add("Course", "Course");

            // add sample data
            dataGridView1.Rows.Add("1001", "Juan Dela Cruz", "BSIT");
            dataGridView1.Rows.Add("1002", "Maria Santos", "BSCS");
            dataGridView1.Rows.Add("1003", "Pedro Reyes", "BSIS");
            dataGridView1.Rows.Add("1004", "Ana Garcia", "BSIT");
            dataGridView1.Rows.Add("1005", "Claire Mendoza", "BSCS");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim();

            bool found = false;

            // sequential search
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                // ignore the empty new row
                if (dataGridView1.Rows[i].IsNewRow)
                    continue;

                string studentName =
                    dataGridView1.Rows[i].Cells["Name"].Value?.ToString() ?? "";

                if (studentName.Equals(searchValue, StringComparison.OrdinalIgnoreCase))
                {
                    // select the matching row
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[i].Selected = true;

                    // more datagridview to the matching records
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells["Name"];
                    
                    MessageBox.Show(
                        "Records found at row " + (i + 1),
                        "Sequential Search",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show(
                    "Records not found.",
                    "Sequential Search",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
