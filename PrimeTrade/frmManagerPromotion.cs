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
    public partial class frmManagerPromotion : MaterialForm
    {
        MySqlConnection connect = new MySqlConnection(connections.classConnection.ConnectNow("GoogleCloude"));

        public frmManagerPromotion()
        {
            InitializeComponent();
            viewPromo();
        }

        private void clearForm()
        {
            txtdes.ResetText();
            txtmac.ResetText();
            txtname.ResetText();
            txtpromoid.ResetText();
        }

        private void viewPromo()
        {
            listView1.Items.Clear();
            listView1.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT idtb_promotion,promoname,promomach,promodes FROM tb_promotion", connect);

            DataTable dTable = new DataTable();
            dAdpter.Fill(dTable);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {

                DataRow dRow = dTable.Rows[i];
                ListViewItem listItem = new ListViewItem(dRow["idtb_promotion"].ToString());
                listItem.SubItems.Add(dRow["promoname"].ToString());
                listItem.SubItems.Add(dRow["promomach"].ToString());
                listItem.SubItems.Add(dRow["promodes"].ToString());

                listView1.Items.Add(listItem);
            }
        }

        private void btnaddpromo_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtmac.Text == "" || txtdes.Text == "")
            {
                MessageBox.Show("Please fill up all the fields.", "Empty Fields Detected !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MySqlParameter[] pera = new MySqlParameter[3];
                pera[0] = new MySqlParameter("promoname", MySqlDbType.VarChar);
                pera[0].Value = txtname.Text;

                pera[1] = new MySqlParameter("promomach", MySqlDbType.VarChar);
                pera[1].Value = txtmac.Text;

                pera[2] = new MySqlParameter("promodes", MySqlDbType.VarChar);
                pera[2].Value = txtdes.Text;
  

                MySqlCommand command = new MySqlCommand();
                command.Connection = connect;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "promo_new";

                command.Parameters.AddRange(pera);
                connect.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    connect.Close();
                    MessageBox.Show("New promotion plan added.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearForm();
                    //load table data
                    viewPromo();
                }
                else
                {
                    connect.Close();
                    MessageBox.Show("Can not add promotion plan item.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtpromoid.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtname.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtmac.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtdes.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }

        private void btnupdatepromo_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtmac.Text == "" || txtpromoid.Text == "")
            {
                MessageBox.Show("Please fill up all the fields.", "Empty Fields Detected !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MySqlParameter[] pera = new MySqlParameter[4];
                pera[0] = new MySqlParameter("promoid", MySqlDbType.VarChar);
                pera[0].Value = txtpromoid.Text;

                pera[1] = new MySqlParameter("promoname", MySqlDbType.VarChar);
                pera[1].Value = txtname.Text;

                pera[2] = new MySqlParameter("promomac", MySqlDbType.VarChar);
                pera[2].Value = txtmac.Text;

                pera[3] = new MySqlParameter("promodec", MySqlDbType.VarChar);
                pera[3].Value = txtdes.Text;


                MySqlCommand command = new MySqlCommand();
                command.Connection = connect;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "promo_update";

                command.Parameters.AddRange(pera);
                connect.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    connect.Close();
                    MessageBox.Show("Promotion plan updated.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearForm();
                    //load table data
                    viewPromo();
                }
                else
                {
                    connect.Close();
                    MessageBox.Show("Can not update promotion plan.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btndeletepromo_Click(object sender, EventArgs e)
        {
            if (txtpromoid.Text == "")
            {
                MessageBox.Show("Please selecte a promotion plan to delete", "Error in Removing promition !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MySqlParameter[] pera = new MySqlParameter[1];
                pera[0] = new MySqlParameter("promoid", MySqlDbType.VarChar);
                pera[0].Value = txtpromoid.Text;

                MySqlCommand command = new MySqlCommand();
                command.Connection = connect;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "promo_delete";

                command.Parameters.AddRange(pera);
                connect.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    connect.Close();
                    MessageBox.Show("Promotion plan deleted.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearForm();
                    //load table data
                    viewPromo();
                }
                else
                {
                    connect.Close();
                    MessageBox.Show("Can not delete promotion plan.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            viewPromo();
        }
    }
}
