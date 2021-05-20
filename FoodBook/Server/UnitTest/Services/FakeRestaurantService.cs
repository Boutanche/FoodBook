using BLL.Services;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Services
{
    class FakeRestaurantService : IRestaurantService
    {
        #region Ingredients

        /// <summary>
        /// Create Fake List Of Fake Ingredients
        /// </summary>
        public List<Ingredients> ingredientsFakeDB = new()
        {
            new Ingredients(1, "Fake_Apple", 10.02m),
            new Ingredients(2, "Fake_Banana", 10.02m),
            new Ingredients(3, "Fake_Carrot", 10.02m),
            new Ingredients(4, "Fake_Apple", 10.02m),


        };
        /// <summary>
        /// Create a fake ingredient 
        /// </summary>
        /// <param name="ingredient"></param>
        /// <returns>Ingredients</returns>
        public Task<Ingredients> CreateIngredient(Ingredients ingredient)
        {
            return Task.FromResult(ingredient);
        }

        /// <summary>
        /// Get all fake igredient
        /// </summary>
        /// <returns>ingredidentFakeDB</returns>
        public Task<List<Ingredients>> GetAllIngredients()
        {
            return Task.FromResult(ingredientsFakeDB);

        }
        /// <summary>
        /// Get Ingredient By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Ingredients</returns>

        public Task<Ingredients> GetIngredientById(int id)
        {
            return Task.FromResult(ingredientsFakeDB.Find(i => i.Id_ingredient == id));
        }
        /// <summary>
        /// Modify Ingredient
        /// </summary>
        /// <param name="ingredient"></param>
        /// <returns>Ingredients</returns>
        public Task<Ingredients> ModifyIngredient(Ingredients ingredient)
        {
            if (ingredient.Id_ingredient > 100)
            {
                return Task.FromResult<Ingredients>(null);
            }
            if (ingredient.Id_ingredient == null)
            {
                return null;
            }

            var _ingredient = ingredientsFakeDB.Find(i => i.Id_ingredient == ingredient.Id_ingredient);
            _ingredient.Name = ingredient.Name;
            _ingredient.Price = ingredient.Price;

            return Task.FromResult(_ingredient);
        }
        /// <summary>
        /// Remove Ingredient by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<bool> RemoveIngredientById(int id)
        {
            ingredientsFakeDB.RemoveAll(i => i.Id_ingredient == id);
            return Task.FromResult(id > 0);
        }
        #endregion

        #region Dish
        /// <summary>
        /// Create Fake List Of Fake Dish
        /// </summary>
        public List<Dish> dishFakeDB = new()
        {
            new Dish(1, "Apple Pie", 0, 3),
            new Dish(2, "Banana Bread", 1, 3),
            new Dish(3, "Carrot Cake", 0, 3),
            new Dish(4, "Pancake", 2, 3),
        };
        /// <summary>
        /// Fake Get All Dish
        /// </summary>
        /// <returns></returns>
        public Task<List<Dish>> GetAllDish()
        {
            return Task.FromResult(dishFakeDB);
        }
        /// <summary>
        /// Fake Create Dish
        /// </summary>
        /// <param name="dish"></param>
        /// <returns></returns>
        public Task<Dish> CreateDish(Dish dish)
        {
            return Task.FromResult(dish);
        }
        /// <summary>
        /// Fake Get Dish By Id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<Dish> GetDishById(int id)
        {
            return Task.FromResult(dishFakeDB.Find(i => i.Id_dish == id));
        }
        public Task<Dish> ModifyDish(Dish dish)
        {
            if (dish.Id_dish > 100)
            {
                return Task.FromResult<Dish>(null);
            }
            if (dish.Id_dish == null)
            {
                return null;
            }

            var _dish = dishFakeDB.Find(i => i.Id_dish == dish.Id_dish);
            _dish.Name = dish.Name;
            _dish.Popularity = dish.Popularity;

            return Task.FromResult(_dish);
        }
        public Task<bool> RemoveDishById(int id)
        {
            dishFakeDB.RemoveAll(i => i.Id_dish == id);
            return Task.FromResult(id > 0);
        }

        public Task<List<TypeOfDish>> GetAllTypeOfDish()
        {
            throw new NotImplementedException();
        }

        public Task<TypeOfDish> GetTypeOfDishById(int id)
        {
            throw new NotImplementedException();
        }

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

        public Task<Menu> GetMenuById(int id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}