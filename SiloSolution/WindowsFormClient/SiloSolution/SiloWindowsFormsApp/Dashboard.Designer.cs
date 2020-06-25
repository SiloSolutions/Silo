namespace SiloWindowsFormsApp
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gauge = new System.Windows.Forms.AGauge();
            this.lblBar = new Bunifu.UI.WinForms.BunifuLabel();
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.circleProgress = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.panel = new System.Windows.Forms.Panel();
            this.lblTemperature = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.separatorMiddle = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator4 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.separatorTop = new Bunifu.UI.WinForms.BunifuSeparator();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblPressure = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 3000;
            // 
            // gauge
            // 
            this.gauge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.gauge.BaseArcColor = System.Drawing.Color.Orange;
            this.gauge.BaseArcRadius = 80;
            this.gauge.BaseArcStart = 135;
            this.gauge.BaseArcSweep = 270;
            this.gauge.BaseArcWidth = 2;
            this.gauge.Center = new System.Drawing.Point(125, 125);
            this.gauge.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gauge.Location = new System.Drawing.Point(281, 377);
            this.gauge.MaxValue = 12F;
            this.gauge.MinValue = 0F;
            this.gauge.Name = "gauge";
            this.gauge.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Red;
            this.gauge.NeedleColor2 = System.Drawing.Color.DimGray;
            this.gauge.NeedleRadius = 80;
            this.gauge.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.gauge.NeedleWidth = 2;
            this.gauge.ScaleLinesInterColor = System.Drawing.Color.White;
            this.gauge.ScaleLinesInterInnerRadius = 73;
            this.gauge.ScaleLinesInterOuterRadius = 80;
            this.gauge.ScaleLinesInterWidth = 1;
            this.gauge.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.gauge.ScaleLinesMajorInnerRadius = 70;
            this.gauge.ScaleLinesMajorOuterRadius = 80;
            this.gauge.ScaleLinesMajorStepValue = 1F;
            this.gauge.ScaleLinesMajorWidth = 2;
            this.gauge.ScaleLinesMinorColor = System.Drawing.Color.Transparent;
            this.gauge.ScaleLinesMinorInnerRadius = 75;
            this.gauge.ScaleLinesMinorOuterRadius = 80;
            this.gauge.ScaleLinesMinorTicks = 9;
            this.gauge.ScaleLinesMinorWidth = 1;
            this.gauge.ScaleNumbersColor = System.Drawing.Color.White;
            this.gauge.ScaleNumbersFormat = null;
            this.gauge.ScaleNumbersRadius = 95;
            this.gauge.ScaleNumbersRotation = 0;
            this.gauge.ScaleNumbersStartScaleLine = 1;
            this.gauge.ScaleNumbersStepScaleLines = 1;
            this.gauge.Size = new System.Drawing.Size(333, 294);
            this.gauge.TabIndex = 22;
            this.gauge.Value = 0F;
            // 
            // lblBar
            // 
            this.lblBar.AllowParentOverrides = false;
            this.lblBar.AutoEllipsis = false;
            this.lblBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.lblBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBar.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblBar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBar.ForeColor = System.Drawing.Color.Transparent;
            this.lblBar.Location = new System.Drawing.Point(391, 603);
            this.lblBar.Name = "lblBar";
            this.lblBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBar.Size = new System.Drawing.Size(105, 20);
            this.lblBar.TabIndex = 23;
            this.lblBar.Text = "1 bar = 100kPa";
            this.lblBar.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblBar.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pieChart
            // 
            this.pieChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.pieChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea";
            this.pieChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend";
            this.pieChart.Legends.Add(legend1);
            this.pieChart.Location = new System.Drawing.Point(620, 377);
            this.pieChart.Name = "pieChart";
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.CustomProperties = "CollectedSliceExploded=True";
            series1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend";
            series1.Name = "Series";
            this.pieChart.Series.Add(series1);
            this.pieChart.Size = new System.Drawing.Size(408, 294);
            this.pieChart.TabIndex = 24;
            // 
            // circleProgress
            // 
            this.circleProgress.Animated = false;
            this.circleProgress.AnimationInterval = 1;
            this.circleProgress.AnimationSpeed = 1;
            this.circleProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.circleProgress.CircleMargin = 25;
            this.circleProgress.Font = new System.Drawing.Font("Century Gothic", 34.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleProgress.ForeColor = System.Drawing.Color.White;
            this.circleProgress.IsPercentage = false;
            this.circleProgress.LineProgressThickness = 10;
            this.circleProgress.LineThickness = 10;
            this.circleProgress.Location = new System.Drawing.Point(1, 18);
            this.circleProgress.Name = "circleProgress";
            this.circleProgress.ProgressAnimationSpeed = 200;
            this.circleProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.circleProgress.ProgressColor = System.Drawing.Color.Orange;
            this.circleProgress.ProgressColor2 = System.Drawing.Color.Orange;
            this.circleProgress.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.circleProgress.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Gradient;
            this.circleProgress.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.circleProgress.SecondaryFont = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleProgress.Size = new System.Drawing.Size(262, 262);
            this.circleProgress.SubScriptColor = System.Drawing.Color.White;
            this.circleProgress.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.circleProgress.SubScriptText = ".00";
            this.circleProgress.SuperScriptColor = System.Drawing.Color.White;
            this.circleProgress.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.circleProgress.SuperScriptText = "°C";
            this.circleProgress.TabIndex = 16;
            this.circleProgress.Text = "30";
            this.circleProgress.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.circleProgress.Value = 30;
            this.circleProgress.ValueByTransition = 30;
            this.circleProgress.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel.Controls.Add(this.lblTemperature);
            this.panel.Controls.Add(this.circleProgress);
            this.panel.Location = new System.Drawing.Point(12, 377);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(264, 294);
            this.panel.TabIndex = 25;
            // 
            // lblTemperature
            // 
            this.lblTemperature.AllowParentOverrides = false;
            this.lblTemperature.AutoEllipsis = false;
            this.lblTemperature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.lblTemperature.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTemperature.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTemperature.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.ForeColor = System.Drawing.Color.White;
            this.lblTemperature.Location = new System.Drawing.Point(55, 0);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTemperature.Size = new System.Drawing.Size(156, 31);
            this.lblTemperature.TabIndex = 17;
            this.lblTemperature.Text = "Temperature";
            this.lblTemperature.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTemperature.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 0);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.bunifuSeparator1.Size = new System.Drawing.Size(12, 670);
            this.bunifuSeparator1.TabIndex = 26;
            // 
            // separatorMiddle
            // 
            this.separatorMiddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.separatorMiddle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("separatorMiddle.BackgroundImage")));
            this.separatorMiddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.separatorMiddle.LineColor = System.Drawing.Color.Transparent;
            this.separatorMiddle.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.separatorMiddle.LineThickness = 1;
            this.separatorMiddle.Location = new System.Drawing.Point(0, 357);
            this.separatorMiddle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.separatorMiddle.Name = "separatorMiddle";
            this.separatorMiddle.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.separatorMiddle.Size = new System.Drawing.Size(1010, 16);
            this.separatorMiddle.TabIndex = 27;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.bunifuSeparator3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator3.BackgroundImage")));
            this.bunifuSeparator3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(273, 363);
            this.bunifuSeparator3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.bunifuSeparator3.Size = new System.Drawing.Size(12, 307);
            this.bunifuSeparator3.TabIndex = 28;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.bunifuSeparator4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator4.BackgroundImage")));
            this.bunifuSeparator4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(612, 364);
            this.bunifuSeparator4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.bunifuSeparator4.Size = new System.Drawing.Size(12, 307);
            this.bunifuSeparator4.TabIndex = 29;
            // 
            // separatorTop
            // 
            this.separatorTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.separatorTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("separatorTop.BackgroundImage")));
            this.separatorTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.separatorTop.LineColor = System.Drawing.Color.Transparent;
            this.separatorTop.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.separatorTop.LineThickness = 1;
            this.separatorTop.Location = new System.Drawing.Point(0, 0);
            this.separatorTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.separatorTop.Name = "separatorTop";
            this.separatorTop.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.separatorTop.Size = new System.Drawing.Size(1010, 10);
            this.separatorTop.TabIndex = 30;
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.chart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(-42, -4);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.ChartArea = "ChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend";
            series2.Name = "Liquid Level";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(1096, 365);
            this.chart.TabIndex = 0;
            // 
            // lblPressure
            // 
            this.lblPressure.AllowParentOverrides = false;
            this.lblPressure.AutoEllipsis = false;
            this.lblPressure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.lblPressure.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPressure.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblPressure.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressure.ForeColor = System.Drawing.Color.White;
            this.lblPressure.Location = new System.Drawing.Point(391, 377);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPressure.Size = new System.Drawing.Size(98, 31);
            this.lblPressure.TabIndex = 18;
            this.lblPressure.Text = "Pressure";
            this.lblPressure.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPressure.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1010, 670);
            this.Controls.Add(this.lblPressure);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.separatorTop);
            this.Controls.Add(this.bunifuSeparator4);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.separatorMiddle);
            this.Controls.Add(this.pieChart);
            this.Controls.Add(this.lblBar);
            this.Controls.Add(this.gauge);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.chart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.AGauge gauge;
        private Bunifu.UI.WinForms.BunifuLabel lblBar;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
        private Bunifu.UI.WinForms.BunifuCircleProgress circleProgress;
        private System.Windows.Forms.Panel panel;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuSeparator separatorMiddle;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator3;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator4;
        private Bunifu.UI.WinForms.BunifuSeparator separatorTop;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private Bunifu.UI.WinForms.BunifuLabel lblTemperature;
        private Bunifu.UI.WinForms.BunifuLabel lblPressure;
    }
}