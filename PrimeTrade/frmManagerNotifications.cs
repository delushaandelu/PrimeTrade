using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using System.Configuration;
using MetroFramework;
using MetroFramework.Fonts;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace PrimeTrade
{
    public partial class frmManagerNotifications : MetroForm
    {
        public frmManagerNotifications()
        {
            InitializeComponent();
            view_stock();
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        MySqlConnection connect = new MySqlConnection(connections.classConnection.ConnectNow("GoogleCloude"));

        public void view_stock()
        {
            listView2.Items.Clear();
            listView2.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT `tb_req_stock`.`idtb_req_stock`, `tb_req_stock`.`stock`, `tb_req_stock`.`qty`, `tb_req_stock`.`fordate`, `tb_req_stock`.`status`, `tb_req_stock`.`comment`, `tb_req_stock`.`distid` FROM `base`.`tb_req_stock`;", connect);

            DataTable dTable = new DataTable();
            dAdpter.Fill(dTable);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {

                DataRow dRow = dTable.Rows[i];
                ListViewItem listItem = new ListViewItem(dRow["idtb_req_stock"].ToString());
                listItem.SubItems.Add(dRow["stock"].ToString());
                listItem.SubItems.Add(dRow["qty"].ToString());
                listItem.SubItems.Add(dRow["fordate"].ToString());
                listItem.SubItems.Add(dRow["status"].ToString());
                listItem.SubItems.Add(dRow["comment"].ToString());
                listItem.SubItems.Add(dRow["distid"].ToString());
                listView2.Items.Add(listItem);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            connect.Open();
            command.Connection = connect;

            string trsid = listView2.SelectedItems[0].SubItems[0].Text;

            if (trsid == "" || trsid is null)
            {
                MessageBox.Show("Please Select a record for the process.", "Select a record");
            }
            else
            {
                command.CommandText = "req_stock_delete";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new MySqlParameter("@transid", trsid));
                command.Parameters["@transid"].Direction = ParameterDirection.Input;

                if (command.ExecuteNonQuery() == 1)
                {
                    connect.Close();
                    MessageBox.Show("Transaction Done.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    view_stock();
                }
                else
                {
                    connect.Close();
                    MessageBox.Show("Transaction can not done.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    view_stock();
                }
            }
        }
    }
}
