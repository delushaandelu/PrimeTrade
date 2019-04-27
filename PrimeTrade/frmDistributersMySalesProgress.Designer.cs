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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbluserid = new MetroFramework.Controls.MetroLabel();
            this.chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CmbPromotion = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnClearChart = new MetroFramework.Controls.MetroButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.chartSales.Location = new System.Drawing.Point(41, 138);
            this.chartSales.Name = "chartSales";
            this.chartSales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
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
            this.chartSales.Size = new System.Drawing.Size(1310, 586);
            this.chartSales.TabIndex = 1;
            this.chartSales.Text = "chart1";
            this.chartSales.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartSales_MouseMove);
            // 
            // CmbPromotion
            // 
            this.CmbPromotion.FormattingEnabled = true;
            this.CmbPromotion.ItemHeight = 23;
            this.CmbPromotion.Location = new System.Drawing.Point(517, 84);
            this.CmbPromotion.Name = "CmbPromotion";
            this.CmbPromotion.Size = new System.Drawing.Size(317, 29);
            this.CmbPromotion.TabIndex = 2;
            this.CmbPromotion.UseSelectable = true;
            this.CmbPromotion.SelectedIndexChanged += new System.EventHandler(this.CmbPromotion_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(339, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(157, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Select a Promotion Code";
            // 
            // btnClearChart
            // 
            this.btnClearChart.Location = new System.Drawing.Point(1178, 304);
            this.btnClearChart.Name = "btnClearChart";
            this.btnClearChart.Size = new System.Drawing.Size(75, 23);
            this.btnClearChart.TabIndex = 4;
            this.btnClearChart.Text = "Clear";
            this.btnClearChart.UseSelectable = true;
            this.btnClearChart.Click += new System.EventHandler(this.btnClearChart_Click);
            // 
            // frmDistributersMySalesProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 795);
            this.Controls.Add(this.btnClearChart);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CmbPromotion);
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
        private MetroFramework.Controls.MetroComboBox CmbPromotion;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnClearChart;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}