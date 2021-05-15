using API.Controllers;
using BLL.Services;
using BO.DTO.Requests;
using BO.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using UnitTest.Services;
using Xunit;

namespace UnitTest
{
    /// <summary>
    /// But pédagogique : Tests Unitaires sur un objet factice
    /// </summary>
    public class BookControllerUnitTest
    {
        /// <summary>
        /// But Pédagogique : Tests Unitaires sur un GetBookByID
        /// </summary>
        [Fact]
        public async void TestGetBookById()
        {
            //Arrange
            ILibrairiService librairiService = new FakeLibrairiService();
            BooksController booksController = new BooksController(librairiService);
            //End Arrange
            
            //Act
            OkObjectResult bookActionResult = await booksController.GetBookById(1) as OkObjectResult;
            //End Act

            //Assert
            Assert.NotNull(bookActionResult);
            Assert.Equal(200, bookActionResult.StatusCode);
            //End Assert
        }
    }
}
