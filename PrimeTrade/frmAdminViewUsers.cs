using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Fonts;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using PrimeTrade.connections;

namespace PrimeTrade
{
    public partial class frmAdminViewUsers : MetroForm
    {
        public frmAdminViewUsers()
        {
            InitializeComponent();
            listView1.Columns.RemoveAt(11);
            listView1.Columns.RemoveAt(10);
            refreshView();
        }

        MySqlConnection connect = new MySqlConnection(classConnection.ConnectNow("GoogleCloude"));

        public void refreshView()
        {
            connect.Open();
            viewUsers();
            connect.Close();
        }

        public void viewUsers()
        {
            listView1.Items.Clear();
            listView1.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT firstname, lasename, email, address, telephone, role, joindate, nic, username, status, idtbl_user, password FROM base.tbl_user", connect);
            
            DataTable dTable = new DataTable();
            dAdpter.Fill(dTable);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {

                DataRow dRow = dTable.Rows[i];
                ListViewItem listItem = new ListViewItem(dRow["firstname"].ToString());
                //listItem.SubItems.Add(dRow["firstname"].ToString());
                listItem.SubItems.Add(dRow["lasename"].ToString());
                listItem.SubItems.Add(dRow["email"].ToString());
                listItem.SubItems.Add(dRow["address"].ToString());
                listItem.SubItems.Add(dRow["telephone"].ToString());
                listItem.SubItems.Add(dRow["role"].ToString());
                listItem.SubItems.Add(dRow["joindate"].ToString());
                listItem.SubItems.Add(dRow["nic"].ToString());
                listItem.SubItems.Add(dRow["username"].ToString());
                listItem.SubItems.Add(dRow["status"].ToString());
                listItem.SubItems.Add(dRow["idtbl_user"].ToString());
                listItem.SubItems.Add(dRow["password"].ToString());

                listView1.Items.Add(listItem);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshView();
        }

        public void SearchUsers()
        {
            listView1.Items.Clear();

            listView1.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT firstname, lasename, email, address, telephone, role, joindate, nic, username, status, idtbl_user FROM base.tbl_user where base.tbl_user.firstname like '%" + txtsearch.Text + "%' or base.tbl_user.lasename like '%" + txtsearch.Text + "%' or base.tbl_user.email like '%" + txtsearch.Text + "%' or base.tbl_user.role like '%" + txtsearch.Text + "%' or base.tbl_user.joindate like '%" + txtsearch.Text + "%' or base.tbl_user.username like '%" + txtsearch.Text + "%' or base.tbl_user.status like '%" + txtsearch.Text + "%' order by base.tbl_user.firstname", connect);
            connect.Open();

            DataTable dTable = new DataTable();
            dAdpter.Fill(dTable);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {

                DataRow dRow = dTable.Rows[i];
                ListViewItem listItem = new ListViewItem(dRow["firstname"].ToString());
                //listItem.SubItems.Add(dRow["firstname"].ToString());
                listItem.SubItems.Add(dRow["lasename"].ToString());
                listItem.SubItems.Add(dRow["email"].ToString());
                listItem.SubItems.Add(dRow["address"].ToString());
                listItem.SubItems.Add(dRow["telephone"].ToString());
                listItem.SubItems.Add(dRow["role"].ToString());
                listItem.SubItems.Add(dRow["joindate"].ToString());
                listItem.SubItems.Add(dRow["nic"].ToString());
                listItem.SubItems.Add(dRow["username"].ToString());
                listItem.SubItems.Add(dRow["status"].ToString());
                listItem.SubItems.Add(dRow["idtbl_user"].ToString());

                listView1.Items.Add(listItem);
            }
            connect.Close();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            SearchUsers();
        }

        private void removeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlParameter[] pera = new MySqlParameter[1];
            pera[0] = new MySqlParameter("userid", SqlDbType.VarChar);
            pera[0].Value = listView1.SelectedItems[0].SubItems[10].Text;

            MySqlCommand command = new MySqlCommand();
            command.Connection = connect;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "user_delete_user";

            command.Parameters.AddRange(pera);
            connect.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                connect.Close();
                MessageBox.Show("User profile Removed.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshView();
            }
            else
            {
                connect.Close();
                MessageBox.Show("Can not remove this profile.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        cntDeleteUser.Show(Cursor.Position);

                        string activeStatus = listView1.SelectedItems[0].SubItems[9].Text;

                        if (activeStatus == "On")
                        {
                            contectActiveStatus.Text = "Deactive this user";
                        }
                        else
                        {
                            contectActiveStatus.Text = "Active this User";
                        }
                    }
                    break;
            }
        }

        private void contectActiveStatus_Click(object sender, EventArgs e)
        {
            string activeStatus = listView1.SelectedItems[0].SubItems[9].Text;
            string state = "";

            MySqlParameter[] pera = new MySqlParameter[2];
            pera[0] = new MySqlParameter("userid", SqlDbType.VarChar);
            pera[0].Value = listView1.SelectedItems[0].SubItems[10].Text;

            pera[1] = new MySqlParameter("state", MySqlDbType.VarChar);
            if (activeStatus == "On")
            {
                state = "Off";
            }
            else
            {

                state = "On";
            }
            pera[1].Value = state.ToString();

            MySqlCommand command = new MySqlCommand();
            command.Connection = connect;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "user_change_active_state";

            command.Parameters.AddRange(pera);
            connect.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                connect.Close();
                MessageBox.Show("User state changes.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshView();
            }
            else
            {
                connect.Close();
                MessageBox.Show("Can not change user state.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string user_id = listView1.SelectedItems[0].SubItems[10].Text;
            string firstname = listView1.SelectedItems[0].SubItems[0].Text;
            string lastname = listView1.SelectedItems[0].SubItems[1].Text;
            string email = listView1.SelectedItems[0].SubItems[2].Text;
            string address = listView1.SelectedItems[0].SubItems[3].Text;
            string telephone = listView1.SelectedItems[0].SubItems[4].Text;
            string role = listView1.SelectedItems[0].SubItems[5].Text;
            string joineddate = listView1.SelectedItems[0].SubItems[6].Text;
            string nic = listView1.SelectedItems[0].SubItems[7].Text;
            string username = listView1.SelectedItems[0].SubItems[8].Text;
            string activestate = listView1.SelectedItems[0].SubItems[9].Text;
            string password = listView1.SelectedItems[0].SubItems[11].Text;
            frmAdminAddUser form = new frmAdminAddUser("Update", user_id, firstname, lastname, email, address, telephone, role, joineddate, nic, username, activestate, password);
            form.MdiParent = frmAdminHome.ActiveForm;
            form.Show();
        }
    }
}
