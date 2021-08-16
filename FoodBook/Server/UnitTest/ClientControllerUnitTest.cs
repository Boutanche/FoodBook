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
        /// <summary>
        /// Module de test de création d'un client
        /// </summary>
        [Fact]
        //ATTENTION Normalement elle est async !
        public void TestCreateClient()
        {
            //WIP : Client :
            //Non prioritaire sur ce jalon.
            //Beaucoup de choses à régler avant d'en arriver là.

            ////Arrange :
            //IClientService clientService = await new FakeClientService();
            //ClientControllerUnitTest clientController = new(clientService);
            //Client robert = new();
            //{
            //    robert.Name = "Robert";
            //    robert.PhoneNumber = " "
            //}
            ////Act : 

            //ActionResult
            ////Assert :  
        }
    }
}
