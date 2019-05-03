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
using MySql.Data.MySqlClient;
using PrimeTrade.connections;

namespace PrimeTrade
{
    public partial class FrmDistibuterHome : MetroForm
    {

        MySqlConnection connect = new MySqlConnection(classConnection.ConnectNow("GoogleCloude"));

        public FrmDistibuterHome(string userid)
        {
            InitializeComponent();
            lblstatus.Text = userid;

            MySqlCommand command = new MySqlCommand();
            connect.Open();
            command.Connection = connect;

            command.CommandText = "get_naem_by_id";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new MySqlParameter("@userid", userid));
            command.Parameters["@userid"].Direction = ParameterDirection.Input;

            command.Parameters.Add(new MySqlParameter("@username", MySqlDbType.VarChar));
            command.Parameters["@username"].Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            lblloginuser.Text = (string)command.Parameters["@username"].Value;

            connect.Close();

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
            else if (window == "NodeNode12")
            {
                lblpath.Text = path;
                frmDistributorReqStock form = new frmDistributorReqStock(lblstatus.Text);
                form.MdiParent = this;
                form.Show();
            }
            else if (window == "Node120")
            {
                lblpath.Text = path;
                frmDistributerWeeklySplit form = new frmDistributerWeeklySplit(lblstatus.Text);
                form.MdiParent = this;
                form.Show();
            }
        }

        private void FrmDistibuterHome_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchTeacher_Click(object sender, EventArgs e)
        {
            FrmDistributerNewPromotins form = new FrmDistributerNewPromotins(lblstatus.Text);
            form.MdiParent = this;
            form.Show();
        }

        private void btnManageTeacher_Click(object sender, EventArgs e)
        {
            frmDistributerMyPromotionTasks form = new frmDistributerMyPromotionTasks(lblstatus.Text);
            form.MdiParent = this;
            form.Show();
        }

        private void btnTeacherAssignClass_Click(object sender, EventArgs e)
        {
            frmDistributersSales form = new frmDistributersSales(lblstatus.Text);
            form.MdiParent = this;
            form.Show();
        }

        private void btnViewAllAssignedClass_Click(object sender, EventArgs e)
        {
            frmDistributerMySalesData from = new frmDistributerMySalesData(lblstatus.Text);
            from.MdiParent = this;
            from.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDistributersMySalesProgress form = new frmDistributersMySalesProgress(lblstatus.Text);
            form.MdiParent = this;
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDistributorReqStock form = new frmDistributorReqStock(lblstatus.Text);
            form.MdiParent = this;
            form.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frmManagerDashboard form = new frmManagerDashboard();
            form.MdiParent = this;
            form.Show();
        }
    }
}
