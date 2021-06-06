using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.DTO.Responses
{
    /// <summary>
    /// 
    /// </summary>
    public class LoginResponse
    {
        /// <summary>
        /// C'est le JWT !!IMPORTANT!!
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public LoginResponse()
        {

        }
    }
}
