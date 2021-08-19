using BO.Entity;
using DAL.UOW;
using Dapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repository
{
    class IsComposedRepository : IIsComposedRepository
    {

        private readonly DbSession _session;

        public IsComposedRepository(DbSession dbSession)
        {
            _session = dbSession;
        }

        public Task<int> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IsComposed>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IsComposed> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IsComposed> InsertAsync(IsComposed entity)
        {
            var stmt = @"insert into isComposed (idDish, idService) output inserted.id values (@idDish, @idService)";
            int i = await _session.Connection.QuerySingleAsync<int>(stmt, entity, _session.Transaction);
            return await GetAsync(i);
        }

        public Task UpdateAsync(IsComposed entity)
        {
            throw new NotImplementedException();
        }
    }
}
