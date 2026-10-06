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
    public partial class ex7_sequential_search_algorithm : Form
    {
        public ex7_sequential_search_algorithm()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        private void ex7_sequential_search_algorithm_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Course");

            table.Rows.Add("1001", "Juan Cruz", "BSIT");
            table.Rows.Add("1002", "Maria Santos", "BSCS");
            table.Rows.Add("1003", "Pedro Reyes", "BSIS");
            table.Rows.Add("1004", "Ana Garcia", "BSIT");

            dataGridView1.DataSource = table;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string target = txtSearch.Text.Trim();
            bool found = false;

            for (int i = 0; i < table.Rows.Count; i++)
            {
                string name = table.Rows[i]["Name"].ToString();

                if (name.Equals(target, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "Student found at record " + (i + 1));

                    found = true;
                    break; 
                }
            }

            if (!found)
                MessageBox.Show("Student not found.");
        }
    }
}
