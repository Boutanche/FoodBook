using BO.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLLC.Services
{
    public interface IRestaurantService
    {
        Task<List<Ingredients>> GetAllIngredients();
        Task<Ingredients> CreateIngredients(Ingredients ingredients);
        Task<Dish> CreateDish(Dish newDish);
        Task<ListOfIngredient> CreateListOfIngredient(ListOfIngredient listOfIngredient);
        Task<Dish> GetDishByName(string name);
    }
}