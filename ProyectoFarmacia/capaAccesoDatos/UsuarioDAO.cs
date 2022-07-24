namespace capaAccesoDatos
{
    using System.Data.SqlClient;
    using System.Data;
    using capaSoporte.Cache;

    public class UsuarioDAO: ConnectionToSql
    {
        //LOGIN
        public bool login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * From TABLA_USUARIO where USER_USUARIO= @user And PASSWORD_USUARIO= @pass ";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //Ojo aqui, Esto tiene que ver con los campos tabla de la base de datos
                            UsuarioCache.idUsuario = reader.GetInt32(0);
                            UsuarioCache.Usuario = reader.GetString(1);
                            UsuarioCache.Contraseña = reader.GetString(2);
                            UsuarioCache.Nombre = reader.GetString(3); 
                            UsuarioCache.APaterno = reader.GetString(4);
                            UsuarioCache.AMaterno = reader.GetString(5);
                            UsuarioCache.idTipoUsuario = reader.GetInt32(7);
                            UsuarioCache.Activo = reader.GetBoolean(6);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }

            }
        }


        public void insertarUsuario(int idUsuario, string Usuario, string Contraseña, string Nombre, string APaterno, string AMaterno, int ID_TIPO_USUARIO )
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Insert Into TABLA_USUARIO Values(" + idUsuario + ", '" + Usuario + "', '" + Contraseña + "', '" + Nombre + "', '" + APaterno + "', '" + AMaterno + "'," + ID_TIPO_USUARIO + ",1)";
                    command.ExecuteNonQuery();
                }
            }
          
        }

        public void borrarUsuario(int idUsuario)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    string Active = "false";
                    command.Connection = connection;
                    command.CommandText = "update TABLA_USUARIO  Set ACTIVO= '" + Active + "' where ID_USUARIO = " + idUsuario;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void editarUsuario(int idUsuario, int idUsuarioTipo, string Nombre, string APaterno, string AMaterno, string Usuario, string Password, bool Active)
        {
            //using (var connecttion = GetConnection())
            //{
            //    connecttion.Open();
            //    using (var command = new SqlCommand())
            //    {
            //        command.Connection = connecttion;
            //        command.CommandText = "update TABLA_TIPOS_EMPLEADO Set ID_TIPO_USUARIO = " + idUsuarioTipo + ", DESCRIPCION = " + idUsuarioTipo + " where ID_TIPO_USUARIO = " + idUsuarioTipo;

            //        command.ExecuteNonQuery();
            //    }
            //}

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    
                    command.CommandText = "update TABLA_USUARIO Set ID_USUARIO= " + idUsuario + ", ID_TIPO_USUARIO= " + idUsuarioTipo + ", NOMBRE_U= '" + Nombre + "', APELLIDO_P_U= '" + APaterno + "', APELLIDO_M_U= '" + AMaterno + "', USER_USUARIO= '" + Usuario + "', PASSWORD_USUARIO=  '" + Password + "', ACTIVO = '" + Active + "'  where ID_USUARIO = " + idUsuario;
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool verificaUsuario(string Nombre, string APaterno, string AMaterno)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * from TABLA_USUARIO Where NOMBRE_U= @Nombre And APELLIDO_P_U= @APaterno And APELLIDO_M_U = @AMaterno";
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@APaterno", APaterno);
                    command.Parameters.AddWithValue("@AMaterno", AMaterno);

                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {

                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }

            }
        }

    }
}
