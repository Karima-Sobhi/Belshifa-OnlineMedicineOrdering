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
    public partial class DeliveryForm : Form
    {
        string ordb = "Data source=orcl;User Id=Belshifa; Password = Belshifa; ";
        OracleConnection conn;
        public DeliveryForm()
        {
            InitializeComponent();
        }

        private void DeliveryForm_Load(object sender, EventArgs e)
        {
            pending_cmb.Text = "None";
        }

        private void showpendingorders_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "ShowORDERS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("orders_results", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                pending_cmb.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void showcanceledorders_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "CountCanceledOrders";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("results",OracleDbType.Int32,ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            canceledLabel.Text = cmd.Parameters["results"].Value.ToString();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Got This Order Suceesfully.");
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            WelcomeForm form = new WelcomeForm();
            this.Hide();
            form.Show();
        }
    }
}
