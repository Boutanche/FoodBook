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
    /// Repository Ingredient : Permet d'accéder aux requêtes concernant les ingrédients. 
    /// </summary>
    class IngredientRepository : IIngredientRepository
    {
        /// <summary>
        /// Etablir une session
        /// </summary>
        private readonly DbSession _session;
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="dbSession"></param>
        public IngredientRepository(DbSession dbSession)
        {
            try
            {
                _session = dbSession;
            }
            catch (Exception)
            {
                throw new Exception ("Error on the procedure : " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
        }
        /// <summary>
        /// Effectuer une suppression d'ingrédient
        /// </summary>
        /// <param name="id">Identifiant unique de l'ingrédient</param>
        /// <returns></returns>
        public async Task<int> DeleteAsync(long id)
        {
            var stmt = @"delete from ingredients where id = @id";
            try
            {
                return await _session.Connection.ExecuteAsync(stmt, new { Id = id }, _session.Transaction);
            }
            catch (Exception)
            {
                throw new Exception ("Error on the Delete Ingredient request" + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
        }
        /// <summary>
        /// Récupérer l'ensemble des Ingrédients
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Ingredients>> GetAllAsync()
        {
            var stmt = @"select * from ingredients";
            try
            {
                return await _session.Connection.QueryAsync<Ingredients>(stmt, null, _session.Transaction);
            }
            catch (Exception)
            {

                throw new Exception ("Error on the Select All Ingredients request" + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }

        }
        /// <summary>
        /// Récupérer un seul ingrédient
        /// </summary>
        /// <param name="id">Identifiant unique de l'ingréident</param>
        /// <returns></returns>
        public async Task<Ingredients> GetAsync(int id)
        {
            var stmt = @"select * from ingredients where id = @id";
            try
            {
                return await _session.Connection.QueryFirstOrDefaultAsync<Ingredients>(stmt, new { Id = id }, _session.Transaction);
            }
            catch (Exception)
            {
                throw new Exception("Error on the Select One Ingredient request" + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
        }
        /// <summary>
        /// Créer un ingrédient
        /// </summary>
        /// <param name="entity">Un Ingrédient</param>
        /// <returns></returns>
        public async Task<Ingredients> InsertAsync(Ingredients entity)
        {
            var stmt = @"insert into ingredients(Name, Price) output INSERTED.Id
            values (@Name, @Price)";
            try
            {
                int i = await _session.Connection.QuerySingleAsync<int>(stmt, entity, _session.Transaction);
                return await GetAsync(i);

            }
            catch (Exception)
            {
                throw new Exception("Error on create Ingredient request" + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
        }
        /// <summary>
        /// Modifier un ingréident
        /// </summary>
        /// <param name="entity">Un ingrédient</param>
        /// <returns></returns>
        public async Task UpdateAsync(Ingredients entity)
        {
            var stmt = @"UPDATE  ingredients SET Name = @Name, Price= @Price WHERE id = @id";
            try
            {
                await _session.Connection.QueryAsync<Ingredients>(stmt, entity, _session.Transaction);
            }
            catch (Exception)
            {
                throw new Exception("Error on the Update Ingredients request" + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
        }
    }
}

