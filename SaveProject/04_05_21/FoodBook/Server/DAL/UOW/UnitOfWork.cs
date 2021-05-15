using DAL.Repository;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DAL.UOW
{
    sealed class UnitOfWork : IUnitOfWork
    {
        private readonly DbSession _session;
        private readonly IServiceProvider _serviceProvider;
        public UnitOfWork(DbSession session, IServiceProvider serviceProvider)
        {
            _session = session;
            _serviceProvider = serviceProvider;
        }

        public void BeginTransaction()
        {
            _session.Transaction = _session.Connection.BeginTransaction();
        }

        public void Commit()
        {
            _session.Transaction.Commit();
            Dispose();
        }

        public void Rollback()
        {
            _session.Transaction.Rollback();
            Dispose();
        }

        public void Dispose() => _session.Transaction?.Dispose();


        public T GetRepository<T>()
        {
           return _serviceProvider.GetRequiredService<T>();
        }
    }
}
