namespace PrimeTrade
{
    partial class frmManagerActivePromo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagerActivePromo));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtpromoid = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtfromdate = new System.Windows.Forms.DateTimePicker();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtuntildate = new System.Windows.Forms.DateTimePicker();
            this.btnaddstock = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtcomments = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtid = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(21, 131);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(572, 133);
            this.listView1.TabIndex = 58;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Promo ID";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Promo Name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Promo Machanism";
            this.columnHeader2.Width = 195;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Promo Description";
            this.columnHeader3.Width = 175;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(17, 109);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(245, 19);
            this.materialLabel1.TabIndex = 59;
            this.materialLabel1.Text = "Select a promotion plan to process";
            // 
            // txtpromoid
            // 
            this.txtpromoid.Depth = 0;
            this.txtpromoid.Enabled = false;
            this.txtpromoid.Hint = "";
            this.txtpromoid.Location = new System.Drawing.Point(754, 131);
            this.txtpromoid.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtpromoid.Name = "txtpromoid";
            this.txtpromoid.PasswordChar = '\0';
            this.txtpromoid.SelectedText = "";
            this.txtpromoid.SelectionLength = 0;
            this.txtpromoid.SelectionStart = 0;
            this.txtpromoid.Size = new System.Drawing.Size(195, 23);
            this.txtpromoid.TabIndex = 61;
            this.txtpromoid.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(614, 131);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(113, 19);
            this.materialLabel2.TabIndex = 60;
            this.materialLabel2.Text = "Promotion Plan";
            // 
            // txtfromdate
            // 
            this.txtfromdate.Location = new System.Drawing.Point(754, 169);
            this.txtfromdate.Name = "txtfromdate";
            this.txtfromdate.Size = new System.Drawing.Size(195, 20);
            this.txtfromdate.TabIndex = 62;
            this.txtfromdate.ValueChanged += new System.EventHandler(this.txtfromdate_ValueChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(614, 170);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(79, 19);
            this.materialLabel3.TabIndex = 63;
            this.materialLabel3.Text = "From Date";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(614, 204);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(75, 19);
            this.materialLabel4.TabIndex = 65;
            this.materialLabel4.Text = "Until Date";
            // 
            // txtuntildate
            // 
            this.txtuntildate.Location = new System.Drawing.Point(754, 204);
            this.txtuntildate.Name = "txtuntildate";
            this.txtuntildate.Size = new System.Drawing.Size(195, 20);
            this.txtuntildate.TabIndex = 64;
            this.txtuntildate.ValueChanged += new System.EventHandler(this.txtuntildate_ValueChanged);
            // 
            // btnaddstock
            // 
            this.btnaddstock.Depth = 0;
            this.btnaddstock.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnaddstock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddstock.Location = new System.Drawing.Point(993, 135);
            this.btnaddstock.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnaddstock.Name = "btnaddstock";
            this.btnaddstock.Primary = true;
            this.btnaddstock.Size = new System.Drawing.Size(120, 25);
            this.btnaddstock.TabIndex = 66;
            this.btnaddstock.Text = "Active Promo";
            this.btnaddstock.UseVisualStyleBackColor = true;
            this.btnaddstock.Click += new System.EventHandler(this.btnaddstock_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(993, 170);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(121, 25);
            this.materialRaisedButton1.TabIndex = 67;
            this.materialRaisedButton1.Text = "Update Promo";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(992, 204);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(121, 25);
            this.materialRaisedButton2.TabIndex = 68;
            this.materialRaisedButton2.Text = "Remove Promo";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // txtcomments
            // 
            this.txtcomments.Depth = 0;
            this.txtcomments.Enabled = false;
            this.txtcomments.Hint = "";
            this.txtcomments.Location = new System.Drawing.Point(754, 241);
            this.txtcomments.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcomments.Name = "txtcomments";
            this.txtcomments.PasswordChar = '\0';
            this.txtcomments.SelectedText = "";
            this.txtcomments.SelectionLength = 0;
            this.txtcomments.SelectionStart = 0;
            this.txtcomments.Size = new System.Drawing.Size(195, 23);
            this.txtcomments.TabIndex = 70;
            this.txtcomments.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(614, 241);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(83, 19);
            this.materialLabel5.TabIndex = 69;
            this.materialLabel5.Text = "Comments";
            // 
            // txtid
            // 
            this.txtid.Depth = 0;
            this.txtid.Enabled = false;
            this.txtid.Hint = "";
            this.txtid.Location = new System.Drawing.Point(993, 85);
            this.txtid.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtid.Name = "txtid";
            this.txtid.PasswordChar = '\0';
            this.txtid.SelectedText = "";
            this.txtid.SelectionLength = 0;
            this.txtid.SelectionStart = 0;
            this.txtid.Size = new System.Drawing.Size(56, 23);
            this.txtid.TabIndex = 71;
            this.txtid.UseSystemPasswordChar = false;
            this.txtid.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.Location = new System.Drawing.Point(561, 96);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(32, 32);
            this.btnRefresh.TabIndex = 72;
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader4});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(21, 327);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(634, 133);
            this.listView2.TabIndex = 73;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseClick);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Active Promotion Plan Code";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Promotion Name";
            this.columnHeader10.Width = 120;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Promotion From";
            this.columnHeader11.Width = 120;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Promotion Until";
            this.columnHeader12.Width = 120;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Comments";
            this.columnHeader13.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "promoid";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(17, 305);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(188, 19);
            this.materialLabel6.TabIndex = 74;
            this.materialLabel6.Text = "All Active promotion Plans";
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton1.BackgroundImage")));
            this.metroButton1.Location = new System.Drawing.Point(623, 292);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(32, 32);
            this.metroButton1.TabIndex = 76;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(992, 239);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(121, 25);
            this.materialRaisedButton3.TabIndex = 77;
            this.materialRaisedButton3.Text = "Reset Fields";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // frmManagerActivePromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 494);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtcomments);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.btnaddstock);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtuntildate);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtfromdate);
            this.Controls.Add(this.txtpromoid);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.listView1);
            this.Name = "frmManagerActivePromo";
            this.Text = "Active Promotion Plan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtpromoid;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DateTimePicker txtfromdate;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.DateTimePicker txtuntildate;
        private MaterialSkin.Controls.MaterialRaisedButton btnaddstock;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtcomments;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtid;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
    }
}