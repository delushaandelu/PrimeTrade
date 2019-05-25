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

        private void frmManagerGenerateReport_Load(object sender, EventArgs e)
        {

            
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPromotion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPromotion.Text == "VIEW USERS")
            {
                frmReportViewer rep = new frmReportViewer();
                rep.Show();
            }
        }
    }
}
