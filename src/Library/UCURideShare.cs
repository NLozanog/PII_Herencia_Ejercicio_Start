using System.Collections.Generic;
using System;

// La clase UCURideShare cumple con el patron Singleton porque solo puede existir una instancia de ella.
// Esto lo hicimos para que la lista de Usuario creada con todos los usuarios del sistema sea única.
namespace PII_Herencia
{
    public class UcuRideShare<Usuario>
    {
        private readonly static UcuRideShare<Usuario> instance = new UcuRideShare<Usuario>();
        private UcuRideShare()
        {
        }
        public static UcuRideShare<Usuario> Instance
        {
            get
            {
                return instance;
            }
        }
        List<PII_Herencia.Usuario> usuarios = new List<PII_Herencia.Usuario>();
        Twitter twitter = Twitter.Instance;
        public void Add(PII_Herencia.Usuario usuario)
        {
            usuarios.Add(usuario);
            twitter.Send(usuario);
        }
        public void Mostrar() 
        {
            Console.WriteLine(usuarios.Count);
        }
    }
}