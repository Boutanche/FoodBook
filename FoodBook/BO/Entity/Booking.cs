using System;
using System.Collections.Generic;
using System.Text;

namespace BO.Entity
{
    /// <summary>
    /// Réprésente l'objet Réservation
    /// </summary>
    public class Booking
    {
        /// <summary>
        /// 
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime BookingDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int MealNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Starter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int MainCourse { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Dessert { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Id_Client { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Id_Service { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Booking()
        {
        }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public Booking(int? id, DateTime bookingDate, int mealNumber, int starter, int mainCourse, int dessert, int id_Client, int id_Service)
        {
            Id = id;
            BookingDate = bookingDate;
            MealNumber = mealNumber;
            Starter = starter;
            MainCourse = mainCourse;
            Dessert = dessert;
            Id_Client = id_Client;
            Id_Service = id_Service;
        }
        
    }
}
