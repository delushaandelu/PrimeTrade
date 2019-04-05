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
    public partial class frmManagerStockBasicData : MaterialForm
    {
        public frmManagerStockBasicData()
        {
            InitializeComponent();
            viewCatogory();
            viewBrand();
            viewManufactor();
        }

        MySqlConnection connect = new MySqlConnection(connections.classConnection.ConnectNow("GoogleCloude"));

        //catogory management
        private void clearCatogory()
        {
            txtcatagory.ResetText();
            chkstate.ResetText();
            txtcatid.ResetText();
        }

        private void viewCatogory()
        {
            listviewCatogory.Items.Clear();
            listviewCatogory.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT idtb_stock_cat,catagoryname,activestate FROM base.tb_stock_cat", connect);

            DataTable dTable = new DataTable();
            dAdpter.Fill(dTable);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {

                DataRow dRow = dTable.Rows[i];
                ListViewItem listItem = new ListViewItem(dRow["idtb_stock_cat"].ToString());
                listItem.SubItems.Add(dRow["catagoryname"].ToString());
                listItem.SubItems.Add(dRow["activestate"].ToString());
                listviewCatogory.Items.Add(listItem);
            }
        }

        private void btncatadd_Click(object sender, EventArgs e)
        {
            if (txtcatagory.Text == "")
            {
                MessageBox.Show("Please fill up all the fields.", "Empty Fields Detected !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MySqlParameter[] pera = new MySqlParameter[2];
                pera[0] = new MySqlParameter("cat", MySqlDbType.VarChar);
                pera[0].Value = txtcatagory.Text;

                pera[1] = new MySqlParameter("state", MySqlDbType.VarChar);
                pera[1].Value = chkstate.Text;

                MySqlCommand command = new MySqlCommand();
                command.Connection = connect;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "stock_cat_new";

                command.Parameters.AddRange(pera);
                connect.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    connect.Close();
                    MessageBox.Show("New stock catagory item added.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearCatogory();
                    //load table data
                    viewCatogory();
                }
                else
                {
                    connect.Close();
                    MessageBox.Show("Can not add new stock catagory item.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btncatupdate_Click(object sender, EventArgs e)
        {
            MySqlParameter[] pera = new MySqlParameter[3];
            pera[0] = new MySqlParameter("row_id", SqlDbType.VarChar);
            pera[0].Value = txtcatid.Text;

            pera[1] = new MySqlParameter("cat", MySqlDbType.VarChar);
            pera[1].Value = txtcatagory.Text;

            pera[2] = new MySqlParameter("state", MySqlDbType.VarChar);
            pera[2].Value = chkstate.Text;

            MySqlCommand command = new MySqlCommand();
            command.Connection = connect;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "stock_cat_update";

            command.Parameters.AddRange(pera);
            connect.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                connect.Close();
                MessageBox.Show("New stock catagory item updated.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearCatogory();
                //load table data
                viewCatogory();
            }
            else
            {
                connect.Close();
                MessageBox.Show("Can not update new stock catagory item.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listviewCatogory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtcatid.Text = listviewCatogory.SelectedItems[0].SubItems[0].Text;
            txtcatagory.Text = listviewCatogory.SelectedItems[0].SubItems[1].Text;
            chkstate.Text = listviewCatogory.SelectedItems[0].SubItems[2].Text;
        }

        private void btncatremove_Click(object sender, EventArgs e)
        {
            MySqlParameter[] pera = new MySqlParameter[1];
            pera[0] = new MySqlParameter("row_id", SqlDbType.VarChar);
            pera[0].Value = txtcatid.Text;

            MySqlCommand command = new MySqlCommand();
            command.Connection = connect;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "stock_cat_delete";

            command.Parameters.AddRange(pera);
            connect.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                connect.Close();
                MessageBox.Show("Stock catagory item Deleted.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearCatogory();
                //load table data
                viewCatogory();
            }
            else
            {
                connect.Close();
                MessageBox.Show("Can not delete stock catagory item.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //brand management
        private void clearBrand()
        {
            txtbrand.ResetText();
            ckkbrandstate.ResetText();
            txtbrandid.ResetText();
        }

        private void viewBrand()
        {
            listviewbrand.Items.Clear();
            listviewbrand.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT idtb_stock_brand,brand,activestate FROM base.tb_stock_brand", connect);

            DataTable dTable = new DataTable();
            dAdpter.Fill(dTable);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {

                DataRow dRow = dTable.Rows[i];
                ListViewItem listItem = new ListViewItem(dRow["idtb_stock_brand"].ToString());
                listItem.SubItems.Add(dRow["brand"].ToString());
                listItem.SubItems.Add(dRow["activestate"].ToString());
                listviewbrand.Items.Add(listItem);
            }
        }

        private void brandadd_Click(object sender, EventArgs e)
        {
            if (txtbrand.Text == "")
            {
                MessageBox.Show("Please fill up all the fields.", "Empty Fields Detected !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MySqlParameter[] pera = new MySqlParameter[2];
                pera[0] = new MySqlParameter("brand", MySqlDbType.VarChar);
                pera[0].Value = txtbrand.Text;

                pera[1] = new MySqlParameter("state", MySqlDbType.VarChar);
                pera[1].Value = ckkbrandstate.Text;

                MySqlCommand command = new MySqlCommand();
                command.Connection = connect;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "stock_brand_new";

                command.Parameters.AddRange(pera);
                connect.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    connect.Close();
                    MessageBox.Show("New stock brand item added.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearBrand();
                    //load table data
                    viewBrand();
                }
                else
                {
                    connect.Close();
                    MessageBox.Show("Can not add new stock brand item.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnbrandchange_Click(object sender, EventArgs e)
        {
            MySqlParameter[] pera = new MySqlParameter[3];
            pera[0] = new MySqlParameter("rec_id", SqlDbType.VarChar);
            pera[0].Value = txtbrandid.Text;

            pera[1] = new MySqlParameter("brand", MySqlDbType.VarChar);
            pera[1].Value = txtbrand.Text;

            pera[2] = new MySqlParameter("state", MySqlDbType.VarChar);
            pera[2].Value = ckkbrandstate.Text;

            MySqlCommand command = new MySqlCommand();
            command.Connection = connect;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "stock_brand_update";

            command.Parameters.AddRange(pera);
            connect.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                connect.Close();
                MessageBox.Show("Stock brand item updated.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearBrand();
                //load table data
                viewBrand();
            }
            else
            {
                connect.Close();
                MessageBox.Show("Can not update stock catagory item.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listviewbrand_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtbrandid.Text = listviewbrand.SelectedItems[0].SubItems[0].Text;
            txtbrand.Text = listviewbrand.SelectedItems[0].SubItems[1].Text;
            ckkbrandstate.Text = listviewbrand.SelectedItems[0].SubItems[2].Text;
        }

        private void btnbrandremove_Click(object sender, EventArgs e)
        {
            MySqlParameter[] pera = new MySqlParameter[1];
            pera[0] = new MySqlParameter("rec_id", SqlDbType.VarChar);
            pera[0].Value = txtbrandid.Text;

            MySqlCommand command = new MySqlCommand();
            command.Connection = connect;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "stock_brand_delete";

            command.Parameters.AddRange(pera);
            connect.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                connect.Close();
                MessageBox.Show("Stock brand item Deleted.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearBrand();
                //load table data
                viewBrand();
            }
            else
            {
                connect.Close();
                MessageBox.Show("Can not delete stock brand item.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //manufactor management
        private void clearManufactor()
        {
            txtmanufactor.ResetText();
            chkmanufactorstate.ResetText();
            txtmanufactorid.ResetText();
        }

        private void viewManufactor()
        {
            listviewmanufactor.Items.Clear();
            listviewmanufactor.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT idtb_stock_manufactor,manufactorname,activestate FROM base.tb_stock_manufactor", connect);

            DataTable dTable = new DataTable();
            dAdpter.Fill(dTable);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {

                DataRow dRow = dTable.Rows[i];
                ListViewItem listItem = new ListViewItem(dRow["idtb_stock_manufactor"].ToString());
                listItem.SubItems.Add(dRow["manufactorname"].ToString());
                listItem.SubItems.Add(dRow["activestate"].ToString());
                listviewmanufactor.Items.Add(listItem);
            }
        }

        private void btnmanadd_Click(object sender, EventArgs e)
        {
            if (txtmanufactor.Text == "")
            {
                MessageBox.Show("Please fill up all the fields.", "Empty Fields Detected !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MySqlParameter[] pera = new MySqlParameter[2];
                pera[0] = new MySqlParameter("man", MySqlDbType.VarChar);
                pera[0].Value = txtmanufactor.Text;

                pera[1] = new MySqlParameter("state", MySqlDbType.VarChar);
                pera[1].Value = chkmanufactorstate.Text;

                MySqlCommand command = new MySqlCommand();
                command.Connection = connect;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "stock_man_new";

                command.Parameters.AddRange(pera);
                connect.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    connect.Close();
                    MessageBox.Show("New stock manufactor item added.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearManufactor();
                    //load table data
                    viewManufactor();
                }
                else
                {
                    connect.Close();
                    MessageBox.Show("Can not add new stock manufactor item.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnmanchange_Click(object sender, EventArgs e)
        {
            MySqlParameter[] pera = new MySqlParameter[3];
            pera[0] = new MySqlParameter("row_id", SqlDbType.VarChar);
            pera[0].Value = txtmanufactorid.Text;

            pera[1] = new MySqlParameter("man", MySqlDbType.VarChar);
            pera[1].Value = txtmanufactor.Text;

            pera[2] = new MySqlParameter("state", MySqlDbType.VarChar);
            pera[2].Value = chkmanufactorstate.Text;

            MySqlCommand command = new MySqlCommand();
            command.Connection = connect;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "stock_man_update";

            command.Parameters.AddRange(pera);
            connect.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                connect.Close();
                MessageBox.Show("Stock manufactor item updated.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearManufactor();
                //load table data
                viewManufactor();
            }
            else
            {
                connect.Close();
                MessageBox.Show("Can not update stock manufactor item.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listviewmanufactor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtmanufactorid.Text = listviewmanufactor.SelectedItems[0].SubItems[0].Text;
            txtmanufactor.Text = listviewmanufactor.SelectedItems[0].SubItems[1].Text;
            chkmanufactorstate.Text = listviewmanufactor.SelectedItems[0].SubItems[2].Text;
        }

        private void btnmanremove_Click(object sender, EventArgs e)
        {
            MySqlParameter[] pera = new MySqlParameter[1];
            pera[0] = new MySqlParameter("row_id", SqlDbType.VarChar);
            pera[0].Value = txtmanufactorid.Text;

            MySqlCommand command = new MySqlCommand();
            command.Connection = connect;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "stock_man_delete";

            command.Parameters.AddRange(pera);
            connect.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                connect.Close();
                MessageBox.Show("Stock Manufactor item Deleted.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearManufactor();
                //load table data
                viewManufactor();
            }
            else
            {
                connect.Close();
                MessageBox.Show("Can not delete stock Manufactor item.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
