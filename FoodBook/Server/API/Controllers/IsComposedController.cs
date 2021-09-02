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
    /// Controller Is Composed
    /// Concerne la table de liaison entre Les services et les plats.
    /// N'est pas utilisé.
    /// </summary>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/isComposed")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class IsComposedController : ControllerBase 
    {
        //Service qui gère la Restauration :
        private readonly IRestaurantService _restaurantService = null;

        public IsComposedController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }
        /// <summary>
        /// Create IsComposed
        /// Concerve une table d'association entre un Service qui est Composé de Plats
        /// </summary>
        /// <param name="isComposed"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateIsComposed([FromBody] IsComposed isComposed)
        {
            //Ajout de IsComposed avec la BLL server
            IsComposed newIsComposed = await _restaurantService.CreateIsComposed(isComposed);
            if (newIsComposed != null)
            {
                
                return CreatedAtAction(nameof(CreateIsComposed), newIsComposed);
            }
            else
            {
                //Retourner code 400 Bad Request
                return BadRequest();
            }
        }
    }
}
