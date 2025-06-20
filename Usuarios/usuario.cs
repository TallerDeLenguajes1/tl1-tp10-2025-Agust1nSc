namespace EspacioUsuarios
{
    public class Direccion
    {
        public string street { get; set; }
        public string suite { get; set; }
        public string city { get; set; }
        public string zipcode { get; set; }
    }

    public class Usuario
    {
        public string name { get; set; }
        public string email { get; set; }
        public Direccion address { get; set; }
    }

}