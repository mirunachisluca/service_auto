using service_auto.BL;
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
    public partial class AddAppointmentForm : Form
    {
        private AppointmentService _appointmentService;
        private AgentForm _agentForm;
        public AddAppointmentForm(AppointmentService appointmentService, AgentForm agentForm)
        {
            _appointmentService = appointmentService;
            _agentForm = agentForm;
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DateTime datetime = datePicker.Value.Date + timePicker.Value.TimeOfDay;
            if (_appointmentService.validateAppointment(datetime))
            {
                _appointmentService.addAppointment(datetime, client.Text, phone.Text, car.Text, problem.Text, "unsolved");
                this.Close();
                _agentForm.Show();
            }
            else
            {
                MessageBox.Show("Unavailable date and time! Choose another", "Error");
            }
            
        }

    }
}
