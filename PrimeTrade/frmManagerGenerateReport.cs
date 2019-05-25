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
                    MySqlDataAdapter dataAdpter = new MySqlDataAdapter("SELECT * FROM base.tbl_user", connect);
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
        }
    }
}
