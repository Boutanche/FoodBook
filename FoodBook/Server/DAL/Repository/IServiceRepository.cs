using BO.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IServiceRepository : IGenericRepository<Service>
    {
        Task<IEnumerable<Service>> GetAsyncByDate(DateTime date);
        Task<IEnumerable<Service>> GetServicesDetailsAsync();
        Task<IEnumerable<Service>> GetServicesDetailsByDateAsync(DateTime date);
        Task<bool> AddDishToService(Service entity);
        //Task<Service> GetAsync(int id);
    }
}
