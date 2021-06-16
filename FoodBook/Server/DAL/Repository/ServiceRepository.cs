using BO.Entity;
using DAL.UOW;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    class ServiceRepository : IServiceRepository
    {
        private readonly DbSession _session;

        public ServiceRepository(DbSession dbSession)
        {
            _session = dbSession;
        }

        public async Task<int> DeleteAsync(long id)
        {
            var stmt = @"delete from service where id = @id";
            return await _session.Connection.ExecuteAsync(stmt, new { Id = id }, _session.Transaction);

        }

        public async Task<IEnumerable<Service>> GetAllAsync()
        {
            var stmt = @"select * from service";
            return await _session.Connection.QueryAsync<Service>(stmt, null, _session.Transaction);
        }

        public async Task<Service> GetAsync(int id)
        {
            var stmt = @"select * from service where id = @id";
            return await _session.Connection.QueryFirstOrDefaultAsync<Service>(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<Service> InsertAsync(Service entity)
        {
            var stmt = @"insert into service (serviceNumber, dateService) output inserted.id values (@ServiceNumber, @dateService)";
            int i = await _session.Connection.QuerySingleAsync<int>(stmt, entity, _session.Transaction);
            return await GetAsync(i);
        }

        public async Task UpdateAsync(Service entity)
        {
            var stmt = @"update service set serviceNumber = @serviceNumber, dateService = @dateService where id = @id";
            await _session.Connection.QueryAsync<Service>(stmt, entity, _session.Transaction);
        }
    }
}
