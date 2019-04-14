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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockManagementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promotionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promotionPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activePromotionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllPromotionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignPromitonToDistributionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.assignAreasToDistributersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.stockManagementToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.areaToolStripMenuItem,
            this.promotionToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(130, 60);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1076, 24);
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
            this.reconnectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reconnectToolStripMenuItem.Text = "Reconnect";
            this.reconnectToolStripMenuItem.Click += new System.EventHandler(this.reconnectToolStripMenuItem_Click);
            // 
            // updateSystemToolStripMenuItem
            // 
            this.updateSystemToolStripMenuItem.Name = "updateSystemToolStripMenuItem";
            this.updateSystemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateSystemToolStripMenuItem.Text = "Update system";
            this.updateSystemToolStripMenuItem.Click += new System.EventHandler(this.updateSystemToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // stockManagementToolStripMenuItem
            // 
            this.stockManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem});
            this.stockManagementToolStripMenuItem.Name = "stockManagementToolStripMenuItem";
            this.stockManagementToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.stockManagementToolStripMenuItem.Text = "Basic Data";
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.sToolStripMenuItem.Text = "Stock Basic Data";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockManagementToolStripMenuItem1,
            this.viewStockToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // stockManagementToolStripMenuItem1
            // 
            this.stockManagementToolStripMenuItem1.Name = "stockManagementToolStripMenuItem1";
            this.stockManagementToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.stockManagementToolStripMenuItem1.Text = "Stock Management";
            this.stockManagementToolStripMenuItem1.Click += new System.EventHandler(this.stockManagementToolStripMenuItem1_Click);
            // 
            // viewStockToolStripMenuItem
            // 
            this.viewStockToolStripMenuItem.Name = "viewStockToolStripMenuItem";
            this.viewStockToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.viewStockToolStripMenuItem.Text = "View Stock";
            this.viewStockToolStripMenuItem.Click += new System.EventHandler(this.viewStockToolStripMenuItem_Click);
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageAreaToolStripMenuItem,
            this.assignAreasToDistributersToolStripMenuItem});
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.areaToolStripMenuItem.Text = "Area";
            // 
            // manageAreaToolStripMenuItem
            // 
            this.manageAreaToolStripMenuItem.Name = "manageAreaToolStripMenuItem";
            this.manageAreaToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.manageAreaToolStripMenuItem.Text = "Manage Area";
            this.manageAreaToolStripMenuItem.Click += new System.EventHandler(this.manageAreaToolStripMenuItem_Click);
            // 
            // promotionToolStripMenuItem
            // 
            this.promotionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promotionPlanToolStripMenuItem,
            this.activePromotionToolStripMenuItem,
            this.viewAllPromotionsToolStripMenuItem,
            this.asignPromitonToDistributionToolStripMenuItem});
            this.promotionToolStripMenuItem.Name = "promotionToolStripMenuItem";
            this.promotionToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.promotionToolStripMenuItem.Text = "Promotion";
            // 
            // promotionPlanToolStripMenuItem
            // 
            this.promotionPlanToolStripMenuItem.Name = "promotionPlanToolStripMenuItem";
            this.promotionPlanToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.promotionPlanToolStripMenuItem.Text = "Promotion Plan";
            this.promotionPlanToolStripMenuItem.Click += new System.EventHandler(this.promotionPlanToolStripMenuItem_Click);
            // 
            // activePromotionToolStripMenuItem
            // 
            this.activePromotionToolStripMenuItem.Name = "activePromotionToolStripMenuItem";
            this.activePromotionToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.activePromotionToolStripMenuItem.Text = "Active Promotion";
            this.activePromotionToolStripMenuItem.Click += new System.EventHandler(this.activePromotionToolStripMenuItem_Click);
            // 
            // viewAllPromotionsToolStripMenuItem
            // 
            this.viewAllPromotionsToolStripMenuItem.Name = "viewAllPromotionsToolStripMenuItem";
            this.viewAllPromotionsToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.viewAllPromotionsToolStripMenuItem.Text = "View all Promotions";
            this.viewAllPromotionsToolStripMenuItem.Click += new System.EventHandler(this.viewAllPromotionsToolStripMenuItem_Click);
            // 
            // asignPromitonToDistributionToolStripMenuItem
            // 
            this.asignPromitonToDistributionToolStripMenuItem.Name = "asignPromitonToDistributionToolStripMenuItem";
            this.asignPromitonToDistributionToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.asignPromitonToDistributionToolStripMenuItem.Text = "Asign Promiton to Distribution";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(130, 619);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1076, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(15, 86);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(94, 93);
            this.metroTile1.TabIndex = 4;
            this.metroTile1.Text = "Stock";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(15, 195);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(94, 93);
            this.metroTile2.TabIndex = 5;
            this.metroTile2.Text = "Basic Data";
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(15, 304);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(94, 93);
            this.metroTile3.TabIndex = 6;
            this.metroTile3.Text = "View Stock";
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(15, 415);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(94, 93);
            this.metroTile4.TabIndex = 7;
            this.metroTile4.Text = "metroTile4";
            this.metroTile4.UseSelectable = true;
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(15, 524);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(94, 93);
            this.metroTile5.TabIndex = 8;
            this.metroTile5.Text = "metroTile5";
            this.metroTile5.UseSelectable = true;
            // 
            // assignAreasToDistributersToolStripMenuItem
            // 
            this.assignAreasToDistributersToolStripMenuItem.Name = "assignAreasToDistributersToolStripMenuItem";
            this.assignAreasToDistributersToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.assignAreasToDistributersToolStripMenuItem.Text = "Assign Areas to Distributers";
            this.assignAreasToDistributersToolStripMenuItem.Click += new System.EventHandler(this.assignAreasToDistributersToolStripMenuItem_Click);
            // 
            // frmManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 661);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmManagerHome";
            this.Padding = new System.Windows.Forms.Padding(130, 60, 20, 20);
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
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile5;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockManagementToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promotionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promotionPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activePromotionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignPromitonToDistributionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllPromotionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignAreasToDistributersToolStripMenuItem;
    }
}



