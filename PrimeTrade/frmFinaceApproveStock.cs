﻿using System;
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
using MetroFramework.Forms;

namespace PrimeTrade
{
    public partial class frmFinaceApproveStock : MetroForm
    {
        public frmFinaceApproveStock()
        {
            InitializeComponent();
            loadDate();
        }
        MySqlConnection connect = new MySqlConnection(connections.classConnection.ConnectNow("GoogleCloude"));

        public void loadDate()
        {
            listView6.Items.Clear();
            listView6.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT `tb_promo_distributer`.`idtb_promo_distributer`, `tbl_user`.`firstname`,`tb_promotion`.`promoname`,`tb_promotion`.`promomach`,`tb_promotion`.`promodes`,`tb_promotion_active`.`fromdate`,`tb_promotion_active`.`untildate`,`tb_promotion_active`.`Comments`,`tb_promo_distributer`.`itemone`,`tb_promo_distributer`.`itemoneqty`,`tb_promo_distributer`.`priceone`,`tb_promo_distributer`.`itemtwo`,`tb_promo_distributer`.`itemtwoqty`,`tb_promo_distributer`.`pricetwo`,`tb_promo_distributer`.`state`FROM `base`.`tb_promo_distributer`, `base`.`tbl_user`,`base`.`tb_promotion`,`base`.`tb_promotion_active` WHERE `tb_promo_distributer`.`dist_id` =`tbl_user`.`idtbl_user` AND `tb_promo_distributer`.`promo_id` = `tb_promotion`.`idtb_promotion` AND `tb_promo_distributer`.`promo_id`=`tb_promotion_active`.`idtb_promotion_active` AND `tb_promo_distributer`.`state` = 'FINANCEAPROVE'  ; ", connect); 

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
                listItem.SubItems.Add(dRow["fromdate"].ToString());
                listItem.SubItems.Add(dRow["untildate"].ToString());
                listItem.SubItems.Add(dRow["Comments"].ToString());
                listItem.SubItems.Add(dRow["itemone"].ToString());
                listItem.SubItems.Add(dRow["itemoneqty"].ToString());
                listItem.SubItems.Add(dRow["priceone"].ToString());
                listItem.SubItems.Add(dRow["itemtwo"].ToString());
                listItem.SubItems.Add(dRow["itemtwoqty"].ToString());
                listItem.SubItems.Add(dRow["pricetwo"].ToString());
                listItem.SubItems.Add(dRow["state"].ToString());


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
                listView6.Items.Add(listItem);
            }
        }

        private void listView6_MouseClick(object sender, MouseEventArgs e)
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

        private void approveRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            connect.Open();
            command.Connection = connect;

            command.CommandText = "promo_approve_finance";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@promoid", listView6.SelectedItems[0].SubItems[0].Text);
            command.Parameters["@promoid"].Direction = ParameterDirection.Input;

            command.Parameters.AddWithValue("@itemid1", listView6.SelectedItems[0].SubItems[8].Text);
            command.Parameters["@itemid1"].Direction = ParameterDirection.Input;

            command.Parameters.AddWithValue("@itemqty1", listView6.SelectedItems[0].SubItems[9].Text);
            command.Parameters["@itemqty1"].Direction = ParameterDirection.Input;

            command.Parameters.AddWithValue("@itemid2", listView6.SelectedItems[0].SubItems[11].Text);
            command.Parameters["@itemid2"].Direction = ParameterDirection.Input;

            command.Parameters.AddWithValue("@itemqty2", listView6.SelectedItems[0].SubItems[12].Text);
            command.Parameters["@itemqty2"].Direction = ParameterDirection.Input;

            if (command.ExecuteNonQuery() == 1)
            {
                connect.Close();
                MessageBox.Show("All Promotion Allocated Successfully.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDate();
            }
            else
            {
                connect.Close();
                MessageBox.Show("All Promotion Allocated Successfully.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
