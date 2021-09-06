using System;

namespace DAL.UOW
{
    /// <summary>
    /// Interface de Unit Of Work
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Commencer une Transaction
        /// </summary>
        void BeginTransaction();
        /// <summary>
        /// Commiter
        /// </summary>
        void Commit();
        /// <summary>
        /// Effectuer un RollBack
        /// </summary>
        void Rollback();
        /// <summary>
        /// Récupérer une Repository
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetRepository<T>();
    }
}