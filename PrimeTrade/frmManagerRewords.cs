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
using PrimeTrade.connections;

namespace PrimeTrade
{
    public partial class frmManagerRewords : MetroForm
    {
        public frmManagerRewords()
        {
            InitializeComponent();
            viewPromotions();
        }
        MySqlConnection connect = new MySqlConnection(classConnection.ConnectNow("GoogleCloude"));
        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void viewPromotions()
        {

            connect.Open();

            string query = "SELECT distinct `tb_sales`.`promotionid` FROM `base`.`tb_sales`";
            using (var command = new MySqlCommand(query, connect))
            {
                using (var reader = command.ExecuteReader())
                {
                    //Iterate through the rows and add it to the combobox's items
                    while (reader.Read())
                    {
                        cmbPromotion.Items.Add(reader.GetString("promotionid"));
                    }
                }
                connect.Close();
            }

        }

        private void viewAllPromotionDetails()
        {
            listView1.Items.Clear();
            listView1.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT `tbl_user`.`firstname`,`tbl_user`.`idtbl_user`  FROM `base`.`tb_sales`, `base`.`tbl_user` WHERE `tbl_user`.`idtbl_user` = `tb_sales`.`distributer` and  `tb_sales`.`promotionid` = '"+cmbPromotion.Text+"' LIMIT 1; ", connect);

            DataTable dTable = new DataTable();
            dAdpter.Fill(dTable);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {

                DataRow dRow = dTable.Rows[i];
                ListViewItem listItem = new ListViewItem(dRow["firstname"].ToString());             
                listItem.SubItems.Add(dRow["idtbl_user"].ToString());
                listView1.Items.Add(listItem);
            }
        }

        private void cmbPromotion_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewAllPromotionDetails();
        }
    }
}
