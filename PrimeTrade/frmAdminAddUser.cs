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
using PrimeTrade.adminUser;
using System.Configuration;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;
using MetroFramework.Fonts;
using PrimeTrade.adminUser;
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace PrimeTrade
{
    public partial class frmAdminAddUser : MetroForm
    {
        MySqlConnection connect = new MySqlConnection(connections.classConnection.ConnectNow("GoogleCloude"));
        string activestatus;
        public frmAdminAddUser(string control)
        {
            InitializeComponent();

            if (control == "Add")
            {
                btnUpdateUser.Hide();
            }
            else if(control == "Update")
            {
                btnAddUser.Hide();
            }
        }

        public frmAdminAddUser(string control, string userid, string firstname, string lastname, string email, string address, string telephone, string role, string joineddate, string nic, string username, string activestate, string password)
        {
            InitializeComponent();
            chkstate.Visible = false;
            lblactive.Visible = false;
            if (control == "Add")
            {
                btnUpdateUser.Hide();
            }
            else if (control == "Update")
            {
                btnAddUser.Hide();
            }

            txtfirstname.Text = firstname;
            txtlastname.Text = lastname;
            txtemail.Text = email;
            txtaddress.Text = address;
            txttelephone.Text = telephone;
            cmbRole.SelectedItem = role;
            dtpjoineddate.Text = joineddate;
            txtnic.Text = nic;
            txtusername.Text = username;
            txtuserid.Text = userid;
            txtpass.Text = password;
            activestatus = activestate;
        }

        public void clearField()
        {
            txtfirstname.ResetText();
            txtlastname.ResetText();
            txtemail.ResetText();
            txtaddress.ResetText();
            txttelephone.ResetText();
            cmbRole.ResetText();
            dtpjoineddate.ResetText();
            txtnic.ResetText();
            txtusername.ResetText();
            chkstate.ResetText();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string firstname = txtfirstname.Text;
            string lastname = txtlastname.Text;
            string email = txtemail.Text;
            string address = txtaddress.Text;
            string telephone = txttelephone.Text;
            string role = cmbRole.Text;
            string joindate = dtpjoineddate.Text;
            string nic = txtnic.Text;
            string username = txtusername.Text;
            string status = chkstate.Text;

            if (firstname == "" || lastname == "" || email == "" || address == "" || telephone == "" || nic == "" || username == "")
            {
                MessageBox.Show("Please fill up all the fields.", "Empty Fields Detected !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                classUser user = new classUser();
                bool ret = user.addUser(firstname, lastname, email, address, telephone, role, joindate, nic, username, status);
                if (ret)
                {
                    MessageBox.Show(this, "New user profile created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearField();
                }
                else
                {
                    MessageBox.Show(this, "Can not create new user now.!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearField();
                }
            }

        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            MySqlParameter[] pera = new MySqlParameter[12];
            pera[0] = new MySqlParameter("userid", SqlDbType.VarChar);
            pera[0].Value = txtuserid.Text;

            pera[1] = new MySqlParameter("firstname", MySqlDbType.VarChar);
            pera[1].Value = txtfirstname.Text;

            pera[2] = new MySqlParameter("lastname", MySqlDbType.VarChar);
            pera[2].Value = txtlastname.Text;

            pera[3] = new MySqlParameter("email", MySqlDbType.VarChar);
            pera[3].Value = txtemail.Text;

            pera[4] = new MySqlParameter("address", MySqlDbType.VarChar);
            pera[4].Value = txtaddress.Text;

            pera[5] = new MySqlParameter("telephone", MySqlDbType.VarChar);
            pera[5].Value = txttelephone.Text;

            pera[6] = new MySqlParameter("role", MySqlDbType.VarChar);
            pera[6].Value = cmbRole.Text;

            pera[7] = new MySqlParameter("joineddate", MySqlDbType.VarChar);
            pera[7].Value = dtpjoineddate.Text;

            pera[8] = new MySqlParameter("nic", MySqlDbType.VarChar);
            pera[8].Value = txtnic.Text;

            pera[9] = new MySqlParameter("username", MySqlDbType.VarChar);
            pera[9].Value = txtusername.Text;

            pera[10] = new MySqlParameter("pass", MySqlDbType.VarChar);
            pera[10].Value = txtpass.Text;

            pera[11] = new MySqlParameter("stat", MySqlDbType.VarChar);
            pera[11].Value = activestatus;

            MySqlCommand command = new MySqlCommand();
            command.Connection = connect;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "user_update_user_data";

            command.Parameters.AddRange(pera);
            connect.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                connect.Close();
                MessageBox.Show("User profile updated.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                connect.Close();
                MessageBox.Show("Can not update user profile.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
