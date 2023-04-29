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
    public partial class SearchForm : Form
    {
        OracleDataAdapter adapter;
        DataSet ds;
        public int Pharmacy_ID,medid;
        public string pharmName, pharmCol, pharmNum, pharmEm, pharmAd;
        public string filepath;
        
        private void Backhome_Click(object sender, EventArgs e)
        {
            Pharmacies pharm = new Pharmacies();
            pharm.Show();
            this.Hide();
        }

        private void Medpanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void MakeOrder_Click(object sender, EventArgs e)
        {
            int q = 0,r=0,sum=0;
            int.TryParse(medavaq.Text, out r);
            int.TryParse(medquantity.Text, out q);
            if (medquantity.Text == "")
            {
                medquantity.Text = "1";
                sum = 1;
            }
            else if ((int.TryParse(medquantity.Text, out q) == false) || (q>r) )
            {
                MessageBox.Show("Enter Valid Number less than the available quantity.");
            }
            else {
                sum = q;
            }
            if(sum>0)
            {
                if (MessageBox.Show("Do You Want To Take The Medicen", "Medice Comfirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    int med = r - sum; int ctr = 0;
                    string ordb = "Data source=orcl;User Id=Belshifa; Password=Belshifa;";
                    string cmdstr = @"update medicines set Quantity=:q where lower(medicinename)= lower(:x) and pharmacyid=:y";
                    adapter = new OracleDataAdapter(cmdstr, ordb);
                    adapter.SelectCommand.Parameters.Add("q", med);
                    adapter.SelectCommand.Parameters.Add("x", SearchT.Text.ToString());
                    adapter.SelectCommand.Parameters.Add("y", Pharmacy_ID);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    medavaq.Text = med.ToString();
                    string ordb1 = "Data source=orcl;User Id=Belshifa; Password=Belshifa;";
                    string cmdstr1 = @"select max(orderid) from orders";
                    adapter = new OracleDataAdapter(cmdstr1, ordb1);               
                    ds = new DataSet();
                    adapter.Fill(ds);
                    DataTable tabel = ds.Tables[0];
                    DataRow dr = tabel.Rows[0];
                    int.TryParse(dr["max(orderid)"].ToString(),out ctr);
                    ctr++;

                    string cmdstr2 = @"insert into orders(ORDERID,CUSTOMERID,MEDICINEID,PHARMACYID,QUANTITY,STATUS,PAYMENTMETHOD,COST) values(:ctr,:cid,:medid,:pid,:q,'pending','cash',15)";
                    adapter = new OracleDataAdapter(cmdstr2, ordb1);
                    adapter.SelectCommand.Parameters.Add("ctr", ctr);
                    adapter.SelectCommand.Parameters.Add("cid",1);
                    adapter.SelectCommand.Parameters.Add("medid", medid);
                    adapter.SelectCommand.Parameters.Add("pid", Pharmacy_ID);
                    adapter.SelectCommand.Parameters.Add("q", sum);
                  
                    OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
                    DataTable panelData = new DataTable();
                    adapter.Fill(panelData);
                    adapter.Update(panelData);
                    MessageBox.Show("The medicine Code is  "+ctr);
                }
            }
            medquantity.Text = "";            
        }
        public SearchForm(int Pharmid)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            Headerpanel.BackColor = Color.FromName(pharmCol);
            Pharmacypanel.BackColor = Color.FromName(pharmCol);
            PharmacyPhone.Text = pharmNum;
            PhramacyName.Text = pharmName;
            PharmacyEmail.Text = pharmEm;
            PharmacyAddress.Text = pharmAd;
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
            WelcomeForm w = new WelcomeForm();
            w.Show();
            this.Hide();
        }
    }
}
