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
    class IngredientRepository : IIngredientRepository
    {
        private readonly DbSession _session;
        public IngredientRepository(DbSession dbSession)
        {
            _session = dbSession;
        }
        public async Task<int> DeleteAsync(long id)
        {
            var stmt = @"delete from ingredients where Id = @id";
            return await _session.Connection.ExecuteAsync(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<IEnumerable<Ingredients>> GetAllAsync()
        {
            var stmt = @"select * from ingredients";

            return await _session.Connection.QueryAsync<Ingredients>(stmt, null, _session.Transaction);
        }

        public async Task<Ingredients> GetAsync(int id)
        {
            //Evité l'injection sql avec des reqêtes paramétrées
            var stmt = @"select * from ingredients where id = @id";
            return await _session.Connection.QueryFirstOrDefaultAsync<Ingredients>(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<Ingredients> InsertAsync(Ingredients entity)
        {
            var stmt = @"insert into ingredients(Name, Price) output INSERTED.ID
            values (@Name, @Price)";
            int i = await _session.Connection.QuerySingleAsync<int>(stmt, entity, _session.Transaction);
            return await GetAsync(i);
        }

        public async Task UpdateAsync(Ingredients entity)
        {
            var stmt = @"UPDATE  ingredients SET Name = @Name, Price= @PriceWHERE Id = @id";
            await _session.Connection.QueryAsync<Ingredients>(stmt, entity, _session.Transaction);
        }
    }
}

