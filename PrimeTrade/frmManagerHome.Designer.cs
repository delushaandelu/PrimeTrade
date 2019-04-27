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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Stock Basic Data");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Basic Data", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Stock Management");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("View Stock");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Stock", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Manage Area");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Assign Areas to Distributers");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("View Areas by DIstributers");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Area", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Promotion Plan");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Active Promotion");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("View all Promotions");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Assign Promotion to Distributers");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("View all Promotions by Distributers");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("View Promotion By State");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("View all Distributers by Promotions");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Promotion", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("View Stock");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("View Area by Distributers");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("View all Promotions");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("View all Promotion by Distributers");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("View all Promotion by State");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("View all Distributers by Promotions");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("View", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23});
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnViewAllAssignedClass = new System.Windows.Forms.Button();
            this.btnSearchTeacher = new System.Windows.Forms.Button();
            this.btnManageTeacher = new System.Windows.Forms.Button();
            this.btnTeacherAssignClass = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(20, 90);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1211, 24);
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
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblstatus});
            this.statusStrip.Location = new System.Drawing.Point(20, 927);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1211, 22);
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
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node6";
            treeNode1.Text = "Stock Basic Data";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Basic Data";
            treeNode3.Name = "Node7";
            treeNode3.Text = "Stock Management";
            treeNode4.Name = "Node8";
            treeNode4.Text = "View Stock";
            treeNode5.Name = "Node2";
            treeNode5.Text = "Stock";
            treeNode6.Name = "Node9";
            treeNode6.Text = "Manage Area";
            treeNode7.Name = "Node10";
            treeNode7.Text = "Assign Areas to Distributers";
            treeNode8.Name = "Node11";
            treeNode8.Text = "View Areas by DIstributers";
            treeNode9.Name = "Node3";
            treeNode9.Text = "Area";
            treeNode10.Name = "Node12";
            treeNode10.Text = "Promotion Plan";
            treeNode11.Name = "Node13";
            treeNode11.Text = "Active Promotion";
            treeNode12.Name = "Node14";
            treeNode12.Text = "View all Promotions";
            treeNode13.Name = "Node15";
            treeNode13.Text = "Assign Promotion to Distributers";
            treeNode14.Name = "Node16";
            treeNode14.Text = "View all Promotions by Distributers";
            treeNode15.Name = "Node17";
            treeNode15.Text = "View Promotion By State";
            treeNode16.Name = "nodedpro1";
            treeNode16.Text = "View all Distributers by Promotions";
            treeNode17.Name = "Node4";
            treeNode17.Text = "Promotion";
            treeNode18.Name = "Node18";
            treeNode18.Text = "View Stock";
            treeNode19.Name = "Node19";
            treeNode19.Text = "View Area by Distributers";
            treeNode20.Name = "Node20";
            treeNode20.Text = "View all Promotions";
            treeNode21.Name = "Node21";
            treeNode21.Text = "View all Promotion by Distributers";
            treeNode22.Name = "Node22";
            treeNode22.Text = "View all Promotion by State";
            treeNode23.Name = "nodedpro2";
            treeNode23.Text = "View all Distributers by Promotions";
            treeNode24.Name = "Node5";
            treeNode24.Text = "View";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode5,
            treeNode9,
            treeNode17,
            treeNode24});
            this.treeView1.SelectedImageKey = "tab.png";
            this.treeView1.Size = new System.Drawing.Size(223, 781);
            this.treeView1.TabIndex = 10;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "image.png");
            this.imageList1.Images.SetKeyName(1, "tab.png");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(20, 114);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(237, 813);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.btnViewAllAssignedClass);
            this.tabPage1.Controls.Add(this.btnSearchTeacher);
            this.tabPage1.Controls.Add(this.btnManageTeacher);
            this.tabPage1.Controls.Add(this.btnTeacherAssignClass);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(229, 787);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Shortcuts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(116, 750);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 123);
            this.button5.TabIndex = 35;
            this.button5.Text = "View Classes by Teacher ";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.Location = new System.Drawing.Point(6, 626);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 123);
            this.button6.TabIndex = 32;
            this.button6.Text = "Search Teacher";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.Location = new System.Drawing.Point(116, 626);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(109, 123);
            this.button7.TabIndex = 33;
            this.button7.Text = "Manage Teacher";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.Location = new System.Drawing.Point(6, 750);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(109, 123);
            this.button8.TabIndex = 34;
            this.button8.Text = "Assign Class for Teacher";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.Location = new System.Drawing.Point(116, 502);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(109, 123);
            this.button9.TabIndex = 31;
            this.button9.Text = "View Classes by Teacher ";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button10.Location = new System.Drawing.Point(6, 502);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(109, 123);
            this.button10.TabIndex = 30;
            this.button10.Text = "Assign Class for Teacher";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(116, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 123);
            this.button1.TabIndex = 29;
            this.button1.Text = "View Classes by Teacher ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(6, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 123);
            this.button2.TabIndex = 26;
            this.button2.Text = "Search Teacher";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(116, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 123);
            this.button3.TabIndex = 27;
            this.button3.Text = "Manage Teacher";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(6, 378);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 123);
            this.button4.TabIndex = 28;
            this.button4.Text = "Assign Class for Teacher";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnViewAllAssignedClass
            // 
            this.btnViewAllAssignedClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnViewAllAssignedClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAllAssignedClass.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllAssignedClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewAllAssignedClass.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewAllAssignedClass.Location = new System.Drawing.Point(116, 130);
            this.btnViewAllAssignedClass.Name = "btnViewAllAssignedClass";
            this.btnViewAllAssignedClass.Size = new System.Drawing.Size(109, 123);
            this.btnViewAllAssignedClass.TabIndex = 25;
            this.btnViewAllAssignedClass.Text = "View Classes by Teacher ";
            this.btnViewAllAssignedClass.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewAllAssignedClass.UseVisualStyleBackColor = false;
            // 
            // btnSearchTeacher
            // 
            this.btnSearchTeacher.BackColor = System.Drawing.Color.DarkViolet;
            this.btnSearchTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchTeacher.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTeacher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchTeacher.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchTeacher.Location = new System.Drawing.Point(6, 6);
            this.btnSearchTeacher.Name = "btnSearchTeacher";
            this.btnSearchTeacher.Size = new System.Drawing.Size(109, 123);
            this.btnSearchTeacher.TabIndex = 22;
            this.btnSearchTeacher.Text = "Search Teacher";
            this.btnSearchTeacher.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearchTeacher.UseVisualStyleBackColor = false;
            this.btnSearchTeacher.Click += new System.EventHandler(this.btnSearchTeacher_Click);
            // 
            // btnManageTeacher
            // 
            this.btnManageTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnManageTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageTeacher.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageTeacher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManageTeacher.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnManageTeacher.Location = new System.Drawing.Point(116, 6);
            this.btnManageTeacher.Name = "btnManageTeacher";
            this.btnManageTeacher.Size = new System.Drawing.Size(109, 123);
            this.btnManageTeacher.TabIndex = 23;
            this.btnManageTeacher.Text = "Manage Teacher";
            this.btnManageTeacher.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManageTeacher.UseVisualStyleBackColor = false;
            // 
            // btnTeacherAssignClass
            // 
            this.btnTeacherAssignClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnTeacherAssignClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacherAssignClass.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherAssignClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTeacherAssignClass.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTeacherAssignClass.Location = new System.Drawing.Point(6, 130);
            this.btnTeacherAssignClass.Name = "btnTeacherAssignClass";
            this.btnTeacherAssignClass.Size = new System.Drawing.Size(109, 123);
            this.btnTeacherAssignClass.TabIndex = 24;
            this.btnTeacherAssignClass.Text = "Assign Class for Teacher";
            this.btnTeacherAssignClass.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTeacherAssignClass.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.treeView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(229, 787);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Navigator";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Empowering Business Process";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "PRIME TRADE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // frmManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 969);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmManagerHome";
            this.Padding = new System.Windows.Forms.Padding(20, 90, 20, 20);
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnViewAllAssignedClass;
        private System.Windows.Forms.Button btnSearchTeacher;
        private System.Windows.Forms.Button btnManageTeacher;
        private System.Windows.Forms.Button btnTeacherAssignClass;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}



