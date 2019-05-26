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
    public partial class frmManagerGenerateReport : MetroForm
    {
        public frmManagerGenerateReport()
        {
            InitializeComponent();
        }

        MySqlConnection connect = new MySqlConnection(connections.classConnection.ConnectNow("GoogleCloude"));

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPromotion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPromotion.Text == "VIEW USERS")
            {
                using (connect)
                {
                    connect.Open();
                    MySqlDataAdapter dataAdpter = new MySqlDataAdapter("SELECT `tbl_user`.`firstname`,`tbl_user`.`lasename`,`tbl_user`.`email`,`tbl_user`.`address`,`tbl_user`.`telephone`,`tbl_user`.`role`,`tbl_user`.`joindate`,`tbl_user`.`nic`,`tbl_user`.`username`,`tbl_user`.`status` FROM `base`.`tbl_user`;", connect);
                    DataTable dtpTable = new DataTable();
                    dataAdpter.Fill(dtpTable);

                    dataGridView.DataSource = dtpTable;
                    connect.Close();
                }
            }
            else if (cmbPromotion.Text == "STOCK SUMMARY")
            {
                using (connect)
                {
                    connect.Open();
                    MySqlDataAdapter dataAdpter = new MySqlDataAdapter("SELECT * FROM base.tb_stock", connect);
                    DataTable dtpTable = new DataTable();
                    dataAdpter.Fill(dtpTable);

                    dataGridView.DataSource = dtpTable;
                    connect.Close();
                }
            }
            
            else if (cmbPromotion.Text == "SALES TRANSACTIONS")
            {
                using (connect)
                {
                    connect.Open();
                    MySqlDataAdapter dataAdpter = new MySqlDataAdapter("SELECT `tb_sales`.`idtb_sales`,`tb_sales`.`promotionid`,`tb_sales`.`item1`,`tb_sales`.`qty1`,`tb_sales`.`item2`,`tb_sales`.`price1`,`tb_sales`.`qty2`,`tb_sales`.`price2`,`tb_sales`.`buyer`, `tb_sales`.`salesdate`, `tb_sales`.`distributer` FROM `base`.`tb_sales`", connect);
                    DataTable dtpTable = new DataTable();
                    dataAdpter.Fill(dtpTable);

                    dataGridView.DataSource = dtpTable;
                    connect.Close();
                }
            }
            
            else if (cmbPromotion.Text == "CASH STATEMENT")
            {
                using (connect)
                {
                    connect.Open();
                    MySqlDataAdapter dataAdpter = new MySqlDataAdapter("SELECT `tb_sales`.`promotionid`, sum(`tb_sales`.`price1`) Item_Main, sum(`tb_sales`.`price2`) Attached_item, sum(`tb_sales`.`price1` + `tb_sales`.`price2`) Total_Income_for_promotion FROM `base`.`tb_sales` group by `tb_sales`.`promotionid`;", connect);
                    DataTable dtpTable = new DataTable();
                    dataAdpter.Fill(dtpTable);

                    dataGridView.DataSource = dtpTable;
                    connect.Close();
                }
            }
            
            else if (cmbPromotion.Text == "DISTRIBUTOR SUMMARY")
            {
                using (connect)
                {
                    connect.Open();
                    MySqlDataAdapter dataAdpter = new MySqlDataAdapter("SELECT `tbl_user`.`idtbl_user`,`tbl_user`.`firstname`,`tbl_user`.`lasename`,`tbl_user`.`email`,`tbl_user`.`address`,`tbl_user`.`telephone`,`tbl_user`.`role`,`tbl_user`.`joindate`,`tbl_user`.`nic`,`tbl_user`.`status` FROM `base`.`tbl_user` where `tbl_user`.`role` = 'DISTRIBUTER';", connect);
                    DataTable dtpTable = new DataTable();
                    dataAdpter.Fill(dtpTable);

                    dataGridView.DataSource = dtpTable;
                    connect.Close();
                }
            }

            else if (cmbPromotion.Text == "LATEST NOTIFICATIONS")
            {
                using (connect)
                {
                    connect.Open();
                    MySqlDataAdapter dataAdpter = new MySqlDataAdapter("SELECT * FROM base.tb_req_stock;", connect);
                    DataTable dtpTable = new DataTable();
                    dataAdpter.Fill(dtpTable);

                    dataGridView.DataSource = dtpTable;
                    connect.Close();
                }
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (cmbPromotion.Text == "VIEW USERS")
            {
                string nowtime = DateTime.Now.ToString("yyyyMMddThhmmss");
                string filename = nowtime + "_" + "UserRecords";
                ClassImportPdfReport importReport = new ClassImportPdfReport();
                importReport.exportGridtoPdf(dataGridView, filename);
            }
            else if (cmbPromotion.Text == "STOCK SUMMARY")
            {
                string nowtime = DateTime.Now.ToString("yyyyMMddThhmmss");
                string filename = nowtime + "_" + "StockRecords";
                ClassImportPdfReport importReport = new ClassImportPdfReport();
                importReport.exportGridtoPdf(dataGridView, filename);
            }
            else if (cmbPromotion.Text == "SALES TRANSACTIONS")
            {
                string nowtime = DateTime.Now.ToString("yyyyMMddThhmmss");
                string filename = nowtime + "_" + "SalesRecords";
                ClassImportPdfReport importReport = new ClassImportPdfReport();
                importReport.exportGridtoPdf(dataGridView, filename);
            }
            else if (cmbPromotion.Text == "CASH STATEMENT")
            {
                string nowtime = DateTime.Now.ToString("yyyyMMddThhmmss");
                string filename = nowtime + "_" + "CashStatement";
                ClassImportPdfReport importReport = new ClassImportPdfReport();
                importReport.exportGridtoPdf(dataGridView, filename);
            }
            else if (cmbPromotion.Text == "DISTRIBUTOR SUMMARY")
            {
                string nowtime = DateTime.Now.ToString("yyyyMMddThhmmss");
                string filename = nowtime + "_" + "DistributerSUmmary";
                ClassImportPdfReport importReport = new ClassImportPdfReport();
                importReport.exportGridtoPdf(dataGridView, filename);
            }
            else if (cmbPromotion.Text == "LATEST NOTIFICATIONS")
            {
                string nowtime = DateTime.Now.ToString("yyyyMMddThhmmss");
                string filename = nowtime + "_" + "LatestNotifiacations";
                ClassImportPdfReport importReport = new ClassImportPdfReport();
                importReport.exportGridtoPdf(dataGridView, filename);
            }
        }
    }
}
