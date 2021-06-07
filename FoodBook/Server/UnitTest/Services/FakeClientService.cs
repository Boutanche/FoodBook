using BLL.Services;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Services
{
    class FakeClientService : IClientService
    {
        #region Client
        //Fake List of Clients :
        public Task<Client> CreateClient(Client client)
        {
            return Task.FromResult(client);
        }
        #endregion

    }
}
