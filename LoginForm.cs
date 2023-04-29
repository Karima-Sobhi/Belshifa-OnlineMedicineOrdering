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
    public partial class LoginForm : Form
    {

        string ordb = "Data source=orcl;User Id=Belshifa; Password = Belshifa; ";
        OracleConnection conn;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Txtusrename.Text == "" || Txtpassword.Text == "" )
            {
                MessageBox.Show("Please Enter All Informations.");
            }
            else
            {

                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select CustomerEmail,CustomerPassword  from Customer Where CustomerEmail = :email and CustomerPassword =:pass";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("email", Txtusrename.Text);
                cmd.Parameters.Add("pass", Txtpassword.Text);
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    MessageBox.Show("login Succeeded");
                    ChooseCustomer c = new ChooseCustomer();
                    c.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("login Failed");

                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Txtusrename_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
