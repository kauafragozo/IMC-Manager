using System.Data;
using Microsoft.Data.SqlClient;
using ImcProgram.Entities;
using Dapper;


namespace ImcProgram.Data
{

    public class DataContext
    {

        Pacientes pacientes = new Pacientes();
        private string _connectionString = "Server=localhost\\SQLEXPRESS;Database=IMCMANAGERDB;TrustServerCertificate=true;Trusted_Connection=true;";

        public IEnumerable<T> LoadData<T>(string sql)
        {
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            return dbConnection.Query<T>(sql);

        }


        public T LoadDataSingle<T>(string sql)
        {
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            return dbConnection.QuerySingle<T>(sql);

        }

        public Boolean ExecuteSql<T>(string sql)
        {

            IDbConnection dbConnection = new SqlConnection(_connectionString);
            return dbConnection.Execute(sql) > 0;

        }

        public int ExecuteSqlCount<T>(string sql)
        {

            IDbConnection dbConnection = new SqlConnection(_connectionString);
            return dbConnection.Execute(sql);

        }

    }
}