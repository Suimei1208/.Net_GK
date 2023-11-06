using _521H0049_521H0174.Models;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _521H0049_521H0174
{
    internal class myDAL
    {
        private SqlConnection connection;
        private Models.User User;

        public myDAL()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["StudentInformationDB"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        public void Dispose()
        {
            if (connection != null)
            {
                connection.Dispose();
            }
        }

        // myDAL.UserExists will return true if exist valid parameters, else return false
        public bool UserExists(string username, string password)
        {
            try
            {
                
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password", connection);
                
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count == 1;
                

                

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
