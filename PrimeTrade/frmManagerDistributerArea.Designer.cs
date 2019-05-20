namespace PrimeTrade
{
    partial class frmManagerDistributerArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagerDistributerArea));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtdistid = new MaterialSkin.Controls.MaterialLabel();
            this.txtdistributer = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtdis = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtareaid = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtareaname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtprov = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeCombinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splashPanel1 = new Syncfusion.Windows.Forms.Tools.SplashPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnaddarea = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnreset = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.contextMenuStrip1.SuspendLayout();
            this.splashPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(27, 129);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(794, 152);
            this.listView1.TabIndex = 49;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Distributer ID";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Address";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Telephone";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Joined Date";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "NIC ";
            this.columnHeader11.Width = 100;
            // 
            // txtdistid
            // 
            this.txtdistid.AutoSize = true;
            this.txtdistid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtdistid.Depth = 0;
            this.txtdistid.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtdistid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtdistid.Location = new System.Drawing.Point(23, 107);
            this.txtdistid.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtdistid.Name = "txtdistid";
            this.txtdistid.Size = new System.Drawing.Size(244, 19);
            this.txtdistid.TabIndex = 50;
            this.txtdistid.Text = "Select a Distrbuter to Assign Areas";
            // 
            // txtdistributer
            // 
            this.txtdistributer.Depth = 0;
            this.txtdistributer.Enabled = false;
            this.txtdistributer.Hint = "";
            this.txtdistributer.Location = new System.Drawing.Point(182, 323);
            this.txtdistributer.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtdistributer.Name = "txtdistributer";
            this.txtdistributer.PasswordChar = '\0';
            this.txtdistributer.SelectedText = "";
            this.txtdistributer.SelectionLength = 0;
            this.txtdistributer.SelectionStart = 0;
            this.txtdistributer.Size = new System.Drawing.Size(114, 23);
            this.txtdistributer.TabIndex = 53;
            this.txtdistributer.UseSystemPasswordChar = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(52, 323);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(83, 19);
            this.materialLabel11.TabIndex = 52;
            this.materialLabel11.Text = "Distributer ";
            // 
            // txtdis
            // 
            this.txtdis.Depth = 0;
            this.txtdis.Enabled = false;
            this.txtdis.Hint = "";
            this.txtdis.Location = new System.Drawing.Point(722, 80);
            this.txtdis.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtdis.Name = "txtdis";
            this.txtdis.PasswordChar = '\0';
            this.txtdis.SelectedText = "";
            this.txtdis.SelectionLength = 0;
            this.txtdis.SelectionStart = 0;
            this.txtdis.Size = new System.Drawing.Size(114, 23);
            this.txtdis.TabIndex = 54;
            this.txtdis.UseSystemPasswordChar = false;
            this.txtdis.Visible = false;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(336, 323);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(317, 152);
            this.listView2.TabIndex = 55;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseClick);
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Area ID";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Area Name";
            this.columnHeader18.Width = 130;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Province ";
            this.columnHeader19.Width = 120;
            // 
            // txtareaid
            // 
            this.txtareaid.Depth = 0;
            this.txtareaid.Enabled = false;
            this.txtareaid.Hint = "";
            this.txtareaid.Location = new System.Drawing.Point(590, 80);
            this.txtareaid.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtareaid.Name = "txtareaid";
            this.txtareaid.PasswordChar = '\0';
            this.txtareaid.SelectedText = "";
            this.txtareaid.SelectionLength = 0;
            this.txtareaid.SelectionStart = 0;
            this.txtareaid.Size = new System.Drawing.Size(114, 23);
            this.txtareaid.TabIndex = 56;
            this.txtareaid.UseSystemPasswordChar = false;
            this.txtareaid.Visible = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(52, 364);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(44, 19);
            this.materialLabel1.TabIndex = 57;
            this.materialLabel1.Text = "Area ";
            // 
            // txtareaname
            // 
            this.txtareaname.Depth = 0;
            this.txtareaname.Enabled = false;
            this.txtareaname.Hint = "";
            this.txtareaname.Location = new System.Drawing.Point(182, 364);
            this.txtareaname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtareaname.Name = "txtareaname";
            this.txtareaname.PasswordChar = '\0';
            this.txtareaname.SelectedText = "";
            this.txtareaname.SelectionLength = 0;
            this.txtareaname.SelectionStart = 0;
            this.txtareaname.Size = new System.Drawing.Size(114, 23);
            this.txtareaname.TabIndex = 58;
            this.txtareaname.UseSystemPasswordChar = false;
            // 
            // txtprov
            // 
            this.txtprov.Depth = 0;
            this.txtprov.Enabled = false;
            this.txtprov.Hint = "";
            this.txtprov.Location = new System.Drawing.Point(182, 408);
            this.txtprov.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtprov.Name = "txtprov";
            this.txtprov.PasswordChar = '\0';
            this.txtprov.SelectedText = "";
            this.txtprov.SelectionLength = 0;
            this.txtprov.SelectionStart = 0;
            this.txtprov.Size = new System.Drawing.Size(114, 23);
            this.txtprov.TabIndex = 60;
            this.txtprov.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(52, 408);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(67, 19);
            this.materialLabel2.TabIndex = 59;
            this.materialLabel2.Text = "Province";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(332, 301);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(258, 19);
            this.materialLabel3.TabIndex = 62;
            this.materialLabel3.Text = "Select a Area to Assign to Distributer";
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader26});
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(27, 529);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(794, 179);
            this.listView3.TabIndex = 63;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            this.listView3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView3_MouseClick);
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Record ID";
            this.columnHeader20.Width = 80;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "First Name";
            this.columnHeader21.Width = 120;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Area Name";
            this.columnHeader22.Width = 105;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Province";
            this.columnHeader23.Width = 100;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Email";
            this.columnHeader24.Width = 140;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Telephone";
            this.columnHeader25.Width = 120;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "Joined Date";
            this.columnHeader26.Width = 120;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(23, 507);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(245, 19);
            this.materialLabel4.TabIndex = 64;
            this.materialLabel4.Text = "All Distubuters with assigned areas";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.Location = new System.Drawing.Point(789, 91);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(32, 32);
            this.btnRefresh.TabIndex = 76;
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(448, 713);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(318, 19);
            this.materialLabel5.TabIndex = 77;
            this.materialLabel5.Text = "RIght Mouse Click on record to remove record";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeCombinationToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 26);
            // 
            // removeCombinationToolStripMenuItem
            // 
            this.removeCombinationToolStripMenuItem.Name = "removeCombinationToolStripMenuItem";
            this.removeCombinationToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.removeCombinationToolStripMenuItem.Text = "Remove Combination";
            this.removeCombinationToolStripMenuItem.Click += new System.EventHandler(this.removeCombinationToolStripMenuItem_Click);
            // 
            // splashPanel1
            // 
            this.splashPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.CornflowerBlue, System.Drawing.Color.RoyalBlue);
            this.splashPanel1.BeforeTouchSize = new System.Drawing.Size(855, 63);
            this.splashPanel1.Controls.Add(this.label1);
            this.splashPanel1.DesktopAlignment = Syncfusion.Windows.Forms.Tools.SplashAlignment.LeftTop;
            this.splashPanel1.DiscreetLocation = new System.Drawing.Point(0, 0);
            this.splashPanel1.Location = new System.Drawing.Point(0, 5);
            this.splashPanel1.Name = "splashPanel1";
            this.splashPanel1.Size = new System.Drawing.Size(855, 63);
            this.splashPanel1.TabIndex = 139;
            this.splashPanel1.Text = "splashPanel1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 40);
            this.label1.TabIndex = 137;
            this.label1.Text = "PRIME TRADE : ASSIGN AREAS TO DISTRIBUTOR";
            // 
            // btnaddarea
            // 
            this.btnaddarea.BeforeTouchSize = new System.Drawing.Size(124, 41);
            this.btnaddarea.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Bump;
            this.btnaddarea.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Browse;
            this.btnaddarea.Image = global::PrimeTrade.Properties.Resources.add;
            this.btnaddarea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddarea.IsBackStageButton = false;
            this.btnaddarea.Location = new System.Drawing.Point(684, 342);
            this.btnaddarea.MetroColor = System.Drawing.Color.Aqua;
            this.btnaddarea.Name = "btnaddarea";
            this.btnaddarea.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.btnaddarea.OverrideFormManagedColor = true;
            this.btnaddarea.PushButton = true;
            this.btnaddarea.Size = new System.Drawing.Size(124, 41);
            this.btnaddarea.TabIndex = 140;
            this.btnaddarea.Text = "ADD ROMO";
            this.btnaddarea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaddarea.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnaddarea.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnaddarea.UseVisualStyle = false;
            this.btnaddarea.Click += new System.EventHandler(this.btnaddarea_Click);
            // 
            // btnreset
            // 
            this.btnreset.BeforeTouchSize = new System.Drawing.Size(124, 41);
            this.btnreset.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Bump;
            this.btnreset.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Browse;
            this.btnreset.Image = global::PrimeTrade.Properties.Resources.reset;
            this.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreset.IsBackStageButton = false;
            this.btnreset.Location = new System.Drawing.Point(684, 390);
            this.btnreset.MetroColor = System.Drawing.Color.Aqua;
            this.btnreset.Name = "btnreset";
            this.btnreset.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.btnreset.OverrideFormManagedColor = true;
            this.btnreset.PushButton = true;
            this.btnreset.Size = new System.Drawing.Size(124, 41);
            this.btnreset.TabIndex = 144;
            this.btnreset.Text = "RESET";
            this.btnreset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreset.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnreset.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnreset.UseVisualStyle = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(73, 41);
            this.buttonAdv2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Bump;
            this.buttonAdv2.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Browse;
            this.buttonAdv2.Image = global::PrimeTrade.Properties.Resources.error;
            this.buttonAdv2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv2.IsBackStageButton = false;
            this.buttonAdv2.Location = new System.Drawing.Point(735, 437);
            this.buttonAdv2.MetroColor = System.Drawing.Color.Aqua;
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.OverrideFormManagedColor = true;
            this.buttonAdv2.PushButton = true;
            this.buttonAdv2.Size = new System.Drawing.Size(73, 41);
            this.buttonAdv2.TabIndex = 151;
            this.buttonAdv2.Text = "Exit";
            this.buttonAdv2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdv2.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAdv2.UseVisualStyle = false;
            this.buttonAdv2.Click += new System.EventHandler(this.buttonAdv2_Click);
            // 
            // frmManagerDistributerArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 737);
            this.Controls.Add(this.buttonAdv2);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnaddarea);
            this.Controls.Add(this.splashPanel1);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtprov);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtareaname);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtareaid);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.txtdis);
            this.Controls.Add(this.txtdistributer);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.txtdistid);
            this.Controls.Add(this.listView1);
            this.Name = "frmManagerDistributerArea";
            this.Text = "Assign ares to distributers";
            this.contextMenuStrip1.ResumeLayout(false);
            this.splashPanel1.ResumeLayout(false);
            this.splashPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private MaterialSkin.Controls.MaterialLabel txtdistid;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtdistributer;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtdis;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtareaid;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtareaname;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtprov;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeCombinationToolStripMenuItem;
        private Syncfusion.Windows.Forms.Tools.SplashPanel splashPanel1;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.ButtonAdv btnaddarea;
        private Syncfusion.Windows.Forms.ButtonAdv btnreset;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
    }
}