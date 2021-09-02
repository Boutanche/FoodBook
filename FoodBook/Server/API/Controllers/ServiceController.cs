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
    /// Controller : Service
    /// Les services regroupent une entrée un plat et un dessert 
    /// En fonction de la date 
    /// Et d'un numéro de service : midi/soir.
    /// Cf : documentation du projet.
    /// </summary>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/service")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class ServiceController : ControllerBase
    {
        //Service qui gère la Restauration : BLL
        private readonly IRestaurantService _restaurantService = null;
        /// <summary>
        /// Business Logic Layer
        /// </summary>
        /// <param name="restaurantService"></param>
        public ServiceController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }
        /// <summary>
        /// Get all Service
        /// </summary>
        /// <returns>List of Service</returns>
        [HttpGet]
        public async Task<ActionResult<List<Service>>> GetAllService()
        {
            return Ok(await _restaurantService.GetAllService());
        }

        /// <summary>
        /// Get Service By ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>One Service</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Service))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetServiceById([FromRoute] int id)
        {
            Service service = await _restaurantService.GetServiceById(id);
            if (service == null)
            {
                return NotFound();        // StatusCode = 404
            }
            else
            {
                return Ok(service);   // StatusCode = 200
            }
        }
        /// <summary>
        /// Create new service
        /// </summary>
        /// <param name="service"></param>
        /// <returns> --Task of IActionResult-- </returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateService([FromBody] Service service)
        {
            //Ajout de l'ingrédient avec la BLL server
            Service newService = await _restaurantService.CreateService(service);
            if (newService != null)
            {
                //Créer une redirection vers GetIngredientById(NewIngredient.IngredientId)
                return CreatedAtAction(nameof(GetServiceById), new { id = newService.Id }, newService);
            }
            else
            {
                //Retourner code 400 Bad Request
                return BadRequest();
            }
        }

        /// <summary>
        /// Add Dish To Service :
        /// </summary>
        /// <param name="service"></param>
        /// <returns> --Task of IActionResult-- </returns>
        [HttpPost("dish")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddDishToService([FromBody] Service service)
        {
            bool newService = await _restaurantService.AddDishToService(service);
            if (newService != false)
            {
                return Ok(service);
            }
            else
            {
                //Retourner code 400 Bad Request
                return BadRequest();
            }
        }

        /// <summary>
        /// Get Service By Date
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        [HttpGet("date")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Service))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetServiceByDate([FromQuery] DateTime date)
        {
            IEnumerable<Service> service = await _restaurantService.GetServiceByDate(date);
            if (service == null)
            {
                return NotFound();        // StatusCode = 404
            }
            else
            {
                return Ok(service);   // StatusCode = 200
            }
        }

    }
}