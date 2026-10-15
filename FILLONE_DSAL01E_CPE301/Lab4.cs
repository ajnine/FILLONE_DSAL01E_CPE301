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
    public partial class Lab4 : Form
    {
        public Lab4()
        {
            InitializeComponent();
        }

        private void Lab4_Load(object sender, EventArgs e)
        {
            DataTable students = new DataTable();
            students.Columns.Add("ID", typeof(int));
            students.Columns.Add("Name", typeof(string));

            students.Rows.Add(101, "Ana");
            students.Rows.Add(102, "Ben");
            students.Rows.Add(103, "Cara");
            students.Rows.Add(104, "Dina");

            dataGridView1.DataSource = students;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*DataTable students = new DataTable();
            students.Columns.Add("ID", typeof(int));
            students.Columns.Add("Name", typeof(string));

            students.Rows.Add(101, "Ana");
            students.Rows.Add(102, "Ben");
            students.Rows.Add(103, "Cara");
            students.Rows.Add(104, "Dina");

            dataGridView1.DataSource = students;*/
        }

        private int SentinelSearch(DataTable table, string key)
        {
            var names = table.AsEnumerable().Select(row => row["Name"].ToString()).ToList();

            int originalCount = names.Count;
            names.Add(key); // Add sentinel
            int i = 0;
            while (!string.Equals(names[i], key, StringComparison.OrdinalIgnoreCase)) i++;

            return i < originalCount ? i : -1; // Return -1 if not found
        }

        private int SequentialSearch(DataTable table, string key)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string name = table.Rows[i]["Name"].ToString();
                if (string.Equals(name, key, StringComparison.OrdinalIgnoreCase)) return i;
            }
            return -1; // Not found
        }

        private void btnSequenial_Click(object sender, EventArgs e)
        {
            RunSearch(SequentialSearch);
        }

        private void btnSentinel_Click(object sender, EventArgs e)
        {
            RunSearch(SentinelSearch);
        }

        private void RunSearch(Func<DataTable, string, int> search)
        {
            var table = (DataTable)dataGridView1.DataSource;
            int index = search(table,txtSearch.Text.Trim());
            dataGridView1.ClearSelection();
            if (index >= 0)
            {
                dataGridView1.Rows[index].Selected = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = index;
            }
            MessageBox.Show(index < 0 ? "Not found" : "Found!");
        }
    }
}
