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
    public partial class frmManagerDistributerArea : MaterialForm
    {
        public frmManagerDistributerArea()
        {
            InitializeComponent();
            viewAllDistributers();
            viewAllAreas();
            viewAlldata();
        }

        MySqlConnection connect = new MySqlConnection(connections.classConnection.ConnectNow("GoogleCloude"));

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

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtdis.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtdistributer.Text = listView1.SelectedItems[0].SubItems[1].Text; ;
        }

        public void viewAllAreas()
        {
            listView2.Items.Clear();
            listView2.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT areaid, areaname, province FROM base.tb_area;", connect);

            DataTable dTable = new DataTable();
            dAdpter.Fill(dTable);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {

                DataRow dRow = dTable.Rows[i];
                ListViewItem listItem = new ListViewItem(dRow["areaid"].ToString());
                listItem.SubItems.Add(dRow["areaname"].ToString());
                listItem.SubItems.Add(dRow["province"].ToString());
                listView2.Items.Add(listItem);
            }
        }

        private void listView2_MouseClick(object sender, MouseEventArgs e)
        {
            txtareaid.Text = listView2.SelectedItems[0].SubItems[0].Text;
            txtareaname.Text = listView2.SelectedItems[0].SubItems[1].Text;
            txtprov.Text = listView2.SelectedItems[0].SubItems[2].Text;
        }

        private void clearall()
        {
            txtareaid.ResetText();
            txtdis.ResetText();
            txtdistributer.ResetText();
            txtareaname.ResetText();
            txtprov.ResetText();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void btnaddarea_Click(object sender, EventArgs e)
        {
            if (txtdis.Text == "" || txtareaid.Text == "")
            {
                MessageBox.Show("Please select a Distributer or a Area to process.", "Need Valid Record !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MySqlParameter[] pera = new MySqlParameter[2];
                pera[0] = new MySqlParameter("user_id", MySqlDbType.VarChar);
                pera[0].Value = txtdis.Text;

                pera[1] = new MySqlParameter("area_id", MySqlDbType.VarChar);
                pera[1].Value = txtareaid.Text;

                MySqlCommand command = new MySqlCommand();
                command.Connection = connect;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "distributer_area_new";

                command.Parameters.AddRange(pera);
                connect.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    connect.Close();
                    MessageBox.Show("New area assign to distributer.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearall();
                    viewAlldata();
                }
                else
                {
                    connect.Close();
                    MessageBox.Show("Can not assign a area to distributer.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void viewAlldata()
        {
            listView3.Items.Clear();
            listView3.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT `tb_distributer_area`.`recid`, `tbl_user`.`firstname`,`tb_area`.`areaname`,`tb_area`.`province`,`tbl_user`.`email`,`tbl_user`.`address`,`tbl_user`.`telephone`,`tbl_user`.`joindate` FROM `base`.`tb_distributer_area`, `base`.`tbl_user`, `base`.`tb_area` where `base`.`tb_distributer_area`.`userid` = `base`.`tbl_user`.`idtbl_user` and `base`.`tb_distributer_area`.`areaid` = `tb_area`.`areaid`;", connect);

            DataTable dTable = new DataTable();
            dAdpter.Fill(dTable);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {

                DataRow dRow = dTable.Rows[i];
                ListViewItem listItem = new ListViewItem(dRow["recid"].ToString());
                listItem.SubItems.Add(dRow["firstname"].ToString());
                listItem.SubItems.Add(dRow["areaname"].ToString());
                listItem.SubItems.Add(dRow["province"].ToString());
                listItem.SubItems.Add(dRow["email"].ToString());
                listItem.SubItems.Add(dRow["address"].ToString());
                listItem.SubItems.Add(dRow["telephone"].ToString());
                listItem.SubItems.Add(dRow["joindate"].ToString());
                listView3.Items.Add(listItem);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            viewAllDistributers();
            viewAllAreas();
            viewAlldata();
        }

        private void listView3_MouseClick(object sender, MouseEventArgs e)
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

        private void removeCombinationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string recid = listView3.SelectedItems[0].SubItems[0].Text;

            MySqlParameter[] pera = new MySqlParameter[1];
            pera[0] = new MySqlParameter("rec_id", MySqlDbType.VarChar);
            pera[0].Value = recid;

            MySqlCommand command = new MySqlCommand();
            command.Connection = connect;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "distributer_area_delete";

            command.Parameters.AddRange(pera);
            connect.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                connect.Close();
                MessageBox.Show("Record deleted.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearall();
                viewAlldata();
            }
            else
            {
                connect.Close();
                MessageBox.Show("Can not delete the record.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

