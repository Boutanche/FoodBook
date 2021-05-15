using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using BLL.Services;
using BO.Entity;
using BO.DTO.Requests;

namespace API.Controllers
{
    /// <summary>
    /// Controller Ingredient
    /// </summary>
    [ApiController]
    [ApiVersion ("1.0")]
    [Route("api/v{version:apiVersion}/ingredients")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class IngredientsController : ControllerBase
    {
        //Service qui gère la Restauration :
        private readonly IRestaurantService _restaurantService = null;

        public IngredientsController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }
        //TODO : Rajoute FromQuery + DTO filtre

        /// <summary>
        /// Récupérer la liste des Ingrédients
        /// </summary>
        /// <returns> la liste des Ingredients</returns>
        [HttpGet]
        public async Task<ActionResult<List<Ingredients>>> GetAll()
        {
 
            return Ok(await _restaurantService.GetAllIngredients());
        }
        /// <summary>
        /// Permet de récupérer la liste des Ingrédients par son identifiant unique
        /// </summary>
        /// <param name="id">Identifiant d'un ingrédient</param>
        /// <returns>L'ingrédient définit par l'indentifiant unique</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Ingredients))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetIngredientById([FromRoute] int id)
        {
            Ingredients ingredient = await _restaurantService.GetIngredientById(id);
            if( ingredient == null)
            {
                return NotFound();        // StatusCode = 404
            }
            else
            {
                return Ok(ingredient);   // StatusCode = 200
            }
        }
        /// <summary>
        /// Créer un ingrédient et l'ajouter en Bdd
        /// </summary>
        /// <param name="ingredient"></param>
        /// <returns>L'ingrédient avec l'indentifiant généré</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateIngredient([FromBody] Ingredients ingredient)
        {
            //Ajout de l'ingrédient avec la BLL server
            Ingredients newIngredient = await _restaurantService.CreateIngredient(ingredient);
            if (newIngredient != null)
            {
                //Créer une redirection vers GetIngredientById(NewIngredient.IngredientId)
                return CreatedAtAction(nameof(GetIngredientById), new { id = newIngredient.Id_ingredient }, newIngredient);
            }
            else
            {
                //Retourner code 400 Bad Request
                return BadRequest();
            }
        }
        /// <summary>
        /// Modifier un ingredient donné
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ingredient"></param>
        /// <returns>Une modification d'un ingrédient</returns>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> ModifyIngredient([FromRoute] int id, [FromBody] Ingredients ingredient)
        {
            if (ingredient == null || id != ingredient.Id_ingredient)
            {
                // Retourne un code 400  Bad Request
                return BadRequest();
            }
            else
            {
                Ingredients ingredientModified = await _restaurantService.ModifyIngredient(ingredient);
                if (ingredientModified != null)
                {
                    // Renvoie la ressource modifiée
                    return Ok(ingredientModified);
                }
                else
                {
                    // Renvoie un code 404: la ressource est introuvable
                    return NotFound();
                }
            }
        }
        /// <summary>
        /// Suppression d'un ingredient donné
        /// </summary>
        /// <param name="id"></param>
        /// <returns>No Content Code 204.</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteIngredient([FromRoute] int id)
        {
            if (await _restaurantService.RemoveIngredientById(id))
            {
                // Renvoie un code 204 aucun contenu
                return NoContent();
            }
            else
            {
                // Renvoie un code 404: la ressource est introuvable
                return NotFound();
            }
        }

    }
}
