using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BLLC.Services;
using BO.DTO.Requests;
using BO.DTO.Responses;
using BO.Entity;

namespace ClientConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IRestaurantService restaurantService = new RestaurantService();
            //Ici les try catch.
            List<Ingredients> ingredientsPage = await restaurantService.GetAllIngredients();
           
            ingredientsPage.ForEach((ingredient) =>
            {
                Console.WriteLine(ingredient.Name);
            });
            Console.ReadLine();
            
        }
    }
}
