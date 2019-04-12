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
            this.cmbprov = new System.Windows.Forms.ComboBox();
            this.txtarea = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnReset = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btndeletearea = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnupdatearea = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnaddarea = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtareaid = new MaterialSkin.Controls.MaterialSingleLineTextField();
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
            // btnReset
            // 
            this.btnReset.Depth = 0;
            this.btnReset.Location = new System.Drawing.Point(480, 136);
            this.btnReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReset.Name = "btnReset";
            this.btnReset.Primary = true;
            this.btnReset.Size = new System.Drawing.Size(107, 25);
            this.btnReset.TabIndex = 47;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btndeletearea
            // 
            this.btndeletearea.Depth = 0;
            this.btndeletearea.Location = new System.Drawing.Point(367, 136);
            this.btndeletearea.MouseState = MaterialSkin.MouseState.HOVER;
            this.btndeletearea.Name = "btndeletearea";
            this.btndeletearea.Primary = true;
            this.btndeletearea.Size = new System.Drawing.Size(107, 25);
            this.btndeletearea.TabIndex = 46;
            this.btndeletearea.Text = "Delete Area";
            this.btndeletearea.UseVisualStyleBackColor = true;
            this.btndeletearea.Click += new System.EventHandler(this.btndeletearea_Click);
            // 
            // btnupdatearea
            // 
            this.btnupdatearea.Depth = 0;
            this.btnupdatearea.Location = new System.Drawing.Point(480, 98);
            this.btnupdatearea.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnupdatearea.Name = "btnupdatearea";
            this.btnupdatearea.Primary = true;
            this.btnupdatearea.Size = new System.Drawing.Size(107, 25);
            this.btnupdatearea.TabIndex = 45;
            this.btnupdatearea.Text = "UPDATE Area";
            this.btnupdatearea.UseVisualStyleBackColor = true;
            this.btnupdatearea.Click += new System.EventHandler(this.btnupdatearea_Click);
            // 
            // btnaddarea
            // 
            this.btnaddarea.Depth = 0;
            this.btnaddarea.Location = new System.Drawing.Point(367, 98);
            this.btnaddarea.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnaddarea.Name = "btnaddarea";
            this.btnaddarea.Primary = true;
            this.btnaddarea.Size = new System.Drawing.Size(107, 25);
            this.btnaddarea.TabIndex = 44;
            this.btnaddarea.Text = "Add Area";
            this.btnaddarea.UseVisualStyleBackColor = true;
            this.btnaddarea.Click += new System.EventHandler(this.btnaddarea_Click);
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
            // frmManagerManageArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 378);
            this.Controls.Add(this.txtareaid);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btndeletearea);
            this.Controls.Add(this.btnupdatearea);
            this.Controls.Add(this.btnaddarea);
            this.Controls.Add(this.cmbprov);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Name = "frmManagerManageArea";
            this.Text = "Manage Distribution Area";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbprov;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtarea;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnReset;
        private MaterialSkin.Controls.MaterialRaisedButton btndeletearea;
        private MaterialSkin.Controls.MaterialRaisedButton btnupdatearea;
        private MaterialSkin.Controls.MaterialRaisedButton btnaddarea;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtareaid;
    }
}