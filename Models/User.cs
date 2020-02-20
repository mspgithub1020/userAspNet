namespace userAspNet.Models
{


    //[{id, email,nombre,apellidos,contraseña,comentarios:[]}]
    public class User
    {
        public long Id { get; set; }
        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Email { get; set; }

        public string Contraseña { get; set; }
    }
}