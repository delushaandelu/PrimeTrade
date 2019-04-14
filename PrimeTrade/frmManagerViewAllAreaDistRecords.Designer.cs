namespace PrimeTrade
{
    partial class frmManagerViewAllAreaDistRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagerViewAllAreaDistRecords));
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.cmbDistributers = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmbarea = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmbprovince = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader26});
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(45, 164);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(794, 502);
            this.listView3.TabIndex = 64;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Record ID";
            this.columnHeader20.Width = 80;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "First Name";
            this.columnHeader21.Width = 120;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Area Name";
            this.columnHeader22.Width = 105;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Province";
            this.columnHeader23.Width = 100;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Email";
            this.columnHeader24.Width = 140;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Telephone";
            this.columnHeader25.Width = 120;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "Joined Date";
            this.columnHeader26.Width = 120;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.Location = new System.Drawing.Point(845, 108);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(32, 32);
            this.btnRefresh.TabIndex = 77;
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbDistributers
            // 
            this.cmbDistributers.FormattingEnabled = true;
            this.cmbDistributers.ItemHeight = 23;
            this.cmbDistributers.Location = new System.Drawing.Point(45, 108);
            this.cmbDistributers.Name = "cmbDistributers";
            this.cmbDistributers.Size = new System.Drawing.Size(242, 29);
            this.cmbDistributers.TabIndex = 78;
            this.cmbDistributers.UseSelectable = true;
            this.cmbDistributers.SelectedIndexChanged += new System.EventHandler(this.cmbDistributers_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(45, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(121, 19);
            this.metroLabel1.TabIndex = 79;
            this.metroLabel1.Text = "Sort by Distributers";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(324, 86);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 19);
            this.metroLabel2.TabIndex = 81;
            this.metroLabel2.Text = "Sort by Area";
            // 
            // cmbarea
            // 
            this.cmbarea.FormattingEnabled = true;
            this.cmbarea.ItemHeight = 23;
            this.cmbarea.Location = new System.Drawing.Point(324, 108);
            this.cmbarea.Name = "cmbarea";
            this.cmbarea.Size = new System.Drawing.Size(242, 29);
            this.cmbarea.TabIndex = 80;
            this.cmbarea.UseSelectable = true;
            this.cmbarea.SelectedIndexChanged += new System.EventHandler(this.cmbarea_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(597, 86);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(106, 19);
            this.metroLabel3.TabIndex = 83;
            this.metroLabel3.Text = "Sort by Province";
            // 
            // cmbprovince
            // 
            this.cmbprovince.FormattingEnabled = true;
            this.cmbprovince.ItemHeight = 23;
            this.cmbprovince.Location = new System.Drawing.Point(597, 108);
            this.cmbprovince.Name = "cmbprovince";
            this.cmbprovince.Size = new System.Drawing.Size(242, 29);
            this.cmbprovince.TabIndex = 82;
            this.cmbprovince.UseSelectable = true;
            this.cmbprovince.SelectedIndexChanged += new System.EventHandler(this.cmbprovince_SelectedIndexChanged);
            // 
            // frmManagerViewAllAreaDistRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 695);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cmbprovince);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cmbarea);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbDistributers);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.listView3);
            this.Name = "frmManagerViewAllAreaDistRecords";
            this.Text = "All ares and assigned distributers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroComboBox cmbDistributers;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cmbarea;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cmbprovince;
    }
}