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
    /// Mise en place des tests unitaires sur Ingredients 
    /// </summary>
    public class IngredientControllerUnitTest
    {
        /// <summary>
        /// Test Unitaire sur CreateIngredient
        /// </summary>
        [Fact]
        public async void TestCreateIngredient()
        {
            //Arange
            IRestaurantService restaurantService = new FakeRestaurantService();
            IngredientsController ingredientsController = new IngredientsController(restaurantService);

            Ingredients salt = new Ingredients();
            {
                salt.Name = "Salt";
                salt.Price = 1.5m;
            }

            //Act
            var IngredientActionResult = await ingredientsController.CreateIngredient(salt);

            //Assert
            Assert.NotNull(IngredientActionResult);
        }

        //TODO : Test Modify Ingredients :
        [Fact]
        public async void TestModifyIngredient()
        {
            //Arrange
            IRestaurantService restaurantService = new FakeRestaurantService();
            IngredientsController ingredientsController = new IngredientsController(restaurantService);
            
            Ingredients salt = new Ingredients();
            {
                salt.Name = "Salt";
                salt.Price = 1.5m;
            }

            //Act
            var IngredientActionResult = await ingredientsController.ModifyIngredient(1, salt);

            //Assert
            Assert.NotNull(IngredientActionResult);



        }
        //TODO : Test Get All Ingredients : 
        /// <summary>
        /// Test Unitaire sur Get All
        /// </summary>
        [Fact]
        public async void GetAll()
        {
            //Arrange
            IRestaurantService restaurantService = new FakeRestaurantService();
            IngredientsController ingredientController = new IngredientsController(restaurantService);

            //Act
            ActionResult<List<Ingredients>> IngredientsActionResult = await ingredientController.GetAll();
            
             //Assert
            Assert.NotNull(IngredientsActionResult);
        }

            /// <summary>
            /// Test Unitaire sur GetIngredientById
            /// </summary>
            [Fact]
        public async void TestGetIngredientById()
        {
            //Arrange
            IRestaurantService restaurantService = new FakeRestaurantService();
            IngredientsController ingredientsController = new IngredientsController(restaurantService);

            //Act
            //Test sur id = 1 
            OkObjectResult ingredientActionResult1 = await ingredientsController.GetIngredientById(1) as OkObjectResult;
            //Test sur id = 2 
            OkObjectResult ingredientActionResult2 = await ingredientsController.GetIngredientById(2) as OkObjectResult;
            //Test sur Résultat n'existe pas :
            NotFoundResult notFoundingredientActionResult = await ingredientsController.GetIngredientById(9999) as NotFoundResult;


            //Assert
            Assert.NotNull(ingredientActionResult1);
            Assert.Equal(200, ingredientActionResult1.StatusCode);
            Assert.Equal(200, ingredientActionResult2.StatusCode);
            Assert.NotNull(notFoundingredientActionResult);
            Assert.Equal(404, notFoundingredientActionResult.StatusCode);
        }
        /// <summary>
        /// Test Suppression d'ingrdédient par identifiant
        /// </summary>
        [Fact]
        public async void TestRemoveIngredientById()
        {
            //Arrange
            IRestaurantService restaurantService = new FakeRestaurantService();
            IngredientsController ingredientsController = new IngredientsController(restaurantService);

            //Act
            var noContentExpected = await ingredientsController.DeleteIngredient(1) as NoContentResult;

            //Assert
            Assert.NotNull(noContentExpected);
            Assert.Equal(204, noContentExpected.StatusCode);

        }
    }
}
