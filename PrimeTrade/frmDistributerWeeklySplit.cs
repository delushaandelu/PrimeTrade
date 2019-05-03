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
    public partial class frmDistributerWeeklySplit : MetroForm
    {
        public frmDistributerWeeklySplit(string userid)
        {
            InitializeComponent();
            lbluser.Text = userid;
        }

        MySqlConnection connect = new MySqlConnection(connections.classConnection.ConnectNow("GoogleCloude"));

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadchartPast()
        {
            connect.Open();

            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT sum(`tb_sales`.`qty1`), sum(`tb_sales`.`qty2`)*1.4,`tb_sales`.`salesdate` FROM `base`.`tb_sales` WHERE `tb_sales`.`distributer` =  '" + lbluser.Text + "'  group by `tb_sales`.`salesdate` order by STR_TO_DATE(`tb_sales`.`salesdate`,'%d/%m/%Y') ASC";
            MySqlDataReader reader;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                chartSales.Series["Actual"].Points.AddXY(reader.GetString("salesdate"), reader.GetInt32("sum(`tb_sales`.`qty1`)"));
                chartSales.Series["Prediction"].Points.AddY(reader.GetInt32("sum(`tb_sales`.`qty2`)*1.4"));
            }

            connect.Close();
        }

        public void loadchartFuture()
        {
            connect.Open();

            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT sum(`tb_sales`.`qty1`)*1.3, sum(`tb_sales`.`qty2`)*1.5,DATE_ADD(STR_TO_DATE(`tb_sales`.`salesdate`,'%d/%m/%Y'), INTERVAL 15 DAY) FROM `base`.`tb_sales` WHERE `tb_sales`.`distributer` =  '" + lbluser.Text + "'  group by DATE_ADD(STR_TO_DATE(`tb_sales`.`salesdate`,'%d/%m/%Y'), INTERVAL 15 DAY)";
            MySqlDataReader reader;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                chartSales.Series["Actual"].Points.AddXY(reader.GetString("DATE_ADD(STR_TO_DATE(`tb_sales`.`salesdate`,'%d/%m/%Y'), INTERVAL 15 DAY)"), 0);
                chartSales.Series["Prediction"].Points.AddY(reader.GetInt32("sum(`tb_sales`.`qty2`)*1.5"));
            }

            connect.Close();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            loadchartPast();
            loadchartFuture();
        }
    }
}
