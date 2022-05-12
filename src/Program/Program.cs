using System;
using System.Collections;

namespace PII_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            En éste método deberas mostrar un ejemplo de funcionamiento de tu programa an pseudocódigo. A continuación te 
            planteamos un ejemplo de como hacerlo. Esto no significa que te limites a hacer solamente esto, debes pensar 
            en grande!*/

            Usuario pasajero1 = new Pasajero("Roberto","Suarez");
            Usuario conductor1 = new Conductor("Pepe","Ruiz");
            Usuario conductorPool1 = new ConductorPool("Jose Manuel","Piriz", 3);
            UcuRideShare<Usuario> rideShare = UcuRideShare<Usuario>.Instance;
            rideShare.Add(pasajero1);
            
            rideShare.Add(conductor1);
           // Se publica en Twitter un nuevo conductor!

            rideShare.Add(conductorPool1);
            //Se publica en Twitter un nuevo conductor!
            rideShare.Mostrar();

            
        }
    }
}
