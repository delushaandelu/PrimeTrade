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
    public partial class frmManagerViewStock : MaterialForm
    {
        public frmManagerViewStock()
        {
            InitializeComponent();
            view_stock();
            
        }
        MySqlConnection connect = new MySqlConnection(connections.classConnection.ConnectNow("GoogleCloude"));
        public void view_stock()
        {
            listView1.Items.Clear();
            listView1.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT idtb_stock,name,catogery,brand,qty,manufactor,mandate,expdate,state,reorder,promocode,newqty,cost,mrp FROM base.tb_stock", connect);

            DataTable dTable = new DataTable();
            dAdpter.Fill(dTable);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {

                DataRow dRow = dTable.Rows[i];
                ListViewItem listItem = new ListViewItem(dRow["idtb_stock"].ToString());
                listItem.SubItems.Add(dRow["name"].ToString());
                listItem.SubItems.Add(dRow["catogery"].ToString());
                listItem.SubItems.Add(dRow["brand"].ToString());
                listItem.SubItems.Add(dRow["qty"].ToString());
                listItem.SubItems.Add(dRow["manufactor"].ToString());
                listItem.SubItems.Add(dRow["mandate"].ToString());
                listItem.SubItems.Add(dRow["expdate"].ToString());
                listItem.SubItems.Add(dRow["state"].ToString());
                listItem.SubItems.Add(dRow["reorder"].ToString());
                listItem.SubItems.Add(dRow["promocode"].ToString());
                listItem.SubItems.Add(dRow["newqty"].ToString());
                listItem.SubItems.Add(dRow["cost"].ToString());
                listItem.SubItems.Add(dRow["mrp"].ToString());

                listView1.Items.Add(listItem);
            }
        }
    }
}
