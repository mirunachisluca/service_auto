using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service_auto
{
    public class User
    {
        private int id;
        private string username;
        private string password;
        private string role;

        public User(int id, string username, string password, string role)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public string getRole()
        {
            return role;
        }
    }
}
