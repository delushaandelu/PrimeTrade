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
using MetroFramework.Forms;


namespace PrimeTrade
{
    public partial class frmDistributorReqStock : MetroForm
    {
        public frmDistributorReqStock(string userid)
        {
            InitializeComponent();
            lbluser.Text = userid;
            viewStockTwo();
            view_stock();
        }
        MySqlConnection connect = new MySqlConnection(connections.classConnection.ConnectNow("GoogleCloude"));

        public void view_stock()
        {
            listView4.Items.Clear();
            listView4.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT `tb_req_stock`.`stock`,`tb_req_stock`.`qty`,`tb_req_stock`.`fordate`, `tb_req_stock`.`status`,`tb_req_stock`.`comment`, `tb_req_stock`.`distid` FROM `base`.`tb_req_stock` WHERE  `tb_req_stock`.`distid` = '"+lbluser.Text+"';", connect);

            DataTable dTable = new DataTable();
            dAdpter.Fill(dTable);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {

                DataRow dRow = dTable.Rows[i];
                ListViewItem listItem = new ListViewItem(dRow["stock"].ToString());
                listItem.SubItems.Add(dRow["qty"].ToString());
                listItem.SubItems.Add(dRow["fordate"].ToString());
                listItem.SubItems.Add(dRow["status"].ToString());
                listItem.SubItems.Add(dRow["comment"].ToString());
                listView4.Items.Add(listItem);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void viewStockTwo()
        {
            connect.Open();

            string query = "SELECT `tb_stock`.`idtb_stock` FROM `base`.`tb_stock`";
            using (var command = new MySqlCommand(query, connect))
            {
                using (var reader = command.ExecuteReader())
                {
                    //Iterate through the rows and add it to the combobox's items
                    while (reader.Read())
                    {
                        cmbstock.Items.Add(reader.GetString("idtb_stock"));
                    }
                }
                connect.Close();
            }
        }

        public void clear()
        {
            cmbstock.ResetText();
            txtqty.ResetText();
            txtfordate.ResetText();
            txtcomment.ResetText();
        }

        private void btnrequest_Click(object sender, EventArgs e)
        {
            if (txtqty.Text == "" || cmbstock.Text == "")
            {
                MessageBox.Show("Please fill all the empty fields.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MySqlCommand command = new MySqlCommand();
                connect.Open();
                command.Connection = connect;

                command.CommandText = "request_new_stock";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new MySqlParameter("@stock", cmbstock.SelectedItem));
                command.Parameters["@stock"].Direction = ParameterDirection.Input;

                command.Parameters.Add(new MySqlParameter("@qty", txtqty.Text));
                command.Parameters["@qty"].Direction = ParameterDirection.Input;

                command.Parameters.Add(new MySqlParameter("@fordate", txtfordate.Text));
                command.Parameters["@fordate"].Direction = ParameterDirection.Input;

                command.Parameters.Add(new MySqlParameter("@state", "NEW"));
                command.Parameters["@state"].Direction = ParameterDirection.Input;

                command.Parameters.Add(new MySqlParameter("@comments", txtcomment.Text));
                command.Parameters["@comments"].Direction = ParameterDirection.Input;

                command.Parameters.Add(new MySqlParameter("@distid", lbluser.Text));
                command.Parameters["@distid"].Direction = ParameterDirection.Input;

                if (command.ExecuteNonQuery() == 1)
                {
                    connect.Close();
                    MessageBox.Show("Reqest Sent.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    view_stock();
                }
                else
                {
                    connect.Close();
                    MessageBox.Show("Can not send request.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
                }
            }
        }
    }
}
