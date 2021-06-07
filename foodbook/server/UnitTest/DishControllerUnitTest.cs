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
            ActionResult<List<Dish>> DishActionResult = await dishController.GetAllDish();
            //Assert
            Assert.NotNull(DishActionResult);
        }

        /// <summary>
        /// Récupération d'un plat par son nom
        /// </summary>
        [Fact]
        public async void TestGetDishByName()
        {
            //Arrange
            
            IRestaurantService restaurantService = new FakeRestaurantService();
            DishController dishController = new(restaurantService);
            string name = "Couscous";
            
            //string noName = "NoName";
            
            //Act
            //Test sur id = 1 
            OkObjectResult dishActionResult1 = await dishController.GetDishByName(name) as OkObjectResult;
            
            //Test sur Résultat n'existe pas :
            //NotFoundResult notFounddishActionResult = await dishController.GetDishByName(noName) as NotFoundResult;


            //Assert
            Assert.NotNull(dishActionResult1);
            Assert.Equal(200, dishActionResult1.StatusCode);
            
            //Assert.NotNull(notFounddishActionResult);
            //Assert.Equal(404, notFounddishActionResult.StatusCode);
        }


        /// <summary>
        /// Test Unitaire sur GetDishById
        /// </summary>
        [Fact]
        public async void TestGetDishById()
        {
            //Arrange
            IRestaurantService restaurantService = new FakeRestaurantService();
            DishController dishController = new(restaurantService);

            //Act
            //Test sur id = 1 
            OkObjectResult dishActionResult1 = await dishController.GetDishById(1) as OkObjectResult;
            //Test sur Résultat n'existe pas :
            NotFoundResult notFounddishActionResult = await dishController.GetDishById(9999) as NotFoundResult;


            //Assert
            Assert.NotNull(dishActionResult1);
            Assert.Equal(200, dishActionResult1.StatusCode);
            Assert.NotNull(notFounddishActionResult);
            Assert.Equal(404, notFounddishActionResult.StatusCode);
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
        }
        /// <summary>
        /// Suppression d'un plat
        /// </summary>
        [Fact]
        public async void TestRemoveDishById()
        {
            //Arrange
            IRestaurantService restaurantService = new FakeRestaurantService();
            DishController dishController = new(restaurantService);

            //Act
            var noContentExpected = await dishController.DeleteDish(1) as NoContentResult;

            //Assert
            Assert.NotNull(noContentExpected);
            Assert.Equal(204, noContentExpected.StatusCode);
        }
        /// <summary>
        /// Test unitaire sur Modifier un plat
        /// </summary>
        [Fact]
        public async void TestModifyDish()
        {
            //Arrange
            IRestaurantService restaurantService = new FakeRestaurantService();
            DishController dishController = new(restaurantService);

            Dish tabbouleh = new();
            {
                tabbouleh.Name = "Tabbouleh";
                tabbouleh.Popularity = 0;
            }

            Dish couscous = new()

            {
                Id = 105,
                Name = "Couscous",
                Popularity = 1
            };
            Dish couscousGood = new()
            {
                Id = 1,
                Name = "Couscous",
                Popularity = 1
            };
            //Act
            var DishActionResult = await dishController.ModifyDish(1, tabbouleh) as BadRequestResult;
            var DishActionResultNull = await dishController.ModifyDish(1, null) as BadRequestResult;
            var DishActionResultNotFoundCase = await dishController.ModifyDish(105, couscous) as NotFoundResult;
            var DishActionResultOkCase = await dishController.ModifyDish(1, couscousGood) as OkObjectResult;

            //Assert
            Assert.NotNull(DishActionResult);
            Assert.NotNull(DishActionResultNull);
            Assert.NotNull(DishActionResultNotFoundCase);
            Assert.NotNull(DishActionResultOkCase);

        }
    }
}