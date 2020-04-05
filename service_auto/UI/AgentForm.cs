using service_auto.BL;
using service_auto.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace service_auto
{
    public partial class AgentForm : Form
    {
        private AppointmentService _appointmentService;
        public AgentForm(AppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
            InitializeComponent();
        }

        private void createAppointmentButton_Click(object sender, EventArgs e)
        {
            AddAppointmentForm addAppointment = new AddAppointmentForm(_appointmentService, this);
            addAppointment.Show();
            this.Hide();
            addAppointment.FormClosed += Form_FormClosed;

        }

        private void closeAppointmentButton_Click(object sender, EventArgs e)
        {
            ClosedAppointmentsForm closeAppointmentForm = new ClosedAppointmentsForm(_appointmentService);
            closeAppointmentForm.Show();
            this.Hide();
            closeAppointmentForm.FormClosed += Form_FormClosed;
        }

        private void showAppointmentsButton_Click(object sender, EventArgs e)
        {
            AgentAppointments showApp = new AgentAppointments(_appointmentService);
            showApp.Show();
            this.Hide();
            showApp.FormClosed += Form_FormClosed;
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
