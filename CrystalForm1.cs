using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareFormsApp1
{
    public partial class CrystalForm1 : Form
    {
        CrystalReport1 cr;
        public CrystalForm1()
        {
            InitializeComponent();
        }

        private void CrystalForm1_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = cr;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            WelcomeForm form = new WelcomeForm();
            form.Show();
            this.Hide();
        }
    }
}
