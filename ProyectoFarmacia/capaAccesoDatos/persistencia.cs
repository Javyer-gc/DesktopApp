
namespace capaAccesoDatos
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

   public class persistencia : ConnectionToSql
    {
        public int siguienteID(string TableName, string IDField)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    int Val;
                    command.Connection = connection;
                    command.CommandText = "Select MAX(" + IDField + ") From " + TableName;
                    object maxValue = command.ExecuteScalar();
                    connection.Close();
                    if (maxValue == DBNull.Value)
                    {
                        return 1;
                    }
                    else
                    {
                        Val = int.Parse((maxValue).ToString());
                        return Val + 1;
                    }


                }
            }
        }
    }
}
