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
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/service")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class ServiceController : ControllerBase
    {
        //Service qui gère la Restauration :
        private readonly IRestaurantService _restaurantService = null;
        public ServiceController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }
        /// <summary>
        /// Récupérer la liste des service du menu :   API/V1/service?menu=4
        /// </summary>
        /// <param name=""></param>
        /// <param name="id_Menu"></param>
        /// <returns></returns>
        [HttpGet()]
        public async Task<ActionResult<List<Service>>> GetServicesByIdMenu ([FromQuery(Name="menu")] int? id_Menu)
        {
            if(id_Menu.HasValue)
            {
                return Ok(await _restaurantService.GetServicesByIdMenu(id_Menu.Value));
            }
            return BadRequest();
        }
        /// <summary>
        /// Récupèrer un service par son Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
        /// Créer un nouveau service
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
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
                return CreatedAtAction(nameof(GetServiceById), new { id = newService.Id_service }, newService);
            }
            else
            {
                //Retourner code 400 Bad Request
                return BadRequest();
            }
        }
        //TODO : AddDishForThisSrvice

        //TODO : RemoveDishForThisService
    }
}
