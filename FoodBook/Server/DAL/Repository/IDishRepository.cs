using BO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    /// <summary>
    /// Interface Dish Repository
    /// </summary>
    public interface IDishRepository : IGenericRepository<Dish>

    {
        /// <summary>
        /// Récupérer plat par son nom
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<Dish> GetAsyncByName(string name);
    }
}
