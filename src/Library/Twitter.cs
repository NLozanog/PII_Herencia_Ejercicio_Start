using System;
using TwitterUCU;
using System.Collections.Generic;

// La clase Twitter cumple con el patron Singleton porque no pueden crearse instancias nuevas de la clase.
// Esto lo utilizamos para que, aunque existan muchos objetos UCUrideShare, todos utilizaran la misma instancia
// de Twitter y no ocuparemos mas memoria de la necesaria guardando diferentes instancias de esta clase.
namespace PII_Herencia
{
    public class Twitter
    {
        private readonly static Twitter instance = new Twitter();
        private Twitter()
        {
        }
        public static Twitter Instance
        {
            get
            {
                return instance;
            }
        }
        string consumerKey = "CkovShLMNVCY0STsZlcRUFu99";
        string consumerKeySecret = "6rc35cHCyqFQSy4vIIjKiCYu31qqkBBkSS5BRlqeYCt5r7zO5B";
        string accessTokenSecret = "gNytQjJgLvurJekVU0wmBBkrR1Th40sJmTO8JDhiyUkuy";
        string accessToken = "1396065818-MeBf8ybIXA3FpmldORfBMdmrVJLVgijAXJv3B18";
        public void Send(Usuario usuario)
        {
            var twitter = new TwitterImage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            Console.WriteLine(twitter.PublishToTwitter($"{usuario.Message}" ,$@"{usuario.Foto}"));
            //var twitterDirectMessage = new TwitterMessage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            //Console.WriteLine(twitterDirectMessage.SendMessage("Hola!", "380889967"));
        }   
    }
}