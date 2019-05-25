namespace PrimeTrade
{
    partial class frmReportViewer
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
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.dataSetGoogleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGoogle = new PrimeTrade.DataSetGoogle();
            this.baseDataSet = new PrimeTrade.baseDataSet();
            this.viewallusersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_all_usersTableAdapter = new PrimeTrade.baseDataSetTableAdapters.view_all_usersTableAdapter();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGoogleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGoogle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewallusersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(731, 452);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dataSetGoogleBindingSource
            // 
            this.dataSetGoogleBindingSource.DataSource = this.dataSetGoogle;
            this.dataSetGoogleBindingSource.Position = 0;
            // 
            // dataSetGoogle
            // 
            this.dataSetGoogle.DataSetName = "DataSetGoogle";
            this.dataSetGoogle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // baseDataSet
            // 
            this.baseDataSet.DataSetName = "baseDataSet";
            this.baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewallusersBindingSource
            // 
            this.viewallusersBindingSource.DataMember = "view_all_users";
            this.viewallusersBindingSource.DataSource = this.baseDataSet;
            // 
            // view_all_usersTableAdapter
            // 
            this.view_all_usersTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(40, 79);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(776, 351);
            this.dataGridView.TabIndex = 1;
            // 
            // frmReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 485);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnPrint);
            this.Name = "frmReportViewer";
            this.Text = "Print Users";
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGoogleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGoogle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewallusersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnPrint;
        private System.Windows.Forms.BindingSource dataSetGoogleBindingSource;
        private DataSetGoogle dataSetGoogle;
        private baseDataSet baseDataSet;
        private System.Windows.Forms.BindingSource viewallusersBindingSource;
        private baseDataSetTableAdapters.view_all_usersTableAdapter view_all_usersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}