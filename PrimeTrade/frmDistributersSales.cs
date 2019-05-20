using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Fonts;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using PrimeTrade.connections;
using Syncfusion;

namespace PrimeTrade
{
    public partial class frmDistributersSales : MetroForm
    {
        public frmDistributersSales(string userid)
        {
            InitializeComponent();
            lbluser.Text = userid;
            viewAllPromotionDetails();
        }

        MySqlConnection connect = new MySqlConnection(classConnection.ConnectNow("GoogleCloude"));

        private void viewAllPromotionDetails()
        {
            listView.Items.Clear();
            listView.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT `tb_promo_distributer`.`idtb_promo_distributer`,`tbl_user`.`firstname`,`tb_promotion`.`promoname`,`tb_promotion`.`promomach`,`tb_promotion`.`promodes`,`tb_promo_distributer`.`itemone`,`tb_stock`.`name`,`tb_promo_distributer`.`priceone`,`tb_promo_distributer`.`itemoneqty`,`tb_promo_distributer`.`itemtwo`,`tb_stock`.`name`,`tb_promo_distributer`.`itemtwoqty`, `tb_promo_distributer`.`pricetwo`,`tb_promotion_active`.`fromdate`,`tb_promotion_active`.`untildate`,`tb_promotion_active`.`Comments`, `tb_promo_distributer`.`state` FROM `base`.`tb_promotion`,`base`.`tb_promo_distributer`,`base`.`tb_promotion_active`, `base`.`tbl_user` ,`base`.`tb_stock`WHERE `tb_promotion_active`.`idtb_promotion_active` = `tb_promo_distributer`.`promo_id` AND   `tb_promotion_active`.`promoid` = `tb_promotion`.`idtb_promotion` AND `tbl_user`.`status` = 'On' AND `tbl_user`.`role` = 'DISTRIBUTER'  AND `tb_promo_distributer`.`itemtwo` = `tb_stock`.`idtb_stock` AND `tb_promo_distributer`.`dist_id` =`tbl_user`.`idtbl_user` AND `tb_promo_distributer`.`state` = 'ONSALES' AND   `tb_promo_distributer`.`dist_id` = '" + lbluser.Text + "'; ", connect);

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
                listView.Items.Add(listItem);
            }
        }

        private void listView4_MouseClick(object sender, MouseEventArgs e)
        {
            txtpromo.Text = listView.SelectedItems[0].SubItems[0].Text;
            
        }

        private void listView_MouseClick(object sender, MouseEventArgs e)
        {
            txtpromo.Text = listView.SelectedItems[0].SubItems[0].Text;
            txtmaincode1.Text = listView.SelectedItems[0].SubItems[5].Text;
            txtmainname.Text = listView.SelectedItems[0].SubItems[6].Text;
            txtmaincode2.Text = listView.SelectedItems[0].SubItems[8].Text;
            txtmainattached.Text = listView.SelectedItems[0].SubItems[9].Text;
            lblonhand1.Text = listView.SelectedItems[0].SubItems[7].Text;
            lblonhand2.Text = listView.SelectedItems[0].SubItems[10].Text;
        }

       
        private void clearFields()
        {
            txtpromo.ResetText();
            txtitemqty1.ResetText();
            txtitemqty2.ResetText();
            txtmainattached.ResetText();
            txtmaincode1.ResetText();
            txtmaincode2.ResetText();
            txtmainname.ResetText();
            txtpromo.ResetText();
            txtseller.ResetText();
            lblonhand1.ResetText();
            lblonhand2.ResetText();
            txtprice1.ResetText();
            txtprice2.ResetText();
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            
            if (txtitemqty1.Text == "" || txtitemqty2.Text == "" || txtseller.Text == "" || txtpromo.Text == "" || txtprice1.Text == "" || txtprice2.Text == "")
            {
                MessageBox.Show("Please fill up all the fields.", "Empty Fields Detected !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int qty1 = Int32.Parse(txtitemqty1.Text);
                int handqty1 = Int32.Parse(lblonhand1.Text);

                int qty2 = Int32.Parse(txtitemqty2.Text);
                int handqty2 = Int32.Parse(lblonhand2.Text);

                if (qty1 > handqty1 || qty2 > handqty2)
                {
                    MessageBox.Show("On Hand stock is not enough for this transaction please reorder qty.", "Qty not enough !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MySqlCommand command = new MySqlCommand();
                    connect.Open();
                    command.Connection = connect;

                    command.CommandText = "sales_new";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@promotionid", txtpromo.Text);
                    command.Parameters["@promotionid"].Direction = ParameterDirection.Input;

                    command.Parameters.AddWithValue("@item1", txtmaincode1.Text);
                    command.Parameters["@item1"].Direction = ParameterDirection.Input;

                    command.Parameters.AddWithValue("@qty1", txtitemqty1.Text);
                    command.Parameters["@qty1"].Direction = ParameterDirection.Input;

                    command.Parameters.AddWithValue("@item2", txtmaincode2.Text);
                    command.Parameters["@item2"].Direction = ParameterDirection.Input;

                    command.Parameters.AddWithValue("@qty2", txtitemqty2.Text);
                    command.Parameters["@qty2"].Direction = ParameterDirection.Input;

                    command.Parameters.AddWithValue("@user", lbluser.Text);
                    command.Parameters["@user"].Direction = ParameterDirection.Input;

                    command.Parameters.AddWithValue("@buyer", txtseller.Text);
                    command.Parameters["@buyer"].Direction = ParameterDirection.Input;

                    command.Parameters.AddWithValue("@salesdate", metroDateTime1.Text);
                    command.Parameters["@salesdate"].Direction = ParameterDirection.Input;

                    command.Parameters.AddWithValue("@distributer", lbluser.Text);
                    command.Parameters["@distributer"].Direction = ParameterDirection.Input;

                    command.Parameters.AddWithValue("@price1", txtprice1.Text);
                    command.Parameters["@price1"].Direction = ParameterDirection.Input;

                    command.Parameters.AddWithValue("@price2", txtprice2.Text);
                    command.Parameters["@price2"].Direction = ParameterDirection.Input;

                    if (command.ExecuteNonQuery() == 1)
                    {
                        connect.Close();
                        MetroMessageBox.Show(frmDistributersSales.ActiveForm, "Stock Allocated Sent to Finance Department for Approval.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        viewAllPromotionDetails();
                        
                        MySqlCommand command1 = new MySqlCommand();
                        connect.Open();
                        command1.Connection = connect;

                        command1.CommandText = "strock_reduice_qty";
                        command1.CommandType = CommandType.StoredProcedure;

                        command1.Parameters.AddWithValue("@stockid", txtmaincode1.Text);
                        command1.Parameters["@stockid"].Direction = ParameterDirection.Input;

                        command1.Parameters.AddWithValue("@qty", txtitemqty1.Text);
                        command1.Parameters["@qty"].Direction = ParameterDirection.Input;
                        command1.ExecuteNonQuery();
                        connect.Close();

                        MySqlCommand command2 = new MySqlCommand();
                        connect.Open();
                        command2.Connection = connect;

                        command2.CommandText = "strock_reduice_qty";
                        command2.CommandType = CommandType.StoredProcedure;

                        command2.Parameters.AddWithValue("@stockid", txtmaincode2.Text);
                        command2.Parameters["@stockid"].Direction = ParameterDirection.Input;

                        command2.Parameters.AddWithValue("@qty", txtitemqty2.Text);
                        command2.Parameters["@qty"].Direction = ParameterDirection.Input;
                        command2.ExecuteNonQuery();
                        connect.Close();
                        viewAllPromotionDetails();
                        clearFields();

                    }
                    else
                    {
                        connect.Close();
                        MetroMessageBox.Show(frmDistributersSales.ActiveForm, "Can not allocate stock for the promotion..", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clearFields();
                    }
                                                                                          
                }
                
            }
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void metroDateTime1_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
