using Dapper.Contrib.Extensions;
using SiloUserModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Dapper;

namespace SiloUserData
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly string _connectionString;

        public ActivityRepository()
        {
            this._connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=boredApi;Integrated Security=True;Pooling=False";
        }
        public IEnumerable<BoredApi> GetCategories()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                const string query = @"select * 
                                    from boredApi 
                                    order by CreationDate desc";
                return connection.Query<BoredApi>(query);
            }
        }

        public IEnumerable<BoredApi> SelectDate(DateTime dateFrom, DateTime dateTo)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                const string query = @"select * 
                                    from boredApi 
                                    where CreationDate between @dateFrom and @dateTo 
                                    order by CreationDate desc";
                return connection.Query<BoredApi>(query, new
                {
                    dateFrom = dateFrom,
                    dateTo = dateTo
                });
            }
        }
    }
}
