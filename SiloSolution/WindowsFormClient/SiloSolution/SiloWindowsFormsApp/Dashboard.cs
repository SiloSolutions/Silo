using SiloData;
using SiloModel;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using LiveCharts;
using System.Windows.Media;
using FontFamily = System.Windows.Media.FontFamily;

[assembly: DisableDpiAwareness]

namespace SiloWindowsFormsApp
{
    public partial class Dashboard : Form
    {
        private readonly string _configuration;

        public ChartValues<Chart> ChartValues { get; set; }

        private void SetAxisLimits(DateTime now)
        {
            cartesianChart.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromMinutes(1).Ticks; // lets force the axis to be 100ms ahead
            cartesianChart.AxisX[0].MinValue = now.Ticks - TimeSpan.FromMinutes(8).Ticks; //we only care about the last 8 seconds
        }

        public Dashboard()
        {

            InitializeComponent();
            if (SiloPage.sideWidth == 202)
            {
                this.Width = 758;

                cartesianChart.Width = 750;
                pieChart.Left = 465;
                gauge.Left = 211;

                lblPressure.Left = 293;
                lblBar.Left = 286;

                separatorTop.Width = 758;
                separatorMiddle.Width = 758;
                separatorSideRight.Visible = true;
            }
            else
            {
                this.Width = 910;

                cartesianChart.Width = 902;
                pieChart.Left = 620;
                gauge.Left = 290;

                lblPressure.Left = 372;
                lblBar.Left = 365;

                separatorTop.Width = 902;
                separatorMiddle.Width = 902;
                separatorSideRight.Visible = false;
            }

            _configuration = Properties.Settings.Default.Silo_Data;

            IDataRepository data = new DataRepository(_configuration);
            try
            {
                var temp = data.LastInsert();

                var mapper = Mappers.Xy<Chart>()
                .X(chart => chart.CreationDate.Ticks)
                .Y(chart => chart.LiquidLevel);

                Charting.For<Chart>(mapper);

                ChartValues = new ChartValues<Chart>();
                cartesianChart.Series = new SeriesCollection
                {
                    new LineSeries
                    {
                        Values = ChartValues,
                        PointGeometrySize = 12,
                        StrokeThickness = 3,
                        Stroke = System.Windows.Media.Brushes.Orange,
                        Title = "Liquid Level",
                        FontFamily = new FontFamily("Century Gothic"),
                        Foreground = System.Windows.Media.Brushes.White,
                        FontSize = 12
                    }
                };

                cartesianChart.ForeColor = System.Drawing.Color.White;

                cartesianChart.AxisX.Add(new Axis
                {
                    DisableAnimations = false,
                    LabelFormatter = value => new DateTime((long)value).AddMinutes(+1).AddSeconds(-DateTime.Now.Second).ToString("HH:mm"),
                    Separator = new Separator
                    {
                        Step = TimeSpan.FromMinutes(1).Ticks
                    },
                    FontFamily = new FontFamily("Century Gothic"),
                    Foreground = System.Windows.Media.Brushes.White,
                    FontSize = 14
                });

                cartesianChart.AxisY.Add(new Axis
                {
                    DisableAnimations = true,
                    FontFamily = new FontFamily("Century Gothic"),
                    Foreground = System.Windows.Media.Brushes.White,
                    FontSize = 14,
                    LabelFormatter = value => value.ToString("N0")
                });

                cartesianChart.LegendLocation = LegendLocation.Right;

                cartesianChart.DefaultLegend.Foreground = System.Windows.Media.Brushes.White;
                cartesianChart.DefaultLegend.FontFamily = new FontFamily("Century Gothic");
                cartesianChart.DefaultLegend.FontSize = 14;


                ChartValues.Add(new Chart
                {
                    CreationDate = temp.CreationDate,
                    LiquidLevel = temp.LiquidLevel
                });

                SetAxisLimits(temp.CreationDate);

                circleProgress.Value = temp.Temperature;

                gauge.Value = temp.Pressure;

                pieChart.Series["Series"].IsValueShownAsLabel = true;

                var emptySpace = 160000 - temp.LiquidLevel;

                pieChart.Series["Series"].Points.AddXY("Liquid", temp.LiquidLevel);
                pieChart.Series["Series"].Points.AddXY("Empty Space", emptySpace);

                pieChart.Series["Series"].Points[0].Color = System.Drawing.Color.Orange;
                pieChart.Series["Series"].Points[1].Color = System.Drawing.Color.Silver;

                pieChart.Series["Series"].Label = "#PERCENT{0.00 %}";
                pieChart.Series["Series"].LegendText = "#VALX";

                lblBar.Text = "10 millibar = 1kPa";
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

            timer.Start();
            timer.Tick += new EventHandler(refreshPage);
            timer.Interval = 5000;
        }

        private void refreshPage(object sender, EventArgs e)
        {
            var moment = DateTime.Now;

            if (moment.Second >= 01 && moment.Second <= 06)
            {
                IDataRepository data = new DataRepository(_configuration);

                try
                {
                    var list = data.LastInsert();



                    ChartValues.Add(new Chart
                    {
                        CreationDate = list.CreationDate,
                        LiquidLevel = list.LiquidLevel
                    });

                    SetAxisLimits(list.CreationDate);

                    circleProgress.Value = list.Temperature;

                    gauge.Value = list.Pressure;

                    pieChart.Series["Series"].Points.Clear();
                    pieChart.Series["Series"].IsValueShownAsLabel = true;

                    var emptySpace = 160000 - list.LiquidLevel;

                    pieChart.Series["Series"].Points.AddXY("Liquid", list.LiquidLevel);
                    pieChart.Series["Series"].Points.AddXY("Empty Space", emptySpace);

                    pieChart.Series["Series"].Points[0].Color = System.Drawing.Color.Orange;
                    pieChart.Series["Series"].Points[1].Color = System.Drawing.Color.Silver;

                    pieChart.Series["Series"].Label = "#PERCENT{0.00 %}";
                    pieChart.Series["Series"].LegendText = "#VALX";

                    lblBar.Text = "10 millibar = 1kPa";
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
}
