using BO.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface ILibrairiService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        Task<Book> CreateBook(Book book);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<List<Book>> GetAllBooks();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Book> GetBookById(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        Task<Book> ModifyBook(Book book);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> RemoveBookById(int id);
    }
}