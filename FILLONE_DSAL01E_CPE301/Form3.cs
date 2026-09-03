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
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) 
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

            popupForm.ShowDialog();
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
                }
            }
        }
    }
}
