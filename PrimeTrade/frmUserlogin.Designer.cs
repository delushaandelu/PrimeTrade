namespace PrimeTrade
{
    partial class frmUserlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserlogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtusername = new MetroFramework.Controls.MetroTextBox();
            this.txtpassword = new MetroFramework.Controls.MetroTextBox();
            this.cmbusertype = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(149, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtusername
            // 
            // 
            // 
            // 
            this.txtusername.CustomButton.Image = null;
            this.txtusername.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.txtusername.CustomButton.Name = "";
            this.txtusername.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtusername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtusername.CustomButton.TabIndex = 1;
            this.txtusername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtusername.CustomButton.UseSelectable = true;
            this.txtusername.CustomButton.Visible = false;
            this.txtusername.Lines = new string[0];
            this.txtusername.Location = new System.Drawing.Point(102, 181);
            this.txtusername.MaxLength = 32767;
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.PromptText = "Username";
            this.txtusername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtusername.SelectedText = "";
            this.txtusername.SelectionLength = 0;
            this.txtusername.SelectionStart = 0;
            this.txtusername.ShortcutsEnabled = true;
            this.txtusername.Size = new System.Drawing.Size(202, 30);
            this.txtusername.TabIndex = 2;
            this.txtusername.Tag = "";
            this.txtusername.UseSelectable = true;
            this.txtusername.WaterMark = "Username";
            this.txtusername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtusername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtpassword
            // 
            // 
            // 
            // 
            this.txtpassword.CustomButton.Image = null;
            this.txtpassword.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.txtpassword.CustomButton.Name = "";
            this.txtpassword.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtpassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpassword.CustomButton.TabIndex = 1;
            this.txtpassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpassword.CustomButton.UseSelectable = true;
            this.txtpassword.CustomButton.Visible = false;
            this.txtpassword.Lines = new string[0];
            this.txtpassword.Location = new System.Drawing.Point(102, 220);
            this.txtpassword.MaxLength = 32767;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.PromptText = "Password";
            this.txtpassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpassword.SelectedText = "";
            this.txtpassword.SelectionLength = 0;
            this.txtpassword.SelectionStart = 0;
            this.txtpassword.ShortcutsEnabled = true;
            this.txtpassword.Size = new System.Drawing.Size(202, 30);
            this.txtpassword.TabIndex = 4;
            this.txtpassword.UseSelectable = true;
            this.txtpassword.WaterMark = "Password";
            this.txtpassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbusertype
            // 
            this.cmbusertype.FormattingEnabled = true;
            this.cmbusertype.ItemHeight = 23;
            this.cmbusertype.Items.AddRange(new object[] {
            "FINANCE",
            "BRAND MANAGER",
            "SYSTEM ADMIN",
            "SALES",
            "DISTRIBUTER"});
            this.cmbusertype.Location = new System.Drawing.Point(102, 273);
            this.cmbusertype.Name = "cmbusertype";
            this.cmbusertype.Size = new System.Drawing.Size(202, 29);
            this.cmbusertype.TabIndex = 5;
            this.cmbusertype.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(102, 255);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 15);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "User Type";
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroButton1.Location = new System.Drawing.Point(306, 431);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(69, 24);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Cancel";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(149, 331);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(122, 38);
            this.metroTile1.TabIndex = 9;
            this.metroTile1.Text = "Login";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // frmUserlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(398, 467);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cmbusertype);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserlogin";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "PRIME TRADE";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtusername;
        private MetroFramework.Controls.MetroTextBox txtpassword;
        private MetroFramework.Controls.MetroComboBox cmbusertype;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}