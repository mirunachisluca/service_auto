using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service_auto
{
    public class User
    {
        private string username;
        private string password;
        private string role;

        public User(string username, string password, string role)
        {
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
