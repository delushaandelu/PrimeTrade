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
    public partial class frmManagerActivePromo : MaterialForm
    {
        MySqlConnection connect = new MySqlConnection(connections.classConnection.ConnectNow("GoogleCloude"));
        public frmManagerActivePromo()
        {
            InitializeComponent();
            veiwPromotion();
            viewActivePromotion();
        }

        public void viewActivePromotion()
        {
            listView2.Items.Clear();
            listView2.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("select proa.idtb_promotion_active,pro.promoname,proa.fromdate, proa.untildate, proa.Comments,proa.promoid from tb_promotion pro,tb_promotion_active proa where pro.idtb_promotion = proa.promoid", connect);

            DataTable dTable = new DataTable();
            dAdpter.Fill(dTable);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {

                DataRow dRow = dTable.Rows[i];
                ListViewItem listItem = new ListViewItem(dRow["idtb_promotion_active"].ToString());
                listItem.SubItems.Add(dRow["promoname"].ToString());
                listItem.SubItems.Add(dRow["fromdate"].ToString());
                listItem.SubItems.Add(dRow["untildate"].ToString());
                listItem.SubItems.Add(dRow["Comments"].ToString());
                listItem.SubItems.Add(dRow["promoid"].ToString());

                listView2.Items.Add(listItem);
            }
        }

        public void veiwPromotion()
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            veiwPromotion();
        }

        private void cleanForm()
        {
            txtid.ResetText();
            txtpromoid.ResetText();
            txtfromdate.ResetText();
            txtuntildate.ResetText();
            txtcomments.ResetText();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtpromoid.Text = listView1.SelectedItems[0].SubItems[0].Text;
        }

        private void btnaddstock_Click(object sender, EventArgs e)
        {
            if (txtpromoid.Text == "" || txtfromdate.Text == "" || txtuntildate.Text == "")
            {
                MessageBox.Show("Please fill up all the fields.", "Empty Fields Detected !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MySqlParameter[] pera = new MySqlParameter[4];
                pera[0] = new MySqlParameter("promoid", MySqlDbType.VarChar);
                pera[0].Value = txtpromoid.Text;

                pera[1] = new MySqlParameter("fromdate", MySqlDbType.VarChar);
                pera[1].Value = txtfromdate.Text;

                pera[2] = new MySqlParameter("untildate", MySqlDbType.VarChar);
                pera[2].Value = txtuntildate.Text;

                pera[3] = new MySqlParameter("Comments", MySqlDbType.VarChar);
                pera[3].Value = txtcomments.Text;

                MySqlCommand command = new MySqlCommand();
                command.Connection = connect;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "promo_active_new";

                command.Parameters.AddRange(pera);
                connect.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    connect.Close();
                    MessageBox.Show("New promotion plan added.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleanForm();
                    //load table data
                    veiwPromotion();
                    viewActivePromotion();
                }
                else
                {
                    connect.Close();
                    MessageBox.Show("Can not add promotion plan item.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtuntildate_ValueChanged(object sender, EventArgs e)
        {
            DateTime fromdate = Convert.ToDateTime(txtfromdate.Text);
            DateTime untildate = Convert.ToDateTime(txtuntildate.Text);

            string date = untildate.Subtract(fromdate).Days.ToString();

            txtcomments.Text = "'" + date + "' Days of promotion";
        }

        private void txtfromdate_ValueChanged(object sender, EventArgs e)
        {
            DateTime fromdate = Convert.ToDateTime(txtfromdate.Text);
            DateTime untildate = Convert.ToDateTime(txtuntildate.Text);

            string date = untildate.Subtract(fromdate).Days.ToString();

            txtcomments.Text = "'" + date + "' Days of promotion";
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (txtpromoid.Text == "" || txtfromdate.Text == "" || txtuntildate.Text == ""|| txtid.Text == "")
            {
                MessageBox.Show("Please fill up all the fields. OR please select an active promotion to update from the belowing table", "Empty Fields Detected !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MySqlParameter[] pera = new MySqlParameter[5];
                pera[0] = new MySqlParameter("recid", MySqlDbType.VarChar);
                pera[0].Value = txtid.Text;

                pera[1] = new MySqlParameter("promoid", MySqlDbType.VarChar);
                pera[1].Value = txtpromoid.Text;

                pera[2] = new MySqlParameter("fromdate", MySqlDbType.VarChar);
                pera[2].Value = txtfromdate.Text;

                pera[3] = new MySqlParameter("untildate", MySqlDbType.VarChar);
                pera[3].Value = txtuntildate.Text;

                pera[4] = new MySqlParameter("Comments", MySqlDbType.VarChar);
                pera[4].Value = txtcomments.Text;

                MySqlCommand command = new MySqlCommand();
                command.Connection = connect;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "promo_active_update";

                command.Parameters.AddRange(pera);
                connect.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    connect.Close();
                    MessageBox.Show("Promotion plan updated.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleanForm();
                    //load table data
                    veiwPromotion();
                    viewActivePromotion();
                }
                else
                {
                    connect.Close();
                    MessageBox.Show("Can not updated promotion plan.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listView2_MouseClick(object sender, MouseEventArgs e)
        {
            txtid.Text =  listView2.SelectedItems[0].SubItems[0].Text;
            txtfromdate.Text = listView2.SelectedItems[0].SubItems[2].Text;
            txtuntildate.Text = listView2.SelectedItems[0].SubItems[3].Text;
            txtcomments.Text = listView2.SelectedItems[0].SubItems[4].Text;
            txtpromoid.Text = listView2.SelectedItems[0].SubItems[5].Text;
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (txtpromoid.Text == "" || txtfromdate.Text == "" || txtuntildate.Text == "" || txtid.Text == "")
            {
                MessageBox.Show("Please select an active promotion to update from the belowing table", "Empty Fields Detected !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MySqlParameter[] pera = new MySqlParameter[1];
                pera[0] = new MySqlParameter("recid", MySqlDbType.VarChar);
                pera[0].Value = txtid.Text;

                MySqlCommand command = new MySqlCommand();
                command.Connection = connect;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "promo_active_delete";

                command.Parameters.AddRange(pera);
                connect.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    connect.Close();
                    MessageBox.Show("Promotion plan deleted.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleanForm();
                    //load table data
                    veiwPromotion();
                    viewActivePromotion();
                }
                else
                {
                    connect.Close();
                    MessageBox.Show("Can not delete promotion plan.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            viewActivePromotion();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            cleanForm();
            veiwPromotion();
            viewActivePromotion();
        }
    }
}
