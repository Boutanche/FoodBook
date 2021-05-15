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
    internal class RestaurantService : IRestaurantService
    {
        private readonly IUnitOfWork _db;
        public RestaurantService(IUnitOfWork unitOfWork)
        {
            _db = unitOfWork;
        }
        #region Ingredients
        public async Task<Ingredients> CreateIngredient(Ingredients ingredient)
        {
            _db.BeginTransaction();
            IIngredientRepository _ingredient = _db.GetRepository<IIngredientRepository>();
            Ingredients newIngredient = await _ingredient.InsertAsync(ingredient);
            _db.Commit();
            return newIngredient;
        }
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

        public async Task<List<Ingredients>> GetAllIngredients()
        {
            IIngredientRepository _ingredients = _db.GetRepository<IIngredientRepository>();

            List<Ingredients> ingredients = (await _ingredients.GetAllAsync()).ToList();

            return ingredients;
        }

        public async Task<Ingredients> GetIngredientById(int id)
        {

            IIngredientRepository _ingredient = _db.GetRepository<IIngredientRepository>();

            return await _ingredient.GetAsync(id);
        }
        #endregion


    }
}
