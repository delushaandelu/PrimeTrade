namespace PrimeTrade
{
    partial class frmManagerStockBasicData
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncatremove = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btncatupdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btncatadd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.chkstate = new MetroFramework.Controls.MetroToggle();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.listviewCatogory = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtcatagory = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnbrandremove = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnbrandchange = new MaterialSkin.Controls.MaterialRaisedButton();
            this.brandadd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ckkbrandstate = new MetroFramework.Controls.MetroToggle();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.listviewbrand = new System.Windows.Forms.ListView();
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtbrandid = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtbrand = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnmanremove = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnmanchange = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnmanadd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.chkmanufactorstate = new MetroFramework.Controls.MetroToggle();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.listviewmanufactor = new System.Windows.Forms.ListView();
            this.columnHeader32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader33 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtmanufactorid = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtmanufactor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtcatid = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.btncatremove);
            this.groupBox1.Controls.Add(this.btncatupdate);
            this.groupBox1.Controls.Add(this.btncatadd);
            this.groupBox1.Controls.Add(this.chkstate);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.listviewCatogory);
            this.groupBox1.Controls.Add(this.txtcatid);
            this.groupBox1.Controls.Add(this.txtcatagory);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Location = new System.Drawing.Point(32, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 434);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Catagory";
            // 
            // btncatremove
            // 
            this.btncatremove.Depth = 0;
            this.btncatremove.Location = new System.Drawing.Point(216, 115);
            this.btncatremove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncatremove.Name = "btncatremove";
            this.btncatremove.Primary = true;
            this.btncatremove.Size = new System.Drawing.Size(63, 35);
            this.btncatremove.TabIndex = 47;
            this.btncatremove.Text = "Remove";
            this.btncatremove.UseVisualStyleBackColor = true;
            this.btncatremove.Click += new System.EventHandler(this.btncatremove_Click);
            // 
            // btncatupdate
            // 
            this.btncatupdate.Depth = 0;
            this.btncatupdate.Location = new System.Drawing.Point(113, 115);
            this.btncatupdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncatupdate.Name = "btncatupdate";
            this.btncatupdate.Primary = true;
            this.btncatupdate.Size = new System.Drawing.Size(63, 35);
            this.btncatupdate.TabIndex = 46;
            this.btncatupdate.Text = "Change";
            this.btncatupdate.UseVisualStyleBackColor = true;
            this.btncatupdate.Click += new System.EventHandler(this.btncatupdate_Click);
            // 
            // btncatadd
            // 
            this.btncatadd.Depth = 0;
            this.btncatadd.Location = new System.Drawing.Point(12, 115);
            this.btncatadd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncatadd.Name = "btncatadd";
            this.btncatadd.Primary = true;
            this.btncatadd.Size = new System.Drawing.Size(50, 35);
            this.btncatadd.TabIndex = 45;
            this.btncatadd.Text = "Add ";
            this.btncatadd.UseVisualStyleBackColor = true;
            this.btncatadd.Click += new System.EventHandler(this.btncatadd_Click);
            // 
            // chkstate
            // 
            this.chkstate.AutoSize = true;
            this.chkstate.Checked = true;
            this.chkstate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkstate.Location = new System.Drawing.Point(124, 77);
            this.chkstate.Name = "chkstate";
            this.chkstate.Size = new System.Drawing.Size(80, 17);
            this.chkstate.TabIndex = 44;
            this.chkstate.Text = "On";
            this.chkstate.UseSelectable = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 75);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(109, 19);
            this.materialLabel1.TabIndex = 43;
            this.materialLabel1.Text = "Available State";
            // 
            // listviewCatogory
            // 
            this.listviewCatogory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.listviewCatogory.FullRowSelect = true;
            this.listviewCatogory.GridLines = true;
            this.listviewCatogory.Location = new System.Drawing.Point(12, 165);
            this.listviewCatogory.Name = "listviewCatogory";
            this.listviewCatogory.Size = new System.Drawing.Size(267, 249);
            this.listviewCatogory.TabIndex = 42;
            this.listviewCatogory.UseCompatibleStateImageBehavior = false;
            this.listviewCatogory.View = System.Windows.Forms.View.Details;
            this.listviewCatogory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listviewCatogory_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Catagory";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Active State";
            this.columnHeader2.Width = 120;
            // 
            // txtcatagory
            // 
            this.txtcatagory.Depth = 0;
            this.txtcatagory.Hint = "";
            this.txtcatagory.Location = new System.Drawing.Point(124, 28);
            this.txtcatagory.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcatagory.Name = "txtcatagory";
            this.txtcatagory.PasswordChar = '\0';
            this.txtcatagory.SelectedText = "";
            this.txtcatagory.SelectionLength = 0;
            this.txtcatagory.SelectionStart = 0;
            this.txtcatagory.Size = new System.Drawing.Size(155, 23);
            this.txtcatagory.TabIndex = 23;
            this.txtcatagory.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(8, 32);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(69, 19);
            this.materialLabel2.TabIndex = 22;
            this.materialLabel2.Text = "Catagory";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.btnbrandremove);
            this.groupBox2.Controls.Add(this.btnbrandchange);
            this.groupBox2.Controls.Add(this.brandadd);
            this.groupBox2.Controls.Add(this.ckkbrandstate);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.listviewbrand);
            this.groupBox2.Controls.Add(this.txtbrandid);
            this.groupBox2.Controls.Add(this.txtbrand);
            this.groupBox2.Controls.Add(this.materialLabel4);
            this.groupBox2.Location = new System.Drawing.Point(361, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 434);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock Brand";
            // 
            // btnbrandremove
            // 
            this.btnbrandremove.Depth = 0;
            this.btnbrandremove.Location = new System.Drawing.Point(216, 115);
            this.btnbrandremove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnbrandremove.Name = "btnbrandremove";
            this.btnbrandremove.Primary = true;
            this.btnbrandremove.Size = new System.Drawing.Size(63, 35);
            this.btnbrandremove.TabIndex = 47;
            this.btnbrandremove.Text = "Remove";
            this.btnbrandremove.UseVisualStyleBackColor = true;
            this.btnbrandremove.Click += new System.EventHandler(this.btnbrandremove_Click);
            // 
            // btnbrandchange
            // 
            this.btnbrandchange.Depth = 0;
            this.btnbrandchange.Location = new System.Drawing.Point(113, 115);
            this.btnbrandchange.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnbrandchange.Name = "btnbrandchange";
            this.btnbrandchange.Primary = true;
            this.btnbrandchange.Size = new System.Drawing.Size(63, 35);
            this.btnbrandchange.TabIndex = 46;
            this.btnbrandchange.Text = "Change";
            this.btnbrandchange.UseVisualStyleBackColor = true;
            this.btnbrandchange.Click += new System.EventHandler(this.btnbrandchange_Click);
            // 
            // brandadd
            // 
            this.brandadd.Depth = 0;
            this.brandadd.Location = new System.Drawing.Point(12, 115);
            this.brandadd.MouseState = MaterialSkin.MouseState.HOVER;
            this.brandadd.Name = "brandadd";
            this.brandadd.Primary = true;
            this.brandadd.Size = new System.Drawing.Size(50, 35);
            this.brandadd.TabIndex = 45;
            this.brandadd.Text = "Add ";
            this.brandadd.UseVisualStyleBackColor = true;
            this.brandadd.Click += new System.EventHandler(this.brandadd_Click);
            // 
            // ckkbrandstate
            // 
            this.ckkbrandstate.AutoSize = true;
            this.ckkbrandstate.Checked = true;
            this.ckkbrandstate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckkbrandstate.Location = new System.Drawing.Point(124, 77);
            this.ckkbrandstate.Name = "ckkbrandstate";
            this.ckkbrandstate.Size = new System.Drawing.Size(80, 17);
            this.ckkbrandstate.TabIndex = 44;
            this.ckkbrandstate.Text = "On";
            this.ckkbrandstate.UseSelectable = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(8, 75);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(109, 19);
            this.materialLabel3.TabIndex = 43;
            this.materialLabel3.Text = "Available State";
            // 
            // listviewbrand
            // 
            this.listviewbrand.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader17,
            this.columnHeader21});
            this.listviewbrand.FullRowSelect = true;
            this.listviewbrand.GridLines = true;
            this.listviewbrand.Location = new System.Drawing.Point(12, 165);
            this.listviewbrand.Name = "listviewbrand";
            this.listviewbrand.Size = new System.Drawing.Size(267, 249);
            this.listviewbrand.TabIndex = 42;
            this.listviewbrand.UseCompatibleStateImageBehavior = false;
            this.listviewbrand.View = System.Windows.Forms.View.Details;
            this.listviewbrand.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listviewbrand_MouseDoubleClick);
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Brand";
            this.columnHeader17.Width = 120;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Active State";
            this.columnHeader21.Width = 120;
            // 
            // txtbrandid
            // 
            this.txtbrandid.Depth = 0;
            this.txtbrandid.Hint = "";
            this.txtbrandid.Location = new System.Drawing.Point(216, 75);
            this.txtbrandid.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtbrandid.Name = "txtbrandid";
            this.txtbrandid.PasswordChar = '\0';
            this.txtbrandid.SelectedText = "";
            this.txtbrandid.SelectionLength = 0;
            this.txtbrandid.SelectionStart = 0;
            this.txtbrandid.Size = new System.Drawing.Size(38, 23);
            this.txtbrandid.TabIndex = 24;
            this.txtbrandid.UseSystemPasswordChar = false;
            this.txtbrandid.Visible = false;
            // 
            // txtbrand
            // 
            this.txtbrand.Depth = 0;
            this.txtbrand.Hint = "";
            this.txtbrand.Location = new System.Drawing.Point(124, 28);
            this.txtbrand.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtbrand.Name = "txtbrand";
            this.txtbrand.PasswordChar = '\0';
            this.txtbrand.SelectedText = "";
            this.txtbrand.SelectionLength = 0;
            this.txtbrand.SelectionStart = 0;
            this.txtbrand.Size = new System.Drawing.Size(155, 23);
            this.txtbrand.TabIndex = 23;
            this.txtbrand.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(8, 32);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(47, 19);
            this.materialLabel4.TabIndex = 22;
            this.materialLabel4.Text = "Brand";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.btnmanremove);
            this.groupBox3.Controls.Add(this.btnmanchange);
            this.groupBox3.Controls.Add(this.btnmanadd);
            this.groupBox3.Controls.Add(this.chkmanufactorstate);
            this.groupBox3.Controls.Add(this.materialLabel5);
            this.groupBox3.Controls.Add(this.listviewmanufactor);
            this.groupBox3.Controls.Add(this.txtmanufactorid);
            this.groupBox3.Controls.Add(this.txtmanufactor);
            this.groupBox3.Controls.Add(this.materialLabel6);
            this.groupBox3.Location = new System.Drawing.Point(688, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 434);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stock Manufactor";
            // 
            // btnmanremove
            // 
            this.btnmanremove.Depth = 0;
            this.btnmanremove.Location = new System.Drawing.Point(216, 115);
            this.btnmanremove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnmanremove.Name = "btnmanremove";
            this.btnmanremove.Primary = true;
            this.btnmanremove.Size = new System.Drawing.Size(63, 35);
            this.btnmanremove.TabIndex = 47;
            this.btnmanremove.Text = "Remove";
            this.btnmanremove.UseVisualStyleBackColor = true;
            this.btnmanremove.Click += new System.EventHandler(this.btnmanremove_Click);
            // 
            // btnmanchange
            // 
            this.btnmanchange.Depth = 0;
            this.btnmanchange.Location = new System.Drawing.Point(113, 115);
            this.btnmanchange.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnmanchange.Name = "btnmanchange";
            this.btnmanchange.Primary = true;
            this.btnmanchange.Size = new System.Drawing.Size(63, 35);
            this.btnmanchange.TabIndex = 46;
            this.btnmanchange.Text = "Change";
            this.btnmanchange.UseVisualStyleBackColor = true;
            this.btnmanchange.Click += new System.EventHandler(this.btnmanchange_Click);
            // 
            // btnmanadd
            // 
            this.btnmanadd.Depth = 0;
            this.btnmanadd.Location = new System.Drawing.Point(12, 115);
            this.btnmanadd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnmanadd.Name = "btnmanadd";
            this.btnmanadd.Primary = true;
            this.btnmanadd.Size = new System.Drawing.Size(50, 35);
            this.btnmanadd.TabIndex = 45;
            this.btnmanadd.Text = "Add ";
            this.btnmanadd.UseVisualStyleBackColor = true;
            this.btnmanadd.Click += new System.EventHandler(this.btnmanadd_Click);
            // 
            // chkmanufactorstate
            // 
            this.chkmanufactorstate.AutoSize = true;
            this.chkmanufactorstate.Checked = true;
            this.chkmanufactorstate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkmanufactorstate.Location = new System.Drawing.Point(124, 77);
            this.chkmanufactorstate.Name = "chkmanufactorstate";
            this.chkmanufactorstate.Size = new System.Drawing.Size(80, 17);
            this.chkmanufactorstate.TabIndex = 44;
            this.chkmanufactorstate.Text = "On";
            this.chkmanufactorstate.UseSelectable = true;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(8, 75);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(109, 19);
            this.materialLabel5.TabIndex = 43;
            this.materialLabel5.Text = "Available State";
            // 
            // listviewmanufactor
            // 
            this.listviewmanufactor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader32,
            this.columnHeader33});
            this.listviewmanufactor.FullRowSelect = true;
            this.listviewmanufactor.GridLines = true;
            this.listviewmanufactor.Location = new System.Drawing.Point(12, 165);
            this.listviewmanufactor.Name = "listviewmanufactor";
            this.listviewmanufactor.Size = new System.Drawing.Size(267, 249);
            this.listviewmanufactor.TabIndex = 42;
            this.listviewmanufactor.UseCompatibleStateImageBehavior = false;
            this.listviewmanufactor.View = System.Windows.Forms.View.Details;
            this.listviewmanufactor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listviewmanufactor_MouseDoubleClick);
            // 
            // columnHeader32
            // 
            this.columnHeader32.Text = "Manufactor";
            this.columnHeader32.Width = 120;
            // 
            // columnHeader33
            // 
            this.columnHeader33.Text = "Active State";
            this.columnHeader33.Width = 120;
            // 
            // txtmanufactorid
            // 
            this.txtmanufactorid.Depth = 0;
            this.txtmanufactorid.Hint = "";
            this.txtmanufactorid.Location = new System.Drawing.Point(216, 75);
            this.txtmanufactorid.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtmanufactorid.Name = "txtmanufactorid";
            this.txtmanufactorid.PasswordChar = '\0';
            this.txtmanufactorid.SelectedText = "";
            this.txtmanufactorid.SelectionLength = 0;
            this.txtmanufactorid.SelectionStart = 0;
            this.txtmanufactorid.Size = new System.Drawing.Size(38, 23);
            this.txtmanufactorid.TabIndex = 24;
            this.txtmanufactorid.UseSystemPasswordChar = false;
            this.txtmanufactorid.Visible = false;
            // 
            // txtmanufactor
            // 
            this.txtmanufactor.Depth = 0;
            this.txtmanufactor.Hint = "";
            this.txtmanufactor.Location = new System.Drawing.Point(124, 28);
            this.txtmanufactor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtmanufactor.Name = "txtmanufactor";
            this.txtmanufactor.PasswordChar = '\0';
            this.txtmanufactor.SelectedText = "";
            this.txtmanufactor.SelectionLength = 0;
            this.txtmanufactor.SelectionStart = 0;
            this.txtmanufactor.Size = new System.Drawing.Size(155, 23);
            this.txtmanufactor.TabIndex = 23;
            this.txtmanufactor.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(8, 32);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(86, 19);
            this.materialLabel6.TabIndex = 22;
            this.materialLabel6.Text = "Manufactor";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Id";
            this.columnHeader3.Width = 30;
            // 
            // txtcatid
            // 
            this.txtcatid.Depth = 0;
            this.txtcatid.Hint = "";
            this.txtcatid.Location = new System.Drawing.Point(216, 75);
            this.txtcatid.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcatid.Name = "txtcatid";
            this.txtcatid.PasswordChar = '\0';
            this.txtcatid.SelectedText = "";
            this.txtcatid.SelectionLength = 0;
            this.txtcatid.SelectionStart = 0;
            this.txtcatid.Size = new System.Drawing.Size(38, 23);
            this.txtcatid.TabIndex = 24;
            this.txtcatid.UseSystemPasswordChar = false;
            this.txtcatid.Visible = false;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Id";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Id";
            // 
            // frmManagerStockBasicData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 584);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmManagerStockBasicData";
            this.Text = "Stock Basic Data";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtcatagory;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ListView listviewCatogory;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MetroFramework.Controls.MetroToggle chkstate;
        private MaterialSkin.Controls.MaterialRaisedButton btncatremove;
        private MaterialSkin.Controls.MaterialRaisedButton btncatupdate;
        private MaterialSkin.Controls.MaterialRaisedButton btncatadd;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialRaisedButton btnbrandremove;
        private MaterialSkin.Controls.MaterialRaisedButton btnbrandchange;
        private MaterialSkin.Controls.MaterialRaisedButton brandadd;
        private MetroFramework.Controls.MetroToggle ckkbrandstate;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ListView listviewbrand;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtbrandid;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtbrand;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialRaisedButton btnmanremove;
        private MaterialSkin.Controls.MaterialRaisedButton btnmanchange;
        private MaterialSkin.Controls.MaterialRaisedButton btnmanadd;
        private MetroFramework.Controls.MetroToggle chkmanufactorstate;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.ListView listviewmanufactor;
        private System.Windows.Forms.ColumnHeader columnHeader32;
        private System.Windows.Forms.ColumnHeader columnHeader33;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtmanufactorid;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtmanufactor;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtcatid;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}