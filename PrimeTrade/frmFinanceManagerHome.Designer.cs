namespace PrimeTrade
{
    partial class frmFinanceManagerHome
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
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockBasicDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promotionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.aprovePromotionStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.promotionToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(160, 60);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1072, 24);
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
            this.reconnectToolStripMenuItem.Text = "Reconnect ";
            this.reconnectToolStripMenuItem.Click += new System.EventHandler(this.reconnectToolStripMenuItem_Click);
            // 
            // updateSystemToolStripMenuItem
            // 
            this.updateSystemToolStripMenuItem.Name = "updateSystemToolStripMenuItem";
            this.updateSystemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateSystemToolStripMenuItem.Text = "Update System";
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
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageStockToolStripMenuItem,
            this.viewStockToolStripMenuItem,
            this.stockBasicDataToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // manageStockToolStripMenuItem
            // 
            this.manageStockToolStripMenuItem.Name = "manageStockToolStripMenuItem";
            this.manageStockToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.manageStockToolStripMenuItem.Text = "Manage Stock";
            this.manageStockToolStripMenuItem.Click += new System.EventHandler(this.manageStockToolStripMenuItem_Click);
            // 
            // viewStockToolStripMenuItem
            // 
            this.viewStockToolStripMenuItem.Name = "viewStockToolStripMenuItem";
            this.viewStockToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.viewStockToolStripMenuItem.Text = "View Stock";
            this.viewStockToolStripMenuItem.Click += new System.EventHandler(this.viewStockToolStripMenuItem_Click);
            // 
            // stockBasicDataToolStripMenuItem
            // 
            this.stockBasicDataToolStripMenuItem.Name = "stockBasicDataToolStripMenuItem";
            this.stockBasicDataToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.stockBasicDataToolStripMenuItem.Text = "Stock Basic Data";
            this.stockBasicDataToolStripMenuItem.Click += new System.EventHandler(this.stockBasicDataToolStripMenuItem_Click);
            // 
            // promotionToolStripMenuItem
            // 
            this.promotionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pToolStripMenuItem,
            this.activeToolStripMenuItem,
            this.aprovePromotionStockToolStripMenuItem});
            this.promotionToolStripMenuItem.Name = "promotionToolStripMenuItem";
            this.promotionToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.promotionToolStripMenuItem.Text = "Promotion";
            // 
            // pToolStripMenuItem
            // 
            this.pToolStripMenuItem.Name = "pToolStripMenuItem";
            this.pToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.pToolStripMenuItem.Text = "View Promotion";
            // 
            // activeToolStripMenuItem
            // 
            this.activeToolStripMenuItem.Name = "activeToolStripMenuItem";
            this.activeToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.activeToolStripMenuItem.Text = "Active ";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(160, 565);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1072, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // aprovePromotionStockToolStripMenuItem
            // 
            this.aprovePromotionStockToolStripMenuItem.Name = "aprovePromotionStockToolStripMenuItem";
            this.aprovePromotionStockToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.aprovePromotionStockToolStripMenuItem.Text = "Approve Promotion Stock";
            this.aprovePromotionStockToolStripMenuItem.Click += new System.EventHandler(this.aprovePromotionStockToolStripMenuItem_Click);
            // 
            // frmFinanceManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 607);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmFinanceManagerHome";
            this.Padding = new System.Windows.Forms.Padding(160, 60, 20, 20);
            this.Text = "PRIME TRADE : FINANCE MANAGER";
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
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockBasicDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promotionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aprovePromotionStockToolStripMenuItem;
    }
}



