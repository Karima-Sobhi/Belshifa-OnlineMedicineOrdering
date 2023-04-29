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
    public partial class LoginForm3 : Form
    {
        string ordb = "Data source=orcl;User Id=Belshifa; Password = Belshifa; ";
        OracleConnection conn;
        public LoginForm3()
        {
            InitializeComponent();
        }

        private void LoginForm3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Txtusrename.Text == "" || Txtpassword.Text == "")
            {
                MessageBox.Show("Please Enter All Informations.");
            }
            else
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select DELIVERYEMAIL ,DELIVERYPASSWORD   from DELIVERY  Where DELIVERYEMAIL  = :email and DELIVERYPASSWORD  =:pass";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("email", Txtusrename.Text);
                cmd.Parameters.Add("pass", Txtpassword.Text);
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("login Succeeded");
                    DeliveryForm form = new DeliveryForm();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("login Failed");

                }
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            WelcomeForm w = new WelcomeForm();
            w.Show();
            this.Hide();
        }
    }
}
