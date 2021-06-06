using BO.DTO.Responses;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAccountService
    {
        Task<LoginResponse> Login(string username, string password);
    }
}
