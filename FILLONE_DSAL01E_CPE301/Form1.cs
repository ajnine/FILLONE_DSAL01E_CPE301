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
            salutationcmbbox.Items.Add("Engr.");
            salutationcmbbox.Items.Add("Dr.");
            salutationcmbbox.Items.Add("Ar.");

            jobcmbbox.Items.Add("Engineer");
            jobcmbbox.Items.Add("Teacher");
            jobcmbbox.Items.Add("Accountant");
            jobcmbbox.Items.Add("Lawyer");
            jobcmbbox.Items.Add("Flight Attendant");
            jobcmbbox.Items.Add("Doctor");
            jobcmbbox.Items.Add("Architect");


            deptcmbbox.Items.Add("Department of Engineering");
            deptcmbbox.Items.Add("Department of Accountancy");
            deptcmbbox.Items.Add("Department of Education");
            deptcmbbox.Items.Add("Department of Law");
            deptcmbbox.Items.Add("Department of Tourism and Hotel Management");
            deptcmbbox.Items.Add("Department of Nursing");
            deptcmbbox.Items.Add("Department of Architecture");

            statuscmbbox.Items.Add("Regular");
            statuscmbbox.Items.Add("Part-time");
            statuscmbbox.Items.Add("OJT");

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
            
                DSAL_dbconnect.DSAL_sql = "INSERT INTO EmployeeTbl (emp_id, emp_salutation, emp_fname, emp_mname, emp_sname, emp_suffix, emp_street, emp_brgy, emp_city, emp_province, emp_zip, emp_bday, emp_nationality, emp_emailadd,emp_telephone, emp_job, emp_dept, emp_status) VALUES ('" + empIDtxtbox.Text + "', '" + salutationcmbbox.Text + "', '" + firstnametxtbox.Text + "', '" + middlenametxtbox.Text + "', '" + surnametxtbox.Text + "', '" + suffixtxtbox.Text + "', '" + streettxtbox.Text + "', '" + brgytxtbox.Text + "', '" + citytxtbox.Text + "', '" + provincetxtbox.Text + "', '" + ziptxtbox.Text + "', '" + birthdaytxtbox.Text + "', '" + nationalitytxtbox.Text + "', '" + emailaddtxtbox.Text + "', '" + mobilenotxtbox.Text + "', '" + jobcmbbox.Text + "', '" + deptcmbbox.Text + "', '" + statuscmbbox.Text + "')";
                DSAL_dbconnect.DSAL_cmd();
                DSAL_dbconnect.DSAL_sqladapterInsert();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
                open_file_image();
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
        }

        private void open_file_image()
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog1.ShowDialog();
        }

        private void form2btn_Click(object sender, EventArgs e)
        {
            // for calling connected to the current form
            Form3 form = new Form3();
            // to display the other form
            form.Show();
        }
    }
}
