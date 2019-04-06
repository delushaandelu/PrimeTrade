using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace PrimeTrade
{
    public partial class frmManagerReceiveStock : MaterialForm
    {
        public frmManagerReceiveStock(string stock_id, int quantity, int newstock, string item, string cat, string brand, string man, string callfrom, string receivedStock)
        {
            InitializeComponent();

            lblitem.Text = stock_id;
            lblitemname.Text = item;
            lblcatagory.Text = cat;
            lblbrand.Text = brand;
            lblmanufactor.Text = man;
            lblstock.Text = quantity.ToString();

            if (callfrom == "APR")
            {
                int stock;
                int newstocks;
                int total;

                int.TryParse(lblstock.Text, out stock);
                int.TryParse(receivedStock, out newstocks);

                total = stock + newstocks;

                btnApproceNewStock.Visible = true;
                txtnewstock.Enabled = false;
                txtnewstock.Text = receivedStock;
                lbltotalstock.Text = total.ToString();
            }
        }

        MySqlConnection connect = new MySqlConnection(connections.classConnection.ConnectNow("GoogleCloude"));

        private void txtreorder_TextChanged(object sender, EventArgs e)
        {
            int stock;
            int total;
            int received;
            int.TryParse(lblstock.Text, out stock);
            int.TryParse(txtnewstock.Text, out received);

            total = stock + received;

            lbltotalstock.Text = total.ToString();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            MySqlParameter[] pera = new MySqlParameter[2];
            pera[0] = new MySqlParameter("row_id", MySqlDbType.VarChar);
            pera[0].Value = lblitem.Text;

            pera[1] = new MySqlParameter("qty", MySqlDbType.VarChar);
            pera[1].Value = txtnewstock.Text;

            MySqlCommand command = new MySqlCommand();
            command.Connection = connect;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "stock_receive_qty";

            command.Parameters.AddRange(pera);
            connect.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                connect.Close();
                MessageBox.Show("Stock have received, Account deparment need to prove the new stock", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                connect.Close();
                MessageBox.Show("Can not receive new stock.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            MySqlParameter[] pera = new MySqlParameter[2];
            pera[0] = new MySqlParameter("row_id", MySqlDbType.VarChar);
            pera[0].Value = lblitem.Text;

            pera[1] = new MySqlParameter("qty", MySqlDbType.VarChar);
            pera[1].Value = lbltotalstock.Text;

            MySqlCommand command = new MySqlCommand();
            command.Connection = connect;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "stock_approve_qty";

            command.Parameters.AddRange(pera);
            connect.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                connect.Close();
                MessageBox.Show("Received stock has added to existing stock.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                connect.Close();
                MessageBox.Show("Can not approved received stock.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
