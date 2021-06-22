using BO.Entity;
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
        //Supression des menu
        //#region Menu
        ////Task<Menu> CreateMenu(Menu newMenu);
        //#endregion
    }
}