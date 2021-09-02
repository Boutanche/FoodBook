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
        /// <summary>
        /// BLL
        /// </summary>
        /// <param name="restaurantService"></param>
        public MenuController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }
        /// <summary>
        /// Get All Menu
        /// </summary>
        /// <returns>List of Menu</returns>
        [HttpGet]
        public async Task<ActionResult<List<Menu>>> GetAllMenu()
        {
            return Ok(await _restaurantService.GetAllMenu());
        }
        /// <summary>
        /// Get Menu By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Task</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Menu))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetMenuById([FromRoute] int id)
        {
            Menu menu = await _restaurantService.GetMenuById(id);
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
        /// <summary>
        /// Créer un menu afin de l'ajouter en base de données. 
        /// </summary>
        /// <param ></param>
        /// <returns>Task</returns>
        public async Task<IActionResult> CreateMenu([FromBody] Menu menu)
        {
            Menu newMenu = await _restaurantService.CreateMenu(menu);
            if (newMenu != null)
            {
                return CreatedAtAction(nameof(GetMenuById), new { id = newMenu.Id }, newMenu);
            }
            else
            {

                //Return Code 400 : Bad Request
                return BadRequest();
            }
        }
    }
}
