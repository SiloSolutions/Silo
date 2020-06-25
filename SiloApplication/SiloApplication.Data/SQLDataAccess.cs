using Microsoft.Data.SqlClient;
using SiloApplication.Models;
using System;

namespace SiloApplication.Data
{
    public class SQLDataAccess : IDataAccess
    {

        private readonly string _connectionString;

        public SQLDataAccess()
        {
            _connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");
        }

        public void Insert(Lambda lambda)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var query = "INSERT INTO Lambda (LiquidLevel,Pressure,Temperature,CreationDate) VALUES (@LiquidLevel,@Pressure,@Temperature,@CreationDate)";

                //Replaced Parameters with Value
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@LiquidLevel", lambda.LiquidLevel);
                    cmd.Parameters.AddWithValue("@Pressure", lambda.Pressure);
                    cmd.Parameters.AddWithValue("@Temperature", lambda.Temperature);
                    cmd.Parameters.AddWithValue("@CreationDate", lambda.CreationDate);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
