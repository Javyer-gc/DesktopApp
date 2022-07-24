namespace capaAccesoDatos
{
    using System.Data.SqlClient;
    public abstract class ConnectionToSql
    {
        private readonly string connectionString;

        public ConnectionToSql()
        {
            connectionString = "Data Source=(local)\\SQLEXPRESS; DataBase=BD_FARMACIA; integrated security = true";

        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
