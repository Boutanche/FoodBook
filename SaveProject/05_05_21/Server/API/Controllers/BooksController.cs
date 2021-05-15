using BO.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using BO.DTO.Requests;

namespace API.Controllers
{
    [ApiController]
    [Route("api/books")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class BooksController : ControllerBase
    {

        //Service qui gère la librairi
        private readonly ILibrairiService _librairiService = null;

        public BooksController(ILibrairiService librairiService)
        {
            _librairiService = librairiService;
        }


        /// <summary>
        /// Permet de récupérer la liste des livres
        /// </summary>
        /// <returns>La liste des livres</returns>
        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetAll([FromQuery] PageRequest pageRequest)
        {
            Console.WriteLine(pageRequest?.page);
            Console.WriteLine(pageRequest?.maxPerPage);
            return Ok(await _librairiService.GetAllBooks());
        }

        /// <summary>
        /// Permert de récupérer un livre avec son identifiant unique
        /// </summary>
        /// <param name="id">Identifiant unique du livre</param>
        /// <returns>Renvoi le livre définit par l'identifiant unique</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetBookById([FromRoute] int id)
        {
            Book book = await _librairiService.GetBookById(id);
            if (book == null)
            {
                return NotFound(); // StatusCode = 404
            }
            else
            {
                return Ok(book); // StatusCode = 200
            }
        }

        /// <summary>
        /// Créer un livre et l'ajoute en BDD
        /// </summary>
        /// <param name="book">Livre à ajouter sans l'identifiant unique</param>
        /// <returns>Renvoi le livre avec l'identifiant généré</returns>
        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateBook([FromBody] Book book)
        {
            // Ajout du livre avec la bll server
            Book newBook = await _librairiService.CreateBook(book);
            if (newBook != null)
            {
                // Créer une redirection vers GetBookById(newBook.BookId);
                return CreatedAtAction(nameof(GetBookById), new { id = newBook.Id }, newBook);
            }
            else
            {
                // Retourne un code 400  Bad Request
                return BadRequest();
            }
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteBook([FromRoute] int id)
        {
            if (await _librairiService.RemoveBookById(id))
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


        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> ModifyBook([FromRoute] int id, [FromBody] Book book)
        {
            if (book == null || id != book.Id)
            {
                // Retourne un code 400  Bad Request
                return BadRequest();
            }
            else
            {
                Book bookModified = await _librairiService.ModifyBook(book);
                if (bookModified != null)
                {
                    // Renvoie la ressource modifiée
                    return Ok(bookModified);
                }
                else
                {
                    // Renvoie un code 404: la ressource est introuvable
                    return NotFound();
                }
            }
        }

    }
}
