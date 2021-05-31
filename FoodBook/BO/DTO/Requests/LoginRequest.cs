using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.DTO.Requests
{
    /// <summary>
    /// 
    /// </summary>
    public class LoginRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public LoginRequest()
        {

        }

    }
}
