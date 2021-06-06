using System;

namespace DAL.UOW
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
        T GetRepository<T>();
    }
}