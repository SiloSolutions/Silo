using LiveCharts;
using LiveCharts.Wpf;
using SiloUserData;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace SiloWindowsFormsApp
{
    public partial class Dashboard : Form
    {
        private Thread cpuThread;
        private double[] cpuArray = new double[60];

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
            }

            cpuThread = new Thread(new ThreadStart(this.getPerformanceCounters));
            cpuThread.IsBackground = true;
            cpuThread.Start();
        }



        /* private void Dashboard_Load(object sender, EventArgs e)
         {
             timer.Interval = 3000;
             timer.Tick += new System.EventHandler(timer_Tick);
             timer.Start();
         }

         private void timer_Tick(object sender, EventArgs e)
         {
             IActivityRepository data = new ActivityRepository();

             data.GetCategories();


             var random = new Random();
             chart.Series["Liquid Level"].Points.AddY(random.Next(0, 300));
         }*/
        private void getPerformanceCounters()
        {
            var cpuPerfCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");

            while (true)
            {
                cpuArray[cpuArray.Length - 1] = Math.Round(cpuPerfCounter.NextValue(), 0);

                Array.Copy(cpuArray, 1, cpuArray, 0, cpuArray.Length - 1);

                if (chart.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateCpuChart(); });
                }
                else
                {
                    //......
                }

                Thread.Sleep(1000);
            }
        }

        private void UpdateCpuChart()
        {
            chart.Series["Liquid Level"].Points.Clear();

            for (int i = 0; i < cpuArray.Length - 1; ++i)
            {
                chart.Series["Liquid Level"].Points.AddY(cpuArray[i]);

            }
        }

    }
}