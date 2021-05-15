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
    /// Controller Dish
    /// </summary>
    [ApiController]
    [ApiVersion ("1.0")]
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
        //TODO : Get Dish By ID

        //TODO : Create Dish
        
        //TODO : Modify Dish
        
        //TODO : Delete Dish
    }
}
