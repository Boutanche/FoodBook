﻿using Microsoft.AspNetCore.Mvc;
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
    /// Controller Dish
    /// </summary>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{Version:apiVersion}/dish")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class DishController : ControllerBase
    {
        //Service qui gère la Restauration : 
        private readonly IRestaurantService _restaurantService = null;

        public DishController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }
        /// <summary>
        /// Get All Dish
        /// </summary>
        /// <returns>List od Dish</returns>
        [HttpGet]
        public async Task<ActionResult<List<Dish>>> GetAll()
        {
            return Ok(await _restaurantService.GetAllDish());
        }
<<<<<<< HEAD
=======
        //TODO : Get Dish By ID
        /// <summary>
        /// Get Dish By Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>Dish </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Dish))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetDishById([FromRoute] int id)
        {
            Dish dish = await _restaurantService.GetDishById(id);
            return Ok(dish);

        } 
>>>>>>> b69de690618d3ff8f6d1116185a82f6e5cb8927d

        /// <summary>
        /// Get Dish By Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>Dish </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Dish))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetDishById([FromRoute] int id)
        {
            Dish dish = await _restaurantService.GetDishById(id);
            return Ok(dish);

        }
        /// <summary>
        /// Créer un plat et l'ajouter à la BDD
        /// </summary>
        /// <param name="dish">Dish</param>
        /// <returns>Le plat avec un identifiant généré</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateDish([FromBody] Dish dish)
        {
            //Ajout ddu plat avec la BLL Server
            Dish newDish = await _restaurantService.CreateDish(dish);
            if (newDish != null)
            {
                //Créer une redirection vers GetDishById(NewDish.Id_dish)
                return CreatedAtAction(nameof(GetDishById), new { id = newDish.Id_dish }, newDish);
            }
            else
            {
                //Return Code 400, Bad Request
                return BadRequest();
            }
        }

        /// <summary>
        /// Modifier un plat donné en le trouvant par son id.
        /// </summary>
        /// <param name="id">int</param>
        /// <param name="dish">dish</param>
        /// <returns>Un plat modifé</returns>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult>ModifyDish([FromRoute] int id, Dish dish)
        {
            if(dish == null || id != dish.Id_dish)
            {
                //Retourner le code 400 : Bad Request
                return BadRequest();
            }
            else
            {
                Dish dishModified = await _restaurantService.ModifyIngredient(dish);
                if (dishModified != null)
                    {
                    //Return du plat modifié.
                    return Ok(dishModified);
                    }
                else
                {
                    //Return 404 : Ressource introuvable
                    return NotFound();
                }
            }
        }
        /// <summary>
        /// Suppression d'un plat donné
        /// </summary>
        /// <param name="id">Int</param>
        /// <returns>No Content Code 204</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteDish([FromRoute] int id)
        {
            if (await _restaurantService.RemoveDishById(id))
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
