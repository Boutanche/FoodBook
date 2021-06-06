using BLL.Services;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Services
{
    /// <summary>
    /// Faux service indépendant de la DAL.
    /// </summary>
    class FakeLibrairiService : ILibrairiService
    {
        
        public List<Book> booksDB = new List<Book>()
        {
            new Book(1, "1111", "Livre1", "Description 1"),
            new Book(2, "2111", "Livre2", "Description 2"),
            new Book(3, "3111", "Livre3", "Description 3"),
            new Book(4, "4111", "Livre4", "Description 4"),
        };
        public Task<Book> CreateBook(Book book)
        {
            return Task.FromResult(book);
        }

        public Task<List<Book>> GetAllBooks()
        {
            return Task.FromResult(booksDB);
           
        }

        public Task<Book> GetBookById(int id)
        {
            //return Task.
            return Task.FromResult(booksDB.Find(b => b.Id == id));

        }

        public Task<Book> ModifyBook(Book book)
        {
            if (book.Id == null)
            {
                return null;
            }
            var _book = booksDB.Find(b => b.Id == book.Id);
            _book.ISBN = book.ISBN;
            _book.Title = book.Title;
            _book.Description = book.Description;

            return Task.FromResult(_book);
        }

        public Task<bool> RemoveBookById(int id)
        {
            booksDB.RemoveAll(b => b.Id == id);

            return Task.FromResult(id > 0);
        }
    }
}
