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
            _httpClient.BaseAddress = new Uri("https://localhost:5001/api/v1.0/");
        }

        public async Task<Dish> CreateDish(Dish newDish)
        {
            var response = await _httpClient.PostAsync("dish",
                new StringContent(JsonSerializer.Serialize(newDish), Encoding.UTF8, "application/json"));
            if (response.IsSuccessStatusCode)
            {
                using (var stream = await response.Content.ReadAsStreamAsync())
                {
                    Dish dish = await JsonSerializer.DeserializeAsync<Dish>(stream, new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return dish;
                }
            }
            else
            {
                return null;
            };
        }

        public async Task<Ingredients> CreateIngredients(Ingredients ingredient)
        {
            var response = await _httpClient.PostAsync("ingredients",
                new StringContent(
                    JsonSerializer.Serialize(ingredient), Encoding.UTF8, "application/json"));
            if (response.IsSuccessStatusCode)
            {
                using (var stream = await response.Content.ReadAsStreamAsync())
                {
                    Ingredients newIngredient = await JsonSerializer.DeserializeAsync<Ingredients>(stream, new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return newIngredient;
                }
            }
            else
            {
                return null;
            };
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
