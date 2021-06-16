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
            var stmt = @"delete from dishes where id = @id";
            return await _session.Connection.ExecuteAsync(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<IEnumerable<Dish>> GetAllAsync()
        {
            var stmt = @"select * from dishes";
            return await _session.Connection.QueryAsync<Dish>(stmt, null, _session.Transaction);
        }

        public async Task<Dish> GetAsync(int id)
        {
            //Eviter l'injection sql avec des reqêtes paramétrées
            var stmt = @"select * from dishes where id = @id";
            return await _session.Connection.QueryFirstOrDefaultAsync<Dish>(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<Dish> GetAsyncByName(string name)
        {
            //TODO : Faire un Like si je veux un système de "search"
            var stmt = @"select * from dishes where name = @name";
            return await _session.Connection.QueryFirstOrDefaultAsync<Dish>(stmt, new { Name = name }, _session.Transaction);
        }

        public async Task<Dish> InsertAsync(Dish entity)
        {
            var stmt = @"insert into dishes(Name, Popularity, IdType) output INSERTED.id
            values (@Name, @Popularity, @IdType)";
            int i = await _session.Connection.QuerySingleAsync<int>(stmt, entity, _session.Transaction);
            return await GetAsync(i);
        }

        public async Task UpdateAsync(Dish entity)
        {
            var stmt = @"UPDATE  dishes SET Name = @Name, Popularity= @Popularity WHERE id = @id";
            await _session.Connection.QueryAsync<Dish>(stmt, entity, _session.Transaction);
        }
    }
}



/**
 * ********************************
 *  Le Code poubelle est par là ->
 * ********************************
 **/




//On doit pouvoir supprimmer tout ça : 
//public async Task<IEnumerable<Dish>> GetAllAsync(string name)
//{
//    if (name != null)
//    {
//        var stmt = @"select * from dishes where name = @name";
//        return await _session.Connection.QueryAsync<Dish>(stmt, new { Name = name }, _session.Transaction);
//    }
//    else
//    {
//        // Traiter l'erreur : 
//        var stmt = @"MESSAGE ERREUR";
//        return await _session.Connection.QueryAsync<Dish>(stmt, null, _session.Transaction);
//    }
//    
//}