using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using service_auto.Entities;

namespace service_auto.DAL
{
    public class AppointmentsDAO
    {
        private static AppointmentsDAO _appointmentDAO = null;
        private String _connectionString = @"Data Source=DESKTOP-4TP9P9L;Initial Catalog=service_auto;Trusted_Connection=Yes;";
        SqlConnection _conn = null;

        private AppointmentsDAO()
        {
            try
            {
                _conn = new SqlConnection(_connectionString);
            }
            catch (SqlException e)
            {
                //de facut ceva error handling, afisat mesaj, etc..
                _conn = null;
            }
        }

        public static AppointmentsDAO getInstance()
        {
            if (_appointmentDAO == null)
            {
                _appointmentDAO = new AppointmentsDAO();
            }
            return _appointmentDAO;
        }

        public void createAppointment(DateTime datetime, String clientName, String phone, String car, String problem, String status)
        {
            string sqlDatetime = datetime.ToString("yyyy-MM-dd HH:mm");
            String sql = "INSERT INTO appointments (datetime, client, phone, car, problem, status) VALUES ('" + sqlDatetime + "', '" + clientName + "', '" + phone + "', '" + car + "', '" + problem + "', 'unsolved')";
            _conn.Open();
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }

        
        public Boolean validateAppointment(DateTime date)
        {
            Boolean ok = true;
            double seconds = date.Second;
            date = date.AddSeconds(-seconds);

            String sql = "SELECT * FROM appointments WHERE datetime='" + date + "'";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    ok = false;
                }
                else
                {
                    ok = true;
                }
                _conn.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                _conn.Close();
                return false;
            }
            return ok;
        }

        public List<Appointment> ListAppointments(String sql)
        {
            List<Appointment> appointments = new List<Appointment>();
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    DateTime datetime = DateTime.Parse(reader["datetime"].ToString());
                    String client = reader["client"].ToString();
                    String phone = reader["phone"].ToString();
                    String car = reader["car"].ToString();
                    String problem = reader["problem"].ToString();
                    String status = reader["status"].ToString();
                    Appointment app = new Appointment(id, datetime, client, phone, car, problem, status);
                    appointments.Add(app);
                }
            }
            catch (Exception exc)
            {
                throw exc;
            }
            finally
            {
                _conn.Close();
            }

            return appointments;
        }

        public List<Appointment> showAppointments(int op, DateTime datetime, DateTime from, DateTime to, String client)
        {
            String sql1 = "SELECT * FROM appointments WHERE status='unsolved' and CONVERT(date, datetime)='" + datetime.Date + "'";
            String sql2 = "SELECT * FROM appointments WHERE CONVERT(date, datetime)='" + datetime.Date + "'";
            String sql3 = "SELECT * FROM appointments WHERE CONVERT(date, datetime)>='" + from.Date + "' and CONVERT(date, datetime)<='" + to.Date + "'";
            String sql4 = "SELECT * FROM appointments WHERE client='" + client +"'";
            switch (op)
            {
                case 1: 
                    return ListAppointments(sql1);
                case 2: 
                    return ListAppointments(sql2);
                case 3:
                    return ListAppointments(sql3);
                case 4:
                    return ListAppointments(sql4);
            }
            return null;
        }

        public void closeAppointment(int id)
        {
            String sql = "UPDATE appointments SET status='solved' WHERE ID='" + id + "'";
            _conn.Open();
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.ExecuteNonQuery();
            _conn.Close();
            
        }
    }
}
