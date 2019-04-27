using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Fonts;
using MetroFramework.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MySql.Data.MySqlClient;

namespace PrimeTrade
{
    public partial class frmManagerViewDistributersByPromotion : MaterialForm
    {
        public frmManagerViewDistributersByPromotion()
        {
            InitializeComponent();
            viewPromotions();
        }
        MySqlConnection connect = new MySqlConnection(connections.classConnection.ConnectNow("GoogleCloude"));

        public void viewPromotions()
        {

            connect.Open();

            string query = "SELECT `tb_promo_distributer`.`promo_id` FROM `base`.`tb_promo_distributer` WHERE `tb_promo_distributer`.`state` = 'ONSALES' ;";
            using (var command = new MySqlCommand(query, connect))
            {
                using (var reader = command.ExecuteReader())
                {
                    //Iterate through the rows and add it to the combobox's items
                    while (reader.Read())
                    {
                        cmbPromotion.Items.Add(reader.GetString("promo_id"));
                    }
                }
                connect.Close();
            }

        }

        private void cmbPromotion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string promotion_id = cmbPromotion.SelectedItem.ToString();
            MessageBox.Show(promotion_id);
            listView2.Items.Clear();
            listView2.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT `tbl_user`.`firstname`,`tb_promotion`.`promoname`,`tb_promotion`.`promomach`,`tb_promotion`.`promodes`,`tb_promo_distributer`.`itemone`,`tb_stock`.`name`,`tb_promo_distributer`.`priceone`,`tb_promo_distributer`.`itemoneqty`,`tb_promo_distributer`.`itemtwo`,`tb_stock`.`name`,`tb_promo_distributer`.`itemtwoqty`, `tb_promo_distributer`.`pricetwo`,`tb_promotion_active`.`fromdate`,`tb_promotion_active`.`untildate`,`tb_promotion_active`.`Comments`, `tb_promo_distributer`.`state` FROM `base`.`tb_promotion`,`base`.`tb_promo_distributer`,`base`.`tb_promotion_active`, `base`.`tbl_user` ,`base`.`tb_stock`WHERE `tb_promotion_active`.`idtb_promotion_active` = `tb_promo_distributer`.`promo_id` AND `tbl_user`.`status` = 'On' AND `tbl_user`.`role` = 'DISTRIBUTER'  AND `tb_promo_distributer`.`itemone` = `tb_stock`.`idtb_stock` AND `tb_promo_distributer`.`itemtwo` = `tb_stock`.`idtb_stock` AND `tb_promo_distributer`.`dist_id` =`tbl_user`.`idtbl_user` AND `tb_promo_distributer`.`state`  = 'ONSALES'AND `tb_promo_distributer`.`promo_id`  = '" + promotion_id + "'", connect);

            DataTable dTable = new DataTable();
            dAdpter.Fill(dTable);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {

                int qty1;

                MySqlCommand command = new MySqlCommand();
                connect.Open();
                command.Connection = connect;

                command.CommandText = "get_tot_item1_sold_qty";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@dist_id", lbluser.Text);
                command.Parameters["@dist_id"].Direction = ParameterDirection.Input;

                command.Parameters.AddWithValue("@promo_id", cmbPromotion.SelectedIndex);
                command.Parameters["@promo_id"].Direction = ParameterDirection.Input;

                command.Parameters.AddWithValue("@qty", MySqlDbType.Int32);
                command.Parameters["@qty"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();

                int.TryParse(command.Parameters["@qty"].Value.ToString(), out qty1);
                connect.Close();


                int qty2;

                MySqlCommand command1 = new MySqlCommand();
                connect.Open();
                command1.Connection = connect;

                command1.CommandText = "get_tot_item2_sold_qty";
                command1.CommandType = CommandType.StoredProcedure;

                command1.Parameters.AddWithValue("@dist_id", lbluser.Text);
                command1.Parameters["@dist_id"].Direction = ParameterDirection.Input;

                command1.Parameters.AddWithValue("@promo_id", cmbPromotion.SelectedIndex);
                command1.Parameters["@promo_id"].Direction = ParameterDirection.Input;

                command1.Parameters.AddWithValue("@qty", MySqlDbType.Int32);
                command1.Parameters["@qty"].Direction = ParameterDirection.Output;

                command1.ExecuteNonQuery();

                int.TryParse(command1.Parameters["@qty"].Value.ToString(), out qty2);
                connect.Close();



                DataRow dRow = dTable.Rows[i];
                ListViewItem listItem = new ListViewItem(dRow["firstname"].ToString());
                listItem.SubItems.Add(dRow["promoname"].ToString());
                listItem.SubItems.Add(dRow["promomach"].ToString());
                listItem.SubItems.Add(dRow["promodes"].ToString());
                listItem.SubItems.Add(dRow["itemone"].ToString());
                listItem.SubItems.Add(dRow["name"].ToString());
                listItem.SubItems.Add(dRow["priceone"].ToString());
                listItem.SubItems.Add(dRow["itemoneqty"].ToString());
                listItem.SubItems.Add(qty1.ToString());
                listItem.SubItems.Add(dRow["itemtwo"].ToString());
                listItem.SubItems.Add(dRow["name"].ToString());
                listItem.SubItems.Add(dRow["pricetwo"].ToString());
                listItem.SubItems.Add(dRow["itemtwoqty"].ToString());
                listItem.SubItems.Add(qty2.ToString());
                listItem.SubItems.Add(dRow["fromdate"].ToString());
                listItem.SubItems.Add(dRow["untildate"].ToString());
                listItem.SubItems.Add(dRow["Comments"].ToString());
                listItem.SubItems.Add("12");
                listView2.Items.Add(listItem);
            }
        }

       
    }
}
