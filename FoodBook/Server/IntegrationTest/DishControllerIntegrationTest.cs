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
                Id_dish = 1,
                Name = "couscous",
                Popularity = 0,
                Id_type = 2
            };
            //Act
            var response = await _client.GetFromJsonAsync<Dish>("api/v1.0/dish/1");
            //Assert
            Assert.Equal(response, expected);
        }
    }
}
