namespace PrimeTrade
{
    partial class frmManagerDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 40D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 50D);
            this.salesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbpromotion = new MetroFramework.Controls.MetroComboBox();
            this.cmbdistributer = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnSearchTeacher = new System.Windows.Forms.Button();
            this.tileStockRange = new System.Windows.Forms.Button();
            this.tileDistributer = new System.Windows.Forms.Button();
            this.tileArea = new System.Windows.Forms.Button();
            this.tileSalesRate = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tileDistributers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.salesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileDistributers)).BeginInit();
            this.SuspendLayout();
            // 
            // salesChart
            // 
            chartArea5.Name = "ChartArea1";
            this.salesChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.salesChart.Legends.Add(legend5);
            this.salesChart.Location = new System.Drawing.Point(43, 102);
            this.salesChart.Name = "salesChart";
            this.salesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Main Item Qty";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Attached Item QTY";
            this.salesChart.Series.Add(series9);
            this.salesChart.Series.Add(series10);
            this.salesChart.Size = new System.Drawing.Size(659, 405);
            this.salesChart.TabIndex = 0;
            this.salesChart.Text = "chart1";
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(43, 545);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "Series2";
            series12.YValuesPerPoint = 2;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series13.Legend = "Legend1";
            series13.Name = "Series3";
            this.chart2.Series.Add(series11);
            this.chart2.Series.Add(series12);
            this.chart2.Series.Add(series13);
            this.chart2.Size = new System.Drawing.Size(659, 303);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // cmbpromotion
            // 
            this.cmbpromotion.FormattingEnabled = true;
            this.cmbpromotion.ItemHeight = 23;
            this.cmbpromotion.Location = new System.Drawing.Point(100, 49);
            this.cmbpromotion.Name = "cmbpromotion";
            this.cmbpromotion.Size = new System.Drawing.Size(219, 29);
            this.cmbpromotion.TabIndex = 2;
            this.cmbpromotion.UseSelectable = true;
            // 
            // cmbdistributer
            // 
            this.cmbdistributer.FormattingEnabled = true;
            this.cmbdistributer.ItemHeight = 23;
            this.cmbdistributer.Location = new System.Drawing.Point(345, 49);
            this.cmbdistributer.Name = "cmbdistributer";
            this.cmbdistributer.Size = new System.Drawing.Size(219, 29);
            this.cmbdistributer.TabIndex = 3;
            this.cmbdistributer.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(100, 27);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Promotion";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(345, 27);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Distributer";
            // 
            // btnSearchTeacher
            // 
            this.btnSearchTeacher.BackColor = System.Drawing.Color.DarkViolet;
            this.btnSearchTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchTeacher.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTeacher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchTeacher.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchTeacher.Location = new System.Drawing.Point(708, 12);
            this.btnSearchTeacher.Name = "btnSearchTeacher";
            this.btnSearchTeacher.Size = new System.Drawing.Size(109, 123);
            this.btnSearchTeacher.TabIndex = 23;
            this.btnSearchTeacher.UseVisualStyleBackColor = false;
            // 
            // tileStockRange
            // 
            this.tileStockRange.BackColor = System.Drawing.Color.DarkViolet;
            this.tileStockRange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tileStockRange.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileStockRange.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tileStockRange.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileStockRange.Location = new System.Drawing.Point(823, 12);
            this.tileStockRange.Name = "tileStockRange";
            this.tileStockRange.Size = new System.Drawing.Size(109, 123);
            this.tileStockRange.TabIndex = 24;
            this.tileStockRange.UseVisualStyleBackColor = false;
            // 
            // tileDistributer
            // 
            this.tileDistributer.BackColor = System.Drawing.Color.DarkViolet;
            this.tileDistributer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tileDistributer.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileDistributer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tileDistributer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileDistributer.Location = new System.Drawing.Point(938, 12);
            this.tileDistributer.Name = "tileDistributer";
            this.tileDistributer.Size = new System.Drawing.Size(109, 123);
            this.tileDistributer.TabIndex = 25;
            this.tileDistributer.UseVisualStyleBackColor = false;
            // 
            // tileArea
            // 
            this.tileArea.BackColor = System.Drawing.Color.DarkViolet;
            this.tileArea.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tileArea.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileArea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tileArea.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileArea.Location = new System.Drawing.Point(1053, 12);
            this.tileArea.Name = "tileArea";
            this.tileArea.Size = new System.Drawing.Size(109, 123);
            this.tileArea.TabIndex = 26;
            this.tileArea.UseVisualStyleBackColor = false;
            // 
            // tileSalesRate
            // 
            this.tileSalesRate.BackColor = System.Drawing.Color.DarkViolet;
            this.tileSalesRate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tileSalesRate.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileSalesRate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tileSalesRate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileSalesRate.Location = new System.Drawing.Point(1168, 12);
            this.tileSalesRate.Name = "tileSalesRate";
            this.tileSalesRate.Size = new System.Drawing.Size(109, 123);
            this.tileSalesRate.TabIndex = 27;
            this.tileSalesRate.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkViolet;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(1283, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 123);
            this.button5.TabIndex = 28;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkViolet;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.Location = new System.Drawing.Point(1398, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 123);
            this.button6.TabIndex = 29;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkViolet;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.Location = new System.Drawing.Point(1513, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(109, 123);
            this.button7.TabIndex = 30;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkViolet;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.Location = new System.Drawing.Point(708, 160);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(914, 329);
            this.button8.TabIndex = 31;
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // chart3
            // 
            chartArea7.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart3.Legends.Add(legend7);
            this.chart3.Location = new System.Drawing.Point(708, 545);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series14.Legend = "Legend1";
            series14.Name = "On Hand";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series15.Legend = "Legend1";
            series15.Name = "Sold";
            this.chart3.Series.Add(series14);
            this.chart3.Series.Add(series15);
            this.chart3.Size = new System.Drawing.Size(454, 303);
            this.chart3.TabIndex = 32;
            this.chart3.Text = "chart3";
            // 
            // tileDistributers
            // 
            chartArea8.Name = "ChartArea1";
            this.tileDistributers.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.tileDistributers.Legends.Add(legend8);
            this.tileDistributers.Location = new System.Drawing.Point(1163, 545);
            this.tileDistributers.Name = "tileDistributers";
            this.tileDistributers.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series16.Legend = "Legend1";
            series16.Name = "Days";
            series16.Points.Add(dataPoint3);
            series16.Points.Add(dataPoint4);
            this.tileDistributers.Series.Add(series16);
            this.tileDistributers.Size = new System.Drawing.Size(454, 303);
            this.tileDistributers.TabIndex = 33;
            this.tileDistributers.Text = "Quick View";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(489, 84);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 34;
            this.metroButton1.Text = "Quick View";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkViolet;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(718, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Estimated Profit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkViolet;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(836, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "Stock Range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkViolet;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(940, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "No of Distributers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkViolet;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(1064, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "Areas in process";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkViolet;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1192, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 39;
            this.label5.Text = "Sales Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkViolet;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(1289, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "Best Product Mix";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkViolet;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(1423, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 41;
            this.label7.Text = "Best Seller";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkViolet;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(1521, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 15);
            this.label8.TabIndex = 42;
            this.label8.Text = "No Sales Today";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(1334, 525);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 47;
            this.metroButton2.Text = "Quick View";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(1109, 497);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 46;
            this.metroLabel3.Text = "Distributer";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(864, 497);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(72, 19);
            this.metroLabel4.TabIndex = 45;
            this.metroLabel4.Text = "Promotion";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(1109, 519);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(219, 29);
            this.metroComboBox1.TabIndex = 44;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(864, 519);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(219, 29);
            this.metroComboBox2.TabIndex = 43;
            this.metroComboBox2.UseSelectable = true;
            // 
            // frmManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1640, 871);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.tileDistributers);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tileSalesRate);
            this.Controls.Add(this.tileArea);
            this.Controls.Add(this.tileDistributer);
            this.Controls.Add(this.tileStockRange);
            this.Controls.Add(this.btnSearchTeacher);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbdistributer);
            this.Controls.Add(this.cmbpromotion);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.salesChart);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmManagerDashboard";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)(this.salesChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileDistributers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart salesChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private MetroFramework.Controls.MetroComboBox cmbpromotion;
        private MetroFramework.Controls.MetroComboBox cmbdistributer;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Button btnSearchTeacher;
        private System.Windows.Forms.Button tileStockRange;
        private System.Windows.Forms.Button tileDistributer;
        private System.Windows.Forms.Button tileArea;
        private System.Windows.Forms.Button tileSalesRate;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart tileDistributers;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
    }
}