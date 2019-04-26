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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Approve Promotions");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("My Promotion Tasks");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Promotions", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Supply Goods");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Distribution", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("View my Sales");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("View my Sales Proress");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("My Sales", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDistibuterHome));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.lblpath = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(20, 84);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Approve Promotions";
            treeNode2.Name = "Node2";
            treeNode2.Text = "My Promotion Tasks";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Promotions";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Supply Goods";
            treeNode5.Name = "Node3";
            treeNode5.Text = "Distribution";
            treeNode6.Name = "Node6";
            treeNode6.Text = "View my Sales";
            treeNode7.Name = "Node7";
            treeNode7.Text = "View my Sales Proress";
            treeNode8.Name = "Node5";
            treeNode8.Text = "My Sales";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode5,
            treeNode8});
            this.treeView1.SelectedImageIndex = 1;
            this.treeView1.Size = new System.Drawing.Size(211, 682);
            this.treeView1.TabIndex = 4;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "folder (1).png");
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(20, 60);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1437, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.Location = new System.Drawing.Point(28, 65);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(0, 13);
            this.lblpath.TabIndex = 6;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(635, 351);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(0, 13);
            this.lblstatus.TabIndex = 7;
            this.lblstatus.Visible = false;
            // 
            // FrmDistibuterHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 786);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.lblpath);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmDistibuterHome";
            this.Text = "PRIMETRADE : Distributers";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Label lblpath;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.ImageList imageList1;
    }
}



