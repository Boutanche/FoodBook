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
    public class ServiceControllerUnitTest
    {
        //WIP : Travailler sur les services.

        /// <summary>
        /// Unit Test Ont Test Get All Service
        /// </summary>
        [Fact]
        public async void TestGetAllService()
        {
            //Arrange
            IRestaurantService restaurantService = new FakeRestaurantService();
            ServiceController serviceController = new(restaurantService);
            //Act
            ActionResult<List<Service>> ServiceActionResult = await serviceController.GetAllService();
            //Assert
            Assert.NotNull(ServiceActionResult);
        }
        [Fact]
        public async void TestCreateService()
        {
            //Arange
            IRestaurantService restaurantService = new FakeRestaurantService();
            ServiceController serviceController = new(restaurantService);
            Service service = new();
            {
                service.ServiceNumber = 1;
                service.DateService = DateTime.Now;
                
            }
            //Act
            var serviceActionResult = await serviceController.CreateService(service);
            //Assert
            Assert.NotNull(serviceActionResult);
        }
    }
}
