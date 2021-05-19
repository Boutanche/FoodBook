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
    class TypeOfDishRepository : ITypeOfDishRepository
    {
        private readonly DbSession _session;
        public TypeOfDishRepository(DbSession dbSession)
        {
            _session = dbSession;
        }
        public Task<int> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TypeOfDish>> GetAllAsync()
        {
            var stmt = @"select * from typeOfDishes";
            return await _session.Connection.QueryAsync<TypeOfDish>(stmt, null, _session.Transaction);
        }

        public async Task<TypeOfDish> GetAsync(int id)
        {
            //Eviter l'injection sql avec des reqêtes paramétrées
            var stmt = @"select * from typeOfDishes where id_type = @id";
            return await _session.Connection.QueryFirstOrDefaultAsync<TypeOfDish>(stmt, new { Id = id }, _session.Transaction);
        }

        public Task<TypeOfDish> InsertAsync(TypeOfDish entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TypeOfDish entity)
        {
            throw new NotImplementedException();
        }
    }
}
