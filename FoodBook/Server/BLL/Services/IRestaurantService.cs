using BO.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface IRestaurantService
    {
        #region ingredients

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
        #endregion
    }
}