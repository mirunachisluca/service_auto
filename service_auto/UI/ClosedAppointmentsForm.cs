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
    public partial class ClosedAppointmentsForm : Form
    {
        private AppointmentService _appointmentService;
        public ClosedAppointmentsForm(AppointmentService appointment)
        {
            InitializeComponent();
            _appointmentService = appointment;
            //dataGridView1.CellClick += dataGridView1_SelectionChanged;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    int id = (int)dataGridView1.SelectedRows[i].Cells[0].Value;
                    _appointmentService.closeAppointment(id);
                }
            }
            dataGridView1.DataSource = _appointmentService.showUnsolvedAppointments(datePicker.Value);
            //this.Close();
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _appointmentService.showUnsolvedAppointments(datePicker.Value);
            dataGridView1.Columns["Id"].Visible = false;
        }
    }
}
