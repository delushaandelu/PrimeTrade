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
    public partial class frmPromotionsToDistributers : MaterialForm
    {
        public frmPromotionsToDistributers()
        {
            InitializeComponent();
            viewAllPromotion();
            viewAllDistributers();
            viewDistributers();
            viewAllPromotionDetails();
            viewAllStock();
            viewStockTwo();
            viewStockOne();
            viewDistributers2();
        }
        MySqlConnection connect = new MySqlConnection(connections.classConnection.ConnectNow("GoogleCloude"));

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

        private void listView2_MouseClick(object sender, MouseEventArgs e)
        {
            txtpromotion.Text = listView2.SelectedItems[0].SubItems[0].Text;
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtdistributer.Text = listView1.SelectedItems[0].SubItems[0].Text;
        }

        private void clearForm()
        {
            txtpromotion.ResetText();
            txtdistributer.ResetText();
        }

        private void btnaddarea_Click(object sender, EventArgs e)
        {
            if (txtpromotion.Text == "" || txtdistributer.Text == "")
            {
                MessageBox.Show("Please fill up all the fields.", "Empty Fields Detected !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MySqlParameter[] pera = new MySqlParameter[2];
                pera[0] = new MySqlParameter("promo_id", MySqlDbType.VarChar);
                pera[0].Value = txtpromotion.Text;

                pera[1] = new MySqlParameter("dist_id", MySqlDbType.VarChar);
                pera[1].Value = txtdistributer.Text;


                MySqlCommand command = new MySqlCommand();
                command.Connection = connect;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "promodis_new";

                command.Parameters.AddRange(pera);
                connect.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    connect.Close();
                    MessageBox.Show("New promotion plan added.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearForm();
                    //load table data

                }
                else
                {
                    connect.Close();
                    MessageBox.Show("Can not add promotion plan item.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listView2_MouseClick_1(object sender, MouseEventArgs e)
        {
            txtpromotion.Text = listView2.SelectedItems[0].SubItems[0].Text;
        }

        private void listView1_MouseClick_1(object sender, MouseEventArgs e)
        {
            txtdistributer.Text = listView1.SelectedItems[0].SubItems[0].Text;
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

        public void viewPromoDetails(string user_id)
        {        
            listView3.Items.Clear();
            listView3.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT `tbl_user`.`firstname`,`tb_promotion`.`promoname`,`tb_promotion`.`promomach`,`tb_promotion`.`promodes`,`tb_promotion_active`.`fromdate`,`tb_promotion_active`.`untildate`,`tb_promotion_active`.`Comments` FROM `base`.`tb_promotion`,`base`.`tb_promo_distributer`,`base`.`tb_promotion_active`, `base`.`tbl_user` WHERE `tb_promotion`.`idtb_promotion` = `tb_promo_distributer`.`promo_id` AND `tb_promotion_active`.`idtb_promotion_active` = `tb_promo_distributer`.`promo_id` AND `tbl_user`.`status` = 'On' AND `tbl_user`.`role` = 'DISTRIBUTER' AND `tb_promo_distributer`.`dist_id` =`tbl_user`.`idtbl_user` AND `tb_promo_distributer`.`dist_id` = '" + user_id + "';", connect);

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
                
                listView3.Items.Add(listItem);           
            } 
        }

        private void cmbDistributers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userid = cmbDistributers.SelectedItem.ToString();
            viewPromoDetails(userid);
        }

        private void viewAllPromotionDetails()
        {
            listView4.Items.Clear();
            listView4.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT `tb_promo_distributer`.`idtb_promo_distributer`,`tbl_user`.`firstname`,`tb_promotion`.`promoname`,`tb_promotion`.`promomach`,`tb_promotion`.`promodes`,`tb_promo_distributer`.`itemone`,`tb_promo_distributer`.`itemoneqty`,`tb_promo_distributer`.`itemtwo`,`tb_promo_distributer`.`itemtwoqty`,`tb_promotion_active`.`fromdate`,`tb_promotion_active`.`untildate`,`tb_promotion_active`.`Comments`, `tb_promo_distributer`.`state` FROM `base`.`tb_promotion`,`base`.`tb_promo_distributer`,`base`.`tb_promotion_active`, `base`.`tbl_user` WHERE `tb_promotion`.`idtb_promotion` = `tb_promo_distributer`.`promo_id` AND `tb_promotion_active`.`idtb_promotion_active` = `tb_promo_distributer`.`promo_id` AND `tbl_user`.`status` = 'On' AND `tbl_user`.`role` = 'DISTRIBUTER' AND `tb_promo_distributer`.`dist_id` =`tbl_user`.`idtbl_user` ; ", connect);

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
                listItem.SubItems.Add(dRow["itemoneqty"].ToString());
                listItem.SubItems.Add(dRow["itemtwo"].ToString());
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

        private void viewAllStock()
        {
            listView5.Items.Clear();
            listView5.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT `tb_stock`.`idtb_stock`,`tb_stock`.`name`,`tb_stock`.`catogery`, `tb_stock`.`brand`, `tb_stock`.`qty`,`tb_stock`.`manufactor`,`tb_stock`.`mandate`,`tb_stock`.`expdate`,`tb_stock`.`cost`,`tb_stock`.`mrp` FROM `base`.`tb_stock`; ", connect);

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
                listItem.SubItems.Add(dRow["cost"].ToString());
                listItem.SubItems.Add(dRow["mrp"].ToString());

                listView5.Items.Add(listItem);
            }
        }

        public void viewStockOne()
        {
            connect.Open();

            string query = "SELECT `tb_stock`.`idtb_stock` FROM `base`.`tb_stock`";
            using (var command = new MySqlCommand(query, connect))
            {
                using (var reader = command.ExecuteReader())
                {
                    //Iterate through the rows and add it to the combobox's items
                    while (reader.Read())
                    {
                        cmbitem1.Items.Add(reader.GetString("idtb_stock"));
                    }
                }
                connect.Close();
            }
        }
        
        public void viewStockTwo()
        {
            connect.Open();

            string query = "SELECT `tb_stock`.`idtb_stock` FROM `base`.`tb_stock`";
            using (var command = new MySqlCommand(query, connect))
            {
                using (var reader = command.ExecuteReader())
                {
                    //Iterate through the rows and add it to the combobox's items
                    while (reader.Read())
                    {
                        cmbitem2.Items.Add(reader.GetString("idtb_stock"));
                    }
                }
                connect.Close();
            }
        }

        private void listView5_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void listView4_MouseClick(object sender, MouseEventArgs e)
        {
            txtpromocode.Text = listView4.SelectedItems[0].SubItems[0].Text;
        }

        private void cmbitem1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtqty1.Enabled = true;
        }

        private void cmbitem2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtqty2.Enabled = true;
        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }

        public void viewDistributers2()
        {
            connect.Open();

            string query = "SELECT firstname FROM tbl_user WHERE status = 'On' AND role = 'DISTRIBUTER'";
            using (var command = new MySqlCommand(query, connect))
            {
                using (var reader = command.ExecuteReader())
                {
                    //Iterate through the rows and add it to the combobox's items
                    while (reader.Read())
                    {
                        cmbdist.Items.Add(reader.GetString("firstname"));
                    }
                }
                connect.Close();
            }
        }

        private void cmbdist_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView4.Items.Clear();
            listView4.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT `tb_promo_distributer`.`idtb_promo_distributer`,`tbl_user`.`firstname`,`tb_promotion`.`promoname`,`tb_promotion`.`promomach`,`tb_promotion`.`promodes`,`tb_promo_distributer`.`itemone`,`tb_promo_distributer`.`itemoneqty`,`tb_promo_distributer`.`itemtwo`,`tb_promo_distributer`.`itemtwoqty`,`tb_promotion_active`.`fromdate`,`tb_promotion_active`.`untildate`,`tb_promotion_active`.`Comments`, `tb_promo_distributer`.`state` FROM `base`.`tb_promotion`,`base`.`tb_promo_distributer`,`base`.`tb_promotion_active`, `base`.`tbl_user` WHERE `tb_promotion`.`idtb_promotion` = `tb_promo_distributer`.`promo_id` AND `tb_promotion_active`.`idtb_promotion_active` = `tb_promo_distributer`.`promo_id` AND `tbl_user`.`status` = 'On' AND `tbl_user`.`role` = 'DISTRIBUTER' AND `tb_promo_distributer`.`dist_id` =`tbl_user`.`idtbl_user` AND `tbl_user`.`firstname` = '"+cmbdist.Text+"' ; ", connect);

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
                listItem.SubItems.Add(dRow["itemoneqty"].ToString());
                listItem.SubItems.Add(dRow["itemtwo"].ToString());
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            viewAllPromotionDetails();
        }

        private void txtqty1_Leave(object sender, EventArgs e)
        {
            int item1;
            int qty1;
            string tableqty = listView5.SelectedItems[0].SubItems[4].Text;


            int.TryParse(txtqty1.Text, out qty1);
            int.TryParse(tableqty, out item1);

            if (qty1 > item1)
            {
                lblstate.Text = "Main item Onhand stock Over Due by '" + (qty1 - item1) + "'";
                btndeliver.Enabled = false;
            }
            else
            {
                lblstate.ResetText();
                btndeliver.Enabled = true;
            }
        }

        private void txtqty2_Leave(object sender, EventArgs e)
        {
            int item1;
            int qty1;
            string tableqty = listView5.SelectedItems[0].SubItems[4].Text;


            int.TryParse(txtqty2.Text, out qty1);
            int.TryParse(tableqty, out item1);

            if (qty1 > item1)
            {
                lblstate1.Text = "Attached item Onhand stock Over Due by '" + (qty1 - item1) + "'";
                btndeliver.Enabled = false;
            }
            else
            {
                lblstate.ResetText();
                btndeliver.Enabled = true;
            }
        }
    }
}
