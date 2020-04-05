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

namespace service_auto
{
    public partial class LoginForm : Form
    {
        private UserService _userService = new UserService();
        private AppointmentService _appointmentService = new AppointmentService();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            User user = _userService.login(usernameTextBox.Text, passwordTextBox.Text);
            if (user == null)
            {
                MessageBox.Show("Incorrect username or password");
            }
            else
            {
                if (user.getRole() == "admin")
                {
                    AdminForm adminForm = new AdminForm(_userService, _appointmentService);
                    adminForm.Show();
                    this.Hide();
                    adminForm.FormClosed += Form_FormClosed;
                }
                else if (user.getRole() == "agent")
                {
                    AgentForm agentForm = new AgentForm(_appointmentService);
                    agentForm.Show();
                    this.Hide();
                    agentForm.FormClosed += Form_FormClosed;
                }
            }
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
