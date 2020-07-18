using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class DataAccess : IDataAccess
    {
        public async Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString)
        {
            using (IDbConnection con = new SqlConnection(connectionString))
            {
                var rows = await con.QueryAsync<T>(sql, parameters);
                return rows.ToList();
            }
        }

        public Task SaveDataAsync<T>(string sql, T parameters, string connectionString)
        {
            using (IDbConnection con = new SqlConnection(connectionString))
            {
                return con.ExecuteAsync(sql, parameters);
            }
        }

        public void SaveData<T>(string sql, T parameters, string connectionString)
        {
            using (IDbConnection con = new SqlConnection(connectionString))
            {
                con.Execute(sql, parameters);
            }
        }
    }
}
