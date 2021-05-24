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
    /// Controller sur Menu
    /// </summary>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/menu")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class MenuController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService = null;

        public MenuController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Menu))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetMenuById([FromRoute] int id)
        {
            Menu menu = await _restaurantService.GetServicesOfMenuById(id);
            if (menu == null)
            {
                return NotFound();  // StatusCode = 404
            }
            else
            {
                return Ok(menu);   // StatusCode = 200
            }
        }

        /// <summary>
        /// Récupère les services du menu.
        /// </summary>
        /// <param name="id">Identifiant du menu </param>
        /// <returns>Liste des services du menu</returns>
        [HttpGet("{id}/services")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Menu))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetServicesOfMenuById([FromRoute] int id)
        {

            Menu menu = await _restaurantService.GetServicesOfMenuById(id);
            if (menu == null)
            {
                return NotFound();  // StatusCode = 404
            }
            else
            {
                return Ok(menu);   // StatusCode = 200
            }
        }
            //TODO : Next Menu (à faire par le client)

            //TODO : Previous Menu (à faire par le client)

            //TODO : IdMenuById 

        }
}
