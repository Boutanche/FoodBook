using BO.Entity;
using DAL.Repository;
using DAL.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    /// <summary>
    /// All concern about restauration service
    /// </summary>
    internal class RestaurantService : IRestaurantService
    {
        private readonly IUnitOfWork _db;
        public RestaurantService(IUnitOfWork unitOfWork)
        {
            _db = unitOfWork;
        }
        #region Ingredients
        /// <summary>
        /// Create an ingredient !
        /// </summary>
        /// <param name="ingredient">Ingredients</param>
        /// <returns>Ingredients</returns>
        public async Task<Ingredients> CreateIngredient(Ingredients ingredient)
        {
            _db.BeginTransaction();
            IIngredientRepository _ingredient = _db.GetRepository<IIngredientRepository>();
            Ingredients newIngredient = await _ingredient.InsertAsync(ingredient);
            _db.Commit();
            return newIngredient;
        }
        /// <summary>
        /// Modify an ingredient
        /// </summary>
        /// <param name="ingredient">Ingredients</param>
        /// <returns>Ingredients</returns>
        public async Task<Ingredients> ModifyIngredient(Ingredients ingredient)
        {
            _db.BeginTransaction();
            IIngredientRepository _ingredients = _db.GetRepository<IIngredientRepository>();
            try
            {
                await _ingredients.UpdateAsync(ingredient);
                _db.Commit();
                return ingredient;
            }
            catch (Exception e)
            {
                _db.Rollback();
                return null;
            }
        }
        /// <summary>
        /// Remove one ingredient with its Id
        /// </summary>
        /// <param name="id">Int</param>
        /// <returns>bool</returns>
        public async Task<bool> RemoveIngredientById(int id)
        {
            _db.BeginTransaction();
            IIngredientRepository _ingredients = _db.GetRepository<IIngredientRepository>();
            try
            {
                var count = await _ingredients.DeleteAsync(id);
                _db.Commit();
                return count > 0;
            }
            catch (Exception e)
            {
                _db.Rollback();
                return false;
            }
        }
        /// <summary>
        /// Get all ingredients
        /// </summary>
        /// <returns>List of Ingredients ></returns>
        public async Task<List<Ingredients>> GetAllIngredients()
        {
            IIngredientRepository _ingredients = _db.GetRepository<IIngredientRepository>();

            List<Ingredients> ingredients = (await _ingredients.GetAllAsync()).ToList();

            return ingredients;
        }
        /// <summary>
        /// Get Ingredient By IF
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Ingredients </returns>
        public async Task<Ingredients> GetIngredientById(int id)
        {

            IIngredientRepository _ingredient = _db.GetRepository<IIngredientRepository>();

            return await _ingredient.GetAsync(id);
        }
        #endregion
        #region Dish
        /// <summary>
        /// Get A list of all dishes on the FoodBook data base.
        /// </summary>
        /// <returns>A List of Dish</returns>
        public async Task<List<Dish>> GetAllDish()
        {
            IDishRepository _dish = _db.GetRepository<IDishRepository>();
            List<Dish> dishes = (await _dish.GetAllAsync()).ToList();
            return dishes;
        }
        public async Task<Dish> GetDishById(int id)
        {

            IDishRepository _dish = _db.GetRepository<IDishRepository>();

            return await _dish.GetAsync(id);
        }
        #endregion


    }
}
