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
using MetroFramework.Forms;
using MetroFramework;

namespace PrimeTrade
{
    public partial class frmManagerSystemSuggestion : MetroForm
    {
        public frmManagerSystemSuggestion()
        {
            InitializeComponent();
            viewPromotions();
        }

        MySqlConnection connect = new MySqlConnection(connections.classConnection.ConnectNow("GoogleCloude"));

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void viewPromotions()
        {
           connect.Open();
            string query = "SELECT distinct `tb_sales`.`promotionid` FROM `base`.`tb_sales`";
            using (var command = new MySqlCommand(query, connect))
            {
                using (var reader = command.ExecuteReader())
                {
                    //Iterate through the rows and add it to the combobox's items
                    while (reader.Read())
                    {
                        cmbPromotion.Items.Add(reader.GetString("promotionid"));
                    }
                }
                connect.Close();
            }
        }

        private void cmbPromotion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            connect.Open();
            command.Connection = connect;

            command.CommandText = "get_system_suggestion";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new MySqlParameter("@promotion_id", cmbPromotion.SelectedItem));
            command.Parameters["@promotion_id"].Direction = ParameterDirection.Input;

            command.Parameters.Add(new MySqlParameter("@firsts", MySqlDbType.VarChar));
            command.Parameters["@firsts"].Direction = ParameterDirection.Output;

            command.Parameters.Add(new MySqlParameter("@lasts", MySqlDbType.VarChar));
            command.Parameters["@lasts"].Direction = ParameterDirection.Output;

            command.Parameters.Add(new MySqlParameter("@qty", MySqlDbType.VarChar));
            command.Parameters["@qty"].Direction = ParameterDirection.Output;

            command.Parameters.Add(new MySqlParameter("@suggestion", MySqlDbType.VarChar));
            command.Parameters["@suggestion"].Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            string message = "UNTIL NOW PROCESS IS GOING WELL!";


            MetroMessageBox.Show(frmDistributersSales.ActiveForm, message, "Allocation Suggestion !", MessageBoxButtons.OK, MessageBoxIcon.Information);



            connect.Close();
        }

        private void splashPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel9_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
