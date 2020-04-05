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
    public partial class AdminForm : Form
    {
        private UserService _userService;
        private AppointmentService _appointmentService;
        public AdminForm(UserService userService, AppointmentService appointmentService)
        {
            _userService = userService;
            _appointmentService = appointmentService;
            InitializeComponent();
        }

        private void createAgentButton_Click(object sender, EventArgs e)
        {
            AddAgentForm addAgent = new AddAgentForm(_userService, this);
            addAgent.Show();
            this.Hide();
            addAgent.FormClosed += Form_FormClosed;
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void showReportBbutton_Click(object sender, EventArgs e)
        {
            AdminReport adminReportForm = new AdminReport(_appointmentService);
            adminReportForm.Show();
            this.Hide();
            adminReportForm.FormClosed += Form_FormClosed;
        }
    }
}
