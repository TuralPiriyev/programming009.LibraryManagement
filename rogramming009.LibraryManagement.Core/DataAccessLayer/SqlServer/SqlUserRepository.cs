

using programming009.LibraryManagement.Core.Domain.Entities;
using programming009.LibraryManagement.Core.Domain.Repositories;
using rogramming009.LibraryManagement.Core.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming009.LibraryManagement.Core.DataAccessLayer.SqlServer
{
    public class SqlUserRepository : IUserRepository
    {
        private readonly string _connectionString;

        public SqlUserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(User user)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            const string query = @"insert into users values(@username, @passwordhash, @email)";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("username", user.Username);
            cmd.Parameters.AddWithValue("passwordhash", user.PasswordHash);
            cmd.Parameters.AddWithValue("email", user.Email);
            cmd.ExecuteNonQuery();
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public User Get(string username, SqlConnection connection)
        {
            connection.Open();

            const string query = "select * from users where username = @username";
            SqlCommand cmd = new SqlCommand(query, connection);

            object value = cmd.Parameters.AddWithValue("username", username);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return Mapper.MapUser(reader);
            }

            return null;
        }

        public User Get(string username)
        {
            throw new NotImplementedException();
        }
    }
}