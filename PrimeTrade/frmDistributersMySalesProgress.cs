using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MetroFramework;
using MetroFramework.Fonts;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using PrimeTrade.connections;

namespace PrimeTrade
{
    public partial class frmDistributersMySalesProgress : MetroForm
    {
        public frmDistributersMySalesProgress(string userid)
        {
            InitializeComponent();
            lbluserid.Text = userid;
            LoadChart();
        }

        MySqlConnection connect = new MySqlConnection(classConnection.ConnectNow("GoogleCloude"));

        public void LoadChart()
        {
            connect.Open();

            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT sum(`tb_sales`.`qty1`), sum(`tb_sales`.`qty2`),`tb_sales`.`salesdate` FROM `base`.`tb_sales` where `tb_sales`.`distributer` = '"+lbluserid.Text+ "' group by `tb_sales`.`salesdate`";
            MySqlDataReader reader;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                chartSales.Series["Main Item Qty"].Points.AddXY(reader.GetString("salesdate"), reader.GetInt32("sum(`tb_sales`.`qty1`)"));
                chartSales.Series["Attached Item QTY"].Points.AddY(reader.GetInt32("sum(`tb_sales`.`qty2`)"));
            }

            connect.Close();
        }
    }
}
