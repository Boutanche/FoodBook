using BO.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLLC.Services
{
    /// <summary>
    /// Interface des données : Contient toutes les méthodes qui me permettent de récupérer les données 
    /// Ici : concernant l'aspect "Restaurant" de l'API        
    /// </summary>
    public interface IRestaurantService
    {
        #region Ingredients
        /// <summary>
        /// Répuréer la liste de tous les ingrédients
        /// </summary>
        /// <returns>Liste d'ingrédients</returns>
        Task<List<Ingredients>> GetAllIngredients();
        /// <summary>
        /// Créer un ingrédient
        /// </summary>
        /// <param name="ingredients"></param>
        /// <returns>Task : Créer un ingrédient</returns>
        Task<Ingredients> CreateIngredients(Ingredients ingredients);
        #endregion
        
        #region Dish
        /// <summary>
        /// Créer un plat
        /// </summary>
        /// <param name="newDish"></param>
        /// <returns></returns>
        Task<Dish> CreateDish(Dish newDish);
        /// <summary>
        /// Récupérer un plat par son nom
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<Dish> GetDishByName(string name);
        /// <summary>
        /// Récupérer un plat par son Id
        /// </summary>
        /// <param name="idDish"></param>
        /// <returns></returns>
        Task<Dish> GetDishById(int? idDish);
        /// <summary>
        /// Récupérer tous les plats
        /// </summary>
        /// <returns></returns>
        Task<List<Dish>> GetAllDish();
        #endregion

        #region ListOfIngredient
        /// <summary>
        /// Créer une liste d'ingrédients
        /// </summary>
        /// <param name="listOfIngredient"></param>
        /// <returns></returns>
        Task<ListOfIngredient> CreateListOfIngredient(ListOfIngredient listOfIngredient);
        #endregion

        #region Menu
        // /!\ : Menu n'existe plus !!
        //Task<Menu> CreateMenu(Menu newMenu);

        #endregion

        #region Booking
        /// <summary>
        /// Créer une réservation
        /// </summary>
        /// <param name="newBooking"></param>
        /// <returns></returns>
        Task<Booking> CreateBooking(Booking newBooking);
        #endregion

        #region Service
        /// <summary>
        /// Créer un service :
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        Task<Service> CreateService(Service service);
        /// <summary>
        /// Récupérer la liste des services par date :
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        Task<List<Service>> GetServiceByDate(DateTime dateTime);
        /// <summary>
        /// Ajouter un plat au service :
        /// </summary>
        /// <param name="createdService"></param>
        /// <returns></returns>
        Task<Service> AddDishToService(Service createdService);
        #endregion

        #region IsComposed
        /// <summary>
        /// Créer un IsComposed
        /// </summary>
        /// <param name="newIsComposed"></param>
        /// <returns></returns>
        Task<IsComposed> CreateIsComposed(IsComposed newIsComposed);
        /// <summary>
        /// Récupérer la liste des IsComposed par l'Id du Service 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<List<IsComposed>> GetIsComposedByIdService(int? id);


        #endregion
    }
}