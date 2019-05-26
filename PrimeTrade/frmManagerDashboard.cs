using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Fonts;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using PrimeTrade.connections;

namespace PrimeTrade
{
    public partial class frmManagerDashboard : MetroForm
    {
        public frmManagerDashboard()
        {
            InitializeComponent();
            AutoStartMethod();
            loadWeeklySplit();
            BarChartCatogary();
            speederMeter();
            salesGraph();
            pieChart();
            AutoGenerationData();
        }

         MySqlConnection connect = new MySqlConnection(classConnection.ConnectNow("GoogleCloude"));

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public void donetChart()
        {
            connect.Open();
            salesChart.ResetAutoValues();

            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT `tb_stock`.`state`,SUM( `tb_stock`.`qty`) FROM `base`.`tb_stock` GROUP BY `tb_stock`.`state`;";
            MySqlDataReader reader;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tileDistributers.Series["Days"].Points.AddXY(reader.GetString("state"), reader.GetInt32("SUM( `tb_stock`.`qty`)"));
            }

            connect.Close();
        }

        public void stockChart()
        {
            connect.Open();
            salesChart.ResetAutoValues();

            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT sum(`tb_sales`.`qty1`),sum(`tb_sales`.`qty2`) FROM `base`.`tb_sales` WHERE `tb_sales`.`promotionid` = '"+ cmbpromotion.Text + "'  GROUP BY `tb_sales`.`promotionid`;";
            MySqlDataReader reader;
            
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tileDistributers.Series["Series1"].Points.AddXY(reader.GetString("sum(`tb_sales`.`qty1`)"), reader.GetInt32("sum(`tb_sales`.`qty2`)"));
                //.Series["Series2"].Points.AddXY(reader.GetString("2"), reader.GetInt32("sum( `tb_sales`.`qty2`)"));
            }

            connect.Close();
        }


        public void pieChart()
        {
            connect.Open();
            salesChart.ResetAutoValues();

            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT `tb_stock`.`name`, SUM( `tb_stock`.`qty`) FROM `base`.`tb_stock` GROUP BY `tb_stock`.`name`;";
            MySqlDataReader reader;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                chartpie.Series["s1"].Points.AddXY(reader.GetString("name"), reader.GetInt32("SUM( `tb_stock`.`qty`)"));
            }

            connect.Close();
        }

        public void speederMeter()
        {
            MySqlCommand command = new MySqlCommand();
            connect.Open();
            command.Connection = connect;

            command.CommandText = "get_overall_kpi";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new MySqlParameter("@kpi", MySqlDbType.VarChar));
            command.Parameters["@kpi"].Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            solidGauge1.Value = Math.Round(Convert.ToDouble((string)command.Parameters["@kpi"].Value),3);
            connect.Close();
        }

        public void loadWeeklySplit()
        {
            loadchartPast();
            //loadchartFuture();
        }

        public void loadchartPast()
        {
            connect.Open();

            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT sum(`tb_sales`.`qty1`), sum(`tb_sales`.`qty2`)*1.4,`tb_sales`.`salesdate` FROM `base`.`tb_sales`  group by `tb_sales`.`salesdate` order by STR_TO_DATE(`tb_sales`.`salesdate`,'%d/%m/%Y') ASC";
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
            cmd.CommandText = "SELECT sum(`tb_sales`.`qty1`)*1.3, sum(`tb_sales`.`qty2`)*1.5,DATE_ADD(`tb_sales`.`salesdate`, INTERVAL 15 DAY) FROM `base`.`tb_sales`  group by DATE_ADD(STR_TO_DATE(`tb_sales`.`salesdate`,'%d/%m/%Y'), INTERVAL 15 DAY)";
            MySqlDataReader reader;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                chartSales.Series["Actual"].Points.AddXY(reader.GetString("DATE_ADD(`tb_sales`.`salesdate`, INTERVAL 15 DAY)"),0);
                chartSales.Series["Prediction"].Points.AddY(reader.GetInt32("sum(`tb_sales`.`qty2`)*1.5"));
            }

            connect.Close();
        }


        public void AutoStartMethod()
        {
            viewPromotions();
            getStockRage();
            getDistributers();
            getAreaCount();
            //etSalesRate();
        }

        public void AutoGenerationData()
        {
            btnSearchTeacher.Text = RandomNumber(2000, 10000).ToString();
            tileSalesRate.Text = RandomNumber(4, 9).ToString();
            button5.Text = RandomNumber(4, 30).ToString();
            button6.Text = RandomNumber(7, 10).ToString();
            button7.Text = RandomNumber(4000, 18000).ToString();
            label22.Text = button7.Text;
            label24.Text = RandomNumber(12000, 18000).ToString();
            label25.Text = RandomNumber(20000, 40000).ToString();

            label33.Text = RandomNumber(5000, 8000).ToString();
            label30.Text = RandomNumber(10000, 16000).ToString();
            label28.Text = RandomNumber(18000, 30000).ToString();
            label43.Text = RandomNumber(7, 9).ToString();
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
                        cmbpromotion.Items.Add(reader.GetString("promotionid"));
                    }
                }
                connect.Close();
            }

        }

        private void BarChartCatogary()
        {
            connect.Open();
            salesChart.ResetAutoValues();

            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT  `tbl_user`.`firstname`, SUM( `tb_promo_distributer`.`itemoneqty`) FROM `base`.`tb_promo_distributer`, `base`.`tbl_user` WHERE `tbl_user`.`idtbl_user` = `tb_promo_distributer`.`idtb_promo_distributer` AND `tbl_user`.`role` = 'DISTRIBUTER' AND `tb_promo_distributer`.`state` in('APPROVED','ONSALES') GROUP BY `tbl_user`.`firstname`;";
            MySqlDataReader reader;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                chartQty.Series["Distributors"].Points.AddXY(reader.GetString("firstname"), reader.GetInt32("SUM( `tb_promo_distributer`.`itemoneqty`)"));
            }

            connect.Close();
        }

        private void salesGraph()
        {
            connect.Open();
            salesChart.ResetAutoValues();

            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT sum(`tb_sales`.`qty1`) ,`tb_sales`.`salesdate` FROM `base`.`tb_sales` ,`base`.`tbl_user` where `tb_sales`.`distributer` = `tbl_user`.`idtbl_user`  group by `tb_sales`.`salesdate`";
            MySqlDataReader reader;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                salesChart.Series["Main Item Qty"].Points.AddXY(reader.GetString("salesdate"), reader.GetInt32("sum(`tb_sales`.`qty1`)"));
            }

            connect.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            connect.Open();
            salesChart.ResetAutoValues();

            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT sum(`tb_sales`.`qty1`) ,`tb_sales`.`salesdate` FROM `base`.`tb_sales` ,`base`.`tbl_user` where `tb_sales`.`distributer` = `tbl_user`.`idtbl_user` AND `tb_sales`.`promotionid` = '"+cmbpromotion.SelectedItem+"' group by `tb_sales`.`salesdate`";
            MySqlDataReader reader;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                salesChart.Series["Main Item Qty"].Points.AddXY(reader.GetString("salesdate"), reader.GetInt32("sum(`tb_sales`.`qty1`)"));
            }

            connect.Close();

            stockChart();
        }

        private void getStockRage()
        {
            int item2 = 0;

            MySqlCommand command = new MySqlCommand();
            connect.Open();
            command.Connection = connect;

            command.CommandText = "get_stockr_ange";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@counts", MySqlDbType.Int32);
            command.Parameters["@counts"].Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            int.TryParse(command.Parameters["@counts"].Value.ToString(), out item2);
            connect.Close();

            tileStockRange.Text = item2.ToString();
        }

        private void getDistributers()
        {
            int item2 = 0;

            MySqlCommand command = new MySqlCommand();
            connect.Open();
            command.Connection = connect;

            command.CommandText = "get_distributer_count";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@counts", MySqlDbType.Int32);
            command.Parameters["@counts"].Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            int.TryParse(command.Parameters["@counts"].Value.ToString(), out item2);
            connect.Close();

            tileDistributer.Text = item2.ToString();
        }

        private void getAreaCount()
        {
            int item2 = 0;

            MySqlCommand command = new MySqlCommand();
            connect.Open();
            command.Connection = connect;

            command.CommandText = "get_area_count";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@counts", MySqlDbType.Int32);
            command.Parameters["@counts"].Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            int.TryParse(command.Parameters["@counts"].Value.ToString(), out item2);
            connect.Close();

            tileArea.Text = item2.ToString();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
          MetroMessageBox.Show(this, "No Any lates Notification Found.", "Notification !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

 
    }
}

    

