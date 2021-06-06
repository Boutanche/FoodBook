using BO.DTO.Requests;
using BO.DTO.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BLLC.Services
{
    public class AuthentificationService
    {
        // Propriété de classe :
        //Mon instance dans toute l'application : 
        private static AuthentificationService _instance;
        private static readonly object locker = new();

        // Propriétés d'instance :
        public bool IsLogged { get; private set; }

        public string Token { get; private set; }

        //private static Lazy<AuthentificationService> _instance = 
        //    new Lazy<AuthentificationService>(() => new AuthentificationService());
        
        //Pattern Singleton : (Constructeur doit être privé)
        private AuthentificationService()
        {
            IsLogged = false;
            Token = null;
        }
        // Récupérer l'instance :
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
        //Fonction de log :
        public async Task<bool> SignIn(string username, string password)
        {
            var _httpClient = new HttpClient();
            var loginRequest = new LoginRequest()
            {
                Username = username,
                Password = password
            };

            //URI De base pour l'API
            //TODO : un singleton de configuration et y mettre toutes les valeurs.
            _httpClient.BaseAddress = new Uri("https://localhost:5001/api/v1.0/");

            try
            {

                var httpResponse = await _httpClient.PostAsJsonAsync("account/login", loginRequest);
                
                if (httpResponse.IsSuccessStatusCode)
                {
                    var loginResponse = httpResponse.Content.ReadFromJsonAsync<LoginResponse>();
                    IsLogged = true;
                    Token = (await loginResponse).AccessToken;
                    return true;
                }
                return false;
            }
            catch(HttpRequestException e)
            {
                return false;
            }
        }

    }
}
