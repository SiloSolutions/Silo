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
            System.Windows.Forms.AGaugeRange aGaugeRange1 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange2 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange3 = new System.Windows.Forms.AGaugeRange();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gauge = new System.Windows.Forms.AGauge();
            this.lblBar = new Bunifu.UI.WinForms.BunifuLabel();
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.circleProgress = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.panel = new System.Windows.Forms.Panel();
            this.lblTemperature = new Bunifu.UI.WinForms.BunifuLabel();
            this.separatorSideLeft = new Bunifu.UI.WinForms.BunifuSeparator();
            this.separatorMiddle = new Bunifu.UI.WinForms.BunifuSeparator();
            this.separatorSideMiddle = new Bunifu.UI.WinForms.BunifuSeparator();
            this.separatorSideRight = new Bunifu.UI.WinForms.BunifuSeparator();
            this.separatorTop = new Bunifu.UI.WinForms.BunifuSeparator();
            this.lblPressure = new Bunifu.UI.WinForms.BunifuLabel();
            this.cartesianChart = new LiveCharts.WinForms.CartesianChart();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            this.panel.SuspendLayout();
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
            aGaugeRange1.Color = System.Drawing.Color.LimeGreen;
            aGaugeRange1.EndValue = 40F;
            aGaugeRange1.InnerRadius = 74;
            aGaugeRange1.InRange = true;
            aGaugeRange1.Name = "Normal";
            aGaugeRange1.OuterRadius = 80;
            aGaugeRange1.StartValue = 0F;
            aGaugeRange2.Color = System.Drawing.Color.Orange;
            aGaugeRange2.EndValue = 80F;
            aGaugeRange2.InnerRadius = 74;
            aGaugeRange2.InRange = false;
            aGaugeRange2.Name = "Alert";
            aGaugeRange2.OuterRadius = 80;
            aGaugeRange2.StartValue = 40F;
            aGaugeRange3.Color = System.Drawing.Color.Red;
            aGaugeRange3.EndValue = 120F;
            aGaugeRange3.InnerRadius = 74;
            aGaugeRange3.InRange = false;
            aGaugeRange3.Name = "Danger";
            aGaugeRange3.OuterRadius = 80;
            aGaugeRange3.StartValue = 80F;
            this.gauge.GaugeRanges.Add(aGaugeRange1);
            this.gauge.GaugeRanges.Add(aGaugeRange2);
            this.gauge.GaugeRanges.Add(aGaugeRange3);
            this.gauge.Location = new System.Drawing.Point(281, 377);
            this.gauge.MaxValue = 120F;
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
            this.gauge.ScaleLinesMajorStepValue = 10F;
            this.gauge.ScaleLinesMajorWidth = 2;
            this.gauge.ScaleLinesMinorColor = System.Drawing.Color.Transparent;
            this.gauge.ScaleLinesMinorInnerRadius = 75;
            this.gauge.ScaleLinesMinorOuterRadius = 80;
            this.gauge.ScaleLinesMinorTicks = 9;
            this.gauge.ScaleLinesMinorWidth = 1;
            this.gauge.ScaleNumbersColor = System.Drawing.Color.White;
            this.gauge.ScaleNumbersFormat = "";
            this.gauge.ScaleNumbersRadius = 95;
            this.gauge.ScaleNumbersRotation = 0;
            this.gauge.ScaleNumbersStartScaleLine = 1;
            this.gauge.ScaleNumbersStepScaleLines = 10;
            this.gauge.Size = new System.Drawing.Size(333, 294);
            this.gauge.TabIndex = 22;
            this.gauge.Value = 5F;
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
            this.lblBar.Location = new System.Drawing.Point(381, 610);
            this.lblBar.Name = "lblBar";
            this.lblBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBar.Size = new System.Drawing.Size(122, 20);
            this.lblBar.TabIndex = 23;
            this.lblBar.Text = "10 millibar = 1kPa";
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
            this.pieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
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
            // separatorSideLeft
            // 
            this.separatorSideLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.separatorSideLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("separatorSideLeft.BackgroundImage")));
            this.separatorSideLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.separatorSideLeft.LineColor = System.Drawing.Color.Transparent;
            this.separatorSideLeft.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.separatorSideLeft.LineThickness = 1;
            this.separatorSideLeft.Location = new System.Drawing.Point(0, 0);
            this.separatorSideLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.separatorSideLeft.Name = "separatorSideLeft";
            this.separatorSideLeft.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.separatorSideLeft.Size = new System.Drawing.Size(12, 670);
            this.separatorSideLeft.TabIndex = 26;
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
            // separatorSideMiddle
            // 
            this.separatorSideMiddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.separatorSideMiddle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("separatorSideMiddle.BackgroundImage")));
            this.separatorSideMiddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.separatorSideMiddle.LineColor = System.Drawing.Color.Transparent;
            this.separatorSideMiddle.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.separatorSideMiddle.LineThickness = 1;
            this.separatorSideMiddle.Location = new System.Drawing.Point(273, 363);
            this.separatorSideMiddle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.separatorSideMiddle.Name = "separatorSideMiddle";
            this.separatorSideMiddle.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.separatorSideMiddle.Size = new System.Drawing.Size(12, 307);
            this.separatorSideMiddle.TabIndex = 28;
            // 
            // separatorSideRight
            // 
            this.separatorSideRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.separatorSideRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("separatorSideRight.BackgroundImage")));
            this.separatorSideRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.separatorSideRight.LineColor = System.Drawing.Color.Transparent;
            this.separatorSideRight.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.separatorSideRight.LineThickness = 1;
            this.separatorSideRight.Location = new System.Drawing.Point(612, 364);
            this.separatorSideRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.separatorSideRight.Name = "separatorSideRight";
            this.separatorSideRight.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.separatorSideRight.Size = new System.Drawing.Size(12, 307);
            this.separatorSideRight.TabIndex = 29;
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
            // cartesianChart
            // 
            this.cartesianChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.cartesianChart.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartesianChart.ForeColor = System.Drawing.Color.White;
            this.cartesianChart.Location = new System.Drawing.Point(12, 12);
            this.cartesianChart.Name = "cartesianChart";
            this.cartesianChart.Size = new System.Drawing.Size(1000, 344);
            this.cartesianChart.TabIndex = 31;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1010, 670);
            this.Controls.Add(this.lblPressure);
            this.Controls.Add(this.separatorSideLeft);
            this.Controls.Add(this.separatorTop);
            this.Controls.Add(this.separatorSideRight);
            this.Controls.Add(this.separatorSideMiddle);
            this.Controls.Add(this.separatorMiddle);
            this.Controls.Add(this.pieChart);
            this.Controls.Add(this.lblBar);
            this.Controls.Add(this.gauge);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.cartesianChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
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
        private Bunifu.UI.WinForms.BunifuSeparator separatorSideLeft;
        private Bunifu.UI.WinForms.BunifuSeparator separatorMiddle;
        private Bunifu.UI.WinForms.BunifuSeparator separatorSideMiddle;
        private Bunifu.UI.WinForms.BunifuSeparator separatorSideRight;
        private Bunifu.UI.WinForms.BunifuSeparator separatorTop;
        private Bunifu.UI.WinForms.BunifuLabel lblTemperature;
        private Bunifu.UI.WinForms.BunifuLabel lblPressure;
        private LiveCharts.WinForms.CartesianChart cartesianChart;
    }
}