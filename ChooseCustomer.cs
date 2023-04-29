using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWproject;

namespace SoftwareFormsApp1
{
    public partial class ChooseCustomer : Form
    {
        public ChooseCustomer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pharmacies f = new Pharmacies();
            f.Show();
            this.Hide();
        }

        private void ChooseCustomer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalForm2 c2 = new CrystalForm2();
            c2.Show();
            this.Hide();
        }
    }
}
