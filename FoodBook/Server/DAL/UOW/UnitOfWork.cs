using DAL.Repository;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics;

namespace DAL.UOW
{
    /// <summary>
    /// Orchestrateur des transactions :
    /// </summary>
    sealed class UnitOfWork : IUnitOfWork
    {
        private readonly DbSession _session;
        private readonly IServiceProvider _serviceProvider;
        public UnitOfWork(DbSession session, IServiceProvider serviceProvider)
        {
            Trace.WriteLine(" Unit Of Work ");
            _session = session;
            _serviceProvider = serviceProvider;
        }
        /// <summary>
        /// Commencer une transaction
        /// </summary>
        public void BeginTransaction()
        {
            _session.Transaction = _session.Connection.BeginTransaction();
        }
        /// <summary>
        /// Commiter 
        /// </summary>
        public void Commit()
        {
            _session.Transaction.Commit();
            Dispose();
        }
        /// <summary>
        /// Effectuer un RollBack
        /// </summary>
        public void Rollback()
        {
            _session.Transaction.Rollback();
            Dispose();
        }
        /// <summary>
        /// Disposer
        /// </summary>
        public void Dispose() => _session.Transaction?.Dispose();

        /// <summary>
        /// Récupérer une repository
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetRepository<T>()
        {
           return _serviceProvider.GetRequiredService<T>();
        }
    }
}
