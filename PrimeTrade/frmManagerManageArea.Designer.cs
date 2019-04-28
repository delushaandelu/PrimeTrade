namespace PrimeTrade
{
    partial class frmManagerManageArea
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
            this.cmbprov = new System.Windows.Forms.ComboBox();
            this.txtarea = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtareaid = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.splashPanel1 = new Syncfusion.Windows.Forms.Tools.SplashPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.materialRaisedButton3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.materialRaisedButton2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.materialRaisedButton1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnaddstock = new Syncfusion.Windows.Forms.ButtonAdv();
            this.splashPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbprov
            // 
            this.cmbprov.FormattingEnabled = true;
            this.cmbprov.Items.AddRange(new object[] {
            "Central ",
            "Eastern",
            "Northern ",
            "Southern ",
            "Western ",
            "North Western ",
            "North Central ",
            "Uva ",
            "Sabaragamuwa "});
            this.cmbprov.Location = new System.Drawing.Point(144, 143);
            this.cmbprov.Name = "cmbprov";
            this.cmbprov.Size = new System.Drawing.Size(195, 21);
            this.cmbprov.TabIndex = 41;
            // 
            // txtarea
            // 
            this.txtarea.Depth = 0;
            this.txtarea.Hint = "";
            this.txtarea.Location = new System.Drawing.Point(144, 98);
            this.txtarea.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtarea.Name = "txtarea";
            this.txtarea.PasswordChar = '\0';
            this.txtarea.SelectedText = "";
            this.txtarea.SelectionLength = 0;
            this.txtarea.SelectionStart = 0;
            this.txtarea.Size = new System.Drawing.Size(195, 23);
            this.txtarea.TabIndex = 40;
            this.txtarea.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(32, 142);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(71, 19);
            this.materialLabel3.TabIndex = 39;
            this.materialLabel3.Text = "Province ";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(32, 98);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(84, 19);
            this.materialLabel2.TabIndex = 38;
            this.materialLabel2.Text = "Area Name";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(36, 200);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(303, 152);
            this.listView1.TabIndex = 48;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Area ID";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Area Name";
            this.columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Province";
            this.columnHeader8.Width = 110;
            // 
            // txtareaid
            // 
            this.txtareaid.Depth = 0;
            this.txtareaid.Hint = "";
            this.txtareaid.Location = new System.Drawing.Point(381, 189);
            this.txtareaid.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtareaid.Name = "txtareaid";
            this.txtareaid.PasswordChar = '\0';
            this.txtareaid.SelectedText = "";
            this.txtareaid.SelectionLength = 0;
            this.txtareaid.SelectionStart = 0;
            this.txtareaid.Size = new System.Drawing.Size(64, 23);
            this.txtareaid.TabIndex = 49;
            this.txtareaid.UseSystemPasswordChar = false;
            this.txtareaid.Visible = false;
            // 
            // splashPanel1
            // 
            this.splashPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.CornflowerBlue, System.Drawing.Color.RoyalBlue);
            this.splashPanel1.BeforeTouchSize = new System.Drawing.Size(661, 63);
            this.splashPanel1.Controls.Add(this.label1);
            this.splashPanel1.DesktopAlignment = Syncfusion.Windows.Forms.Tools.SplashAlignment.LeftTop;
            this.splashPanel1.DiscreetLocation = new System.Drawing.Point(0, 0);
            this.splashPanel1.Location = new System.Drawing.Point(0, 5);
            this.splashPanel1.Name = "splashPanel1";
            this.splashPanel1.Size = new System.Drawing.Size(661, 63);
            this.splashPanel1.TabIndex = 139;
            this.splashPanel1.Text = "splashPanel1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 32);
            this.label1.TabIndex = 137;
            this.label1.Text = "PRIME TRADE :MANAGE DISTRIBUTION AREA";
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.BeforeTouchSize = new System.Drawing.Size(124, 41);
            this.materialRaisedButton3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Bump;
            this.materialRaisedButton3.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Browse;
            this.materialRaisedButton3.Image = global::PrimeTrade.Properties.Resources.reset;
            this.materialRaisedButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialRaisedButton3.IsBackStageButton = false;
            this.materialRaisedButton3.Location = new System.Drawing.Point(416, 252);
            this.materialRaisedButton3.MetroColor = System.Drawing.Color.Aqua;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.materialRaisedButton3.OverrideFormManagedColor = true;
            this.materialRaisedButton3.PushButton = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(124, 41);
            this.materialRaisedButton3.TabIndex = 148;
            this.materialRaisedButton3.Text = "RESET";
            this.materialRaisedButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.materialRaisedButton3.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.materialRaisedButton3.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.materialRaisedButton3.UseVisualStyle = false;
            this.materialRaisedButton3.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.BeforeTouchSize = new System.Drawing.Size(124, 41);
            this.materialRaisedButton2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Bump;
            this.materialRaisedButton2.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Browse;
            this.materialRaisedButton2.Image = global::PrimeTrade.Properties.Resources.remove;
            this.materialRaisedButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialRaisedButton2.IsBackStageButton = false;
            this.materialRaisedButton2.Location = new System.Drawing.Point(416, 205);
            this.materialRaisedButton2.MetroColor = System.Drawing.Color.Aqua;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.materialRaisedButton2.OverrideFormManagedColor = true;
            this.materialRaisedButton2.PushButton = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(124, 41);
            this.materialRaisedButton2.TabIndex = 147;
            this.materialRaisedButton2.Text = "REMOVE AREA";
            this.materialRaisedButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.materialRaisedButton2.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.materialRaisedButton2.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.materialRaisedButton2.UseVisualStyle = false;
            this.materialRaisedButton2.Click += new System.EventHandler(this.btndeletearea_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.BeforeTouchSize = new System.Drawing.Size(124, 41);
            this.materialRaisedButton1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Bump;
            this.materialRaisedButton1.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Browse;
            this.materialRaisedButton1.Image = global::PrimeTrade.Properties.Resources.update;
            this.materialRaisedButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialRaisedButton1.IsBackStageButton = false;
            this.materialRaisedButton1.Location = new System.Drawing.Point(416, 158);
            this.materialRaisedButton1.MetroColor = System.Drawing.Color.Aqua;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.materialRaisedButton1.OverrideFormManagedColor = true;
            this.materialRaisedButton1.PushButton = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(124, 41);
            this.materialRaisedButton1.TabIndex = 146;
            this.materialRaisedButton1.Text = "UPDATE AREA";
            this.materialRaisedButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.materialRaisedButton1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.materialRaisedButton1.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.materialRaisedButton1.UseVisualStyle = false;
            this.materialRaisedButton1.Click += new System.EventHandler(this.btnupdatearea_Click);
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(73, 41);
            this.buttonAdv2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Bump;
            this.buttonAdv2.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Browse;
            this.buttonAdv2.Image = global::PrimeTrade.Properties.Resources.error;
            this.buttonAdv2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv2.IsBackStageButton = false;
            this.buttonAdv2.Location = new System.Drawing.Point(467, 299);
            this.buttonAdv2.MetroColor = System.Drawing.Color.Aqua;
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.OverrideFormManagedColor = true;
            this.buttonAdv2.PushButton = true;
            this.buttonAdv2.Size = new System.Drawing.Size(73, 41);
            this.buttonAdv2.TabIndex = 145;
            this.buttonAdv2.Text = "Exit";
            this.buttonAdv2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdv2.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAdv2.UseVisualStyle = false;
            this.buttonAdv2.Click += new System.EventHandler(this.buttonAdv2_Click);
            // 
            // btnaddstock
            // 
            this.btnaddstock.BeforeTouchSize = new System.Drawing.Size(124, 41);
            this.btnaddstock.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Bump;
            this.btnaddstock.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Browse;
            this.btnaddstock.Image = global::PrimeTrade.Properties.Resources.add;
            this.btnaddstock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddstock.IsBackStageButton = false;
            this.btnaddstock.Location = new System.Drawing.Point(416, 111);
            this.btnaddstock.MetroColor = System.Drawing.Color.Aqua;
            this.btnaddstock.Name = "btnaddstock";
            this.btnaddstock.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.btnaddstock.OverrideFormManagedColor = true;
            this.btnaddstock.PushButton = true;
            this.btnaddstock.Size = new System.Drawing.Size(124, 41);
            this.btnaddstock.TabIndex = 144;
            this.btnaddstock.Text = "ADD AREA";
            this.btnaddstock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaddstock.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnaddstock.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnaddstock.UseVisualStyle = false;
            this.btnaddstock.Click += new System.EventHandler(this.btnaddarea_Click);
            // 
            // frmManagerManageArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 378);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.buttonAdv2);
            this.Controls.Add(this.btnaddstock);
            this.Controls.Add(this.splashPanel1);
            this.Controls.Add(this.txtareaid);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cmbprov);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Name = "frmManagerManageArea";
            this.Text = "Manage Distribution Area";
            this.splashPanel1.ResumeLayout(false);
            this.splashPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbprov;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtarea;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtareaid;
        private Syncfusion.Windows.Forms.Tools.SplashPanel splashPanel1;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.ButtonAdv materialRaisedButton3;
        private Syncfusion.Windows.Forms.ButtonAdv materialRaisedButton2;
        private Syncfusion.Windows.Forms.ButtonAdv materialRaisedButton1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
        private Syncfusion.Windows.Forms.ButtonAdv btnaddstock;
    }
}