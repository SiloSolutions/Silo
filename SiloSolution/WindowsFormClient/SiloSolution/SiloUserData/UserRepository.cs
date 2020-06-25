using SiloUserModel;
using System;
using System.Data.SqlClient;
using Dapper;
using System.Threading;
using System.IO;

namespace SiloUserData
{
    public class UserRepository : IUserRepository
    {

        private readonly string _connectionString;


        public UserRepository(string configuration)
        {
            _connectionString = configuration;
        }

        public User GetUser(string username, string password)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                const string query = @"select FirstName, LastName, Username, Password from Users " +
                                    "where Username = @Username and Password = @Password";
                return connection.QueryFirstOrDefault<User>(query, new
                {
                    Username = username,
                    Password = password
                });

            }
        }

        public User SelectUser(string username)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                const string query = @"select FirstName, LastName, Username, Password from Users " +
                                    "where Username = @Username";
                return connection.QueryFirstOrDefault<User>(query, new
                {
                    Username = username,
                });

            }
        }

        public User Insert(User user)
        {
            var control = new User();
            using (var connection = new SqlConnection(_connectionString))
            {
                const string query = @"select Username from Users " +
                                    "where Username = @Username";
                control = connection.QueryFirstOrDefault<User>(query, new
                {
                    Username = user.Username
                });

            }

            if (control == null)
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    const string query = @"insert into Users (Username, FirstName, LastName, Password) " +
                                        "values (@Username, @FirstName, @LastName, @Password)";

                    connection.Execute(query, user);
                }

                using (var connection = new SqlConnection(_connectionString))
                {
                    const string query = @"select Username from Users " +
                                        "where Username = @Username";
                    return connection.QueryFirstOrDefault<User>(query, new
                    {
                        Username = user.Username
                    });

                }
            }
            else
            {
                if (control.Username == user.Username)
                {
                    return null;
                }
                else
                {
                    return new User
                    {
                        Username = control.Username
                    };
                }
            }
        }

        public int Update(User user)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                const string query = @"update Users 
                                        set 
                                            Username = @Username, 
                                            FirstName = @FirstName,
                                            LastName = @LastName,
                                            Password = @Password
                                        where Username = @Username";

                return connection.Execute(query, user);
            }
        }
    }
}
