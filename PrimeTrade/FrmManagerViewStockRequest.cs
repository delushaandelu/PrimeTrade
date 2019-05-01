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
using MetroFramework;
using MetroFramework.Fonts;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;

namespace PrimeTrade
{
    public partial class FrmManagerViewStockRequest : MetroForm
    {
        public FrmManagerViewStockRequest()
        {
            InitializeComponent();
            view_stock();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        MySqlConnection connect = new MySqlConnection(connections.classConnection.ConnectNow("GoogleCloude"));

        public void view_stock()
        {
            listView4.Items.Clear();
            listView4.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT `tb_req_stock`.`stock`,`tb_req_stock`.`qty`,`tb_req_stock`.`fordate`, `tb_req_stock`.`status`,`tb_req_stock`.`comment`, `tb_req_stock`.`distid` FROM `base`.`tb_req_stock`;", connect);

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
    }
}
