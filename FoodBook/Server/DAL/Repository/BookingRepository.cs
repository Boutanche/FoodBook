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
    class BookingRepository : IBookingRepository
    {
        private readonly DbSession _session;
        public BookingRepository(DbSession dbSession)
        {
            _session = dbSession;
        }

        public Task<int> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Booking>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Booking> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<Booking> InsertAsync(Booking entity)
        {
            var stmt = @"insert into booking(BookingDate, MealNumber, Starter, MainCourse, Dessert, Id_Client, Id_Service) 
                            output INSERTED.Id
                            values (@BookingDate, @MealNumber, @Starter, @MainCourse, @Dessert, @Id_Client, @Id_Service)";
            int i = await _session.Connection.QuerySingleAsync<int>(stmt, entity, _session.Transaction);
            return await GetAsync(i);
            
        }

        public Task UpdateAsync(Booking entity)
        {
            throw new NotImplementedException();
        }
    }
}
