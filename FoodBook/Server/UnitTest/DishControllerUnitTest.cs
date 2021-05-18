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
<<<<<<< HEAD
            DishController dishController = new(restaurantService);
=======
            DishController dishController = new DishController(restaurantService);
>>>>>>> b69de690618d3ff8f6d1116185a82f6e5cb8927d
            //Act
            ActionResult<List<Dish>> DishActionResult = await dishController.GetAll();
            //Assert
            Assert.NotNull(DishActionResult);    
<<<<<<< HEAD
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
=======
>>>>>>> b69de690618d3ff8f6d1116185a82f6e5cb8927d
        }
    }
}
