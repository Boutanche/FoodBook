using API;
using BO.Entity;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTest
{
    public class DishControllerIntegrationTest : IntegrationTest
    {
        public DishControllerIntegrationTest(WebApplicationFactory<Startup> factory) : base(factory) { }
        [Fact]
        public async void GetDishById_Should_Be_OK()
        {
            //Arrange
            var expected = new Dish()
            {
                Id = 6,
                Name = "Couscous",
                Popularity = 0,
                IdType = 2
            };
            //Act
            var response = await _client.GetFromJsonAsync<Dish>("api/v1.0/dish/6");
            //Assert
            Assert.Equal(response, expected);
        }
        [Fact]
        public async void GetDishByName_Should_Be_OK()
        {
            //Arrange
            var expected = new Dish()
            {
                Id = 6,
                Name = "Couscous",
                Popularity = 0,
                IdType = 2
            };
            //Act
            var response = await _client.GetFromJsonAsync<Dish>("api/v1.0/dish/name/Couscous");
            //Assert
            Assert.Equal(response, expected);
        }
    }
}
