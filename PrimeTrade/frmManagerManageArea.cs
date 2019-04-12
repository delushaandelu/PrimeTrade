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
    public partial class frmManagerManageArea : MaterialForm
    {
        public frmManagerManageArea()
        {
            InitializeComponent();
            view_area();
        }

        MySqlConnection connect = new MySqlConnection(connections.classConnection.ConnectNow("GoogleCloude"));

        public void clearn_form()
        {
            txtarea.ResetText();
            cmbprov.ResetText();
        }

        public void view_area()
        {
            listView1.Items.Clear();
            listView1.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT areaid,areaname,province FROM tb_area", connect);

            DataTable dTable = new DataTable();
            dAdpter.Fill(dTable);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {

                DataRow dRow = dTable.Rows[i];
                ListViewItem listItem = new ListViewItem(dRow["areaid"].ToString());
                listItem.SubItems.Add(dRow["areaname"].ToString());
                listItem.SubItems.Add(dRow["province"].ToString());
                
                listView1.Items.Add(listItem);
            }
        }

        private void btnaddarea_Click(object sender, EventArgs e)
        {
            if (txtarea.Text == "" || cmbprov.Text == "")
            {
                MessageBox.Show("Please fill up all the fields.", "Empty Fields Detected !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MySqlParameter[] pera = new MySqlParameter[2];
                pera[0] = new MySqlParameter("areaname", MySqlDbType.VarChar);
                pera[0].Value = txtarea.Text;

                pera[1] = new MySqlParameter("provience", MySqlDbType.VarChar);
                pera[1].Value = cmbprov.Text;

                MySqlCommand command = new MySqlCommand();
                command.Connection = connect;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "area_new";

                command.Parameters.AddRange(pera);
                connect.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    connect.Close();
                    MessageBox.Show("New area added.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearn_form();
                    //load table data
                    view_area();
                }
                else
                {
                    connect.Close();
                    MessageBox.Show("Can not add new area.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnupdatearea_Click(object sender, EventArgs e)
        {
            if (txtarea.Text == "" || cmbprov.Text == "" || txtareaid.Text == "")
            {
                MessageBox.Show("Please select a record from the view to update.", "Empty Fields Detected !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int areadid;
                MySqlParameter[] pera = new MySqlParameter[3];
                pera[0] = new MySqlParameter("areaid", SqlDbType.Int);
                int.TryParse(txtareaid.Text, out areadid);
                pera[0].Value = areadid;

                pera[1] = new MySqlParameter("areaname", MySqlDbType.VarChar);
                pera[1].Value = txtarea.Text;
                
                pera[2] = new MySqlParameter("provience", MySqlDbType.VarChar);
                pera[2].Value = cmbprov.SelectedItem;

                MySqlCommand command = new MySqlCommand();
                command.Connection = connect;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "area_data_update";

                command.Parameters.AddRange(pera);
                connect.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    connect.Close();
                    MessageBox.Show("New area updated.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearn_form();
                    //load table data
                    view_area();
                }
                else
                {
                    connect.Close();
                    MessageBox.Show("Can not update area details.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtareaid.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtarea.Text = listView1.SelectedItems[0].SubItems[1].Text;
            cmbprov.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearn_form();
        }

        private void btndeletearea_Click(object sender, EventArgs e)
        {
            if (txtareaid.Text == "")
            {
                MessageBox.Show("Please select a record from the view to update.", "Empty Fields Detected !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MySqlParameter[] pera = new MySqlParameter[1];
                pera[0] = new MySqlParameter("areaid", SqlDbType.Int);
                pera[0].Value = txtareaid.Text;


                MySqlCommand command = new MySqlCommand();
                command.Connection = connect;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "area_delete";

                command.Parameters.AddRange(pera);
                connect.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    connect.Close();
                    MessageBox.Show("New area deleted.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearn_form();
                    //load table data
                    view_area();
                }
                else
                {
                    connect.Close();
                    MessageBox.Show("Can not delete area details.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
