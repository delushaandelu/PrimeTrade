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

namespace PrimeTrade
{
    public partial class frmManagerStockManagement : MaterialForm
    {
        public frmManagerStockManagement()
        {
            InitializeComponent();
            //load table data
            view_stock();
        }
        MySqlConnection connect = new MySqlConnection(connections.classConnection.ConnectNow("GoogleCloude"));

        private void btnaddstock_Click(object sender, EventArgs e)
        {
            if (txtstockname.Text == "" || txtqty.Text == "" || txtreorder.Text == "" || txtreorder.Text == "" || cmbcatogery.Text == "" || cmbbrand.Text == "" || cmbmanufactor.Text  == "" || cmbstate.Text  == "" || cmbpromocode.Text == "" )
            {
                MessageBox.Show("Please fill up all the fields.", "Empty Fields Detected !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MySqlParameter[] pera = new MySqlParameter[10];
                pera[0] = new MySqlParameter("stockname", MySqlDbType.VarChar);
                pera[0].Value = txtstockname.Text;

                pera[1] = new MySqlParameter("catogery", MySqlDbType.VarChar);
                pera[1].Value = cmbcatogery.Text;

                pera[2] = new MySqlParameter("brand", MySqlDbType.VarChar);
                pera[2].Value = cmbbrand.Text;

                pera[3] = new MySqlParameter("qty", MySqlDbType.VarChar);
                pera[3].Value = txtqty.Text;

                pera[4] = new MySqlParameter("manufator", MySqlDbType.VarChar);
                pera[4].Value = cmbmanufactor.Text;

                pera[5] = new MySqlParameter("mandate", MySqlDbType.VarChar);
                pera[5].Value = dtpmandate.Text;

                pera[6] = new MySqlParameter("expdate", MySqlDbType.VarChar);
                pera[6].Value = dtpexpdate.Text;

                pera[7] = new MySqlParameter("state", MySqlDbType.VarChar);
                pera[7].Value = cmbstate.Text;

                pera[8] = new MySqlParameter("reorder", MySqlDbType.VarChar);
                pera[8].Value = txtreorder.Text;

                pera[9] = new MySqlParameter("promocode", MySqlDbType.VarChar);
                pera[9].Value = cmbpromocode.Text;

                MySqlCommand command = new MySqlCommand();
                command.Connection = connect;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "stock_add_new";

                command.Parameters.AddRange(pera);
                connect.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    connect.Close();
                    MessageBox.Show("New stock item added.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearn_form();
                    //load table data
                    view_stock();
                }
                else
                {
                    connect.Close();
                    MessageBox.Show("Can not add new stock item.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
        }

        private void clearn_form()
        {
            txtstockid.ResetText();
            txtstockname.ResetText();
            cmbcatogery.ResetText();
            cmbmanufactor.ResetText();
            cmbbrand.ResetText();
            cmbstate.ResetText();
            dtpmandate.ResetText();
            dtpexpdate.ResetText();
            txtqty.ResetText();
            txtreorder.ResetText();
            cmbpromocode.ResetText();
        }

        public void view_stock()
        {
            listView1.Items.Clear();
            listView1.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT idtb_stock,name,catogery,brand,qty,manufactor,mandate,expdate,state,reorder,promocode FROM base.tb_stock", connect);

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

                listView1.Items.Add(listItem);
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtstkid.Text       = listView1.SelectedItems[0].SubItems[0].Text;
            txtstockname.Text   = listView1.SelectedItems[0].SubItems[1].Text;
            cmbcatogery.Text    = listView1.SelectedItems[0].SubItems[2].Text;
            cmbbrand.Text       = listView1.SelectedItems[0].SubItems[3].Text;
            cmbmanufactor.Text  = listView1.SelectedItems[0].SubItems[5].Text;
            cmbstate.Text       = listView1.SelectedItems[0].SubItems[8].Text;
            dtpmandate.Text     = listView1.SelectedItems[0].SubItems[6].Text;
            dtpexpdate.Text     = listView1.SelectedItems[0].SubItems[7].Text;
            txtqty.Text         = listView1.SelectedItems[0].SubItems[4].Text;
            txtreorder.Text     = listView1.SelectedItems[0].SubItems[9].Text;
            cmbpromocode.Text   = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void btnupdatestock_Click(object sender, EventArgs e)
        {
            MySqlParameter[] pera = new MySqlParameter[11];
            pera[0] = new MySqlParameter("idtb_stock", SqlDbType.VarChar);
            pera[0].Value = txtstkid.Text;

            pera[1] = new MySqlParameter("stname", MySqlDbType.VarChar);
            pera[1].Value = txtstockname.Text;

            pera[2] = new MySqlParameter("catogery", MySqlDbType.VarChar);
            pera[2].Value = cmbcatogery.Text;

            pera[3] = new MySqlParameter("brand", MySqlDbType.VarChar);
            pera[3].Value = cmbbrand.Text;

            pera[4] = new MySqlParameter("qty", MySqlDbType.VarChar);
            pera[4].Value = cmbbrand.Text;

            pera[5] = new MySqlParameter("manufactor", MySqlDbType.VarChar);
            pera[5].Value = cmbmanufactor.Text;

            pera[6] = new MySqlParameter("mandate", MySqlDbType.VarChar);
            pera[6].Value = dtpmandate.Text;

            pera[7] = new MySqlParameter("expdate", MySqlDbType.VarChar);
            pera[7].Value = dtpexpdate.Text;

            pera[8] = new MySqlParameter("state", MySqlDbType.VarChar);
            pera[8].Value = cmbstate.Text;

            pera[9] = new MySqlParameter("reorder", MySqlDbType.VarChar);
            pera[9].Value = txtreorder.Text;

            pera[10] = new MySqlParameter("promocode", MySqlDbType.VarChar);
            pera[10].Value = cmbpromocode.Text;

            MySqlCommand command = new MySqlCommand();
            command.Connection = connect;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "stock_update";

            command.Parameters.AddRange(pera);
            connect.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                connect.Close();
                MessageBox.Show("Stock data updated.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                view_stock();
            }
            else
            {
                connect.Close();
                MessageBox.Show("Can not update stock data.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
