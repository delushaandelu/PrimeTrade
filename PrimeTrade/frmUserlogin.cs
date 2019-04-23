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
using System.Configuration;
using MySql.Data.MySqlClient;
using PrimeTrade.connections;


namespace PrimeTrade
{
    public partial class frmUserlogin : MetroForm
    {

        public frmUserlogin()
        {
            InitializeComponent();
        }

        public void hideThisWindow(string profile, string userid)
        {
            if (profile == "BRAND MANAGER")
            {
                frmManagerHome managerHome = new frmManagerHome();
                managerHome.Closed += (s, arg) => this.Close();
                managerHome.Show();
                this.Hide();
            }
            else if (profile == "FINANCE")
            {
                frmFinanceManagerHome financeManagerHome = new frmFinanceManagerHome();
                financeManagerHome.Closed += (s, arg) => this.Close();
                financeManagerHome.Show();
                this.Hide();
            }
            else if (profile == "SYSTEM ADMIN")
            {
                frmAdminHome adminHome = new frmAdminHome();
                adminHome.Closed += (s, arg) => this.Close();
                adminHome.Show();
                this.Hide();
            }
            else if (profile == "SALES") 
            {
                frmSalesHome adminHome = new frmSalesHome();
                adminHome.Closed += (s, arg) => this.Close();
                adminHome.Show();
                this.Hide();
            }
            else if (profile == "DISTRIBUTER") 
            {
                FrmDistibuterHome adminHome = new FrmDistibuterHome(userid);
                adminHome.Closed += (s, arg) => this.Close();
                adminHome.Show();
                this.Hide();
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            string db_string = classConnection.ConnectNow("GoogleCloude");
            MySqlConnection connect = new MySqlConnection(db_string);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connect;
            connect.Open();

            string username = txtusername.Text;
            string password = txtpassword.Text;
            string profile = cmbusertype.Text;
            string auth = "FALSE";
            string userid = "";

            if (username == "" || password == "" || profile == "")
            {
                MessageBox.Show(this, "Empty Fields Detected ! Please fill up all the fields");
                return;
            }

            cmd.CommandText = "SELECT * FROM base.tbl_user where username=@user and password=@pass and role=@role and status = 'on'";
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pass", password);
            cmd.Parameters.AddWithValue("@role", profile);

            MySqlDataReader login = cmd.ExecuteReader();

            if (login.HasRows)
            {
                auth = "TRUE";
                connect.Close();
                if (auth == "TRUE")
                {
                    MySqlCommand cmd2 = new MySqlCommand("SELECT idtbl_user FROM base.tbl_user where username=@user and password=@pass and role=@role", connect);
                    cmd2.Parameters.AddWithValue("@user", username);
                    cmd2.Parameters.AddWithValue("@pass", password);
                    cmd2.Parameters.AddWithValue("@role", profile);
                    connect.Open();

                    MySqlDataReader dReader = cmd2.ExecuteReader();

                    if (dReader.HasRows)
                    {
                        while (dReader.Read())
                        {
                            userid = dReader.GetValue(0).ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalide Login Credentials.", "Please check you username and password!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtpassword.ResetText();
                        txtusername.ResetText();
                        cmbusertype.ResetText();
                    }
                    hideThisWindow(profile, userid);
                }
            }
            else
            {
                MessageBox.Show("Invalide Login Credentials.", "Please check you username and password!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.ResetText();
                txtusername.ResetText();
                cmbusertype.ResetText();
            }
        }
    }
}
