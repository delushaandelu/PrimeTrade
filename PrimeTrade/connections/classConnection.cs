using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace PrimeTrade.connections
{
    class classConnection
    {
        public void connectDatabase()
        {
            string conn_string = System.Configuration.ConfigurationManager.ConnectionStrings["GoogleCloude"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(conn_string))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Problem Occures While Connection to Server. '" + "conn_string" + "'", "Connection Eerror!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static string ConnectNow(string conn_name)
        {
            return ConfigurationManager.ConnectionStrings[conn_name].ConnectionString;
        }
    }
}
