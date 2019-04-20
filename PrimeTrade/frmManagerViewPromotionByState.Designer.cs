namespace PrimeTrade
{
    partial class frmManagerViewPromotionByState
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
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader33 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader34 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader35 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader36 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader37 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader38 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader39 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader40 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader41 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader42 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader43 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbState = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader23,
            this.columnHeader31,
            this.columnHeader32,
            this.columnHeader33,
            this.columnHeader34,
            this.columnHeader35,
            this.columnHeader1,
            this.columnHeader36,
            this.columnHeader37,
            this.columnHeader2,
            this.columnHeader38,
            this.columnHeader39,
            this.columnHeader40,
            this.columnHeader41,
            this.columnHeader42,
            this.columnHeader43,
            this.columnHeader16});
            this.listView4.FullRowSelect = true;
            this.listView4.GridLines = true;
            this.listView4.Location = new System.Drawing.Point(24, 129);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(1217, 501);
            this.listView4.TabIndex = 105;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "PROMO CODE";
            this.columnHeader23.Width = 80;
            // 
            // columnHeader31
            // 
            this.columnHeader31.Text = "Distributer";
            this.columnHeader31.Width = 80;
            // 
            // columnHeader32
            // 
            this.columnHeader32.Text = "Promotion Name";
            this.columnHeader32.Width = 100;
            // 
            // columnHeader33
            // 
            this.columnHeader33.Text = "Promo Machanisum";
            this.columnHeader33.Width = 100;
            // 
            // columnHeader34
            // 
            this.columnHeader34.Text = "Promo Dec";
            this.columnHeader34.Width = 100;
            // 
            // columnHeader35
            // 
            this.columnHeader35.Text = "Main Item";
            this.columnHeader35.Width = 80;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item Name";
            // 
            // columnHeader36
            // 
            this.columnHeader36.Text = "Left QTY";
            // 
            // columnHeader37
            // 
            this.columnHeader37.Text = "Attaced Item";
            this.columnHeader37.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item Name";
            // 
            // columnHeader38
            // 
            this.columnHeader38.Text = "Left QTY";
            // 
            // columnHeader39
            // 
            this.columnHeader39.Text = "From Date";
            this.columnHeader39.Width = 80;
            // 
            // columnHeader40
            // 
            this.columnHeader40.Text = "Until Date";
            this.columnHeader40.Width = 80;
            // 
            // columnHeader41
            // 
            this.columnHeader41.Text = "Comments";
            this.columnHeader41.Width = 100;
            // 
            // columnHeader42
            // 
            this.columnHeader42.Text = "Active State";
            this.columnHeader42.Width = 100;
            // 
            // columnHeader43
            // 
            this.columnHeader43.Text = "Left Days";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Track State";
            this.columnHeader16.Width = 80;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(409, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(147, 19);
            this.metroLabel1.TabIndex = 107;
            this.metroLabel1.Text = "Search by Process State";
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.ItemHeight = 23;
            this.cmbState.Items.AddRange(new object[] {
            "APPROVED",
            "ONSALES",
            "FINANCEAPROVE"});
            this.cmbState.Location = new System.Drawing.Point(557, 84);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(242, 29);
            this.cmbState.TabIndex = 106;
            this.cmbState.UseSelectable = true;
            this.cmbState.SelectedIndexChanged += new System.EventHandler(this.cmbState_SelectedIndexChanged);
            // 
            // frmManagerViewPromotionByState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 653);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.listView4);
            this.Name = "frmManagerViewPromotionByState";
            this.Text = "Promotion Information By State";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader31;
        private System.Windows.Forms.ColumnHeader columnHeader32;
        private System.Windows.Forms.ColumnHeader columnHeader33;
        private System.Windows.Forms.ColumnHeader columnHeader34;
        private System.Windows.Forms.ColumnHeader columnHeader35;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader36;
        private System.Windows.Forms.ColumnHeader columnHeader37;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader38;
        private System.Windows.Forms.ColumnHeader columnHeader39;
        private System.Windows.Forms.ColumnHeader columnHeader40;
        private System.Windows.Forms.ColumnHeader columnHeader41;
        private System.Windows.Forms.ColumnHeader columnHeader42;
        private System.Windows.Forms.ColumnHeader columnHeader43;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbState;
    }
}