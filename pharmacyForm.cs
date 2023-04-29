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
    public partial class pharmacyForm : Form
    {
        public pharmacyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm2 form = new LoginForm2();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignupForm2 form = new SignupForm2();
            form.Show();
            this.Hide();
        }

        private void pharmacyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
