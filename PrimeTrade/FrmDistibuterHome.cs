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
    public partial class FrmDistibuterHome : MetroForm
    {
        public FrmDistibuterHome(string userid)
        {
            InitializeComponent();
            lblstatus.Text = userid;
        }

        private void approvedPromotionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDistributerNewPromotins form = new FrmDistributerNewPromotins(lblstatus.Text);
            form.MdiParent = this;
            form.Show();
        }

        private void myPromotionTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDistributerMyPromotionTasks form = new frmDistributerMyPromotionTasks(lblstatus.Text);
            form.MdiParent = this;
            form.Show();
        }

        private void suppliyGoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDistributersSales form = new frmDistributersSales(lblstatus.Text);
            form.MdiParent = this;
            form.Show();
        }

        private void viewMySalesProgressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDistributersMySalesProgress form = new frmDistributersMySalesProgress(lblstatus.Text);
            form.MdiParent = this;
            form.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = treeView1.SelectedNode.FullPath;
            string window = treeView1.SelectedNode.Name;

            if (window == "Node1")
            {
                lblpath.Text = path;
                FrmDistributerNewPromotins form = new FrmDistributerNewPromotins(lblstatus.Text);
                form.MdiParent = this;
                form.Show();
            }
            else if (window == "Node2")
            {
                lblpath.Text = path;
                frmDistributerMyPromotionTasks form = new frmDistributerMyPromotionTasks(lblstatus.Text);
                form.MdiParent = this;
                form.Show();
            }
            else if (window == "Node4")
            {
                lblpath.Text = path;
                frmDistributersSales form = new frmDistributersSales(lblstatus.Text);
                form.MdiParent = this;
                form.Show();
            }
            else if (window == "Node6")
            {
                lblpath.Text = path;
                frmDistributerMySalesData from = new frmDistributerMySalesData(lblstatus.Text);
                from.MdiParent = this;
                from.Show();
            }
            else if (window == "Node7")
            {
                lblpath.Text = path;
                frmDistributersMySalesProgress form = new frmDistributersMySalesProgress(lblstatus.Text);
                form.MdiParent = this;
                form.Show();
            }
        }
    }
}
