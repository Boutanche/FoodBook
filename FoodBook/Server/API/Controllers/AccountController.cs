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
using Microsoft.AspNetCore.Authorization;
using BO.DTO.Responses;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{Version:apiVersion}/account")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        //Récupèretation des logs.
        private readonly ILogger _logger;
        public AccountController (IAccountService accountService, ILogger<AccountController> logger)
        {
            _logger = logger;
            _accountService = accountService;

            
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login ([FromBody] LoginRequest loginRequest)
        {
            LoginResponse loginResponse = await _accountService.Login(loginRequest.Username, loginRequest.Password);
            if (loginResponse != null)
            {
                _logger.LogInformation("Reception d'une réponse positive sur login.");
                return Ok(loginResponse);
            }
            else
            {
                _logger.LogError("Erreur sur les autorisations.");
                return Unauthorized();
            }
        }
           
    }

}
