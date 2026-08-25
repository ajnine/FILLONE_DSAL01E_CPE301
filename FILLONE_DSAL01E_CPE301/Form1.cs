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
    public partial class Form1 : Form
    {
        DSAL_dbconnection DSAL_dbconnect = new DSAL_dbconnection();
        private string picpath;
        private Image pic;

        private DataGridView datagriddisplay;
        public Form1()
        {
            DSAL_dbconnect.DSAL_connString();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            salutationcmbbox.Items.Add("Mr.");
            salutationcmbbox.Items.Add("Ms.");
            salutationcmbbox.Items.Add("Mrs.");

            jobcmbbox.Items.Add("Engineer");
            jobcmbbox.Items.Add("Teacher");
            jobcmbbox.Items.Add("Accountant");
            jobcmbbox.Items.Add("Lawyer");
            jobcmbbox.Items.Add("Flight Attendant");

            deptcmbbox.Items.Add("Department of Engineering");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            
                DSAL_dbconnect.DSAL_sql = "INSERT INTO EmployeeTbl (empReg_id, emp_id, emp_salutation, emp_fname, emp_mname, emp_surname, emp_suffix, emp_street, emp_brgy, emp_city, emp_province, emp_zip, emp_bday, emp_nationality, emp_email,emp_mobile, emp_job, emp_dept,  emp_status  ) VALUES ('" + empIDtxtbox.Text + "', '" + salutationcmbbox.Text + "', '" + firstnametxtbox.Text + "', '" + middlenametxtbox.Text + "', '" + surnametxtbox.Text + "', '" + suffixtxtbox.Text + "', '" + streettxtbox.Text + "', '" + brgytxtbox.Text + "', '" + citytxtbox.Text + "', '" + provincetxtbox.Text + "', '" + ziptxtbox.Text + "', '" + birthdaytxtbox.Text + "', '" + nationalitytxtbox.Text + "', '" + emailaddtxtbox.Text + "', '" + mobilenotxtbox.Text + "', '" + jobcmbbox.Text + "', '" + deptcmbbox.Text + "', '" + statuscmbbox.Text + "')";
                DSAL_dbconnect.DSAL_cmd();
                DSAL_dbconnect.DSAL_sqladapterInsert();

                //DSAL_dbconnect.DSAL_select();
                DSAL_dbconnect.DSAL_cmd();
                DSAL_dbconnect.DSAL_sqladapterSelect();
               //DSAL_dbconnect.DSAL_sqldatasetSELECT();
                datagriddisplay.DataSource = DSAL_dbconnect.DSAL_sql_dataset.Tables[0];
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
                open_file_image();
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
            
                MessageBox.Show("No Image Selected!");
            
        }

        private void open_file_image()
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog1.ShowDialog();
        }
    }
}
