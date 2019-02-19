using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeTrade.adminUser;
using System.Configuration;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;
using MetroFramework.Fonts;

namespace PrimeTrade.adminUser
{
    class classUser
    {
        public bool addUser(string firstname, string lastname, string email, string address, string telephone, string role, string joindate, string nic, string username, string status)
        {
            MySqlConnection connect = new MySqlConnection(connections.classConnection.ConnectNow("GoogleCloude"));
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connect;
            connect.Open();

            cmd.CommandText = @"INSERT INTO `base`.`tbl_user`(`firstname`,`lasename`,`email`,`address`,`telephone`,`role`,`joindate`,`nic`,`username`,`password`,`status`)VALUES(@firstname,@lasename,@email,@address,@telephone,@role,@joindate,@nic,@username,@password,@status)";

            cmd.Parameters.AddWithValue("@firstname", firstname);
            cmd.Parameters.AddWithValue("@lasename", lastname);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@telephone", telephone);
            cmd.Parameters.AddWithValue("@role", role);
            cmd.Parameters.AddWithValue("@joindate", joindate);
            cmd.Parameters.AddWithValue("@nic", nic);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", username);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Connection = connect;

            int state = cmd.ExecuteNonQuery();

            if (state == 0)
            {
                connect.Close();
                return false;
            }
            else
            {
                connect.Close();
                return true;
            }
        }
    }
}
