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
using MetroFramework;
using MetroFramework.Fonts;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using PrimeTrade.connections;
namespace PrimeTrade
{
    public partial class frmDistributerMySalesData : MaterialForm
    {
        public frmDistributerMySalesData(string userid)
        {
           
            InitializeComponent();
            lbluser.Text = userid;
            viewAllPromotionDetails();
        }

        MySqlConnection connect = new MySqlConnection(connections.classConnection.ConnectNow("GoogleCloude"));

        private void viewAllPromotionDetails()
        {
            listView4.Items.Clear();
            listView4.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT `tb_sales`.`promotionid`,`tb_sales`.`item1`,`tb_sales`.`qty1`,`tb_sales`.`price1`,`tb_sales`.`item2`,`tb_sales`.`qty2`,`tb_sales`.`price2`,`tb_sales`.`buyer`,`tb_sales`.`salesdate`FROM `base`.`tb_sales` where `tb_sales`.`distributer`= '"+ lbluser.Text + "'; ", connect);

            DataTable dTable = new DataTable();
            dAdpter.Fill(dTable);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {

                DataRow dRow = dTable.Rows[i];
                ListViewItem listItem = new ListViewItem(dRow["promotionid"].ToString());
                listItem.SubItems.Add(dRow["item1"].ToString());
                listItem.SubItems.Add(dRow["qty1"].ToString());
                listItem.SubItems.Add(dRow["price1"].ToString());
                listItem.SubItems.Add(dRow["price1"].ToString());
                listItem.SubItems.Add(dRow["item2"].ToString());
                listItem.SubItems.Add(dRow["qty2"].ToString());
                listItem.SubItems.Add(dRow["price2"].ToString());
                listItem.SubItems.Add(dRow["price2"].ToString());
                listItem.SubItems.Add(dRow["buyer"].ToString());
                listItem.SubItems.Add(dRow["salesdate"].ToString());
                listView4.Items.Add(listItem);
            }
        }
    }
}
