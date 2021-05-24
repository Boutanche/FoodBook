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
        //Back to the conception
    }
}
