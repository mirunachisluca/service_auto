using service_auto.BL;
using service_auto.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace service_auto.UI
{
    public partial class AdminReport : Form
    {
        private AppointmentService _appointmentService;
        public AdminReport(AppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
            InitializeComponent();
        }

        private void searchButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _appointmentService.showAppointmentsForClient(clientTextBox.Text);
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void searchButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _appointmentService.showReport(fromDatePicker.Value, toDatePicker.Value);
            dataGridView1.Columns["Id"].Visible = false;
        }
    }
}
