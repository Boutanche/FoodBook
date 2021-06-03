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
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:5001/api/v1.0/")
            };
        }
        //TODO : Faire des régions : ce qui concerne les plats, les ingrédients, etc...
        
        /// <summary>
        /// Créer un plat
        /// </summary>
        /// <param name="newDish"></param>
        /// <returns></returns>
        public async Task<Dish> CreateDish(Dish newDish)
        {
            //WIP : If is logged ?

            //TODO : Travailler sur la vérification du Token de connexion.

            var response = await _httpClient.PostAsync("dish",
                new StringContent(JsonSerializer.Serialize(newDish), Encoding.UTF8, "application/json"));
            if (response.IsSuccessStatusCode)
            {
                using var stream = await response.Content.ReadAsStreamAsync();
                Dish dish = await JsonSerializer.DeserializeAsync<Dish>(stream, new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                return dish;
            }
            else
            {
                return null;
            };
        }
        /// <summary>
        /// Créer un ingrédient
        /// </summary>
        /// <param name="ingredient"></param>
        /// <returns></returns>
        public async Task<Ingredients> CreateIngredients(Ingredients ingredient)
        {
            var response = await _httpClient.PostAsync("ingredients",
                new StringContent(
                    JsonSerializer.Serialize(ingredient), Encoding.UTF8, "application/json"));
            if (response.IsSuccessStatusCode)
            {
                using var stream = await response.Content.ReadAsStreamAsync();
                Ingredients newIngredient = await JsonSerializer.DeserializeAsync<Ingredients>(stream, new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                return newIngredient;
            }
            else
            {
                return null;
            };
        }
        /// <summary>
        /// Créer un élément de liaison entre un plat et un ingrédient
        /// </summary>
        /// <param name="listOfIngredient"></param>
        /// <returns></returns>
        public async Task<ListOfIngredient> CreateListOfIngredient(ListOfIngredient listOfIngredient)
        {
            var response = await _httpClient.PostAsync("listOfIngredient",
                new StringContent(
                    JsonSerializer.Serialize(listOfIngredient), Encoding.UTF8, "application/json"));
            if (response.IsSuccessStatusCode)
            {
                using var stream = await response.Content.ReadAsStreamAsync();
                ListOfIngredient newListOfIngredient = await JsonSerializer.DeserializeAsync<ListOfIngredient>(stream, new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                return newListOfIngredient;
            }
            else
            {
                return null;
            };
        }

        public async Task<List<Dish>> GetAllDish()
        {
            var reponse = await _httpClient.GetAsync("dish");
            if (reponse.IsSuccessStatusCode)
            {
                using var stream = await reponse.Content.ReadAsStreamAsync();
                //Ici reception de json qu'il faut que je remette en objet C#.
                List<Dish> dishesPage = await JsonSerializer.DeserializeAsync<List<Dish>>
                    (stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                return dishesPage;
            }
            else
            {
                //Faudra traiter ça sur l'interface si problème.
                return null;
            }
            throw new NotImplementedException();
        }

        /// <summary>
        /// Récupérer la liste de tous les ingrédients.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Ingredients>> GetAllIngredients()
        {
            //var reponse = await _httpClient.GetAsync($"ingredients?page={pageRequest.Page}&pageSize={pageRequest.PageSize}");
            //var reponse = await _httpClient.GetAsync($"ingredients{pageRequest.ToUriQuery()}");
            var reponse = await _httpClient.GetAsync("ingredients");

            // Si la requete a reussi
            if (reponse.IsSuccessStatusCode)
            {
                using var stream = await reponse.Content.ReadAsStreamAsync();
                //Ici reception de json qu'il faut que je remette en objet C#.
                List<Ingredients> ingredientsPage = await JsonSerializer.DeserializeAsync<List<Ingredients>>
                    (stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                return ingredientsPage;
            }
            else
            {
                //Faudra traiter ça sur l'interface si problème.
                return null;
            }
        }

        /// <summary>
        /// Récupérer un plat par son nom
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<Dish> GetDishByName(string name)
        {
            var reponse = await _httpClient.GetAsync($"dish/name/{name}");
            if (reponse.IsSuccessStatusCode)
            {
                using var stream = await reponse.Content.ReadAsStreamAsync();
                //Ici reception de json qu'il faut que je remette en objet C#.
                Dish dish = await JsonSerializer.DeserializeAsync<Dish>
                    (stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                return dish;
            }
            else
            {
                //Faudra traiter ça sur l'interface si problème.
                return null;
            }
        }
    }
}
