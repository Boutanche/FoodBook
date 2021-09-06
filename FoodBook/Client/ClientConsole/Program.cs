using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BLLC.Services;
using BO.DTO.Requests;
using BO.DTO.Responses;
using BO.Entity;
/// <summary>
/// Application Console : But pédagogique et controle.
/// </summary>
namespace ClientConsole
{
    /// <summary>
    /// Application console : me permet de vérifier que tout fonctionne.
    /// </summary>
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Mon Application Console fonctionne  : ");

            IRestaurantService restaurantService = new RestaurantService();
            //Ici mes tests d'affichage :
            List<Ingredients> ingredientsPage = await restaurantService.GetAllIngredients();
           
            ingredientsPage.ForEach((ingredient) =>
            {
                Console.WriteLine(ingredient.Name);
            });
            //Fermeture de la console :
            Console.ReadLine();
        }
    }
}
