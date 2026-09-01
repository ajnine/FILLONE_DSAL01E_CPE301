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
            DSAL_dbconnect.DSAL_sql = "SELECT * FROM EmployeeTbl WHERE emp_id = '" + emp_id_cmbbox.Text + "'";
            DSAL_dbconnect.DSAL_cmd();
            DSAL_dbconnect.DSAL_sqladapterSelect();

            datagriddisplay.DataSource = DSAL_dbconnect.DSAL_sql_dataset.Tables[0];
        }
    }
}
