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
    public class MenuControllerUnitTest
    {
        /// <summary>
        /// Unit Test On Fake Get All Menu
        /// </summary>
        [Fact]
        public async void TestGetAllMenu()
        {
            //Arrange
            IRestaurantService restaurantService = new FakeRestaurantService();
            MenuController menuController = new(restaurantService);
            //Act
            ActionResult<List<Menu>> MenuActionResult = await menuController.GetAllMenu();
            //Assert
            Assert.NotNull(MenuActionResult);
        }
    }
}
