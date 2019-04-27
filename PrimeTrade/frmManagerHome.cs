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


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = treeView1.SelectedNode.FullPath;
            string window = treeView1.SelectedNode.Name;

            lblstatus.Text = path;

            if (window == "Node6")
            {
                frmManagerStockBasicData form = new frmManagerStockBasicData();
                form.MdiParent = this;
                form.Show();
            }
            else if (window == "Node7")
            {
                frmManagerStockManagement form = new frmManagerStockManagement("BRAND");
                form.MdiParent = this;
                form.Show();
            }
            else if (window == "Node8")
            {
                frmManagerViewStock form = new frmManagerViewStock();
                form.MdiParent = this;
                form.Show();
            }
            else if (window == "Node9")
            {
                frmManagerManageArea form = new frmManagerManageArea();
                form.MdiParent = this;
                form.Show();
            }
            else if (window == "Node10")
            {
                frmManagerDistributerArea form = new frmManagerDistributerArea();
                form.MdiParent = this;
                form.Show();
            }
            else if (window == "Node11")
            {
                frmManagerViewAllAreaDistRecords form = new frmManagerViewAllAreaDistRecords();
                form.MdiParent = this;
                form.Show();
            }
            else if (window == "Node12")
            {
                frmManagerPromotion form = new frmManagerPromotion();
                form.MdiParent = this;
                form.Show();
            }
            else if (window == "Node13")
            {
                frmManagerActivePromo form = new frmManagerActivePromo();
                form.MdiParent = this;
                form.Show();
            }
            else if (window == "Node14")
            {
                frmManagerViewAllPromotion form = new frmManagerViewAllPromotion();
                form.MdiParent = this;
                form.Show();
            }
            else if (window == "Node15")
            {
                frmPromotionsToDistributers form = new frmPromotionsToDistributers();
                form.MdiParent = this;
                form.Show();
            }
            else if (window == "Node16")
            {
                ManagerViewPromotionByDistributers form = new ManagerViewPromotionByDistributers();
                form.MdiParent = this;
                form.Show();
            }
            else if (window == "Node17")
            {
                frmManagerViewPromotionByState form = new frmManagerViewPromotionByState();
                form.MdiParent = this;
                form.Show();
            }
            else if (window == "Node18")
            {
                frmManagerViewStock form = new frmManagerViewStock();
                form.MdiParent = this;
                form.Show();
            }
            else if (window == "Node19")
            {
                frmManagerViewAllAreaDistRecords form = new frmManagerViewAllAreaDistRecords();
                form.MdiParent = this;
                form.Show();
            }
            else if (window == "Node20")
            {
                frmManagerViewAllPromotion form = new frmManagerViewAllPromotion();
                form.MdiParent = this;
                form.Show();
            }
            else if (window == "Node21")
            {
                ManagerViewPromotionByDistributers form = new ManagerViewPromotionByDistributers();
                form.MdiParent = this;
                form.Show();
            }
            else if (window == "Node22")
            {
                frmManagerViewPromotionByState form = new frmManagerViewPromotionByState();
                form.MdiParent = this;
                form.Show();
            }
            else if (window == "nodedpro1")
            { 
                frmManagerViewDistributersByPromotion form = new frmManagerViewDistributersByPromotion();
                form.MdiParent = this;
                form.Show();
            }
            else if (window == "nodedpro2")
            {
                frmManagerViewDistributersByPromotion form = new frmManagerViewDistributersByPromotion();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnSearchTeacher_Click(object sender, EventArgs e)
        {
            ManagerViewPromotionByDistributers form = new ManagerViewPromotionByDistributers();
            form.MdiParent = this;
            form.Show();
        }
    }
}
