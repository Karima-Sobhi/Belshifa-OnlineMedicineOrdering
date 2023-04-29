using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalimSW;
using SWproject;
namespace SoftwareFormsApp1
{
    public partial class ChoosePharmacy : Form
    {
        public int id;
        public ChoosePharmacy(int pharmacy_id)
        {
            InitializeComponent();
            id = pharmacy_id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PharmacySearchForm f = new PharmacySearchForm(id);
            f.Show();
            this.Hide();
        }

        private void ChoosePharmacy_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalForm1 c1 = new CrystalForm1();
            c1.Show();
            this.Hide();
        }
    }
}
