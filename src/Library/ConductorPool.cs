// Separamos ConductorPool de la clase Conductor porque el ConductorPool debe conocer la
// capacidad máxima de pasajeros que esta dispuesto a llevar, mientras que al conductor
// esto no le importa porque por defecto solo esta dispuesto a llevar a 1 pasajero.
namespace PII_Herencia
{
    public class ConductorPool : Conductor
    {
        private int capacidad;
        public int Capacidad
        {
            get
            {
                return this.capacidad;
            }
            set
            {
                this.capacidad = value;
            }
        }
        public ConductorPool(string nombre, string apellido, int capacidad) 
            : base(nombre, apellido)
        {
            this.Capacidad = capacidad;
        }
    }
}