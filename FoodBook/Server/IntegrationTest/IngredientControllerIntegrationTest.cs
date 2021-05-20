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
    public class IngredientControllerIntegrationTest : IntegrationTest
    {
        public IngredientControllerIntegrationTest(WebApplicationFactory<Startup> factory ) : base(factory){}
        [Fact]
        public async void GetIngredientById_Should_Be_OK()
        {
            //Arrange
            var expected = new Ingredients()
            {
                Id_ingredient = 1,
                Name = "Apple",
                Price = 2.5m
            };

            //Act
            var response = await _client.GetFromJsonAsync<Ingredients>("api/v1/ingredients/1");
                
            //Assert
            Assert.Equal(response, expected);
                    
        }
    }
}
