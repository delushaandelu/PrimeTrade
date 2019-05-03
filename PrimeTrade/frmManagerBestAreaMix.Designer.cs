namespace PrimeTrade
{
    partial class frmManagerBestAreaMix
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
            this.label1 = new System.Windows.Forms.Label();
            this.splashPanel1 = new Syncfusion.Windows.Forms.Tools.SplashPanel();
            this.txtmac = new MetroFramework.Controls.MetroComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.splashPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 32);
            this.label1.TabIndex = 137;
            this.label1.Text = "PRIME TRADE :INTORODUICE PROMOTION";
            // 
            // splashPanel1
            // 
            this.splashPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.CornflowerBlue, System.Drawing.Color.RoyalBlue);
            this.splashPanel1.BeforeTouchSize = new System.Drawing.Size(800, 63);
            this.splashPanel1.Controls.Add(this.label1);
            this.splashPanel1.DesktopAlignment = Syncfusion.Windows.Forms.Tools.SplashAlignment.LeftTop;
            this.splashPanel1.DiscreetLocation = new System.Drawing.Point(0, 0);
            this.splashPanel1.Location = new System.Drawing.Point(0, 5);
            this.splashPanel1.Name = "splashPanel1";
            this.splashPanel1.Size = new System.Drawing.Size(800, 63);
            this.splashPanel1.TabIndex = 150;
            this.splashPanel1.Text = "INTRODUICE PROMOTION";
            // 
            // txtmac
            // 
            this.txtmac.FormattingEnabled = true;
            this.txtmac.ItemHeight = 23;
            this.txtmac.Items.AddRange(new object[] {
            "Buy one get one free",
            "Free 3rd party item",
            "Free pack with another SKU"});
            this.txtmac.Location = new System.Drawing.Point(253, 99);
            this.txtmac.Name = "txtmac";
            this.txtmac.Size = new System.Drawing.Size(399, 29);
            this.txtmac.TabIndex = 152;
            this.txtmac.UseSelectable = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(73, 103);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(162, 19);
            this.materialLabel1.TabIndex = 151;
            this.materialLabel1.Text = "Promotion Mechanism";
            // 
            // frmManagerBestAreaMix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 790);
            this.Controls.Add(this.txtmac);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.splashPanel1);
            this.Name = "frmManagerBestAreaMix";
            this.splashPanel1.ResumeLayout(false);
            this.splashPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.SplashPanel splashPanel1;
        private MetroFramework.Controls.MetroComboBox txtmac;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}