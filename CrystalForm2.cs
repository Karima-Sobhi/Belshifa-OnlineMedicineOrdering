using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace SoftwareFormsApp1
{
    public partial class CrystalForm2 : Form
    {
        CrystalReport2 cr;
        public CrystalForm2()
        {
            InitializeComponent();
        }

        private void CrystalForm2_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport2();
            foreach (ParameterDiscreteValue v in cr.ParameterFields[0].DefaultValues)
                pharmacy_cbx.Items.Add(v.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, pharmacy_cbx.Text);
            crystalReportViewer1.ReportSource = cr;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {
            WelcomeForm form = new WelcomeForm();
            this.Hide();
            form.Show();
        }
    }
}
