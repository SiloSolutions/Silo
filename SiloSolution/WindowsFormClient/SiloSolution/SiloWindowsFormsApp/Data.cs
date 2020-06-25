using SiloUserData;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SiloWindowsFormsApp
{
    public partial class Data : Form
    {
        private readonly string _configuration;

        public Data()
        {
            InitializeComponent();
            if (SiloPage.sideWidth == 202)
            {
                lblFrom.Location = new Point(24, 19);
                lblTo.Location = new Point(252, 63);

                this.Width = 758;
                dataGridView.Width = 740;
            }
            else
            {
                lblFrom.Location = new Point(24, 19);
                lblTo.Location = new Point(252, 63);

                this.Width = 910;
                dataGridView.Width = 892;
            }

            _configuration = Properties.Settings.Default.Silo_Data;

            datePickerFrom.MaxDate = DateTime.Now;
            datePickerTo.MaxDate = DateTime.Now;

            timePickerFrom.Value = DateTime.Now.AddMinutes(-1);
            timePickerTo.Value = DateTime.Now;

            IDataRepository data = new DataRepository(_configuration);
            try
            {
                var list = data.GetAll();
                dataGridView.DataSource = list;
                dataGridView.Columns["CreationDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error " + e);
            }

        }


        private void timePickerTo_ValueChanged(object sender, EventArgs e)
        {
            if (timePickerTo.Checked == true)
            {
                IDataRepository data = new DataRepository(_configuration);
                var dateFrom = datePickerFrom.Value.Date + timePickerFrom.Value.TimeOfDay;
                var dateTo = datePickerTo.Value.Date + timePickerTo.Value.TimeOfDay;

                try
                {
                    var listDate = data.SelectDate(dateFrom, dateTo);
                    dataGridView.DataSource = listDate;
                    dataGridView.Columns["CreationDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Error " + ex);
                }
            }
        }

        private void refreshPage(object sender, EventArgs e)
        {
            IDataRepository data = new DataRepository(_configuration);

            try
            {
                var list = data.GetAll();
                dataGridView.DataSource = list;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error " + ex);
            }
        }

        private void Data_Load(object sender, EventArgs e)
        {
            timer.Interval = 60000;
            timer.Tick += new EventHandler(refreshPage);
            timer.Start();
        }
    }
}
