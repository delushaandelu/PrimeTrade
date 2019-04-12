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
    public partial class frmManagerDistributerArea : MaterialForm
    {
        public frmManagerDistributerArea()
        {
            InitializeComponent();
            viewAllDistributers();
        }

        MySqlConnection connect = new MySqlConnection(connections.classConnection.ConnectNow("GoogleCloude"));

        public void viewAllDistributers()
        {
            listView1.Items.Clear();
            listView1.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT idtbl_user,firstname,lasename,email,address,telephone,joindate,nic FROM tbl_user WHERE status = 'On' AND role = 'DISTRIBUTER';", connect);

            DataTable dTable = new DataTable();
            dAdpter.Fill(dTable);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {

                DataRow dRow = dTable.Rows[i];
                ListViewItem listItem = new ListViewItem(dRow["idtbl_user"].ToString());
                listItem.SubItems.Add(dRow["firstname"].ToString());
                listItem.SubItems.Add(dRow["lasename"].ToString());
                listItem.SubItems.Add(dRow["email"].ToString());
                listItem.SubItems.Add(dRow["address"].ToString());
                listItem.SubItems.Add(dRow["telephone"].ToString());
                listItem.SubItems.Add(dRow["joindate"].ToString());
                listItem.SubItems.Add(dRow["nic"].ToString());
                listView1.Items.Add(listItem);
            }
        }
    }
}
