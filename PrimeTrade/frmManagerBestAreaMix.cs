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
using MetroFramework;
using MetroFramework.Fonts;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;
using PrimeTrade.connections;

namespace PrimeTrade
{
    public partial class frmManagerBestAreaMix : MetroForm
    {
        public frmManagerBestAreaMix()
        {
            InitializeComponent();
            viewPromotions();
        }

        MySqlConnection connect = new MySqlConnection(classConnection.ConnectNow("GoogleCloude"));

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

            command.CommandText = "get_best_mix_info";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new MySqlParameter("@distributer", MySqlDbType.VarChar));
            command.Parameters["@distributer"].Direction = ParameterDirection.Output;

            command.Parameters.Add(new MySqlParameter("@promoArea", MySqlDbType.VarChar));
            command.Parameters["@promoArea"].Direction = ParameterDirection.Output;

            command.Parameters.Add(new MySqlParameter("@promoName", MySqlDbType.VarChar));
            command.Parameters["@promoName"].Direction = ParameterDirection.Output;

            command.Parameters.Add(new MySqlParameter("@promoMach", MySqlDbType.VarChar));
            command.Parameters["@promoMach"].Direction = ParameterDirection.Output;

            command.Parameters.Add(new MySqlParameter("@totalIncome", MySqlDbType.VarChar));
            command.Parameters["@totalIncome"].Direction = ParameterDirection.Output;

            command.Parameters.Add(new MySqlParameter("@totalprofit", MySqlDbType.VarChar));
            command.Parameters["@totalprofit"].Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            txtmachanism.Text       = (string)command.Parameters["@promoMach"].Value;
            txtproductmix.Text      = (string)command.Parameters["@promoName"].Value;
            txtareas.Text           = (string)command.Parameters["@promoArea"].Value;
            txtdistributers.Text    = (string)command.Parameters["@distributer"].Value;
            txtincome.Text          = (string)command.Parameters["@totalIncome"].Value;
            txtprofit.Text          = (string)command.Parameters["@totalprofit"].Value;

            connect.Close();

        }
    }
}
