using BO.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface ILibrairiService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        Task<Book> CreateBook(Book book);

        Task<List<Book>> GetAllBooks();

        Task<Book> GetBookById(int id);

        Task<Book> ModifyBook(Book book);

        Task<bool> RemoveBookById(int id);
    }
}