using BO.Entity;
using DAL.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DAL.Repository
{
    class DishRepository : IDishRepository
    {
        private readonly DbSession _session;

        public DishRepository(DbSession dbSession)
        {
            _session = dbSession;
        }
        public async Task<int> DeleteAsync(long id)
        {
            var stmt = @"delete from dishes where id_dish = @id";
            return await _session.Connection.ExecuteAsync(stmt, new { Id = id }, _session.Transaction);
        }

        public Task<IEnumerable<Dish>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Dish> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Dish> InsertAsync(Dish entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Dish entity)
        {
            throw new NotImplementedException();
        }
    }
}
