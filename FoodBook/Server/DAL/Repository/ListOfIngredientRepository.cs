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
    /// Association entre un ingrédient et un plat
    /// </summary>
    class ListOfIngredientRepository : IListOfIngredientRepository
    {
        /// <summary>
        /// Etablir une session
        /// </summary>
        private readonly DbSession _session;
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="dbSession"></param>
        public ListOfIngredientRepository(DbSession dbSession)
        {
            try
            {
                _session = dbSession;
            }
            catch (Exception)
            {
                throw new Exception("Error on the procedure" + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
        }
        /// <summary>
        /// Effectuer la suppression de l'association entre un plat et un ingrédient // Non implémenté V1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<int> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Non implémenté V.1
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<ListOfIngredient>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Non Implémenté V.1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<ListOfIngredient> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Créer une table d'association entre un Ingrédient et un plat
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<ListOfIngredient> InsertAsync(ListOfIngredient entity)
        {
            var stmt = @"insert into listOfIngredients (IdIngredient, IdDish, Quantity)
            values (@IdIngredient, @IdDish, @Quantity)";
            try
            {
                await _session.Connection.ExecuteAsync(stmt, entity, _session.Transaction);
                return entity;
            }
            catch (Exception)
            {
                throw new Exception("Error on the Insert ListOfIngredient request" + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
        }
        /// <summary>
        /// Non implémenté V.1
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Task UpdateAsync(ListOfIngredient entity)
        {
            throw new NotImplementedException();
        }
    }
}

