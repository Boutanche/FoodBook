using BO.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface IRestaurantService
    {
        #region Ingredients
        /// <summary>
        /// Récupérer un ingrédient par son identifiant
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Ingredients> GetIngredientById(int id);
        /// <summary>
        /// Créer un ingrédient
        /// </summary>
        /// <param name="ingredient"></param>
        /// <returns></returns>
        Task<Ingredients> CreateIngredient(Ingredients ingredient);
        /// <summary>
        /// Modifier un ingrédient
        /// </summary>
        /// <param name="ingredient"></param>
        /// <returns></returns>
        Task<Ingredients> ModifyIngredient(Ingredients ingredient);
        /// <summary>
        /// Supprimer un ingrédient
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> RemoveIngredientById(int id);
        

        /// <summary>
        /// Récupérer la liste de tous les ingrédients
        /// </summary>
        /// <returns></returns>
        Task<List<Ingredients>> GetAllIngredients();
        #endregion
        #region Dish
        /// <summary>
        /// Récupérer la liste de tous les plats
        /// </summary>
        /// <returns></returns>
        Task<List<Dish>> GetAllDish();
        /// <summary>
        /// Récupérer un plat par son Id.
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>Dish</returns>
        Task<Dish> GetDishById(int id);
        /// <summary>
        /// Créer un plat
        /// </summary>
        /// <param name="dish">Dish</param>
        /// <returns>Dish</returns>
        Task<Dish> CreateDish(Dish dish);


        /// <summary>
        /// Modifé un plat
        /// </summary>
        /// <param name="dish">Dish</param>
        /// <returns>Dish</returns>
        Task<Dish> ModifyDish(Dish dish);
        /// <summary>
        /// Supprimer un plat
        /// </summary>
        /// <param name="id">Int</param>
        /// <returns>Code No Content : 204</returns>
        Task<bool> RemoveDishById(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Dish> GetIngredientsOfDishById(int id);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<Dish> GetDishByName(string name);
        #endregion
        #region TypeOfDish
        /// <summary>
        /// Récupérer tous les Type Of Dish
        /// </summary>
        /// <returns></returns>
        Task<List<TypeOfDish>> GetAllTypeOfDish();
        /// <summary>
        /// Récupérer un Type Of Dish par son id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TypeOfDish> GetTypeOfDishById(int id);
        #endregion
        #region Service
        /// <summary>
        /// Trouver un service par son Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Service</returns>
        Task<Service> GetServiceById(int id);
        /// <summary>
        /// Trouver les services qui composent un menu de la semaine
        /// </summary>
        /// <param name="idMenu">int</param>
        /// <returns>List des services du menu de la semaine</returns>
        Task<List<Service>> GetServicesByIdMenu(int idMenu);
        /// <summary>
        /// Créer un service
        /// </summary>
        /// <param name="service"></param>
        /// <returns>Service</returns>
        Task<Service> CreateService(Service service);


        /// <summary>
        /// Ajouter un plat au service
        /// </summary>
        /// <param name="dish"></param>
        /// <param name="service"></param>
        /// <returns>Bool</returns>
        Task<bool> AddDishForThisService(Dish dish, Service service);
        /// <summary>
        /// Supprimer un plat du Service
        /// </summary>
        /// <param name="dish"></param>
        /// <param name="service"></param>
        /// <returns>Bool</returns>
        Task<bool> RemoveDishForThisService(Dish dish, Service service);
        #endregion
        #region Menu
        /// <summary>
        /// Menu Suivant
        /// </summary>
        /// <param name="date"></param>
        /// <returns>Menu</returns>
        Task<DateTime> NextMenu(DateTime date);


        /// <summary>
        /// Menu Précédent
        /// </summary>
        /// <param name="date"></param>
        /// <returns>Menu</returns>
        Task<DateTime> PreviousMenu(DateTime date);
        /// <summary>
        /// Trouver l'id d'un menu par sa date
        /// </summary>
        /// <param name="date"></param>
        /// <returns>Int</returns>
        Task<int> GetIdMenuByDate(DateTime date);
        /// <summary>
        /// Trouver un menu par son Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Menu</returns>
        Task<Menu> GetServicesOfMenuById(int id);

        #endregion
        #region ListOfIngredient
        /// <summary>
        /// Récupérer toutes les listOfIngredient: table de liaison en Ingredient et Dish
        /// </summary>
        /// <returns></returns>
        Task<List<ListOfIngredient>> GetAllListOfIngredient();
        /// <summary>
        /// Récupérer les ListOfIngredient qui composent un plat désigné par on id.
        /// </summary>
        /// <returns></returns>
        Task<List<ListOfIngredient>> GetListOfIngredientByIdDish(int idDish);
        /// <summary>
        /// Créer une ListOfIngredient
        /// </summary>
        /// <param name="listOfIngredient"></param>
        /// <returns></returns>
        Task<ListOfIngredient> CreateListOfIngredient(ListOfIngredient listOfIngredient);
        /// <summary>
        /// Modifier un ...
        /// Penser que id = int32.Parse(idIngredient.toString() + idDish.toString())
        /// </summary>
        /// <param name="listOfIngredient"></param>
        /// <returns></returns>
        Task<ListOfIngredient> ModifyListOfIngredient(ListOfIngredient listOfIngredient);
        /// <summary>
        /// Supprimer un ListOfIngredient
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> RemoveListOfIngredientById(int id);
        #endregion

    }
}