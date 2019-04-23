namespace PrimeTrade
{
    partial class frmDistributersMySalesProgress
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbluserid = new MetroFramework.Controls.MetroLabel();
            this.chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).BeginInit();
            this.SuspendLayout();
            // 
            // lbluserid
            // 
            this.lbluserid.AutoSize = true;
            this.lbluserid.Location = new System.Drawing.Point(848, 32);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(0, 0);
            this.lbluserid.TabIndex = 0;
            this.lbluserid.Visible = false;
            // 
            // chartSales
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSales.Legends.Add(legend1);
            this.chartSales.Location = new System.Drawing.Point(36, 83);
            this.chartSales.Name = "chartSales";
            this.chartSales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Main Item Qty";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Attached Item QTY";
            series2.YValuesPerPoint = 2;
            this.chartSales.Series.Add(series1);
            this.chartSales.Series.Add(series2);
            this.chartSales.Size = new System.Drawing.Size(611, 413);
            this.chartSales.TabIndex = 1;
            this.chartSales.Text = "chart1";
            // 
            // frmDistributersMySalesProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 602);
            this.Controls.Add(this.chartSales);
            this.Controls.Add(this.lbluserid);
            this.Name = "frmDistributersMySalesProgress";
            this.Text = "My Sales Progress";
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbluserid;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;
    }
}