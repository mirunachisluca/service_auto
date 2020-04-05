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
    public partial class AddAgentForm : Form
    {
        private UserService _userService;
        private AdminForm _adminForm;
        public AddAgentForm(UserService userService, AdminForm adminForm)
        {
            _userService = userService;
            _adminForm = adminForm;
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _userService.createAgentAccount(usernameTextBox.Text, passwordTextBox.Text);
            this.Close();
            _adminForm.Show();
        }

    }
}
