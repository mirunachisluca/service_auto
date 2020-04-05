using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace service_auto.DAL
{
    public class UsersDAO
    {
        private static UsersDAO _usersDAO = null;
        private String _connectionString = @"Data Source=DESKTOP-4TP9P9L;Initial Catalog=service_auto;Trusted_Connection=Yes;";
        SqlConnection _conn = null;

        private UsersDAO()
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

        public static UsersDAO getInstance()
        {
            if (_usersDAO == null)
            {
                _usersDAO = new UsersDAO();
            }
            return _usersDAO;
        }


        public User getUser(String username, String password)
        {
            User u = null;
            String sql = "SELECT * FROM users WHERE username='" + username + "' AND password='" + password + "'";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                    u = new User((int)reader["ID"], reader["username"].ToString(), reader["password"].ToString(), reader["role"].ToString());
                else
                    u = null;
                _conn.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return u;
        }

        public void createAgent(String username, String password)
        {
            String sql = "INSERT INTO users (username, password, role) VALUES ('"+username+"', '"+password+"', 'agent')";
            _conn.Open();
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.ExecuteNonQuery();
            _conn.Close();
        
        }

    }
}
