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
    public partial class ManagerViewPromotionByDistributers : MaterialForm
    {
        public ManagerViewPromotionByDistributers()
        {
            InitializeComponent();
            viewDistributers();
        }

        MySqlConnection connect = new MySqlConnection(connections.classConnection.ConnectNow("GoogleCloude"));

        public void viewAllPromotionByDIstributers(string userid)
        {
            listView3.Items.Clear();
            listView3.View = View.Details;
            
            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT `tbl_user`.`firstname`,`tb_promotion`.`promoname`,`tb_promotion`.`promomach`,`tb_promotion`.`promodes`,`tb_promotion_active`.`fromdate`,`tb_promotion_active`.`untildate`,`tb_promotion_active`.`Comments` FROM `base`.`tb_promotion`,`base`.`tb_promo_distributer`,`base`.`tb_promotion_active`, `base`.`tbl_user` WHERE `tb_promotion_active`.`idtb_promotion_active` = `tb_promo_distributer`.`promo_id` AND `tbl_user`.`status` = 'On' AND `tbl_user`.`role` = 'DISTRIBUTER' AND `tb_promo_distributer`.`dist_id` =`tbl_user`.`idtbl_user` AND `tb_promo_distributer`.`dist_id` = '" + userid + "';", connect);

            DataTable dTable = new DataTable();
            dAdpter.Fill(dTable);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {
                DataRow dRow = dTable.Rows[i];
                ListViewItem listItem = new ListViewItem(dRow["firstname"].ToString());
                listItem.SubItems.Add(dRow["promoname"].ToString());
                listItem.SubItems.Add(dRow["promomach"].ToString());
                listItem.SubItems.Add(dRow["promodes"].ToString());
                listItem.SubItems.Add(dRow["fromdate"].ToString());
                listItem.SubItems.Add(dRow["untildate"].ToString());
                listItem.SubItems.Add(dRow["Comments"].ToString());

                DateTime thisDay = DateTime.Today;
                DateTime fromdate = DateTime.Parse(dRow["fromdate"].ToString());
                DateTime untildate = DateTime.Parse(dRow["untildate"].ToString());

                string state = "";

                if (fromdate > thisDay)
                {
                    state = "NOTSTARTED";
                    listItem.SubItems.Add(state);
                }
                else if (fromdate <= thisDay && thisDay <= untildate)
                {
                    state = "ONGOING";
                    listItem.SubItems.Add(state);
                }
                else if (fromdate < thisDay && thisDay > untildate)
                {
                    state = "COMPLTED";
                    listItem.SubItems.Add(state);
                }
                
                listView3.Items.Add(listItem);
            }
        }

        public void viewDistributers()
        {
            connect.Open();

            string query = "SELECT idtbl_user FROM tbl_user WHERE status = 'On' AND role = 'DISTRIBUTER'";
            using (var command = new MySqlCommand(query, connect))
            {
                using (var reader = command.ExecuteReader())
                {
                    //Iterate through the rows and add it to the combobox's items
                    while (reader.Read())
                    {
                        cmbDistributers.Items.Add(reader.GetString("idtbl_user"));
                    }
                }
                connect.Close();
            }
        }

        private void cmbDistributers_SelectedValueChanged(object sender, EventArgs e)
        {
            string userid = cmbDistributers.SelectedItem.ToString();
            viewAllPromotionByDIstributers(userid);
        }
    }
}
