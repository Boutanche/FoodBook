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
    public class ListOfDishControllerUnitTest
    {
        [Fact]
        public async void TestCreateListOfIngredient()
        {
            //Arrange
            IRestaurantService restaurantService = new FakeRestaurantService();
            ListOfIngredientController listOfIngredientController = new(restaurantService);
            ListOfIngredient fakeIdDishAndfakeIdIngredient = new();
            {
                fakeIdDishAndfakeIdIngredient.IdDish = 1;
                fakeIdDishAndfakeIdIngredient.IdIngredient = 2;
                fakeIdDishAndfakeIdIngredient.Quantity = 1;
            }
            //Act
            var fakeListOfIngredientActionResult = await listOfIngredientController.CreateListOfIngredient(fakeIdDishAndfakeIdIngredient);

            //Assert
            Assert.NotNull(fakeListOfIngredientActionResult);
        }
        //TODO : Get List Of Dish  : 
    }
}
