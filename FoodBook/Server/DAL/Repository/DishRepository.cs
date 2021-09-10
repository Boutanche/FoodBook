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
    /// <summary>
    /// Repository Dish : Les plats qui sont composés d'Ingrédients et qui composent des Services
    /// </summary>
    class DishRepository : IDishRepository
    {
        /// <summary>
        /// Etablir une session
        /// </summary>
        private readonly DbSession _session;
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="dbSession"></param>
        public DishRepository(DbSession dbSession)
        {
            _session = dbSession;
        }
        /// <summary>
        /// Supprimer un plat
        /// </summary>
        /// <param name="id">Identifiant unique du plat</param>
        /// <returns></returns>
        public async Task<int> DeleteAsync(long id)
        {

            var stmt = @"delete from dishes where id = @id";
            try
            {
                return await _session.Connection.ExecuteAsync(stmt, new { Id = id }, _session.Transaction);

            }
            catch (Exception)
            {
                throw new Exception("Error on the Delete Dish request" + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
        }
        /// <summary>
        /// Récupérer touts les plats
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Dish>> GetAllAsync()
        {
            var stmt = @"select * from dishes";
            try
            {
                return await _session.Connection.QueryAsync<Dish>(stmt, null, _session.Transaction);
            }
            catch (Exception)
            {

                throw new Exception("Error on Select all Dish request" + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
        }
        /// <summary>
        /// Récupérer un plat
        /// </summary>
        /// <param name="id">Identifiant unique d'un plat</param>
        /// <returns></returns>
        public async Task<Dish> GetAsync(int id)
        {
            var stmt = @"select * from dishes where id = @id";
            try
            {
                return await _session.Connection.QueryFirstOrDefaultAsync<Dish>(stmt, new { Id = id }, _session.Transaction);
            }
            catch (Exception)
            {
                throw new Exception("Error on the Select One Dish request" + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
        }
        /// <summary>
        /// Réchercher un plat par son nom
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<Dish> GetAsyncByName(string name)
        {
            //TODO : V0 : Faire une requête --Like-- si je veux un système de "search" et de Filtre

            var stmt = @"select * from dishes where name = @name";
            try
            {
                return await _session.Connection.QueryFirstOrDefaultAsync<Dish>(stmt, new { Name = name }, _session.Transaction);
            }
            catch (Exception)
            {
                throw new Exception("Error on the Select One Dish by Name request" + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
        }
        /// <summary>
        /// Création d'un plat
        /// </summary>
        /// <param name="entity">Un plat</param>
        /// <returns></returns>
        public async Task<Dish> InsertAsync(Dish entity)
        {
            var stmt = @"insert into dishes(Name, Popularity, IdType) output INSERTED.id
            values (@Name, @Popularity, @IdType)";
            try
            {
            int i = await _session.Connection.QuerySingleAsync<int>(stmt, entity, _session.Transaction);
            return await GetAsync(i);
            }
            catch (Exception)
            {

                throw new Exception("Error on the Création dish request" + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
        }
        /// <summary>
        /// Faire une mise à jour d'un plat
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task UpdateAsync(Dish entity)
        {
            var stmt = @"UPDATE  dishes SET Name = @Name, Popularity= @Popularity WHERE id = @id";
            try
            {
                await _session.Connection.QueryAsync<Dish>(stmt, entity, _session.Transaction);
            }
            catch (Exception)
            {
                throw new Exception("Error on the Update Dish request" + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
        }
    }
}

