namespace PrimeTrade
{
    partial class frmManagerHome
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
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Stock Basic Data");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Basic Data", new System.Windows.Forms.TreeNode[] {
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Stock Management");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("View Stock");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Stock", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Manage Area");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Assign Areas to Distributers");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("View Areas by DIstributers");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Area", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode29,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Promotion Plan");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Active Promotion");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("View all Promotions");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Assign Promotion to Distributers");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("View all Promotions by Distributers");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("View Promotion By State");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Promotion", new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode37});
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("View Stock");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("View Area by Distributers");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("View all Promotions");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("View all Promotion by Distributers");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("View all Promotion by State");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("View", new System.Windows.Forms.TreeNode[] {
            treeNode39,
            treeNode40,
            treeNode41,
            treeNode42,
            treeNode43});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagerHome));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(20, 60);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1186, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reconnectToolStripMenuItem,
            this.updateSystemToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // reconnectToolStripMenuItem
            // 
            this.reconnectToolStripMenuItem.Name = "reconnectToolStripMenuItem";
            this.reconnectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reconnectToolStripMenuItem.Text = "Reconnect";
            this.reconnectToolStripMenuItem.Click += new System.EventHandler(this.reconnectToolStripMenuItem_Click);
            // 
            // updateSystemToolStripMenuItem
            // 
            this.updateSystemToolStripMenuItem.Name = "updateSystemToolStripMenuItem";
            this.updateSystemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateSystemToolStripMenuItem.Text = "Update system";
            this.updateSystemToolStripMenuItem.Click += new System.EventHandler(this.updateSystemToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblstatus});
            this.statusStrip.Location = new System.Drawing.Point(20, 619);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1186, 22);
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
            this.treeView1.ImageIndex = 1;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(20, 84);
            this.treeView1.Name = "treeView1";
            treeNode23.Name = "Node6";
            treeNode23.Text = "Stock Basic Data";
            treeNode24.Name = "Node1";
            treeNode24.Text = "Basic Data";
            treeNode25.Name = "Node7";
            treeNode25.Text = "Stock Management";
            treeNode26.Name = "Node8";
            treeNode26.Text = "View Stock";
            treeNode27.Name = "Node2";
            treeNode27.Text = "Stock";
            treeNode28.Name = "Node9";
            treeNode28.Text = "Manage Area";
            treeNode29.Name = "Node10";
            treeNode29.Text = "Assign Areas to Distributers";
            treeNode30.Name = "Node11";
            treeNode30.Text = "View Areas by DIstributers";
            treeNode31.Name = "Node3";
            treeNode31.Text = "Area";
            treeNode32.Name = "Node12";
            treeNode32.Text = "Promotion Plan";
            treeNode33.Name = "Node13";
            treeNode33.Text = "Active Promotion";
            treeNode34.Name = "Node14";
            treeNode34.Text = "View all Promotions";
            treeNode35.Name = "Node15";
            treeNode35.Text = "Assign Promotion to Distributers";
            treeNode36.Name = "Node16";
            treeNode36.Text = "View all Promotions by Distributers";
            treeNode37.Name = "Node17";
            treeNode37.Text = "View Promotion By State";
            treeNode38.Name = "Node4";
            treeNode38.Text = "Promotion";
            treeNode39.Name = "Node18";
            treeNode39.Text = "View Stock";
            treeNode40.Name = "Node19";
            treeNode40.Text = "View Area by Distributers";
            treeNode41.Name = "Node20";
            treeNode41.Text = "View all Promotions";
            treeNode42.Name = "Node21";
            treeNode42.Text = "View all Promotion by Distributers";
            treeNode43.Name = "Node22";
            treeNode43.Text = "View all Promotion by State";
            treeNode44.Name = "Node5";
            treeNode44.Text = "View";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode27,
            treeNode31,
            treeNode38,
            treeNode44});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(226, 535);
            this.treeView1.TabIndex = 10;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder (1).png");
            this.imageList1.Images.SetKeyName(1, "folder.png");
            // 
            // frmManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 661);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmManagerHome";
            this.Text = "PRIME TRADE : BRAND MANAGER";
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
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}



