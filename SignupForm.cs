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

namespace SoftwareFormsApp1
{
    public partial class SignupForm : Form
    {
        string ordb = "Data source=orcl;User Id=Belshifa; Password = Belshifa; ";
        OracleConnection conn;
        public SignupForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (custmorname.Text == "" || custmorid.Text == "" || custmorpassword.Text==""|| custmorEmail.Text=="")
            {
                MessageBox.Show("Please Enter All Informations.");
            }
            else
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into Customer (CustomerName ,CustomerID ,CustomerEmail, CustomerPassword ) values (:CName,:CId,:CEmail,:CPassword )";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("CName", custmorname.Text);
                cmd.Parameters.Add("CId", custmorid.Text);
                cmd.Parameters.Add("CEmail", custmorEmail.Text);
                cmd.Parameters.Add("CPassword", custmorpassword.Text);
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("signup Succeeded");
                    ChooseCustomer c = new ChooseCustomer();
                    c.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("signup Failed");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            WelcomeForm w = new WelcomeForm();
            w.Show();
            this.Hide();
        }
    }
}
