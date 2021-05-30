using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mime;
using BLL.Services;
using BO.Entity;

namespace API.Controllers
{
    /// <summary>
    /// List Of Ingredient for a Dish : Link Table
    /// Know the necessary amount of ingredients for this dish
    /// </summary>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{Version:apiVersion}/listOfIngredient")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class ListOfIngredientController : ControllerBase
    {
        //Service qui gère la restauration :
        private readonly IRestaurantService _restaurantService = null;
        public ListOfIngredientController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }
        /// <summary>
        /// Récupérer l'ensemble des ListOfIngredient Table de liaison entre le ingrédient et les plats qu'ils composent.
        /// Permet de connaitre la quantité nécessaire des produits en question pour ce plat.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<List<ListOfIngredient>>> GetAll()
        {
            return Ok(await _restaurantService.GetAllListOfIngredient());
        }
        /// <summary>
        /// Récupérer uniquement les ingrédients qui composent le plat désigné par l'id précisé.
        /// </summary>
        /// <returns></returns>
        [HttpGet("{idDish}")]
        
        public async Task<ActionResult<List<ListOfIngredient>>> GetListOfIngredientByIdDish(int idDish)
        {
            return Ok(await _restaurantService.GetListOfIngredientByIdDish(idDish));
        }
        /// <summary>
        /// Créer un ListOfIngredient :
        /// </summary>
        /// <param name="ListOfIngredient"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateListOfIngredient([FromBody] ListOfIngredient ListOfIngredient)
        {
            // Bug FIX : Important sur insert !
            if (ListOfIngredient != null)
            {
                //Créer une redirection vers GetIngredientById(NewIngredient.IngredientId)
                return Ok (await _restaurantService.CreateListOfIngredient(ListOfIngredient));
                //C'est fait.
            }
            else
            {
                //Retourner code 400 Bad Request
                return BadRequest();
            }
        }
        /// <summary>
        /// Modifier un ...
        /// Penser que id = int32.Parse(idIngredient.toString() + idDish.toString())
        /// </summary>
        /// <param name="id"></param>
        /// <param name="listOfIngredient"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> ModifyListOfIngredient([FromRoute] int id, [FromBody] ListOfIngredient listOfIngredient)
        {
            if (listOfIngredient == null || id != Int32.Parse(listOfIngredient.IdIngredient.ToString() + listOfIngredient.IdDish.ToString()))
            {
                // Retourne un code 400  Bad Request
                return BadRequest();
            }
            else
            {
                ListOfIngredient listOfIngredientModified = await _restaurantService.ModifyListOfIngredient(listOfIngredient);
                if (listOfIngredientModified != null)
                {
                    // Renvoie la ressource modifiée
                    return Ok(listOfIngredientModified);
                }
                else
                {
                    // Renvoie un code 404: la ressource est introuvable
                    return NotFound();
                }
            }
        }
        /// <summary>
        /// Suppression d'un ListOfIngredient donné
        /// </summary>
        /// <param name="id"></param>
        /// <returns>No Content Code 204.</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteListOfIngredient([FromRoute] int id)
        {
            if (await _restaurantService.RemoveListOfIngredientById(id))
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
