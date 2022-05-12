namespace PII_Herencia
{
    public class Pasajero : Usuario
    {
       private int calificacionpasajero;
       private int CantidadCalificaciones = 0;
       public new string Message {get; set;}
       public int CalificacionPasajero
       {
           get
           {
               return this.calificacionpasajero;
           }
           set
           {
               this.calificacionpasajero = value;
           }
       }
       public override void Mensaje()
       {
           this.Message = $"Nombre: {this.Nombre}";
       }
        public Pasajero(string nombre, string apellido) 
            : base(nombre, apellido)
        {
        }
        public void CalificarPasajero(int calificacion)
        {
            CantidadCalificaciones ++;
            CalificacionPasajero = (calificacion + CalificacionPasajero*(CantidadCalificaciones-1))/CantidadCalificaciones;
        }

    }
}