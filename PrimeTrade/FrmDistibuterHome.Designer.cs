namespace PrimeTrade
{
    partial class FrmDistibuterHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Open");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Close");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("File", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Fix");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Edit", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("View");
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.newRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approvedPromotionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myPromotionTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distributionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliyGoodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mySalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMySalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMySalesProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRequestToolStripMenuItem,
            this.distributionToolStripMenuItem,
            this.mySalesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(20, 60);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1231, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // newRequestToolStripMenuItem
            // 
            this.newRequestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.approvedPromotionsToolStripMenuItem,
            this.myPromotionTasksToolStripMenuItem});
            this.newRequestToolStripMenuItem.Name = "newRequestToolStripMenuItem";
            this.newRequestToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.newRequestToolStripMenuItem.Text = "Promotions";
            // 
            // approvedPromotionsToolStripMenuItem
            // 
            this.approvedPromotionsToolStripMenuItem.Name = "approvedPromotionsToolStripMenuItem";
            this.approvedPromotionsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.approvedPromotionsToolStripMenuItem.Text = "Approved Promotions";
            this.approvedPromotionsToolStripMenuItem.Click += new System.EventHandler(this.approvedPromotionsToolStripMenuItem_Click);
            // 
            // myPromotionTasksToolStripMenuItem
            // 
            this.myPromotionTasksToolStripMenuItem.Name = "myPromotionTasksToolStripMenuItem";
            this.myPromotionTasksToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.myPromotionTasksToolStripMenuItem.Text = "My Promotion Tasks";
            this.myPromotionTasksToolStripMenuItem.Click += new System.EventHandler(this.myPromotionTasksToolStripMenuItem_Click);
            // 
            // distributionToolStripMenuItem
            // 
            this.distributionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suppliyGoodsToolStripMenuItem});
            this.distributionToolStripMenuItem.Name = "distributionToolStripMenuItem";
            this.distributionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.distributionToolStripMenuItem.Text = "Distribution";
            // 
            // suppliyGoodsToolStripMenuItem
            // 
            this.suppliyGoodsToolStripMenuItem.Name = "suppliyGoodsToolStripMenuItem";
            this.suppliyGoodsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.suppliyGoodsToolStripMenuItem.Text = "Supply Goods";
            this.suppliyGoodsToolStripMenuItem.Click += new System.EventHandler(this.suppliyGoodsToolStripMenuItem_Click);
            // 
            // mySalesToolStripMenuItem
            // 
            this.mySalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMySalesToolStripMenuItem,
            this.viewMySalesProgressToolStripMenuItem});
            this.mySalesToolStripMenuItem.Name = "mySalesToolStripMenuItem";
            this.mySalesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.mySalesToolStripMenuItem.Text = "My Sales";
            // 
            // viewMySalesToolStripMenuItem
            // 
            this.viewMySalesToolStripMenuItem.Name = "viewMySalesToolStripMenuItem";
            this.viewMySalesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.viewMySalesToolStripMenuItem.Text = "View My Sales";
            // 
            // viewMySalesProgressToolStripMenuItem
            // 
            this.viewMySalesProgressToolStripMenuItem.Name = "viewMySalesProgressToolStripMenuItem";
            this.viewMySalesProgressToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.viewMySalesProgressToolStripMenuItem.Text = "View My Sales Progress";
            this.viewMySalesProgressToolStripMenuItem.Click += new System.EventHandler(this.viewMySalesProgressToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblstatus});
            this.statusStrip.Location = new System.Drawing.Point(20, 673);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1231, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // lblstatus
            // 
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(39, 17);
            this.lblstatus.Text = "Status";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(20, 84);
            this.treeView1.Name = "treeView1";
            treeNode1.ForeColor = System.Drawing.Color.Black;
            treeNode1.Name = "Node1";
            treeNode1.Text = "Open";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Close";
            treeNode3.Name = "Node0";
            treeNode3.Text = "File";
            treeNode4.Name = "Node5";
            treeNode4.Text = "Fix";
            treeNode5.Name = "Node4";
            treeNode5.Text = "Edit";
            treeNode6.Name = "Node6";
            treeNode6.Text = "View";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode5,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(211, 589);
            this.treeView1.TabIndex = 4;
            // 
            // FrmDistibuterHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 715);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmDistibuterHome";
            this.Text = "PRIMETRADE : Distributers";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblstatus;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem newRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approvedPromotionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distributionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliyGoodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myPromotionTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mySalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMySalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMySalesProgressToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
    }
}



