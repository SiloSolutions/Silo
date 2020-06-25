using SiloUserModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace SiloUserData
{
    public class DataRepository : IDataRepository
    {
        private readonly string _connectionString;


        public DataRepository(string configuration)
        {
            _connectionString = configuration;
        }

        public IEnumerable<Data> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                const string query = @"select CreationDate, LiquidLevel, Pressure, Temperature
                                    from Lambda 
                                    order by CreationDate desc";
                return connection.Query<Data>(query);
            }
        }

        public Data LastInsert()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                const string query = @"select CreationDate, LiquidLevel, Pressure, Temperature
                                    from Lambda 
                                    order by CreationDate desc";
                return connection.QueryFirstOrDefault<Data>(query);
            }
        }

        public IEnumerable<Data> GetCurrentDay(DateTime date)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                const string query = @"select CreationDate, LiquidLevel, Pressure, Temperature
                                    from Lambda 
                                    where CreationDate >= @date 
                                    order by CreationDate desc";
                return connection.Query<Data>(query, new
                {
                    date = date
                });
            }
        }

        public IEnumerable<Data> SelectDate(DateTime dateFrom, DateTime dateTo)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                const string query = @"select CreationDate, LiquidLevel, Pressure, Temperature
                                    from Lambda  
                                    where CreationDate between @dateFrom and @dateTo 
                                    order by CreationDate desc";
                return connection.Query<Data>(query, new
                {
                    dateFrom = dateFrom,
                    dateTo = dateTo
                });
            }
        }
    }
}
