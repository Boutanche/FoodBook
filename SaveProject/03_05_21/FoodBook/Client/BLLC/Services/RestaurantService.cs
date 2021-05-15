using BO.DTO.Requests;
using BO.DTO.Responses;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BLLC.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly HttpClient _httpClient;
        public RestaurantService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:5001/api/");
        }

        public async Task<List<Ingredients>> GetAllIngredients()
        {
            //var reponse = await _httpClient.GetAsync($"ingredients?page={pageRequest.Page}&pageSize={pageRequest.PageSize}");
            //var reponse = await _httpClient.GetAsync($"ingredients{pageRequest.ToUriQuery()}");
            var reponse = await _httpClient.GetAsync("ingredients");

            // Si la requete a reussi
            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    //Ici reception de json qu'il faut que je remette en objet C#.
                    List<Ingredients> ingredientsPage = await JsonSerializer.DeserializeAsync<List<Ingredients>>
                        (stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return ingredientsPage;
                }
            }
            else
            {
                //Faudra traiter ça sur l'interface si problème.
                return null;
            }
        }

    }
}
