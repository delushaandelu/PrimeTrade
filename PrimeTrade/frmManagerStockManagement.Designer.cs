namespace PrimeTrade
{
    partial class frmManagerStockManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagerStockManagement));
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtstockid = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtstockname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtqty = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtreorder = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dtpexpdate = new System.Windows.Forms.DateTimePicker();
            this.dtpmandate = new System.Windows.Forms.DateTimePicker();
            this.btnaddstock = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnupdatestock = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btndeletestock = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmbmanufactor = new System.Windows.Forms.ComboBox();
            this.cmbcatogery = new System.Windows.Forms.ComboBox();
            this.cmbbrand = new System.Windows.Forms.ComboBox();
            this.cmbpromocode = new System.Windows.Forms.ComboBox();
            this.cmbstate = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtstkid = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnReset = new MaterialSkin.Controls.MaterialRaisedButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.receiveNewStockQuantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approveNewStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.lblcallfrom = new MaterialSkin.Controls.MaterialLabel();
            this.chkShowQtyRecords = new MaterialSkin.Controls.MaterialCheckBox();
            this.txtcost = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtmrp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.lblprofit = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(440, 241);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(100, 19);
            this.materialLabel6.TabIndex = 19;
            this.materialLabel6.Text = "Reorder Level";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(50, 285);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(44, 19);
            this.materialLabel7.TabIndex = 18;
            this.materialLabel7.Text = "State";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(440, 194);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(64, 19);
            this.materialLabel8.TabIndex = 17;
            this.materialLabel8.Text = "Quantity";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(440, 150);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(101, 19);
            this.materialLabel9.TabIndex = 16;
            this.materialLabel9.Text = "Expaired Date";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(440, 107);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(128, 19);
            this.materialLabel10.TabIndex = 15;
            this.materialLabel10.Text = "Manufucture Date";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(50, 241);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(86, 19);
            this.materialLabel5.TabIndex = 14;
            this.materialLabel5.Text = "Manufactor";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(50, 198);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(47, 19);
            this.materialLabel4.TabIndex = 13;
            this.materialLabel4.Text = "Brand";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(50, 151);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(69, 19);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "Catogery";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(50, 107);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(83, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Item Name";
            // 
            // txtstockid
            // 
            this.txtstockid.AutoSize = true;
            this.txtstockid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtstockid.Depth = 0;
            this.txtstockid.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtstockid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtstockid.Location = new System.Drawing.Point(791, 85);
            this.txtstockid.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtstockid.Name = "txtstockid";
            this.txtstockid.Size = new System.Drawing.Size(0, 19);
            this.txtstockid.TabIndex = 10;
            this.txtstockid.Visible = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(440, 284);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(119, 19);
            this.materialLabel1.TabIndex = 20;
            this.materialLabel1.Text = "Promotion Code";
            // 
            // txtstockname
            // 
            this.txtstockname.Depth = 0;
            this.txtstockname.Hint = "";
            this.txtstockname.Location = new System.Drawing.Point(162, 107);
            this.txtstockname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtstockname.Name = "txtstockname";
            this.txtstockname.PasswordChar = '\0';
            this.txtstockname.SelectedText = "";
            this.txtstockname.SelectionLength = 0;
            this.txtstockname.SelectionStart = 0;
            this.txtstockname.Size = new System.Drawing.Size(195, 23);
            this.txtstockname.TabIndex = 21;
            this.txtstockname.UseSystemPasswordChar = false;
            // 
            // txtqty
            // 
            this.txtqty.Depth = 0;
            this.txtqty.Hint = "";
            this.txtqty.Location = new System.Drawing.Point(607, 194);
            this.txtqty.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtqty.Name = "txtqty";
            this.txtqty.PasswordChar = '\0';
            this.txtqty.SelectedText = "";
            this.txtqty.SelectionLength = 0;
            this.txtqty.SelectionStart = 0;
            this.txtqty.Size = new System.Drawing.Size(195, 23);
            this.txtqty.TabIndex = 27;
            this.txtqty.UseSystemPasswordChar = false;
            // 
            // txtreorder
            // 
            this.txtreorder.Depth = 0;
            this.txtreorder.Hint = "";
            this.txtreorder.Location = new System.Drawing.Point(607, 239);
            this.txtreorder.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtreorder.Name = "txtreorder";
            this.txtreorder.PasswordChar = '\0';
            this.txtreorder.SelectedText = "";
            this.txtreorder.SelectionLength = 0;
            this.txtreorder.SelectionStart = 0;
            this.txtreorder.Size = new System.Drawing.Size(195, 23);
            this.txtreorder.TabIndex = 28;
            this.txtreorder.UseSystemPasswordChar = false;
            // 
            // dtpexpdate
            // 
            this.dtpexpdate.Location = new System.Drawing.Point(607, 149);
            this.dtpexpdate.Name = "dtpexpdate";
            this.dtpexpdate.Size = new System.Drawing.Size(195, 20);
            this.dtpexpdate.TabIndex = 30;
            // 
            // dtpmandate
            // 
            this.dtpmandate.Location = new System.Drawing.Point(607, 107);
            this.dtpmandate.Name = "dtpmandate";
            this.dtpmandate.Size = new System.Drawing.Size(195, 20);
            this.dtpmandate.TabIndex = 31;
            // 
            // btnaddstock
            // 
            this.btnaddstock.Depth = 0;
            this.btnaddstock.Location = new System.Drawing.Point(856, 105);
            this.btnaddstock.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnaddstock.Name = "btnaddstock";
            this.btnaddstock.Primary = true;
            this.btnaddstock.Size = new System.Drawing.Size(107, 25);
            this.btnaddstock.TabIndex = 33;
            this.btnaddstock.Text = "Add Stock";
            this.btnaddstock.UseVisualStyleBackColor = true;
            this.btnaddstock.Click += new System.EventHandler(this.btnaddstock_Click);
            // 
            // btnupdatestock
            // 
            this.btnupdatestock.Depth = 0;
            this.btnupdatestock.Location = new System.Drawing.Point(856, 136);
            this.btnupdatestock.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnupdatestock.Name = "btnupdatestock";
            this.btnupdatestock.Primary = true;
            this.btnupdatestock.Size = new System.Drawing.Size(107, 25);
            this.btnupdatestock.TabIndex = 34;
            this.btnupdatestock.Text = "UPDATE STOCK";
            this.btnupdatestock.UseVisualStyleBackColor = true;
            this.btnupdatestock.Click += new System.EventHandler(this.btnupdatestock_Click);
            // 
            // btndeletestock
            // 
            this.btndeletestock.Depth = 0;
            this.btndeletestock.Location = new System.Drawing.Point(856, 167);
            this.btndeletestock.MouseState = MaterialSkin.MouseState.HOVER;
            this.btndeletestock.Name = "btndeletestock";
            this.btndeletestock.Primary = true;
            this.btndeletestock.Size = new System.Drawing.Size(107, 25);
            this.btndeletestock.TabIndex = 35;
            this.btndeletestock.Text = "Delete Stock";
            this.btndeletestock.UseVisualStyleBackColor = true;
            this.btndeletestock.Click += new System.EventHandler(this.btndeletestock_Click);
            // 
            // cmbmanufactor
            // 
            this.cmbmanufactor.FormattingEnabled = true;
            this.cmbmanufactor.Items.AddRange(new object[] {
            "Default "});
            this.cmbmanufactor.Location = new System.Drawing.Point(162, 242);
            this.cmbmanufactor.Name = "cmbmanufactor";
            this.cmbmanufactor.Size = new System.Drawing.Size(195, 21);
            this.cmbmanufactor.TabIndex = 36;
            // 
            // cmbcatogery
            // 
            this.cmbcatogery.FormattingEnabled = true;
            this.cmbcatogery.Items.AddRange(new object[] {
            "Default "});
            this.cmbcatogery.Location = new System.Drawing.Point(162, 152);
            this.cmbcatogery.Name = "cmbcatogery";
            this.cmbcatogery.Size = new System.Drawing.Size(195, 21);
            this.cmbcatogery.TabIndex = 37;
            // 
            // cmbbrand
            // 
            this.cmbbrand.FormattingEnabled = true;
            this.cmbbrand.Items.AddRange(new object[] {
            "Default "});
            this.cmbbrand.Location = new System.Drawing.Point(162, 196);
            this.cmbbrand.Name = "cmbbrand";
            this.cmbbrand.Size = new System.Drawing.Size(195, 21);
            this.cmbbrand.TabIndex = 38;
            // 
            // cmbpromocode
            // 
            this.cmbpromocode.FormattingEnabled = true;
            this.cmbpromocode.Items.AddRange(new object[] {
            "Default "});
            this.cmbpromocode.Location = new System.Drawing.Point(607, 285);
            this.cmbpromocode.Name = "cmbpromocode";
            this.cmbpromocode.Size = new System.Drawing.Size(195, 21);
            this.cmbpromocode.TabIndex = 39;
            // 
            // cmbstate
            // 
            this.cmbstate.FormattingEnabled = true;
            this.cmbstate.Items.AddRange(new object[] {
            "Default "});
            this.cmbstate.Location = new System.Drawing.Point(162, 286);
            this.cmbstate.Name = "cmbstate";
            this.cmbstate.Size = new System.Drawing.Size(195, 21);
            this.cmbstate.TabIndex = 40;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader22,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(54, 424);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(909, 299);
            this.listView1.TabIndex = 41;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Item ID";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Item Name";
            this.columnHeader13.Width = 90;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Category";
            this.columnHeader14.Width = 80;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Brand";
            this.columnHeader15.Width = 80;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "QTY";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Manufactor";
            this.columnHeader18.Width = 80;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Manufacture Date";
            this.columnHeader19.Width = 120;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Expaired Date";
            this.columnHeader20.Width = 120;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "State";
            this.columnHeader22.Width = 80;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Reorder Level";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Promo Code";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "New Qty";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cost";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "MRP";
            // 
            // txtstkid
            // 
            this.txtstkid.Depth = 0;
            this.txtstkid.Hint = "";
            this.txtstkid.Location = new System.Drawing.Point(162, 71);
            this.txtstkid.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtstkid.Name = "txtstkid";
            this.txtstkid.PasswordChar = '\0';
            this.txtstkid.SelectedText = "";
            this.txtstkid.SelectionLength = 0;
            this.txtstkid.SelectionStart = 0;
            this.txtstkid.Size = new System.Drawing.Size(40, 23);
            this.txtstkid.TabIndex = 42;
            this.txtstkid.UseSystemPasswordChar = false;
            this.txtstkid.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Depth = 0;
            this.btnReset.Location = new System.Drawing.Point(856, 198);
            this.btnReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReset.Name = "btnReset";
            this.btnReset.Primary = true;
            this.btnReset.Size = new System.Drawing.Size(107, 25);
            this.btnReset.TabIndex = 43;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receiveNewStockQuantityToolStripMenuItem,
            this.approveNewStockToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(220, 48);
            // 
            // receiveNewStockQuantityToolStripMenuItem
            // 
            this.receiveNewStockQuantityToolStripMenuItem.Name = "receiveNewStockQuantityToolStripMenuItem";
            this.receiveNewStockQuantityToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.receiveNewStockQuantityToolStripMenuItem.Text = "Receive new stock Quantity";
            this.receiveNewStockQuantityToolStripMenuItem.Click += new System.EventHandler(this.receiveNewStockQuantityToolStripMenuItem_Click);
            // 
            // approveNewStockToolStripMenuItem
            // 
            this.approveNewStockToolStripMenuItem.Name = "approveNewStockToolStripMenuItem";
            this.approveNewStockToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.approveNewStockToolStripMenuItem.Text = "Approve new stock";
            this.approveNewStockToolStripMenuItem.Visible = false;
            this.approveNewStockToolStripMenuItem.Click += new System.EventHandler(this.approveNewStockToolStripMenuItem_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.Location = new System.Drawing.Point(933, 389);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(32, 32);
            this.btnRefresh.TabIndex = 45;
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblcallfrom
            // 
            this.lblcallfrom.AutoSize = true;
            this.lblcallfrom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcallfrom.Depth = 0;
            this.lblcallfrom.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblcallfrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblcallfrom.Location = new System.Drawing.Point(208, 75);
            this.lblcallfrom.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblcallfrom.Name = "lblcallfrom";
            this.lblcallfrom.Size = new System.Drawing.Size(0, 19);
            this.lblcallfrom.TabIndex = 46;
            this.lblcallfrom.Visible = false;
            // 
            // chkShowQtyRecords
            // 
            this.chkShowQtyRecords.AutoSize = true;
            this.chkShowQtyRecords.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkShowQtyRecords.Depth = 0;
            this.chkShowQtyRecords.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkShowQtyRecords.Location = new System.Drawing.Point(722, 391);
            this.chkShowQtyRecords.Margin = new System.Windows.Forms.Padding(0);
            this.chkShowQtyRecords.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkShowQtyRecords.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkShowQtyRecords.Name = "chkShowQtyRecords";
            this.chkShowQtyRecords.Ripple = true;
            this.chkShowQtyRecords.Size = new System.Drawing.Size(193, 30);
            this.chkShowQtyRecords.TabIndex = 47;
            this.chkShowQtyRecords.Text = "Show finalized qty records";
            this.chkShowQtyRecords.UseVisualStyleBackColor = false;
            this.chkShowQtyRecords.CheckedChanged += new System.EventHandler(this.materialCheckBox1_CheckedChanged);
            // 
            // txtcost
            // 
            this.txtcost.Depth = 0;
            this.txtcost.Hint = "";
            this.txtcost.Location = new System.Drawing.Point(404, 322);
            this.txtcost.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcost.Name = "txtcost";
            this.txtcost.PasswordChar = '\0';
            this.txtcost.SelectedText = "";
            this.txtcost.SelectionLength = 0;
            this.txtcost.SelectionStart = 0;
            this.txtcost.Size = new System.Drawing.Size(195, 23);
            this.txtcost.TabIndex = 49;
            this.txtcost.UseSystemPasswordChar = false;
            this.txtcost.TextChanged += new System.EventHandler(this.txtcost_TextChanged);
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(277, 324);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(47, 19);
            this.materialLabel11.TabIndex = 48;
            this.materialLabel11.Text = "COST";
            // 
            // txtmrp
            // 
            this.txtmrp.Depth = 0;
            this.txtmrp.Hint = "";
            this.txtmrp.Location = new System.Drawing.Point(404, 351);
            this.txtmrp.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtmrp.Name = "txtmrp";
            this.txtmrp.PasswordChar = '\0';
            this.txtmrp.SelectedText = "";
            this.txtmrp.SelectionLength = 0;
            this.txtmrp.SelectionStart = 0;
            this.txtmrp.Size = new System.Drawing.Size(195, 23);
            this.txtmrp.TabIndex = 51;
            this.txtmrp.UseSystemPasswordChar = false;
            this.txtmrp.TextChanged += new System.EventHandler(this.txtmrp_TextChanged);
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(277, 353);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(40, 19);
            this.materialLabel12.TabIndex = 50;
            this.materialLabel12.Text = "MRP";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(605, 326);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(39, 19);
            this.materialLabel13.TabIndex = 52;
            this.materialLabel13.Text = ".LKR";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(605, 353);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(39, 19);
            this.materialLabel14.TabIndex = 53;
            this.materialLabel14.Text = ".LKR";
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(230, 389);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(173, 19);
            this.materialLabel15.TabIndex = 54;
            this.materialLabel15.Text = "Estimated Profit per Qty:";
            // 
            // lblprofit
            // 
            this.lblprofit.AutoSize = true;
            this.lblprofit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblprofit.Depth = 0;
            this.lblprofit.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblprofit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblprofit.Location = new System.Drawing.Point(409, 389);
            this.lblprofit.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblprofit.Name = "lblprofit";
            this.lblprofit.Size = new System.Drawing.Size(0, 19);
            this.lblprofit.TabIndex = 55;
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(605, 386);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(39, 19);
            this.materialLabel17.TabIndex = 56;
            this.materialLabel17.Text = ".LKR";
            // 
            // frmManagerStockManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 735);
            this.Controls.Add(this.materialLabel17);
            this.Controls.Add(this.lblprofit);
            this.Controls.Add(this.materialLabel15);
            this.Controls.Add(this.materialLabel14);
            this.Controls.Add(this.materialLabel13);
            this.Controls.Add(this.txtmrp);
            this.Controls.Add(this.materialLabel12);
            this.Controls.Add(this.txtcost);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.chkShowQtyRecords);
            this.Controls.Add(this.lblcallfrom);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtstkid);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cmbstate);
            this.Controls.Add(this.cmbpromocode);
            this.Controls.Add(this.cmbbrand);
            this.Controls.Add(this.cmbcatogery);
            this.Controls.Add(this.cmbmanufactor);
            this.Controls.Add(this.btndeletestock);
            this.Controls.Add(this.btnupdatestock);
            this.Controls.Add(this.btnaddstock);
            this.Controls.Add(this.dtpmandate);
            this.Controls.Add(this.dtpexpdate);
            this.Controls.Add(this.txtreorder);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.txtstockname);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtstockid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManagerStockManagement";
            this.Text = "Inventory Management ";
            this.Load += new System.EventHandler(this.frmManagerStockManagement_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel txtstockid;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtstockname;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtqty;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtreorder;
        private System.Windows.Forms.DateTimePicker dtpexpdate;
        private System.Windows.Forms.DateTimePicker dtpmandate;
        private MaterialSkin.Controls.MaterialRaisedButton btnaddstock;
        private MaterialSkin.Controls.MaterialRaisedButton btnupdatestock;
        private MaterialSkin.Controls.MaterialRaisedButton btndeletestock;
        private System.Windows.Forms.ComboBox cmbmanufactor;
        private System.Windows.Forms.ComboBox cmbcatogery;
        private System.Windows.Forms.ComboBox cmbbrand;
        private System.Windows.Forms.ComboBox cmbpromocode;
        private System.Windows.Forms.ComboBox cmbstate;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtstkid;
        private MaterialSkin.Controls.MaterialRaisedButton btnReset;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem receiveNewStockQuantityToolStripMenuItem;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialLabel lblcallfrom;
        private System.Windows.Forms.ToolStripMenuItem approveNewStockToolStripMenuItem;
        private MaterialSkin.Controls.MaterialCheckBox chkShowQtyRecords;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtcost;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtmrp;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel lblprofit;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
    }
}