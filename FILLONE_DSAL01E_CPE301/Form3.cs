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
    public partial class Form3 : Form
    {
        DSAL_dbconnection DSAL_dbconnect = new DSAL_dbconnection();
        private string picpath;
        private Image pic;
        private DataGridView datagriddisplay;
        public Form3()
        {
            DSAL_dbconnect.DSAL_connString();
            InitializeComponent();
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            DSAL_dbconnect.DSAL_sql = "SELECT * FROM EmployeeTbl WHERE emp_id = '" + searchtxtbox.Text + "'";
            DSAL_dbconnect.DSAL_cmd();
            DSAL_dbconnect.DSAL_sqladapterSelect();

            DSAL_dbconnect.DSAL_sqldatasetSelect();
            dataGridView1.DataSource = DSAL_dbconnect.DSAL_sql_dataset.Tables[0];


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DSAL_dbconnect.DSAL_sql = "SELECT * FROM EmployeeTbl";
            DSAL_dbconnect.DSAL_cmd();
            DSAL_dbconnect.DSAL_sqladapterSelect();

            DSAL_dbconnect.DSAL_sqldatasetSelect();
            dataGridView1.DataSource = DSAL_dbconnect.DSAL_sql_dataset.Tables[0];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cellvalue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (e.ColumnIndex == 0)
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                }
            }

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            string id = row.Cells["emp_id"].Value?.ToString() ?? "";
            string fname = row.Cells["emp_fname"].Value?.ToString() ?? "";
            string mname = row.Cells["emp_sname"].Value?.ToString() ?? "";

            Form2 popupForm = new Form2(id, fname, mname);

            popupForm.ShowDialog();*/
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cellvalue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (e.ColumnIndex == 0)
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    form2.Activate();

                    form2.show_info(Convert.ToInt32(cellvalue));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = searchtxtbox.Text.Trim();

            bool found = false;

            // sequential search
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                // ignore the empty new row
                if (dataGridView1.Rows[i].IsNewRow)
                    continue;

                string studentName = dataGridView1.Rows[i].Cells[2].Value?.ToString() ?? "";

                if (studentName.Equals(fname, StringComparison.OrdinalIgnoreCase))
                {
                    // select the matching row
                    dataGridView1.ClearSelection(); 
                    dataGridView1.Rows[i].Selected = true;

                    // more datagridview to the matching records
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[2];

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

        private void ex2BTN_Click(object sender, EventArgs e)
        {
            string searchmname = searchtxtbox.Text.Trim();
            bool found = false;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].IsNewRow)
                    continue;

                string mname = dataGridView1.Rows[i].Cells[3].Value?.ToString() ?? "";
                if (mname.Equals(searchmname, StringComparison.OrdinalIgnoreCase))
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[i].Selected = true;

                    string birthdate = dataGridView1.Rows[i].Cells[11].Value?.ToString() ?? "";

                    MessageBox.Show(
                        "Employee found! \n\n" + "Employee's first name is : " + mname + "\n Birthdate: " + birthdate);

                    found = true;
                    break;
                }
            }

            if (!found)
                MessageBox.Show("Product not found.");
        }

        private void ex3BTN_Click(object sender, EventArgs e)
        {
            string searchsname = searchtxtbox.Text.Trim();
            bool found = false;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].IsNewRow)
                    continue;

                string sname = dataGridView1.Rows[i].Cells[4].Value?.ToString() ?? "";

                if (sname.Equals(searchsname, StringComparison.OrdinalIgnoreCase))
                {
                    string id = dataGridView1.Rows[i].Cells[0].Value?.ToString() ?? "";

                    string department = dataGridView1.Rows[i].Cells[16].Value?.ToString() ?? "";

                    string job = dataGridView1.Rows[i].Cells[15].Value?.ToString() ?? "";

                    MessageBox.Show(
                        "Employee Found! \n\n" + "ID: " + id + "\nName: " + sname + "\nDepartment: " + department + "\nPosition: " + job);

                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[i].Selected = true;

                    found = true;
                    break;
                }
            }
        }

        private void ex4BTN_Click(object sender, EventArgs e)
        {
            string searchValue = searchtxtbox.Text.Trim();
            bool found = false;

            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                if (dataGridView1.Rows[row].IsNewRow)
                    continue;

                for (int col = 0; col < dataGridView1.Columns.Count; col++)
                {
                    string value = dataGridView1.Rows[row].Cells[col].Value?.ToString() ?? "";

                    if (value.Equals(searchValue, StringComparison.OrdinalIgnoreCase))
                    {
                        dataGridView1.ClearSelection();

                        dataGridView1.Rows[row].Selected = true;
                        dataGridView1.CurrentCell = dataGridView1.Rows[row].Cells[col];

                        MessageBox.Show(
                            "Record found at row " + (row + 1));

                        found = true;
                        break;
                    }
                }
            }
        }

        private void ex5BTN_Click(object sender, EventArgs e)
        {
            string empprovince = searchtxtbox.Text.Trim();
            int count = 0;

            dataGridView1.ClearSelection();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].IsNewRow)
                    continue;

                string course = dataGridView1.Rows[i].Cells[9].Value?.ToString() ?? "";

                if (course.Equals(empprovince, StringComparison.OrdinalIgnoreCase))
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

        private void ex6BTN_Click(object sender, EventArgs e)
        {
            DataTable table = (DataTable)dataGridView1.DataSource;
            string target = searchtxtbox.Text.Trim();
            bool found = false;

            for (int i = 0; i < table.Rows.Count; i++)
            {
                string name = table.Rows[i][2].ToString();

                if (name.Equals(target, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "Employee found at record " + (i + 1));

                    found = true;
                    break;
                }
            }

            if (!found)
                MessageBox.Show("Employee not found.");
        }
    }
}