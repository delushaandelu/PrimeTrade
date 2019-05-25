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
using Syncfusion;
using PagedList;
using DGVPrinterHelper;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace PrimeTrade
{
    public partial class frmReportViewer : MetroForm
    {
        public frmReportViewer()
        {
            InitializeComponent();
            load_data();

            
        }

        public void load_data()
        {
            MySqlConnection connect = new MySqlConnection(connections.classConnection.ConnectNow("GoogleCloude"));
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


        private void btnPrint_Click(object sender, EventArgs e)
        {
            string nowtime = DateTime.Now.ToString("yyyyMMddThhmmss");
            string filename = nowtime + "_" + "UserRecords";
            ClassImportPdfReport importReport = new ClassImportPdfReport();
            importReport.exportGridtoPdf(dataGridView, filename);
        }
    }
}
