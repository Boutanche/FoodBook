using BO.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLLC.Services
{
    public interface IRestaurantService
    {
        #region Ingredients
        Task<List<Ingredients>> GetAllIngredients();

        Task<Ingredients> CreateIngredients(Ingredients ingredients);
        #endregion
        #region Dish
        Task<Dish> CreateDish(Dish newDish);
        
        Task<Dish> GetDishByName(string name);

        Task<List<Dish>> GetAllDish();
        #endregion
        #region ListOfIngredient
        Task<ListOfIngredient> CreateListOfIngredient(ListOfIngredient listOfIngredient);
        #endregion

        #region Menu
        // /!\ : Menu n'existe plus !!
        //Task<Menu> CreateMenu(Menu newMenu);
        // TODO : Supression des menu
        #endregion
        #region Booking
        Task<Booking> CreateBooking(Booking newBooking);
        #endregion
        #region Service
        Task<Service> CreateService(Service service);
        Task<List<Service>> GetServiceByDate(DateTime dateTime);
        Task<Service> AddDishToService(Service createdService);
        #endregion
        #region
        Task<IsComposed> CreateIsComposed(IsComposed newIsComposed);
        Task<List<IsComposed>> GetIsComposedByIdService(int? id);
        Task<Dish> GetDishById(int? idDish);

        #endregion
    }
}