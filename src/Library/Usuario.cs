// Usuario es la clase base de Conductor y Pasajero. Por ello es que aqui se encuentran todos los atributos
// compartidos de ambas clases.
namespace PII_Herencia
{
    public abstract class Usuario
    {
        private string nombre;
        private string apellido;
        private string cedula;
        private string foto;
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        public string Cedula
        {
            get
            {
                return this.cedula;
            }
        }
        public string Foto
        {
            get
            {
                return this.foto;
            }
        }
        public string Message {get;}
        public Usuario (string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public virtual void Mensaje()
        {
        }
    }
}