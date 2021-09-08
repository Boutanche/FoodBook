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
            return Task.FromResult(ingredientsFakeDB.Find(i => i.Id == id));
        }
        /// <summary>
        /// Modify Ingredient
        /// </summary>
        /// <param name="ingredient"></param>
        /// <returns>Ingredients</returns>
        public Task<Ingredients> ModifyIngredient(Ingredients ingredient)
        {
            if (ingredient.Id > 100)
            {
                return Task.FromResult<Ingredients>(null);
            }
            if (ingredient.Id == null)
            {
                return null;
            }

            var _ingredient = ingredientsFakeDB.Find(i => i.Id == ingredient.Id);
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
            ingredientsFakeDB.RemoveAll(i => i.Id == id);
            return Task.FromResult(id > 0);
        }
        public Task<Dish> GetIngredientsOfDishById(int id)
        {
            throw new NotImplementedException();
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
            new Dish(5 , "Couscous", 2, 1)
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
            return Task.FromResult(dishFakeDB.Find(i => i.Id == id));
        }
        public Task<Dish> ModifyDish(Dish dish)
        {
            if (dish.Id > 100)
            {
                return Task.FromResult<Dish>(null);
            }
            if (dish.Id == null)
            {
                return null;
            }

            var _dish = dishFakeDB.Find(i => i.Id == dish.Id);
            _dish.Name = dish.Name;
            _dish.Popularity = dish.Popularity;

            return Task.FromResult(_dish);
        }
        public Task<bool> RemoveDishById(int id)
        {
            dishFakeDB.RemoveAll(i => i.Id == id);
            return Task.FromResult(id > 0);
        }

        public Task<Dish> GetDishByName(string name)
        {
            return Task.FromResult(dishFakeDB.Find(i => i.Name == name));
        }
        #endregion

        #region TypeOfDish

        public Task<List<TypeOfDish>> GetAllTypeOfDish()
        {
            throw new NotImplementedException();
        }

        public Task<TypeOfDish> GetTypeOfDishById(int id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Service

       
        public List<Service> serviceFakeDB = new()
        {
            
            new Service(1, 1, DateTime.Parse("01/01/2021")),
            new Service(2, 2, DateTime.Parse("01/01/2021")),
            new Service(3, 1, DateTime.Parse("08/01/2021")),
            new Service(4, 2, DateTime.Parse("08/01/2021")),
            new Service(5, 1, DateTime.Parse("15/01/2021")),

        };
        public async Task<List<Service>> GetAllService()
        {
            return await Task.FromResult(serviceFakeDB);
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
            return Task.FromResult(service);
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

        #region ListOfIngredient  
        public Task<List<ListOfIngredient>> GetAllListOfIngredient()
        {
            throw new NotImplementedException();
        }

        public Task<List<ListOfIngredient>> GetListOfIngredientByIdDish(int idDish)
        {
            throw new NotImplementedException();
        }

        public Task<ListOfIngredient> CreateListOfIngredient(ListOfIngredient listOfIngredient)
        {
            return Task.FromResult(listOfIngredient);
        }

        public Task<ListOfIngredient> ModifyListOfIngredient(ListOfIngredient listOfIngredient)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveListOfIngredientById(int id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Booking
        public List<Booking> bookingFakeDB = new()
        {
            new Booking(1, DateTime.Now, 1, 1, 1, 1, 1, 1),
            new Booking(2, DateTime.Now, 1, 0, 0, 1, 2, 1),
            new Booking(3, DateTime.Now, 1, 1, 1, 1, 1, 2),
            new Booking(4, DateTime.Now, 1, 0, 0, 0, 2, 2),


        };


        public Task<Booking> GetBookingById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Booking> CreateBooking(Booking booking)
        {
            return Task.FromResult(booking);
        }

        public Task<IEnumerable<Service>> GetServiceByDate(DateTime date)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IsComposed
        public Task<IsComposed> CreateIsComposed(IsComposed isComposed)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddDishToService(Service service)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}