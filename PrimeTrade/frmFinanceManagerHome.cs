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
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace PrimeTrade
{
    public partial class frmFinanceManagerHome : MetroForm
    {
        private int childFormNumber = 0;

        public frmFinanceManagerHome()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }     

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void manageStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagerStockManagement form = new frmManagerStockManagement("FINANCE");
            form.MdiParent = this;
            form.Show();
        }

        private void viewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagerViewStock form = new frmManagerViewStock();
            form.MdiParent = this;
            form.Show();
        }

        private void stockBasicDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagerStockBasicData form = new frmManagerStockBasicData();
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

        private void receiveNewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aprovePromotionStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFinaceApproveStock form = new frmFinaceApproveStock();
            form.MdiParent = this;
            form.Show();
        }
    }
}
