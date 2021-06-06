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
        //Get Menu By Id
        /// <summary>
        /// Unit Test On Get Menu By Id
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async void TestGetMenuById()
        {
            //Arrange
            IRestaurantService restaurantService = new FakeRestaurantService();
            MenuController menuController = new(restaurantService);
            //Act
            OkObjectResult menuActionResult = await menuController.GetMenuById(1) as OkObjectResult;
            NotFoundResult notFoundMenuActionResult = await menuController.GetMenuById(9999) as NotFoundResult;
            //Assert
            Assert.NotNull(menuActionResult);
            Assert.Equal(200, menuActionResult.StatusCode);
            Assert.NotNull(notFoundMenuActionResult);
            Assert.Equal(404, notFoundMenuActionResult.StatusCode);
        }
        //Next Menu
        //Previous Menu

    }
}
