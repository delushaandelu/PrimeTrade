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
    public partial class FrmDistributerNewPromotins : MaterialForm
    {
        public FrmDistributerNewPromotins(string userid)
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

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT `tb_promo_distributer`.`idtb_promo_distributer`,`tbl_user`.`firstname`,`tb_promotion`.`promoname`,`tb_promotion`.`promomach`,`tb_promotion`.`promodes`,`tb_promo_distributer`.`itemone`,`tb_stock`.`name`,`tb_promo_distributer`.`priceone`,`tb_promo_distributer`.`itemoneqty`,`tb_promo_distributer`.`itemtwo`,`tb_stock`.`name`,`tb_promo_distributer`.`itemtwoqty`, `tb_promo_distributer`.`pricetwo`,`tb_promotion_active`.`fromdate`,`tb_promotion_active`.`untildate`,`tb_promotion_active`.`Comments`, `tb_promo_distributer`.`state` FROM `base`.`tb_promotion`,`base`.`tb_promo_distributer`,`base`.`tb_promotion_active`, `base`.`tbl_user` ,`base`.`tb_stock`WHERE  `tb_promotion_active`.`idtb_promotion_active` = `tb_promo_distributer`.`promo_id` AND `tbl_user`.`status` = 'On' AND `tbl_user`.`role` = 'DISTRIBUTER'  AND `tb_promo_distributer`.`itemone` = `tb_stock`.`idtb_stock` AND `tb_promo_distributer`.`itemtwo` = `tb_stock`.`idtb_stock` AND `tb_promo_distributer`.`dist_id` =`tbl_user`.`idtbl_user` AND `tb_promo_distributer`.`state` = 'APPROVED' AND `tb_promo_distributer`.`dist_id` = '" + lbluser.Text + "'; ", connect);

            DataTable dTable = new DataTable();
            dAdpter.Fill(dTable);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {

                DataRow dRow = dTable.Rows[i];
                ListViewItem listItem = new ListViewItem(dRow["idtb_promo_distributer"].ToString());
                listItem.SubItems.Add(dRow["firstname"].ToString());
                listItem.SubItems.Add(dRow["promoname"].ToString());
                listItem.SubItems.Add(dRow["promomach"].ToString());
                listItem.SubItems.Add(dRow["promodes"].ToString());
                listItem.SubItems.Add(dRow["itemone"].ToString());
                listItem.SubItems.Add(dRow["name"].ToString());
                listItem.SubItems.Add(dRow["itemoneqty"].ToString());
                listItem.SubItems.Add(dRow["itemtwo"].ToString());
                listItem.SubItems.Add(dRow["name"].ToString());
                listItem.SubItems.Add(dRow["itemtwoqty"].ToString());
                listItem.SubItems.Add(dRow["fromdate"].ToString());
                listItem.SubItems.Add(dRow["untildate"].ToString());
                listItem.SubItems.Add(dRow["comments"].ToString());

                DateTime thisDay = DateTime.Today;
                DateTime fromdate = DateTime.Parse(dRow["fromdate"].ToString());
                DateTime untildate = DateTime.Parse(dRow["untildate"].ToString());

                string state = "";

                if (fromdate > thisDay)
                {
                    state = "NOTSTARTED";
                    listItem.SubItems.Add(state);
                    listItem.SubItems.Add("0");
                }
                else if (fromdate <= thisDay && thisDay <= untildate)
                {
                    state = "ONGOING";
                    listItem.SubItems.Add(state);

                    string date = untildate.Subtract(fromdate).Days.ToString();

                    listItem.SubItems.Add(date);
                }
                else if (fromdate < thisDay && thisDay > untildate)
                {
                    state = "COMPLTED";
                    listItem.SubItems.Add("0");
                }
                listItem.SubItems.Add(dRow["state"].ToString());
                listView4.Items.Add(listItem);
            }
        }

        private void listView4_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        contextMenuStrip1.Show(Cursor.Position);
                    }
                    break;
            }
        }

        private void startPromotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            connect.Open();
            command.Connection = connect;

            command.CommandText = "distributer_approve_promo";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@promoid", listView4.SelectedItems[0].SubItems[0].Text);
            command.Parameters["@promoid"].Direction = ParameterDirection.Input;

            if (command.ExecuteNonQuery() == 1)
            {
                connect.Close();
                MessageBox.Show("You can working on this promotion work.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                viewAllPromotionDetails();
            }
            else
            {
                connect.Close();
                MessageBox.Show("Can not accept the promotion work", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
