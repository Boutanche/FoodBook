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
    /// Controler sur les réservations
    /// </summary>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/booking")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class BookingController : ControllerBase
    {
        //Service qui gére la restauration : 
        private readonly IRestaurantService _restaurantService = null;

        public BookingController (IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Booking))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetBookingById([FromRoute] int id)
        {
            Booking booking = await _restaurantService.GetBookingById(id);
            if (booking == null)
            {
                return NotFound();        // StatusCode = 404
            }
            else
            {
                return Ok(booking);   // StatusCode = 200
            }
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateBooking([FromBody] Booking booking)
        {
            Booking newBooking = await _restaurantService.CreateBooking(booking);
            if (newBooking != null)
            {
                //Créer une redirection vers GetBookingById(NewBooking.BookingId)
                return CreatedAtAction(nameof(GetBookingById), new { id = newBooking.Id }, newBooking);
            }
            else
            {
                //Retourner code 400 Bad Request
                return BadRequest();
            }
        }

    }
}
