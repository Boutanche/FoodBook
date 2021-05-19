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
    /// Controller Type Of Dish
    /// </summary>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/typeOfDish")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class TypeOfDishController : ControllerBase
    {
        //Service qui gère la Restauration
        private readonly IRestaurantService _restaurantService = null;
        public TypeOfDishController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }
        /// <summary>
        /// Récupérer la liste de tous les Type Of Dish
        /// </summary>
        /// <returns>Une liste de TypeOdDish</returns>
        [HttpGet]
        public async Task<ActionResult<List<TypeOfDish>>> GetAll()
        {
            return Ok(await _restaurantService.GetAllTypeOfDish());
        }
        /// <summary>
        /// Récupérer un Type Of Dish par son id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>TypeOfDish</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TypeOfDish))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetTypeOfDishById([FromRoute] int id)
        {
            TypeOfDish typeOfDish = await _restaurantService.GetTypeOfDishById(id);
            if (typeOfDish == null)
            {
                return NotFound();        // StatusCode = 404
            }
            else
            {
                return Ok(typeOfDish);   // StatusCode = 200
            }
        }
        //Dans la modélisation je n'ai pas mis qu'on pouvait Créer/Modifier/Supprimer un TypeOfDish à voir pour une version ultérieure
    }
}
