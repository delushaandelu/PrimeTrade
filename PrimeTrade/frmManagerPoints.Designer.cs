namespace PrimeTrade
{
    partial class frmManagerPoints
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
            this.label1 = new System.Windows.Forms.Label();
            this.splashPanel1 = new Syncfusion.Windows.Forms.Tools.SplashPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialRaisedButton2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.splashPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 32);
            this.label1.TabIndex = 137;
            this.label1.Text = "PRIME TRADE :DISTRIBUTOR REWARDS";
            // 
            // splashPanel1
            // 
            this.splashPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.CornflowerBlue, System.Drawing.Color.RoyalBlue);
            this.splashPanel1.BeforeTouchSize = new System.Drawing.Size(801, 63);
            this.splashPanel1.Controls.Add(this.label1);
            this.splashPanel1.DesktopAlignment = Syncfusion.Windows.Forms.Tools.SplashAlignment.LeftTop;
            this.splashPanel1.DiscreetLocation = new System.Drawing.Point(0, 0);
            this.splashPanel1.Location = new System.Drawing.Point(0, 4);
            this.splashPanel1.Name = "splashPanel1";
            this.splashPanel1.Size = new System.Drawing.Size(801, 63);
            this.splashPanel1.TabIndex = 149;
            this.splashPanel1.Text = "splashPanel1";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(23, 85);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(552, 293);
            this.listView1.TabIndex = 148;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Distributers";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Rewards Information";
            this.columnHeader2.Width = 400;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.BeforeTouchSize = new System.Drawing.Size(124, 41);
            this.materialRaisedButton2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Bump;
            this.materialRaisedButton2.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Browse;
            this.materialRaisedButton2.Image = global::PrimeTrade.Properties.Resources.remove;
            this.materialRaisedButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialRaisedButton2.IsBackStageButton = false;
            this.materialRaisedButton2.Location = new System.Drawing.Point(598, 85);
            this.materialRaisedButton2.MetroColor = System.Drawing.Color.Aqua;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.materialRaisedButton2.OverrideFormManagedColor = true;
            this.materialRaisedButton2.PushButton = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(124, 41);
            this.materialRaisedButton2.TabIndex = 151;
            this.materialRaisedButton2.Text = "REMOVE LINE";
            this.materialRaisedButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.materialRaisedButton2.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.materialRaisedButton2.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.materialRaisedButton2.UseVisualStyle = false;
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(73, 41);
            this.buttonAdv2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Bump;
            this.buttonAdv2.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Browse;
            this.buttonAdv2.Image = global::PrimeTrade.Properties.Resources.error;
            this.buttonAdv2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv2.IsBackStageButton = false;
            this.buttonAdv2.Location = new System.Drawing.Point(649, 132);
            this.buttonAdv2.MetroColor = System.Drawing.Color.Aqua;
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.OverrideFormManagedColor = true;
            this.buttonAdv2.PushButton = true;
            this.buttonAdv2.Size = new System.Drawing.Size(73, 41);
            this.buttonAdv2.TabIndex = 150;
            this.buttonAdv2.Text = "Exit";
            this.buttonAdv2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdv2.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAdv2.UseVisualStyle = false;
            this.buttonAdv2.Click += new System.EventHandler(this.buttonAdv2_Click);
            // 
            // frmManagerPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 401);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.buttonAdv2);
            this.Controls.Add(this.splashPanel1);
            this.Controls.Add(this.listView1);
            this.Name = "frmManagerPoints";
            this.Text = "frmManagerPoints";
            this.splashPanel1.ResumeLayout(false);
            this.splashPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.ButtonAdv materialRaisedButton2;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
        private Syncfusion.Windows.Forms.Tools.SplashPanel splashPanel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}