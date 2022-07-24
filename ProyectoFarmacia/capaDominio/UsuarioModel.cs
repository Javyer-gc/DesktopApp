namespace capaDominio
{
    using capaAccesoDatos;

    public class UsuarioModel
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        persistencia persistencia = new persistencia();

        public bool LoginUser(string user, string pass)
        {
            return usuarioDAO.login(user, pass);
        }

        public void insertarUsuario( string Nombre, string APaterno, string AMaterno, string Usuario, string Password, int ID_TIPO_USUARIO)
        {
            int ID = persistencia.siguienteID("TABLA_USUARIO", "ID_USUARIO");
            usuarioDAO.insertarUsuario(ID, Usuario, Password, Nombre, APaterno, AMaterno, ID_TIPO_USUARIO);
        }

        public void borrarUsuario(int idUsuario)
        {
            usuarioDAO.borrarUsuario(idUsuario);
        }

        public void editarUsuario(int idUsuario, int idUsuarioTipo, string Nombre, string APaterno, string AMaterno, string Usuario, string Password)
        {

            usuarioDAO.editarUsuario(idUsuario, idUsuarioTipo, Nombre, APaterno, AMaterno, Usuario, Password, true);
        }

        public bool verificaUsuario(string Nombre, string APaterno, string AMaterno)
        {
            return usuarioDAO.verificaUsuario(Nombre, APaterno, AMaterno);
        }


    }
}
