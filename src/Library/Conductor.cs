namespace PII_Herencia
{
    public class Conductor : Usuario
    {
       private int calificacionconductor;
       private string biografia;
       private string vehiculo;
       private int CantidadCalificaciones = 0;
       public new string Message {get; set;}
        public int CalificacionConductor
        {
            get
            {
                return this.calificacionconductor;
            }
            set
            {
                this.calificacionconductor = value;
            }
        }
        public string Biografia
        {
           get
           {
               return this.biografia;
           }
           set
           {
               this.biografia = value;
           }
        }      
        public string Vehiculo
        {
            get
            {
                return this.vehiculo;
            }
            set
            {
                this.vehiculo = value;
            }
        }
        public Conductor(string nombre, string apellido)
        : base(nombre, apellido)
        {
        }
        public void CalificarConductor(int calificacion)
        {
            CantidadCalificaciones ++;
            CalificacionConductor = (calificacion + CalificacionConductor*(CantidadCalificaciones-1))/CantidadCalificaciones;
        }
        public override void Mensaje()
       {
           this.Message = $"Nombre: {this.Nombre} \n Bio: \n {this.biografia}";
       }
    }
}