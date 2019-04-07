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
    public partial class frmManagerStockManagement : MaterialForm
    {
        public frmManagerStockManagement(string callfrom)
        {
            InitializeComponent();
            //load table data
            view_stock();
            viewCatagory();
            viewBrand();
            ViewManufactor();
            lblcallfrom.Text = callfrom;

            if (callfrom == "FINANCE")
            {
                approveNewStockToolStripMenuItem.Visible = true;
            }
        }
        MySqlConnection connect = new MySqlConnection(connections.classConnection.ConnectNow("GoogleCloude"));
        
        private void btnaddstock_Click(object sender, EventArgs e)
        {
            if (txtstockname.Text == "" || txtqty.Text == "" || txtreorder.Text == "" || txtreorder.Text == "" || cmbcatogery.Text == "" || cmbbrand.Text == "" || cmbmanufactor.Text  == "" || cmbstate.Text  == "" || txtcost.Text == "" || txtmrp.Text == "")
            {
                MessageBox.Show("Please fill up all the fields.", "Empty Fields Detected !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MySqlParameter[] pera = new MySqlParameter[12];
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

                pera[10] = new MySqlParameter("cost", MySqlDbType.VarChar);
                pera[10].Value = txtcost.Text;

                pera[11] = new MySqlParameter("mrp", MySqlDbType.VarChar);
                pera[11].Value = txtmrp.Text;

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
            txtcost.ResetText();
            txtmrp.ResetText();
        }

        public void view_stock()
        {
            listView1.Items.Clear();
            listView1.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT idtb_stock,name,catogery,brand,qty,manufactor,mandate,expdate,state,reorder,promocode,newqty,cost,mrp FROM base.tb_stock", connect);

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
                listItem.SubItems.Add(dRow["newqty"].ToString());
                listItem.SubItems.Add(dRow["cost"].ToString());
                listItem.SubItems.Add(dRow["mrp"].ToString());

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
            txtcost.Text        = listView1.SelectedItems[0].SubItems[11].Text;
            txtmrp.Text         = listView1.SelectedItems[0].SubItems[12].Text;
        }

        private void btnupdatestock_Click(object sender, EventArgs e)
        {
            if (txtstkid.Text is null || txtstkid.Text == "")
            {
                MessageBox.Show("Please select a stock item update.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
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
                    clearn_form();
                }
                else
                {
                    connect.Close();
                    MessageBox.Show("Can not update stock data.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    clearn_form();
                }
            }
        }

        private void btndeletestock_Click(object sender, EventArgs e)
        {
            if (txtstkid.Text is null || txtstkid.Text == "")
            {
                MessageBox.Show("Please select a stock item deleted.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MySqlParameter[] pera = new MySqlParameter[1];
                pera[0] = new MySqlParameter("stockid", SqlDbType.VarChar);
                pera[0].Value = txtstkid.Text;

                MySqlCommand command = new MySqlCommand();
                command.Connection = connect;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "stock_delete_item";

                command.Parameters.AddRange(pera);
                connect.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    connect.Close();
                    MessageBox.Show("Stock Item Deleted.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    view_stock();
                    clearn_form();
                }
                else
                {
                    connect.Close();
                    MessageBox.Show("Can not Delete the Stock Item.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearn_form();
                }
            }  
        }

        public void viewCatagory()
        {
            connect.Open();

            string query = "SELECT catagoryname FROM tb_stock_cat";
            using (var command = new MySqlCommand(query, connect))
            {
                using (var reader = command.ExecuteReader())
                {
                    //Iterate through the rows and add it to the combobox's items
                    while (reader.Read())
                    {
                        cmbcatogery.Items.Add(reader.GetString("catagoryname"));
                    }
                }
                connect.Close();
            }
        }

        public void viewBrand()
        {
            connect.Open();

            string query = "SELECT idtb_stock_brand FROM tb_stock_brand";
            using (var command = new MySqlCommand(query, connect))
            {
                using (var reader = command.ExecuteReader())
                {
                    //Iterate through the rows and add it to the combobox's items
                    while (reader.Read())
                    {
                        cmbbrand.Items.Add(reader.GetString("idtb_stock_brand"));
                    }
                }
                connect.Close();
            }
        }

        public void ViewManufactor()
        {
            connect.Open();

            string query = "SELECT manufactorname FROM tb_stock_manufactor";
            using (var command = new MySqlCommand(query, connect))
            {
                using (var reader = command.ExecuteReader())
                {
                    //Iterate through the rows and add it to the combobox's items
                    while (reader.Read())
                    {
                        cmbmanufactor.Items.Add(reader.GetString("manufactorname"));
                    }
                }
                connect.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearn_form();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
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

        private void receiveNewStockQuantityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string stockid = listView1.SelectedItems[0].SubItems[0].Text;
            string item = listView1.SelectedItems[0].SubItems[1].Text;
            string cat = listView1.SelectedItems[0].SubItems[2].Text;
            string brand = listView1.SelectedItems[0].SubItems[3].Text;
            string man = listView1.SelectedItems[0].SubItems[5].Text;
            int quantity;
            int newqty;

            int.TryParse(listView1.SelectedItems[0].SubItems[4].Text, out quantity);
            int.TryParse(listView1.SelectedItems[0].SubItems[11].Text, out newqty);

            frmManagerReceiveStock receiveStock = new frmManagerReceiveStock(stockid, quantity, newqty, item, cat, brand, man, "REC", "0");
            receiveStock.MdiParent = frmFinanceManagerHome.ActiveForm;
            receiveStock.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            view_stock();
            clearn_form();
        }

        private void approveNewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string stockid = listView1.SelectedItems[0].SubItems[0].Text;
            string item = listView1.SelectedItems[0].SubItems[1].Text;
            string cat = listView1.SelectedItems[0].SubItems[2].Text;
            string brand = listView1.SelectedItems[0].SubItems[3].Text;
            string man = listView1.SelectedItems[0].SubItems[5].Text;
            string newstock = listView1.SelectedItems[0].SubItems[11].Text;
            int quantity;
            int newqty;

            int.TryParse(listView1.SelectedItems[0].SubItems[4].Text, out quantity);
            int.TryParse(listView1.SelectedItems[0].SubItems[11].Text, out newqty);

            frmManagerReceiveStock receiveStock = new frmManagerReceiveStock(stockid, quantity, newqty, item, cat, brand, man, "APR", newstock);
            receiveStock.MdiParent = frmFinanceManagerHome.ActiveForm;
            receiveStock.Show();
        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowQtyRecords.Checked == false)
            {
                listView1.Items.Clear();
                listView1.View = View.Details;

                MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT idtb_stock,name,catogery,brand,qty,manufactor,mandate,expdate,state,reorder,promocode,newqty,cost,mrp FROM base.tb_stock where newqty !=0 or newqty != null", connect);

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
                    listItem.SubItems.Add(dRow["newqty"].ToString());
                    listItem.SubItems.Add(dRow["cost"].ToString());
                    listItem.SubItems.Add(dRow["mrp"].ToString());

                    listView1.Items.Add(listItem);
                }  
            }
            else if (chkShowQtyRecords.Checked == true)
            {
                listView1.Items.Clear();
                listView1.View = View.Details;

                MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT idtb_stock,name,catogery,brand,qty,manufactor,mandate,expdate,state,reorder,promocode,newqty,cost,mrp FROM base.tb_stock where newqty =0 or newqty = null", connect);

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
                    listItem.SubItems.Add(dRow["newqty"].ToString());
                    listItem.SubItems.Add(dRow["cost"].ToString());
                    listItem.SubItems.Add(dRow["mrp"].ToString());

                    listView1.Items.Add(listItem);
                }
            }
        }

        private void txtmrp_TextChanged(object sender, EventArgs e)
        {
            int cost;
            int mrp;
            int profit;
            lblprofit.ResetText();

            int.TryParse(txtcost.Text, out cost);
            int.TryParse(txtmrp.Text, out mrp);

            profit = mrp - cost;

            lblprofit.Text = profit.ToString();
        }

        private void txtcost_TextChanged(object sender, EventArgs e)
        {
            int cost;
            int mrp;
            int profit;
            lblprofit.ResetText();

            int.TryParse(txtcost.Text, out cost);
            int.TryParse(txtmrp.Text, out mrp);

            profit = mrp - cost;

            lblprofit.Text = profit.ToString();
        }

        private void frmManagerStockManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
