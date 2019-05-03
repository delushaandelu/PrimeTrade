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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDistibuterHome));
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
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("View Weekly Split");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("My Sales", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Request");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Request Stock", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.lblpath = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblloginuser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnViewAllAssignedClass = new System.Windows.Forms.Button();
            this.btnSearchTeacher = new System.Windows.Forms.Button();
            this.btnManageTeacher = new System.Windows.Forms.Button();
            this.btnTeacherAssignClass = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip.Location = new System.Drawing.Point(20, 90);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1386, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.Location = new System.Drawing.Point(28, 95);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(0, 13);
            this.lblpath.TabIndex = 6;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(635, 381);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(0, 13);
            this.lblstatus.TabIndex = 7;
            this.lblstatus.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Distributor Profile";
            // 
            // lblloginuser
            // 
            this.lblloginuser.AutoSize = true;
            this.lblloginuser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloginuser.Location = new System.Drawing.Point(221, 69);
            this.lblloginuser.Name = "lblloginuser";
            this.lblloginuser.Size = new System.Drawing.Size(0, 16);
            this.lblloginuser.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Login User: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.treeView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(224, 623);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tree View";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
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
            treeNode8.Name = "Node120";
            treeNode8.Text = "View Weekly Split";
            treeNode9.Name = "Node5";
            treeNode9.Text = "My Sales";
            treeNode10.Name = "Node12";
            treeNode10.Text = "Request";
            treeNode11.Name = "Node0";
            treeNode11.Text = "Request Stock";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode5,
            treeNode9,
            treeNode11});
            this.treeView1.SelectedImageIndex = 1;
            this.treeView1.Size = new System.Drawing.Size(218, 617);
            this.treeView1.TabIndex = 5;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.btnViewAllAssignedClass);
            this.tabPage1.Controls.Add(this.btnSearchTeacher);
            this.tabPage1.Controls.Add(this.btnManageTeacher);
            this.tabPage1.Controls.Add(this.btnTeacherAssignClass);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(224, 623);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Shortcuts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::PrimeTrade.Properties.Resources.sale__1_;
            this.button2.Location = new System.Drawing.Point(3, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 123);
            this.button2.TabIndex = 32;
            this.button2.Text = "Sales Progress";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = global::PrimeTrade.Properties.Resources.application;
            this.button3.Location = new System.Drawing.Point(113, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 123);
            this.button3.TabIndex = 33;
            this.button3.Text = "Request Stock";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnViewAllAssignedClass
            // 
            this.btnViewAllAssignedClass.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewAllAssignedClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAllAssignedClass.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllAssignedClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewAllAssignedClass.Image = global::PrimeTrade.Properties.Resources.result1;
            this.btnViewAllAssignedClass.Location = new System.Drawing.Point(113, 125);
            this.btnViewAllAssignedClass.Name = "btnViewAllAssignedClass";
            this.btnViewAllAssignedClass.Size = new System.Drawing.Size(109, 123);
            this.btnViewAllAssignedClass.TabIndex = 31;
            this.btnViewAllAssignedClass.Text = "View My Sales";
            this.btnViewAllAssignedClass.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewAllAssignedClass.UseVisualStyleBackColor = false;
            this.btnViewAllAssignedClass.Click += new System.EventHandler(this.btnViewAllAssignedClass_Click);
            // 
            // btnSearchTeacher
            // 
            this.btnSearchTeacher.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchTeacher.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTeacher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchTeacher.Image = global::PrimeTrade.Properties.Resources.product;
            this.btnSearchTeacher.Location = new System.Drawing.Point(3, 1);
            this.btnSearchTeacher.Name = "btnSearchTeacher";
            this.btnSearchTeacher.Size = new System.Drawing.Size(109, 123);
            this.btnSearchTeacher.TabIndex = 28;
            this.btnSearchTeacher.Text = "Approve Promo";
            this.btnSearchTeacher.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearchTeacher.UseVisualStyleBackColor = false;
            this.btnSearchTeacher.Click += new System.EventHandler(this.btnSearchTeacher_Click);
            // 
            // btnManageTeacher
            // 
            this.btnManageTeacher.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnManageTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageTeacher.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageTeacher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManageTeacher.Image = global::PrimeTrade.Properties.Resources.vision;
            this.btnManageTeacher.Location = new System.Drawing.Point(113, 1);
            this.btnManageTeacher.Name = "btnManageTeacher";
            this.btnManageTeacher.Size = new System.Drawing.Size(109, 123);
            this.btnManageTeacher.TabIndex = 29;
            this.btnManageTeacher.Text = "My Promo Task";
            this.btnManageTeacher.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManageTeacher.UseVisualStyleBackColor = false;
            this.btnManageTeacher.Click += new System.EventHandler(this.btnManageTeacher_Click);
            // 
            // btnTeacherAssignClass
            // 
            this.btnTeacherAssignClass.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTeacherAssignClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacherAssignClass.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherAssignClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTeacherAssignClass.Image = global::PrimeTrade.Properties.Resources.plus_sign_in_a_black_circle1;
            this.btnTeacherAssignClass.Location = new System.Drawing.Point(3, 125);
            this.btnTeacherAssignClass.Name = "btnTeacherAssignClass";
            this.btnTeacherAssignClass.Size = new System.Drawing.Size(109, 123);
            this.btnTeacherAssignClass.TabIndex = 30;
            this.btnTeacherAssignClass.Text = "New Sales";
            this.btnTeacherAssignClass.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTeacherAssignClass.UseVisualStyleBackColor = false;
            this.btnTeacherAssignClass.Click += new System.EventHandler(this.btnTeacherAssignClass_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(20, 114);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(232, 649);
            this.tabControl1.TabIndex = 24;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(121, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 33);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(121, 65);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 32);
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(258, 91);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(107, 23);
            this.metroButton1.TabIndex = 30;
            this.metroButton1.Text = "Show Dashboard";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // FrmDistibuterHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 793);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblloginuser);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.lblpath);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pictureBox3);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmDistibuterHome";
            this.Padding = new System.Windows.Forms.Padding(20, 90, 50, 30);
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDistibuterHome_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Label lblpath;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblloginuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnViewAllAssignedClass;
        private System.Windows.Forms.Button btnSearchTeacher;
        private System.Windows.Forms.Button btnManageTeacher;
        private System.Windows.Forms.Button btnTeacherAssignClass;
        private System.Windows.Forms.TabControl tabControl1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}



