using SiloUserData;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SiloWindowsFormsApp
{
    public partial class Dashboard : Form
    {
        private readonly string _configuration;

        public Dashboard()
        {

            InitializeComponent();
            if (SiloPage.sideWidth == 202)
            {
                this.Width = 758;
            }
            else
            {
                this.Width = 800;

                separatorTop.Width = 800;
                chart.Width = 950;
                chart.Location = new Point(-42, -4);
                separatorMiddle.Width = 800;
            }

            _configuration = Properties.Settings.Default.Silo_Data;

            IDataRepository data = new DataRepository(_configuration);
            try
            {


                var temp = data.LastInsert();

                chart.Series["Liquid Level"].Points.AddXY(temp.CreationDate, temp.LiquidLevel);

                chart.Series["Liquid Level"].ChartType = SeriesChartType.Line;

                chart.Series["Liquid Level"].XValueType = ChartValueType.DateTime;
                chart.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm";
                chart.ChartAreas[0].AxisX.Interval = 60;
                chart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                chart.ChartAreas[0].AxisX.IntervalOffset = 1;

                circleProgress.Value = temp.Temperature;

                gauge.Value = (float)temp.Pressure * 10;

                pieChart.Series["Series"].IsValueShownAsLabel = true;
                pieChart.Series["Series"].Points.AddXY("Liquid", temp.LiquidLevel);
                var emptySpace = 160000 - temp.LiquidLevel;
                pieChart.Series["Series"].Points.AddXY("Empty Space", emptySpace);

                pieChart.Series["Series"].Label = "#PERCENT{0.00 %}";
                pieChart.Series["Series"].LegendText = "#VALX";

                lblBar.Text = "1 bar = 100kPa";
                lblTemperature.Text = "Temperature";
                lblPressure.Text = "Pressure";
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error " + e);
            }

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer.Tick += new EventHandler(refreshPage);
            timer.Start();
            timer.Interval = 5000;


        }

        private void refreshPage(object sender, EventArgs e)
        {
            IDataRepository data = new DataRepository(_configuration);

            try
            {
                var list = data.LastInsert();

                chart.Series["Liquid Level"].Points.AddXY(list.CreationDate, list.LiquidLevel);

                chart.Series["Liquid Level"].ChartType = SeriesChartType.Line;

                chart.Series["Liquid Level"].XValueType = ChartValueType.DateTime;
                chart.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm";
                chart.ChartAreas[0].AxisX.Interval = 60;
                chart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                chart.ChartAreas[0].AxisX.IntervalOffset = 1;

                circleProgress.Value = list.Temperature;

                gauge.Value = (float)list.Pressure * 10;

                pieChart.Series["Series"].Points.Clear();
                pieChart.Series["Series"].IsValueShownAsLabel = true;
                pieChart.Series["Series"].Points.AddXY("Liquid", list.LiquidLevel);
                var emptySpace = 160000 - list.LiquidLevel;
                pieChart.Series["Series"].Points.AddXY("Empty Space", emptySpace);
                pieChart.Series["Series"].Label = "#PERCENT{0.00 %}";
                pieChart.Series["Series"].LegendText = "#VALX";

                lblBar.Text = "1 bar = 100kPa";
                lblTemperature.Text = "Temperature";
                lblPressure.Text = "Pressure";
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error " + ex);
            }
        }
    }
}
