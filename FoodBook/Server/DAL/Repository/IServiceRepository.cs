using BO.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repository
{
    /// <summary>
    /// Interface de ServiceREpository
    /// </summary>
    public interface IServiceRepository : IGenericRepository<Service>
    {
        /// <summary>
        /// Récupérer un service par la Date
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        Task<IEnumerable<Service>> GetAsyncByDate(DateTime date);
        /// <summary>
        /// Récupérer un service complet (avec les plats et les ingrédients des plats)
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Service>> GetServicesDetailsAsync();
        /// <summary>
        /// Récupérer un service complet (avec les plats et les ingrédients des plats) par date.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        Task<IEnumerable<Service>> GetServicesDetailsByDateAsync(DateTime date);
        /// <summary>
        /// Ajouter un plat aux services
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> AddDishToService(Service entity);
        /// <summary>
        /// Retirer tous les plats qui composent le service dont l'id est : id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> RemovAllIsComposedByIdService(int? id);
        //Task<Service> GetAsync(int id);
    }
}
