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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustmorFom form = new CustmorFom();
            form.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pharmacyForm form = new pharmacyForm();
            form.Show();
            this.Hide();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm3 form = new LoginForm3();
            form.Show();
            this.Hide();
        }
    }
}
