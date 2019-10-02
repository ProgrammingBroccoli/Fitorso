using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;

namespace DAL
{
    public class UserMemoryContext : IUserDB
    {
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Ruben\\Desktop\\Fitorso\\Fitorso\\Fitorso\\App_Data\\Database1.mdf;Integrated Security=True");
        SqlCommand command = new SqlCommand();

        public UserMemoryContext()
        {
            command.Connection = connection;
        }

        public void RegisterNewAccount(string email, string password)
        {
            connection.Open();
            command.CommandText = "INSERT INTO [User] (Email, Password) VALUES ('" + email + "', '" + password + "')";
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
