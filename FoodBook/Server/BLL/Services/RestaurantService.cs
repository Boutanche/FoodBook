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
        //TODO : Il y a plein de méthodes qui ne sont pas encore implémenté ici !

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
        public async Task<Dish> GetDishByName(string name)
        {
            IDishRepository _dish = _db.GetRepository<IDishRepository>();

            return await _dish.GetAsync(name);
        }
        /// <summary>
        /// Get a Dish By an ID
        /// </summary>
        /// <param name="id">Int</param>
        /// <returns>Dish</returns>

        public async Task<Dish> GetDishById(int id)
        {

            IDishRepository _dish = _db.GetRepository<IDishRepository>();

            return await _dish.GetAsync(id);
        }

        /// <summary>
        /// Create a Dish
        /// </summary>
        /// <param name="dish">Dish</param>
        /// <returns>A new Dish</returns>
        public async Task<Dish> CreateDish(Dish dish)
        {
            _db.BeginTransaction();
            IDishRepository _dish = _db.GetRepository<IDishRepository>();
            Dish newDish = await _dish.InsertAsync(dish);
            _db.Commit();
            return newDish;
        }
        /// <summary>
        /// Modifier un plat
        /// </summary>
        /// <param name="dish">Dish</param>
        /// <returns>Un plat modifié</returns>
        public async Task<Dish> ModifyDish(Dish dish)
        {
            _db.BeginTransaction();
            IDishRepository _dish = _db.GetRepository<IDishRepository>();
            try
            {
                await _dish.UpdateAsync(dish);
                _db.Commit();
                return dish;
            }
            catch (Exception e)
            {
                _db.Rollback();
                return null;
            }
        }
        /// <summary>
        /// Supprimer un plat
        /// </summary>
        /// <param name="id">Int</param>
        /// <returns>Code No Content : 204</returns>
        public async Task<bool> RemoveDishById(int id)
        {
            _db.BeginTransaction();
            IDishRepository _dish = _db.GetRepository<IDishRepository>();
            try
            {
                var count = await _dish.DeleteAsync(id);
                _db.Commit();
                return count > 0;
            }
            catch (Exception e)
            {
                _db.Rollback();
                return false;
            }
        }
        public Task<Dish> GetIngredientsOfDishById(int id)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region TypeOfDish
        /// <summary>
        /// Get a list of TypeOfDish
        /// </summary>
        /// <returns></returns>
        public async Task<List<TypeOfDish>> GetAllTypeOfDish()
        {
            ITypeOfDishRepository _typeOfDish = _db.GetRepository<ITypeOfDishRepository>();
            List<TypeOfDish> typeOfDishes = (await _typeOfDish.GetAllAsync()).ToList();
            return typeOfDishes;
        }
        /// <summary>
        /// Get a TypeOfDish
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<TypeOfDish> GetTypeOfDishById(int id)
        {
            ITypeOfDishRepository _dish = _db.GetRepository<ITypeOfDishRepository>();

            return await _dish.GetAsync(id);
        }
        #endregion
        #region Service

        public Task<Service> GetServiceById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Service>> GetServicesByIdMenu(int idMenu)
        {
            throw new NotImplementedException();
        }

        public Task<Service> CreateService(Service service)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddDishForThisService(Dish dish, Service service)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveDishForThisService(Dish dish, Service service)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Menu
        public Task<DateTime> NextMenu(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task<DateTime> PreviousMenu(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetIdMenuByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task<Menu> GetServicesOfMenuById(int id)
        {
            throw new NotImplementedException();
    }



        #endregion


    }
}
