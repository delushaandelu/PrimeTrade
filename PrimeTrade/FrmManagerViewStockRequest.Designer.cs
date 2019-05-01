namespace PrimeTrade
{
    partial class FrmManagerViewStockRequest
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.splashPanel1 = new Syncfusion.Windows.Forms.Tools.SplashPanel();
            this.btnClose = new Syncfusion.Windows.Forms.ButtonAdv();
            this.splashPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(10, 78);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(127, 19);
            this.metroLabel2.TabIndex = 145;
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
            this.listView4.Location = new System.Drawing.Point(15, 111);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(719, 391);
            this.listView4.TabIndex = 144;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
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
            // splashPanel1
            // 
            this.splashPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.CornflowerBlue, System.Drawing.Color.RoyalBlue);
            this.splashPanel1.BeforeTouchSize = new System.Drawing.Size(1263, 63);
            this.splashPanel1.Controls.Add(this.label1);
            this.splashPanel1.DesktopAlignment = Syncfusion.Windows.Forms.Tools.SplashAlignment.LeftTop;
            this.splashPanel1.DiscreetLocation = new System.Drawing.Point(0, 0);
            this.splashPanel1.Location = new System.Drawing.Point(0, 5);
            this.splashPanel1.Name = "splashPanel1";
            this.splashPanel1.Size = new System.Drawing.Size(1263, 63);
            this.splashPanel1.TabIndex = 146;
            this.splashPanel1.Text = "splashPanel1";
            // 
            // btnClose
            // 
            this.btnClose.BeforeTouchSize = new System.Drawing.Size(73, 41);
            this.btnClose.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Bump;
            this.btnClose.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Browse;
            this.btnClose.Image = global::PrimeTrade.Properties.Resources.error;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.IsBackStageButton = false;
            this.btnClose.Location = new System.Drawing.Point(656, 508);
            this.btnClose.MetroColor = System.Drawing.Color.Aqua;
            this.btnClose.Name = "btnClose";
            this.btnClose.OverrideFormManagedColor = true;
            this.btnClose.PushButton = true;
            this.btnClose.Size = new System.Drawing.Size(73, 41);
            this.btnClose.TabIndex = 147;
            this.btnClose.Text = "Exit";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.UseVisualStyle = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmManagerViewStockRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 561);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.splashPanel1);
            this.Controls.Add(this.btnClose);
            this.Name = "FrmManagerViewStockRequest";
            this.Text = "FrmManagerViewStockRequest";
            this.splashPanel1.ResumeLayout(false);
            this.splashPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.SplashPanel splashPanel1;
        private Syncfusion.Windows.Forms.ButtonAdv btnClose;
    }
}