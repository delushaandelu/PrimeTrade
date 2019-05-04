namespace PrimeTrade
{
    partial class ManagerViewPromotionByDistributers
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
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbDistributers = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.splashPanel1 = new Syncfusion.Windows.Forms.Tools.SplashPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.splashPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader27,
            this.columnHeader28,
            this.columnHeader29,
            this.columnHeader30,
            this.columnHeader1});
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(36, 155);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(967, 519);
            this.listView3.TabIndex = 96;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Distributer Name";
            this.columnHeader24.Width = 120;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Promotion";
            this.columnHeader25.Width = 120;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "Promo Machanisum";
            this.columnHeader26.Width = 120;
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "Promo Des";
            this.columnHeader27.Width = 120;
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "From Date";
            this.columnHeader28.Width = 120;
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "Until Date";
            this.columnHeader29.Width = 120;
            // 
            // columnHeader30
            // 
            this.columnHeader30.Text = "Comments";
            this.columnHeader30.Width = 120;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Status";
            this.columnHeader1.Width = 120;
            // 
            // cmbDistributers
            // 
            this.cmbDistributers.FormattingEnabled = true;
            this.cmbDistributers.ItemHeight = 23;
            this.cmbDistributers.Location = new System.Drawing.Point(458, 98);
            this.cmbDistributers.Name = "cmbDistributers";
            this.cmbDistributers.Size = new System.Drawing.Size(270, 29);
            this.cmbDistributers.TabIndex = 97;
            this.cmbDistributers.UseSelectable = true;
            this.cmbDistributers.SelectedValueChanged += new System.EventHandler(this.cmbDistributers_SelectedValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(281, 104);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(154, 19);
            this.metroLabel1.TabIndex = 98;
            this.metroLabel1.Text = "Select a Distributer Code";
            // 
            // splashPanel1
            // 
            this.splashPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.CornflowerBlue, System.Drawing.Color.RoyalBlue);
            this.splashPanel1.BeforeTouchSize = new System.Drawing.Size(1044, 63);
            this.splashPanel1.Controls.Add(this.label1);
            this.splashPanel1.DesktopAlignment = Syncfusion.Windows.Forms.Tools.SplashAlignment.LeftTop;
            this.splashPanel1.DiscreetLocation = new System.Drawing.Point(0, 0);
            this.splashPanel1.Location = new System.Drawing.Point(0, 4);
            this.splashPanel1.Name = "splashPanel1";
            this.splashPanel1.Size = new System.Drawing.Size(1044, 63);
            this.splashPanel1.TabIndex = 147;
            this.splashPanel1.Text = "splashPanel1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(674, 32);
            this.label1.TabIndex = 137;
            this.label1.Text = "PRIME TRADE :VIEW ALL PROMOTIONS BY DISTRIBUTERS";
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(73, 41);
            this.buttonAdv2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Bump;
            this.buttonAdv2.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Browse;
            this.buttonAdv2.Image = global::PrimeTrade.Properties.Resources.error;
            this.buttonAdv2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv2.IsBackStageButton = false;
            this.buttonAdv2.Location = new System.Drawing.Point(930, 680);
            this.buttonAdv2.MetroColor = System.Drawing.Color.Aqua;
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.OverrideFormManagedColor = true;
            this.buttonAdv2.PushButton = true;
            this.buttonAdv2.Size = new System.Drawing.Size(73, 41);
            this.buttonAdv2.TabIndex = 148;
            this.buttonAdv2.Text = "Exit";
            this.buttonAdv2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdv2.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAdv2.UseVisualStyle = false;
            this.buttonAdv2.Click += new System.EventHandler(this.buttonAdv2_Click);
            // 
            // ManagerViewPromotionByDistributers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 738);
            this.Controls.Add(this.buttonAdv2);
            this.Controls.Add(this.splashPanel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbDistributers);
            this.Controls.Add(this.listView3);
            this.Name = "ManagerViewPromotionByDistributers";
            this.Text = "View All promotions By Distributers";
            this.splashPanel1.ResumeLayout(false);
            this.splashPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.ColumnHeader columnHeader29;
        private System.Windows.Forms.ColumnHeader columnHeader30;
        private MetroFramework.Controls.MetroComboBox cmbDistributers;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private Syncfusion.Windows.Forms.Tools.SplashPanel splashPanel1;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
    }
}