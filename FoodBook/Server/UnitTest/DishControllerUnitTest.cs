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
    /// <summary>
    /// Unit Test for Dish
    /// </summary>
    public class DishControllerUnitTest
    {
        /// <summary>
        /// Unit Test on Fake Get All Dish
        /// </summary>
        [Fact]
        public async void TestGetAllDish()
        {
            //Arrange
            IRestaurantService restaurantService = new FakeRestaurantService();
            DishController dishController = new(restaurantService);
            //Act
            ActionResult<List<Dish>> DishActionResult = await dishController.GetAll();
            //Assert
            Assert.NotNull(DishActionResult);
        }
        [Fact]
        public async void TestCreateDish()
        {
            //Arrange
            IRestaurantService restaurantService = new FakeRestaurantService();
            DishController dishController = new(restaurantService);
            Dish tabbouleh = new();
            {
                tabbouleh.Name = "Tabbouleh";
                tabbouleh.Popularity = 0;
            }
            //Act
            var tabboulehDishActionResult = await dishController.CreateDish(tabbouleh);
            //Assert
            Assert.NotNull(tabboulehDishActionResult);
            Assert.Equal("Tabbouleh", tabbouleh.Name);
        }
    }
}