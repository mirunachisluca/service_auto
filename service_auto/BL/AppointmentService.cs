using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using service_auto.DAL;
using service_auto.Entities;

namespace service_auto.BL
{
    public class AppointmentService
    {
        private AppointmentsDAO _appointmentDAO = AppointmentsDAO.getInstance();

        public void addAppointment(DateTime datetime, String clientName, String phone, String car, String problem, String status)
        {
            _appointmentDAO.createAppointment(datetime, clientName, phone, car, problem, status);
        }

        public void closeAppointment(int id)
        {
            _appointmentDAO.closeAppointment(id);
        }

        public Boolean validateAppointment(DateTime date)
        {
            return _appointmentDAO.validateAppointment(date);
        }

        public List<Appointment> showAppointmentsForClient(String client)
        {
            return _appointmentDAO.showAppointments(4, DateTime.Now, DateTime.Now, DateTime.Now, client);
        }

        public List<Appointment> showReport(DateTime from, DateTime to)
        {
            return _appointmentDAO.showAppointments(3, DateTime.Now, from, to, null);
        }

        public List<Appointment> showAppointmentsOnDay(DateTime today)
        {
            return _appointmentDAO.showAppointments(2, today, DateTime.Now, DateTime.Now, null);
        }

        public List<Appointment> showUnsolvedAppointments(DateTime date)
        {
            return _appointmentDAO.showAppointments(1, date, DateTime.Now, DateTime.Now, null);
        }


    }
}
