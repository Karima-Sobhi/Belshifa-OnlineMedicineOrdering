using Oracle.DataAccess.Client;
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
using System.Xml.Linq;

namespace SoftwareFormsApp1
{
  
    public partial class SignupForm2 : Form
    {
        string ordb = "Data source=orcl;User Id=Belshifa; Password = Belshifa; ";
        OracleConnection conn;
        public SignupForm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Pharmacyname.Text == ""|| PharmacyId.Text==""|| PharmacyEmail.Text==""|| PharmacyPassword.Text==""|| PharmacyAddress.Text==""|| phone.Text==""|| color.Text=="")
            {
                MessageBox.Show("Please Enter All Informations.");
            }
            else
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into Pharmacy  (PharmacyName  ,PharmacyID  ,PharmacyEmail , PharmacyPassword,Address,phone_number,color ) values (:CName,:CId,:CEmail,:CPassword,:CAddress,:Phone,:Color)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("CName", Pharmacyname.Text);
                cmd.Parameters.Add("CId", PharmacyId.Text);
                cmd.Parameters.Add("CEmail", PharmacyEmail.Text);
                cmd.Parameters.Add("CPassword", PharmacyPassword.Text);
                cmd.Parameters.Add("CAddress", PharmacyAddress.Text);
                cmd.Parameters.Add("Phone", phone.Text);
                cmd.Parameters.Add("Color", color.Text);
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("signup Succeeded");
                    ChoosePharmacy c = new ChoosePharmacy(Convert.ToInt32(PharmacyId.Text));
                    c.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("signup Failed");
                }
            }
        }

        private void SignupForm2_Load(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            WelcomeForm w = new WelcomeForm();
            w.Show();
            this.Hide();
        }

        private void PharmacyId_TextChanged(object sender, EventArgs e)
        {

        }

        private void PharmacyPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
