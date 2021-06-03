using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLC.Services
{
    public class AuthentificationService
    {
        //Mon instance dans toute l'application : 
        private static AuthentificationService _instance;
        private static readonly object locker = new();

        //private static Lazy<AuthentificationService> _instance = 
        //    new Lazy<AuthentificationService>(() => new AuthentificationService());
        
        //Pattern Singleton : (Constructeur doit être privé)
        private AuthentificationService()
        {

        }
        public static AuthentificationService GetInstance()
        {
            // Double Vérification, c'est comme Double Dragon mais avec des if. 
            if (_instance == null)
            {
                // Goulot d'étranglement. Fait passer les processus un par un. 
                lock (locker)
                {
                    // Si l'instanche n'existe pas
                    if (_instance == null)
                    {
                        // Création.
                        _instance = new AuthentificationService();
                    }
                }
            }
            
            //Quoi qu'il arrive retourne l'instance.
            return _instance;
        }
    }
}
