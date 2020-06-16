using SiloUserData;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SiloWindowsFormsApp
{
    public partial class Data : Form
    {
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

            datePickerFrom.MaxDate = DateTime.Now;
            datePickerTo.MaxDate = DateTime.Now;

            IActivityRepository data = new ActivityRepository();

            var list = data.GetCategories();
            dataGridView.DataSource = list;
            dataGridView.Columns["CreationDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";

        }

        private void timePickerTo_ValueChanged(object sender, EventArgs e)
        {
            if (timePickerTo.Checked == true)
            {
                IActivityRepository data = new ActivityRepository();
                var dateFrom = datePickerFrom.Value.Date + timePickerFrom.Value.TimeOfDay;
                var dateTo = datePickerTo.Value.Date + timePickerTo.Value.TimeOfDay;

                var listDate = data.SelectDate(dateFrom, dateTo);
                dataGridView.DataSource = listDate;
                dataGridView.Columns["CreationDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            }
        }
    }
}
