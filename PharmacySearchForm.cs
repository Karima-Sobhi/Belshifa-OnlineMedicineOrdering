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

namespace HalimSW
{
    public partial class PharmacySearchForm : Form
    {
        OracleDataAdapter adapter;
        DataSet ds;
        public int Pharmacy_ID, medid;
        public string pharmName, pharmCol, pharmNum, pharmEm, pharmAd;

        private void Update1_Click(object sender, EventArgs e)
        {
            updatepanel.Visible = true;
            Medpanel.Visible = false;
            updateName.Text = SearchT.Text;
            updatePrice.Text = MedPrice.Text;
            filepath = Medpic.ImageLocation.ToString();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            Medpanel.Visible = false;
            if (updatePrice.Text == "" || updatequantity.Text == "")
            {
                MessageBox.Show("Please Enter The Medicine Price, Quantity.");
            }
            else
            {
                string ordb = "Data source=orcl;User Id=Belshifa; Password=Belshifa;";
                string cmdstr = @"update medicines set price =:p,Quantity=:q,IMAGE=:imgtxt where lower(medicinename)= lower(:x) and pharmacyid=:y";
                adapter = new OracleDataAdapter(cmdstr, ordb);
                decimal pr = 0; int q = 0;
                if (decimal.TryParse(updatePrice.Text, out pr) == false || int.TryParse(updatequantity.Text, out q) == false)
                    MessageBox.Show("Please Enter Valid Price , Quantity");
                else
                {
                    if (pr <= 0 || q < 0)
                    {
                        MessageBox.Show("Please Enter Valid Values For Price,Quantity");
                    }
                    else
                    {
                        adapter.SelectCommand.Parameters.Add("p", pr);
                        adapter.SelectCommand.Parameters.Add("q", q);
                        adapter.SelectCommand.Parameters.Add("imgtxt", filepath.ToString());
                        adapter.SelectCommand.Parameters.Add("x", MedName.Text);
                        adapter.SelectCommand.Parameters.Add("y", Pharmacy_ID);
                        OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
                        DataTable panelData = new DataTable();
                        adapter.Fill(panelData);
                        adapter.Update(panelData);
                        MessageBox.Show("Updated Successfully.");
                    }
                }
            }
        }

        private void btnloadpicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            filepath = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(filepath);
        }

        private void Searchpb_Click(object sender, EventArgs e)
        {
            if (SearchT.Text == "")
            {
                MessageBox.Show("Please Enter The Name Of Medicine ");
            }
            else
            {
                string ordb = "Data source=orcl;User Id=Belshifa; Password=Belshifa;";
                string cmdstr = @"select image,price,MedicineName,quantity,MEDICINEID FROM medicines WHERE  LOWER(MedicineName) LIKE CONCAT(LOWER(:x),'%') and PharmacyID=:y";
                adapter = new OracleDataAdapter(cmdstr, ordb);

                try
                {
                    adapter.SelectCommand.Parameters.Add("x", SearchT.Text.ToString());
                    adapter.SelectCommand.Parameters.Add("y", Pharmacy_ID);

                    ds = new DataSet();
                    adapter.Fill(ds);

                    DataTable tabel = ds.Tables[0];
                    DataRow dr = tabel.Rows[0];
                    updatepanel.Visible = false;
                    Medpanel.Visible = true;
                    MedName.Text = dr["MedicineName"].ToString();
                    // acess each attribute in the row by its name; 
                    MedPrice.Text = dr["price"].ToString();
                    Medpic.ImageLocation = dr["image"].ToString();
                    medavaq.Text = dr["quantity"].ToString();
                    int.TryParse(dr["MEDICINEID"].ToString(), out medid);
                }
                catch
                {
                    Medpanel.Visible = false;
                    MessageBox.Show("NOT FOUND");
                }
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            WelcomeForm f = new WelcomeForm();
            this.Hide();
            f.Show();
        }

        public string filepath;
        public PharmacySearchForm(int Pharmid)
        {
            InitializeComponent();
            Pharmacy_ID = Pharmid;
            string ordb = "Data source=orcl;User Id=Belshifa; Password=Belshifa;";
            string cmdstr = @"select PHARMACYNAME,phone_number,PHARMACYEMAIL,ADDRESS,color from pharmacy where PHARMACYID = :x";

            adapter = new OracleDataAdapter(cmdstr, ordb);
            adapter.SelectCommand.Parameters.Add("x", Pharmacy_ID);
            ds = new DataSet();
            adapter.Fill(ds);

            DataTable tabel = ds.Tables[0];
            DataRow dr = tabel.Rows[0];

            // acess each attribute in the row by its name; 

            pharmName = dr["PHARMACYNAME"].ToString();
            pharmEm = dr["PHARMACYEMAIL"].ToString();
            pharmCol = dr["color"].ToString();
            pharmAd = dr["ADDRESS"].ToString();
            pharmNum = dr["phone_number"].ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void PharmacySearchForm_Load(object sender, EventArgs e)
        {
            Headerpanel.BackColor = Color.FromName(pharmCol);
            Pharmacypanel.BackColor = Color.FromName(pharmCol);
            PharmacyPhone.Text = pharmNum;
            PhramacyName.Text = pharmName;
            PharmacyEmail.Text = pharmEm;
            PharmacyAddress.Text = pharmAd;
        }
    }
}
