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
    class ListOfIngredientRepository : IListOfIngredientRepository
    {
        private readonly DbSession _session;
        public ListOfIngredientRepository(DbSession dbSession)
        {
            _session = dbSession;
        }

        public Task<int> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ListOfIngredient>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ListOfIngredient> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ListOfIngredient> InsertAsync(ListOfIngredient entity)
        {
            var stmt = @"insert into listOfIngredients (IdIngredient, IdDish, Quantity)
            values (@IdIngredient, @IdDish, @Quantity)";
            await _session.Connection.ExecuteAsync(stmt, entity, _session.Transaction);
            return entity;
        }
        public Task UpdateAsync(ListOfIngredient entity)
        {
            throw new NotImplementedException();
        }
    }
}

