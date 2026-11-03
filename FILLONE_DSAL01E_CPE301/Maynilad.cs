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
    public partial class Maynilad : Form
    {
        double
            rate_cu_meter = 23.52,
            cu_m = 0.00,
            basic_charge = 0.00,
            envi_charges = 108.28,
            maintenance_charge = 1.53,
            tot_charges_before_taxes = 0.00,
            gov_taxes = 0.00,
            tot_amnt_due = 0.00;

        private void label43_Click(object sender, EventArgs e)
        {

        }

        public Maynilad()
        {
            InitializeComponent();
        }

        private void Maynilad_Load(object sender, EventArgs e)
        {

        }

        private void displaywaterbillBTN_Click(object sender, EventArgs e)
        {
            // billing period - last date
            billing_readingdateTXTBOX.Text = readingdateTXTBOX.Text;

            // basic charges
            cu_m = Convert.ToInt32(consumpTXTBOX.Text);
            basic_charge= cu_m * rate_cu_meter;
            basicchargeTXTBOX.Text = basic_charge.ToString("");

            // total charges before taxes
            tot_charges_before_taxes = basic_charge + envi_charges + maintenance_charge;
            tot_currentchargesTXTBOX.Text = tot_charges_before_taxes.ToString("");

            // government taxes
            gov_taxes = tot_charges_before_taxes * 0.025;
            govern_taxesTXTBOX.Text = gov_taxes.ToString("");

            // total amount due
            tot_amnt_due = tot_charges_before_taxes + gov_taxes;
            tot_amntdueTXTBOX.Text = tot_amnt_due.ToString("");

            // current charges
            tot_amntdueTXTBOX.Text = currentchargesTXTBOX.Text;

            // environmental charges
            envichargesTXTBOX.Text = envi_charges.ToString("");

            // maintenance charges
            maintenanceTXTBOX.Text = maintenance_charge.ToString("");
        }
    }
}
