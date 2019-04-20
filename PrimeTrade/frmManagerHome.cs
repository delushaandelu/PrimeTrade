using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Fonts;
using MetroFramework.Forms;


namespace PrimeTrade
{
    public partial class frmManagerHome : MetroForm
    {
        private int childFormNumber = 0;

        public frmManagerHome()
        {
            InitializeComponent();

            foreach (Control ctl in this.Controls)
            {
                try
                {
                    System.Windows.Forms.Control Mdi = (MdiClient)ctl;

                    Mdi.BackColor = System.Drawing.Color.Gray;
                }
                catch (Exception a)
                {
                }
            }

        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            frmManagerStockManagement form = new frmManagerStockManagement("BRAND");
            form.MdiParent = this;
            form.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            frmManagerStockBasicData form = new frmManagerStockBasicData();
            form.MdiParent = this;
            form.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            frmManagerViewStock form = new frmManagerViewStock();
            form.MdiParent = this;
            form.Show();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStartup login = new frmStartup();
            login.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void reconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("System is reconnect to the Cloud.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void updateSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("System has updated from Github reposotory. Please restart", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagerStockBasicData form = new frmManagerStockBasicData();
            form.MdiParent = this;
            form.Show();
        }

        private void stockManagementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmManagerStockManagement form = new frmManagerStockManagement("BRAND");
            form.MdiParent = this;
            form.Show();
        }

        private void viewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagerViewStock form = new frmManagerViewStock();
            form.MdiParent = this;
            form.Show();
        }

        private void promotionPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagerPromotion form = new frmManagerPromotion();
            form.MdiParent = this;
            form.Show();
        }

        private void activePromotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagerActivePromo form = new frmManagerActivePromo();
            form.MdiParent = this;
            form.Show();
        }

        private void viewAllPromotionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagerViewAllPromotion form = new frmManagerViewAllPromotion();
            form.MdiParent = this;
            form.Show();
        }

        private void manageAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagerManageArea form = new frmManagerManageArea();
            form.MdiParent = this;
            form.Show();
        }

        private void assignAreasToDistributersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagerDistributerArea form = new frmManagerDistributerArea();
            form.MdiParent = this;
            form.Show();
        }

        private void viewAreasByDistributersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagerViewAllAreaDistRecords form = new frmManagerViewAllAreaDistRecords();
            form.MdiParent = this;
            form.Show();

        }

        private void asignPromitonToDistributionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPromotionsToDistributers form = new frmPromotionsToDistributers();
            form.MdiParent = this;
            form.Show();
        }

        private void viewAllPromotionByDIstributersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManagerViewPromotionByDistributers form = new ManagerViewPromotionByDistributers();
            form.MdiParent = this;
            form.Show();
        }

        private void viewAllPromotionByDistributersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerViewPromotionByDistributers form = new ManagerViewPromotionByDistributers();
            form.MdiParent = this;
            form.Show();
        }

        private void viewStockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmManagerViewStock form = new frmManagerViewStock();
            form.MdiParent = this;
            form.Show();
        }

        private void viewAreaByDIstributersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagerViewAllAreaDistRecords form = new frmManagerViewAllAreaDistRecords();
            form.MdiParent = this;
            form.Show();
        }

        private void viewAllPromotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagerViewAllPromotion form = new frmManagerViewAllPromotion();
            form.MdiParent = this;
            form.Show();
        }

        private void viewAllPromotionByStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagerViewPromotionByState form = new frmManagerViewPromotionByState();
            form.MdiParent = this;
            form.Show();
        }
    }
}
