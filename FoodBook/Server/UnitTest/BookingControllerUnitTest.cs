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
    public class BookingControllerUnitTest
    {
        /// <summary>
        /// Mise en place des tests unitaires sur une réservation
        /// </summary>
        [Fact]
        public async void TestCreateBooking()
        {
            //Arange
            IRestaurantService restaurantService = new FakeRestaurantService();
            BookingController bookingController = new(restaurantService);
            Booking firstFakeBooking = new()
            {
            Id = 1,
            BookingDate = DateTime.Now,
            MealNumber = 1,
            Starter = 1,
            MainCourse = 1,
            Dessert = 1,
            Id_Client = 1,
            Id_Service = 1 
        };

            //Act

            var firstFakeBookingActionResult = await bookingController.CreateBooking(firstFakeBooking);

            //Assert
            Assert.NotNull(firstFakeBookingActionResult);

        }
    }
}
