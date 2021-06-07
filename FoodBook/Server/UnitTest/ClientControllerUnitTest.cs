using API.Controllers;
using BLL.Services;
using BO.DTO.Requests;
using BO.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using UnitTest.Services;
using Xunit;

namespace UnitTest
{
    public class ClientControllerUnitTest
    {
        //Créer un client : 
        [Fact]
        public async void TestCreateClient()
        {
            //Arrange :
            ///IClientService clientService = await new FakeClientService();
            ///ClientControllerUnitTest clientController = new(clientService);
            ///Client robert = new();
            {
               /// robert.Name = "Robert"
            }
            //Act : 

            ///ActionResult
            //Assert :  
        }
    }
}
