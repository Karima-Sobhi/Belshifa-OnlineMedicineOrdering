using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using SoftwareFormsApp1;

namespace SWproject
{
    public partial class Pharmacies : Form
    {
        public Pharmacies()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SearchForm form = new SearchForm(501);
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchForm form = new SearchForm(502);
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchForm form = new SearchForm(503);
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchForm form = new SearchForm(504);
            form.Show();
            this.Hide();
        }

        private void Pharmacies_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            WelcomeForm form = new WelcomeForm();
            form.Show();
            this.Hide();
        }
    }
}
