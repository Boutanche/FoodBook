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
    class BookRepository : IBookRepository
    {
        private readonly DbSession _session;
        public BookRepository(DbSession dbSession)
        {
            _session = dbSession;

        }

        public Task<int> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            var stmt = @"select * from book";

            return await _session.Connection.QueryAsync<Book>(stmt, null, _session.Transaction);
        }

        public async Task<Book> GetAsync(int id)
        {
            //Evité l'injection sql avec des reqêtes paramétrées
            var stmt = @"select * from book where id = @id";
            return await _session.Connection.QueryFirstOrDefaultAsync<Book>(stmt, new { Id = id },  _session.Transaction);
        }

        public async Task<Book> InsertAsync(Book entity)
        {
            var stmt = @"insert into book(ISBN, title, description) output INSERTED.ID
            values (@iSBN, @title, @description)";
            int i = await _session.Connection.QuerySingleAsync<int>(stmt, entity, _session.Transaction);
            return await GetAsync(i);
        }

        public Task UpdateAsync(Book entity)
        {
            throw new NotImplementedException();
        }
    }
}
