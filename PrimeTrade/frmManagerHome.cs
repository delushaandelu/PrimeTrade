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
using MySql.Data.MySqlClient;
using PrimeTrade.connections;

namespace PrimeTrade
{
    public partial class frmManagerHome : MetroForm
    {
        private int childFormNumber = 0;

        MySqlConnection connect = new MySqlConnection(classConnection.ConnectNow("GoogleCloude"));

        public frmManagerHome()
        {
            InitializeComponent();
           
            frmManagerDashboard form = new frmManagerDashboard();
            form.MdiParent = this;
            form.Show();

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
            else if (window == "Node110")
            {
                FrmManagerViewStockRequest form = new FrmManagerViewStockRequest();
                form.MdiParent = this;
                form.Show();
            }
            else if (window == "Node129")
            {
                frmManagerBestAreaMix form = new frmManagerBestAreaMix();
                form.MdiParent = this;
                form.Show();
            }
            else if (window == "Node130")
            {
                frmManagerPastData form = new frmManagerPastData();
                form.MdiParent = this;
                form.Show();
            }
            else if (window == "Node131") 
            {
                frmManagerWeeklySplit form = new frmManagerWeeklySplit();
                form.MdiParent = this;
                form.Show();
            }
             else if (window == "Node132") 
            {
                frmManagerSystemSuggestion form = new frmManagerSystemSuggestion();
                form.MdiParent = this;
                form.Show();
            }
            else if (window == "Node135") 
            {
                frmManagerRewords form = new frmManagerRewords();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnSearchTeacher_Click(object sender, EventArgs e)
        {
            frmManagerActivePromo form = new frmManagerActivePromo();
            form.MdiParent = this;
            form.Show();
        }

        private void btnManageTeacher_Click(object sender, EventArgs e)
        {
            frmManagerViewAllPromotion form = new frmManagerViewAllPromotion();
            form.MdiParent = this;
            form.Show();
        }

        private void btnTeacherAssignClass_Click(object sender, EventArgs e)
        {
            frmPromotionsToDistributers form = new frmPromotionsToDistributers();
            form.MdiParent = this;
            form.Show();
        }

        private void btnViewAllAssignedClass_Click(object sender, EventArgs e)
        {
            frmManagerViewStock form = new frmManagerViewStock();
            form.MdiParent = this;
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmManagerManageArea form = new frmManagerManageArea();
            form.MdiParent = this;
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmManagerViewDistributersByPromotion form = new frmManagerViewDistributersByPromotion();
            form.MdiParent = this;
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmManagerGenerateReport form = new frmManagerGenerateReport();
            form.MdiParent = this;
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmManagerMap form = new frmManagerMap();
            form.MdiParent = this;
            form.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmManagerPoints form = new frmManagerPoints();
            form.MdiParent = this;
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmManagerViewStock form = new frmManagerViewStock();
            form.MdiParent = this;
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Less Data founded for Generate the Cash Flow","Data Not Enough!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Notification();

            frmManagerNotifications form = new frmManagerNotifications();
            form.MdiParent = this;
            form.Show();
        }

        public void Notification()
        {
            requestStockNotfication(); 
        }

        public void requestStockNotfication()
        {
 
            connect.Open();

            string query = "SELECT `tb_req_stock`.`stock`,`tb_req_stock`.`qty`,`tb_req_stock`.`fordate`, `tb_req_stock`.`status`,`tb_req_stock`.`comment`, `tb_req_stock`.`distid` FROM `base`.`tb_req_stock`;";
            using (var command = new MySqlCommand(query, connect))
            {
                using (var reader = command.ExecuteReader())
                {
                    //Iterate through the rows and add it to the combobox's items
                    while (reader.Read())
                    {
                        string message = "The Distributor '"+ reader.GetString("distid") + "' is Requesting '" + reader.GetString("qty") + "' No of of stock from the stock '"+ reader.GetString("stock") + "' for the date of '"+ reader.GetString("fordate") + "'. Added Comments '"+ reader.GetString("comment") + "'" ;

                        MetroFramework.MetroMessageBox.Show(this, message, "NEW STOCK REQUEST FROM THE DISTRIBUTOR...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                connect.Close(); 
            }



        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frmManagerDashboard form = new frmManagerDashboard();
            form.MdiParent = this;
            form.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
