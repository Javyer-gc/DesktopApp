namespace capaSoporte.Cache
{
    public static class UsuarioCache
    {      
        //Aqui van los el Nombre de los Campos de la tabla de la base de datos
        //Por lo que Estos formatos podrian Cambiar, que es muy posible Javi, hay que checar esto con Apk y Chucho
        //Escribi estos Como Referencia
        public static int idUsuario { get; set; }

        public static string Usuario { get; set; }

        public static string Contraseña { get; set; }

        public static string Nombre { get; set; }

        public static string APaterno { get; set; }

        public static string AMaterno { get; set; }

        public static int idTipoUsuario { get; set; }

        public static bool Activo { get; set; }


    }
}
