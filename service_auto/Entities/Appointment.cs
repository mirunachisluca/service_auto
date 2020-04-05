using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service_auto.Entities
{
    public class Appointment
    {
        private int id;
        private DateTime datetime;
        private String clientName;
        private String phone;
        private String car;
        private String problem;
        private String status;

        public Appointment(int id, DateTime datetime, String clientName, String phone, String car, String problem, String status)
        {
            this.id = id;
            this.datetime = datetime;
            this.clientName = clientName;
            this.phone = phone;
            this.car = car;
            this.problem = problem;
            this.status = status;
        }

        public int Id
        {
            get { return id; }
        }

        public DateTime Datetime
        {
            get { return datetime; }
        }
        public String ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }

        public String Phone
        {
            get { return phone; }
        }
        public String Car
        {
            get { return car; }
        }
        public String Problem
        {
            get { return problem; }
        }
        public String Status
        {
            get { return status; }
        }


    }
}
