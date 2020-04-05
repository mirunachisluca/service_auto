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
    public partial class AgentAppointments : Form
    {
        private AppointmentService _appointmentService;
        public AgentAppointments(AppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
            InitializeComponent();
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _appointmentService.showAppointmentsOnDay(datePicker.Value);
            dataGridView1.Columns["Id"].Visible = false;


        }
    }
}
