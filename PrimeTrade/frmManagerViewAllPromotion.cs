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
    public partial class frmManagerViewAllPromotion : MaterialForm
    {
        MySqlConnection connect = new MySqlConnection(connections.classConnection.ConnectNow("GoogleCloude"));
        public frmManagerViewAllPromotion()
        {
            InitializeComponent();
            viewAllPromotion();
        }

        private void viewAllPromotion()
        {
            listView2.Items.Clear();
            listView2.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("select proa.idtb_promotion_active,pro.promoname,pro.promomach,pro.promodes,proa.fromdate, proa.untildate, proa.Comments from tb_promotion pro,tb_promotion_active proa where pro.idtb_promotion = proa.promoid", connect);

            DataTable dTable = new DataTable();
            dAdpter.Fill(dTable);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {

                DataRow dRow = dTable.Rows[i];
                ListViewItem listItem = new ListViewItem(dRow["idtb_promotion_active"].ToString());
                listItem.SubItems.Add(dRow["promoname"].ToString());
                listItem.SubItems.Add(dRow["promomach"].ToString());
                listItem.SubItems.Add(dRow["promodes"].ToString());
                listItem.SubItems.Add(dRow["fromdate"].ToString());
                listItem.SubItems.Add(dRow["untildate"].ToString());
                listItem.SubItems.Add(dRow["Comments"].ToString());

                listView2.Items.Add(listItem);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            viewAllPromotion();
        }
    }
}
