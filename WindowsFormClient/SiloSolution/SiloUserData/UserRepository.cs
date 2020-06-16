using SiloUserModel;
using System;
using System.Data.SqlClient;
using Dapper;
using System.Threading;
using System.IO;
using Dapper.Contrib.Extensions;

namespace SiloUserData
{
    public class UserRepository : IUserRepository
    {

        private readonly string _connectionString;

        public UserRepository()
        {
            this._connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=SiloSolution_Login;Integrated Security=True;Pooling=False";
        }

        public User GetUser(string username, string password)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                const string query = @"select FirstName, LastName, Username, Password from Silo_Users " +
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
                const string query = @"select FirstName, LastName, Username, Password from Silo_Users " +
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
                const string query = @"select Username from Silo_Users " +
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
                    const string query = @"insert into Silo_Users (Username, FirstName, LastName, Password) " +
                                        "values (@Username, @FirstName, @LastName, @Password)";

                    connection.Execute(query, user);
                }

                using (var connection = new SqlConnection(_connectionString))
                {
                    const string query = @"select Username from Silo_Users " +
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
                const string query = @"update Silo_Users 
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
