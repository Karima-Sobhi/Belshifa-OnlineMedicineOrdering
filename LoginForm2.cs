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
    public partial class LoginForm2 : Form
    {
        string ordb = "Data source=orcl;User Id=Belshifa; Password = Belshifa; ";
        OracleConnection conn;
        public LoginForm2()
        {
            InitializeComponent();
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
                cmd.CommandText = "select PharmacyEmail ,PharmacyPassword,pharmacyid   from Pharmacy  Where PharmacyEmail  = :email and PharmacyPassword  =:pass";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("email", Txtusrename.Text);
                cmd.Parameters.Add("pass", Txtpassword.Text);

                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("login Succeeded");
                    int id = Convert.ToInt32(dr["pharmacyid"].ToString());
                    ChoosePharmacy c = new ChoosePharmacy(id);
                    c.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("login Failed");

                }
            }
        }

        private void LoginForm2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
