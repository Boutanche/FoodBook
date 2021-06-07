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
    class MenuRepository : IMenuRepository
    {
        private readonly DbSession _session;
        public MenuRepository(DbSession dbSession)
        {
            _session = dbSession;
        }
        public Task<int> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Menu>> GetAllAsync()
        {
            var stmt = @"select * from menu";
            return await _session.Connection.QueryAsync<Menu>(stmt, null, _session.Transaction);
        }
        public async Task<Menu> GetMenuByIdAsync(int id)
        {
            //Eviter l'injection sql avec des reqêtes paramétrées
            var stmt = @"select * from menu where id = @id";
            return await _session.Connection.QueryFirstOrDefaultAsync<Menu>(stmt, new { Id = id }, _session.Transaction);
        }
        public Task<Menu> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Menu> InsertAsync(Menu entity)
        {
            var stmt = @"INSERT INTO menu (Year, WeekNumber) OUPUT INSERTED.id VALUES (@Year, @WeekNumber)";
            int i = await _session.Connection.QuerySingleAsync<int>(stmt, entity, _session.Transaction);
            return await GetAsync(i);
        }

        public Task UpdateAsync(Menu entity)
        {
            throw new NotImplementedException();
        }
    }
}
