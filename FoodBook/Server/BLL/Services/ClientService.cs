using BO.Entity;
using DAL.Repository;
using DAL.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    internal class ClientService : IClientService
    {
        private readonly IUnitOfWork _db;
        public ClientService(IUnitOfWork unitOfWork)
        {
            _db = unitOfWork;
        }
        
        //Update du 15/06/2021 : Suppression de Cient remplacé par User :

        //TODO : V2 : Implémenter User : 

        #region Client
        /// <summary>
        /// Create NewClient with a Client
        /// </summary>
        /// <param name="client">Client</param>
        /// <returns>New Client</returns>
        public async Task<Client> CreateClient(Client client)
        {
            _db.BeginTransaction();
            IClientRepository _client = _db.GetRepository<IClientRepository>();
            Client newClient = await _client.InsertAsync(client);
            _db.Commit();
            return newClient;

        }
        //Get all clients

        //Get client by id
        #endregion
        #region  Booking

        //Create Booking

        //Remove Booking

        //Get Booking by Menu
        #endregion
    }
}
