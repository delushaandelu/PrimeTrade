namespace PrimeTrade
{
    partial class frmDistributorReqStock
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
            this.splashPanel1 = new Syncfusion.Windows.Forms.Tools.SplashPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.listView4 = new System.Windows.Forms.ListView();
            this.btnClose = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnrequest = new Syncfusion.Windows.Forms.ButtonAdv();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtcomment = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtqty = new MetroFramework.Controls.MetroTextBox();
            this.txtfordate = new MetroFramework.Controls.MetroDateTime();
            this.cmbstock = new System.Windows.Forms.ComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lbluser = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splashPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splashPanel1
            // 
            this.splashPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.CornflowerBlue, System.Drawing.Color.RoyalBlue);
            this.splashPanel1.BeforeTouchSize = new System.Drawing.Size(1263, 63);
            this.splashPanel1.Controls.Add(this.label1);
            this.splashPanel1.DesktopAlignment = Syncfusion.Windows.Forms.Tools.SplashAlignment.LeftTop;
            this.splashPanel1.DiscreetLocation = new System.Drawing.Point(0, 0);
            this.splashPanel1.Location = new System.Drawing.Point(-1, 5);
            this.splashPanel1.Name = "splashPanel1";
            this.splashPanel1.Size = new System.Drawing.Size(1263, 63);
            this.splashPanel1.TabIndex = 142;
            this.splashPanel1.Text = "splashPanel1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 37);
            this.label1.TabIndex = 137;
            this.label1.Text = "PRIME TRADE : REQUEST NEW STOCK";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 235);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(127, 19);
            this.metroLabel2.TabIndex = 141;
            this.metroLabel2.Text = "Request Information";
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView4.FullRowSelect = true;
            this.listView4.GridLines = true;
            this.listView4.Location = new System.Drawing.Point(23, 268);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(719, 391);
            this.listView4.TabIndex = 140;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // btnClose
            // 
            this.btnClose.BeforeTouchSize = new System.Drawing.Size(73, 41);
            this.btnClose.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Bump;
            this.btnClose.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Browse;
            this.btnClose.Image = global::PrimeTrade.Properties.Resources.error;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.IsBackStageButton = false;
            this.btnClose.Location = new System.Drawing.Point(602, 139);
            this.btnClose.MetroColor = System.Drawing.Color.Aqua;
            this.btnClose.Name = "btnClose";
            this.btnClose.OverrideFormManagedColor = true;
            this.btnClose.PushButton = true;
            this.btnClose.Size = new System.Drawing.Size(73, 41);
            this.btnClose.TabIndex = 143;
            this.btnClose.Text = "Exit";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.UseVisualStyle = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnrequest
            // 
            this.btnrequest.BeforeTouchSize = new System.Drawing.Size(127, 41);
            this.btnrequest.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Bump;
            this.btnrequest.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Browse;
            this.btnrequest.Image = global::PrimeTrade.Properties.Resources.success;
            this.btnrequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrequest.IsBackStageButton = false;
            this.btnrequest.Location = new System.Drawing.Point(548, 89);
            this.btnrequest.MetroColor = System.Drawing.Color.Aqua;
            this.btnrequest.Name = "btnrequest";
            this.btnrequest.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.btnrequest.OverrideFormManagedColor = true;
            this.btnrequest.PushButton = true;
            this.btnrequest.Size = new System.Drawing.Size(127, 41);
            this.btnrequest.TabIndex = 150;
            this.btnrequest.Text = "Request Stock";
            this.btnrequest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnrequest.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnrequest.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnrequest.UseVisualStyle = false;
            this.btnrequest.Click += new System.EventHandler(this.btnrequest_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(168, 204);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(73, 19);
            this.metroLabel3.TabIndex = 149;
            this.metroLabel3.Text = "Comments";
            // 
            // txtcomment
            // 
            // 
            // 
            // 
            this.txtcomment.CustomButton.Image = null;
            this.txtcomment.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtcomment.CustomButton.Name = "";
            this.txtcomment.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtcomment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtcomment.CustomButton.TabIndex = 1;
            this.txtcomment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtcomment.CustomButton.UseSelectable = true;
            this.txtcomment.CustomButton.Visible = false;
            this.txtcomment.Lines = new string[0];
            this.txtcomment.Location = new System.Drawing.Point(281, 204);
            this.txtcomment.MaxLength = 32767;
            this.txtcomment.Name = "txtcomment";
            this.txtcomment.PasswordChar = '\0';
            this.txtcomment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcomment.SelectedText = "";
            this.txtcomment.SelectionLength = 0;
            this.txtcomment.SelectionStart = 0;
            this.txtcomment.ShortcutsEnabled = true;
            this.txtcomment.Size = new System.Drawing.Size(200, 23);
            this.txtcomment.TabIndex = 148;
            this.txtcomment.UseSelectable = true;
            this.txtcomment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtcomment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(168, 161);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 19);
            this.metroLabel1.TabIndex = 147;
            this.metroLabel1.Text = "For Date";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(168, 124);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(30, 19);
            this.metroLabel4.TabIndex = 145;
            this.metroLabel4.Text = "Qty";
            // 
            // txtqty
            // 
            // 
            // 
            // 
            this.txtqty.CustomButton.Image = null;
            this.txtqty.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtqty.CustomButton.Name = "";
            this.txtqty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtqty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtqty.CustomButton.TabIndex = 1;
            this.txtqty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtqty.CustomButton.UseSelectable = true;
            this.txtqty.CustomButton.Visible = false;
            this.txtqty.Lines = new string[0];
            this.txtqty.Location = new System.Drawing.Point(281, 124);
            this.txtqty.MaxLength = 32767;
            this.txtqty.Name = "txtqty";
            this.txtqty.PasswordChar = '\0';
            this.txtqty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtqty.SelectedText = "";
            this.txtqty.SelectionLength = 0;
            this.txtqty.SelectionStart = 0;
            this.txtqty.ShortcutsEnabled = true;
            this.txtqty.Size = new System.Drawing.Size(200, 23);
            this.txtqty.TabIndex = 144;
            this.txtqty.UseSelectable = true;
            this.txtqty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtqty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtfordate
            // 
            this.txtfordate.Location = new System.Drawing.Point(281, 161);
            this.txtfordate.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtfordate.Name = "txtfordate";
            this.txtfordate.Size = new System.Drawing.Size(200, 29);
            this.txtfordate.TabIndex = 151;
            // 
            // cmbstock
            // 
            this.cmbstock.FormattingEnabled = true;
            this.cmbstock.Location = new System.Drawing.Point(281, 87);
            this.cmbstock.Name = "cmbstock";
            this.cmbstock.Size = new System.Drawing.Size(200, 21);
            this.cmbstock.TabIndex = 152;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(168, 89);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(40, 19);
            this.metroLabel5.TabIndex = 153;
            this.metroLabel5.Text = "Stock";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(626, 198);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(0, 13);
            this.lbluser.TabIndex = 154;
            this.lbluser.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Stock ID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "QTY";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "For Date";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Comments";
            this.columnHeader5.Width = 260;
            // 
            // frmDistributorReqStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 692);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cmbstock);
            this.Controls.Add(this.txtfordate);
            this.Controls.Add(this.btnrequest);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtcomment);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.splashPanel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.listView4);
            this.Name = "frmDistributorReqStock";
            this.Text = "frmDistributorReqStock";
            this.splashPanel1.ResumeLayout(false);
            this.splashPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.SplashPanel splashPanel1;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.ButtonAdv btnClose;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ListView listView4;
        private Syncfusion.Windows.Forms.ButtonAdv btnrequest;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtcomment;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtqty;
        private MetroFramework.Controls.MetroDateTime txtfordate;
        private System.Windows.Forms.ComboBox cmbstock;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}