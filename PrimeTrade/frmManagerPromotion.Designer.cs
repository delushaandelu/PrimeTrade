namespace PrimeTrade
{
    partial class frmManagerPromotion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagerPromotion));
            this.txtname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtdes = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnaddpromo = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnupdatepromo = new MaterialSkin.Controls.MaterialFlatButton();
            this.btndeletepromo = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtpromoid = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.txtmac = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Depth = 0;
            this.txtname.Hint = "";
            this.txtname.Location = new System.Drawing.Point(207, 100);
            this.txtname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.SelectedText = "";
            this.txtname.SelectionLength = 0;
            this.txtname.SelectionStart = 0;
            this.txtname.Size = new System.Drawing.Size(292, 23);
            this.txtname.TabIndex = 50;
            this.txtname.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(27, 172);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(161, 19);
            this.materialLabel3.TabIndex = 49;
            this.materialLabel3.Text = "Promotion Description";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(27, 136);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(162, 19);
            this.materialLabel1.TabIndex = 48;
            this.materialLabel1.Text = "Promotion Mechanism";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(27, 100);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(124, 19);
            this.materialLabel2.TabIndex = 47;
            this.materialLabel2.Text = "Promotion Name";
            // 
            // txtdes
            // 
            this.txtdes.Depth = 0;
            this.txtdes.Hint = "";
            this.txtdes.Location = new System.Drawing.Point(207, 172);
            this.txtdes.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtdes.Name = "txtdes";
            this.txtdes.PasswordChar = '\0';
            this.txtdes.SelectedText = "";
            this.txtdes.SelectionLength = 0;
            this.txtdes.SelectionStart = 0;
            this.txtdes.Size = new System.Drawing.Size(399, 23);
            this.txtdes.TabIndex = 51;
            this.txtdes.UseSystemPasswordChar = false;
            // 
            // btnaddpromo
            // 
            this.btnaddpromo.AutoSize = true;
            this.btnaddpromo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnaddpromo.Depth = 0;
            this.btnaddpromo.Location = new System.Drawing.Point(58, 220);
            this.btnaddpromo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnaddpromo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnaddpromo.Name = "btnaddpromo";
            this.btnaddpromo.Primary = false;
            this.btnaddpromo.Size = new System.Drawing.Size(91, 36);
            this.btnaddpromo.TabIndex = 53;
            this.btnaddpromo.Text = "Add Promo";
            this.btnaddpromo.UseVisualStyleBackColor = true;
            this.btnaddpromo.Click += new System.EventHandler(this.btnaddpromo_Click);
            // 
            // btnupdatepromo
            // 
            this.btnupdatepromo.AutoSize = true;
            this.btnupdatepromo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnupdatepromo.Depth = 0;
            this.btnupdatepromo.Location = new System.Drawing.Point(186, 220);
            this.btnupdatepromo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnupdatepromo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnupdatepromo.Name = "btnupdatepromo";
            this.btnupdatepromo.Primary = false;
            this.btnupdatepromo.Size = new System.Drawing.Size(116, 36);
            this.btnupdatepromo.TabIndex = 54;
            this.btnupdatepromo.Text = "Update Promo";
            this.btnupdatepromo.UseVisualStyleBackColor = true;
            this.btnupdatepromo.Click += new System.EventHandler(this.btnupdatepromo_Click);
            // 
            // btndeletepromo
            // 
            this.btndeletepromo.AutoSize = true;
            this.btndeletepromo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btndeletepromo.Depth = 0;
            this.btndeletepromo.Location = new System.Drawing.Point(341, 220);
            this.btndeletepromo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btndeletepromo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btndeletepromo.Name = "btndeletepromo";
            this.btndeletepromo.Primary = false;
            this.btndeletepromo.Size = new System.Drawing.Size(112, 36);
            this.btndeletepromo.TabIndex = 55;
            this.btndeletepromo.Text = "Delete Promo";
            this.btndeletepromo.UseVisualStyleBackColor = true;
            this.btndeletepromo.Click += new System.EventHandler(this.btndeletepromo_Click);
            // 
            // txtpromoid
            // 
            this.txtpromoid.Depth = 0;
            this.txtpromoid.Hint = "";
            this.txtpromoid.Location = new System.Drawing.Point(31, 71);
            this.txtpromoid.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtpromoid.Name = "txtpromoid";
            this.txtpromoid.PasswordChar = '\0';
            this.txtpromoid.SelectedText = "";
            this.txtpromoid.SelectionLength = 0;
            this.txtpromoid.SelectionStart = 0;
            this.txtpromoid.Size = new System.Drawing.Size(33, 23);
            this.txtpromoid.TabIndex = 56;
            this.txtpromoid.UseSystemPasswordChar = false;
            this.txtpromoid.Visible = false;
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
            this.listView1.Location = new System.Drawing.Point(31, 285);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(575, 283);
            this.listView1.TabIndex = 57;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
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
            this.columnHeader2.Width = 190;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Promo Description";
            this.columnHeader3.Width = 175;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.Location = new System.Drawing.Point(574, 247);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(32, 32);
            this.btnRefresh.TabIndex = 58;
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtmac
            // 
            this.txtmac.FormattingEnabled = true;
            this.txtmac.ItemHeight = 23;
            this.txtmac.Items.AddRange(new object[] {
            "Buy one get one free",
            "Free 3rd party item",
            "Free pack with another SKU"});
            this.txtmac.Location = new System.Drawing.Point(207, 132);
            this.txtmac.Name = "txtmac";
            this.txtmac.Size = new System.Drawing.Size(399, 29);
            this.txtmac.TabIndex = 59;
            this.txtmac.UseSelectable = true;
            // 
            // frmManagerPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 607);
            this.Controls.Add(this.txtmac);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtpromoid);
            this.Controls.Add(this.btndeletepromo);
            this.Controls.Add(this.btnupdatepromo);
            this.Controls.Add(this.btnaddpromo);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "frmManagerPromotion";
            this.Text = "Promotion ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtname;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtdes;
        private MaterialSkin.Controls.MaterialFlatButton btnaddpromo;
        private MaterialSkin.Controls.MaterialFlatButton btnupdatepromo;
        private MaterialSkin.Controls.MaterialFlatButton btndeletepromo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtpromoid;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroComboBox txtmac;
    }
}