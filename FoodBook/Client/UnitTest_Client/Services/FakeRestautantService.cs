using BLLC.Services;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_Client.Services
{
    /// <summary>
    /// Service Fictif pour les tests unitaires côté Client.
    /// </summary>
    class FakeRestautantService : IRestaurantService
    {

        #region Ingredients
        /// <summary>
        /// Créer une fausse liste d'ingrédients pour simuler la BDD.
        /// Ce sont des Mock ?
        /// </summary>
        public List<Ingredients> ingredientsFakeDB = new()
        {
            new Ingredients(1, "Fake_Apple", 10.02m),
            new Ingredients(2, "Fake_Banana", 10.02m),
            new Ingredients(3, "Fake_Carrot", 10.02m),
            new Ingredients(4, "Fake_Apple", 10.02m),
        };
        /// <summary>
        /// Créer des Ingredients
        /// </summary>
        /// <param name="ingredients">Un ingrédient, qui composera peut-être un plat</param>
        /// <returns>Un ingrédient : permet de composer des plats</returns>
        public Task<Ingredients> CreateIngredients(Ingredients ingredient)
        {
            return Task.FromResult(ingredient);
        }
        /// <summary>
        /// Créer une liste d'ingrédients
        /// </summary>
        /// <param name="listOfIngredient">Liste d'ingrédients utilisé pour composer un plat</param>
        /// <returns>Une liste de d'ingrédients qui permet de connaitre la composition d'un plat</returns>
        public Task<ListOfIngredient> CreateListOfIngredient(ListOfIngredient listOfIngredient)
        {
            return Task.FromResult(listOfIngredient);
        }
        /// <summary>
        /// Récupérer tous les ingrédients
        /// </summary>
        /// <returns>Liste de tous les ingredients</returns>
        public Task<List<Ingredients>> GetAllIngredients()
        {
            return Task.FromResult(ingredientsFakeDB);
        }
        
        #endregion

        #region Dishes
        /// <summary>
        /// Créer un plat
        /// </summary>
        /// <param name="newDish"></param>
        /// <returns></returns>
        public Task<Dish> CreateDish(Dish newDish)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Récupérer tous les plats
        /// </summary>
        /// <returns></returns>
        public Task<List<Dish>> GetAllDish()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Récupérer un plat par son Identifiant
        /// </summary>
        /// <param name="idDish"></param>
        /// <returns></returns>
        public Task<Dish> GetDishById(int? idDish)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Récupérer un plat par son nom
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Task<Dish> GetDishByName(string name)
        {
            throw new NotImplementedException();
        }
        
        #endregion

        #region TypeOfDish
        
        #endregion

        #region Services
        /// <summary>
        /// Ajouter un plat à un service
        /// </summary>
        /// <param name="createdService"></param>
        /// <returns></returns>
        public Task<Service> AddDishToService(Service createdService)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Créer un service
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        public Task<Service> CreateService(Service service)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Récupérer un service par son plat
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public Task<List<Service>> GetServiceByDate(DateTime dateTime)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Booking
        /// <summary>
        /// Créer une réservation
        /// </summary>
        /// <param name="newBooking"></param>
        /// <returns></returns>
        public Task<Booking> CreateBooking(Booking newBooking)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IsComposed
        /// <summary>
        /// Créer une composition
        /// </summary>
        /// <param name="newIsComposed"></param>
        /// <returns></returns>
        public Task<IsComposed> CreateIsComposed(IsComposed newIsComposed)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Récupérer les compositions par l'ID du service
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<List<IsComposed>> GetIsComposedByIdService(int? id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
