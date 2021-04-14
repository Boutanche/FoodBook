using API_FoodBook.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace API_FoodBook.Controllers
{

    [ApiController]
    [Route("/api_foodbook/[controller]")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class IngredientsController : ControllerBase
    {
        //Liste des Ingrédients temporaires pour tests
        public List<IngredientsModel> IngredientsList = new List<IngredientsModel>()
        {
            new IngredientsModel(1, "Apple", 2.5),
            new IngredientsModel(2, "Butter", 4.1),
            new IngredientsModel(3, "Curcuma", 9.9),
            new IngredientsModel(4, "Ginger", 6),
            new IngredientsModel(5, "Honey", 19.6),

        };
        /// <summary>
        /// Récupérer l'ensemble des ingrédients
        /// </summary>
        /// <returns>Une liste d'ingrédients en forma json</returns>
        [HttpGet]
        public async Task<ActionResult> GetIngredients()
        {
            return await Task.FromResult(Ok(IngredientsList));
        }

        //Demander à Fabien : 

        /// <summary>
        /// Récupérer un ingrédient dont on connait l'identifiant
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Un ingrdient</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult> GetIngredientsById([FromRoute] int Id)
        {
            IngredientsModel Ingredient = null;
            for (int i = 0; i < IngredientsList.Count; i++)
            {
                if (IngredientsList[i].Id == Id)
                {
                    Ingredient = IngredientsList[i];
                    break;
                }
            }
            if (Ingredient != null)
            {
                return await Task.FromResult(Ok(Ingredient));
            }
            else
            {
                return await Task.FromResult(NotFound());
            }

        }
        /// <summary>
        /// Récupérer un ingrédient dont on connait le nom
        /// </summary>
        /// <param name="Name"></param>
        /// <returns>Un ingrédient</returns>
        [HttpGet("{name}")]
        public async Task<ActionResult> GetIngredientsByName([FromRoute] string Name)
        {
            IngredientsModel Ingredient = null;
            for (int i = 0; i < IngredientsList.Count; i++)
            {
                if (IngredientsList[i].Name == Name)
                {
                    Ingredient = IngredientsList[i];
                    break;
                }
            }
            if (Ingredient != null)
            {
                return await Task.FromResult(Ok(Ingredient));
            }
            else
            {
                return await Task.FromResult(NotFound());
            }
        }
    }
}