using App.Models;
using BLLC.Services;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;
using Windows.ApplicationModel.Store.Preview.InstallControl;
using Windows.Globalization;
using Windows.Storage;

namespace ClientMobile.Models
{
    /// <summary>
    /// Model des réservations
    /// </summary>
    public class BookingM : ModelBase
    {
        /// <summary>
        /// Singleton 
        /// </summary>
        private static BookingM _instance;

        private static readonly object Verrou = new object();

        /// <summary>
        /// Instance de Réservation Model
        /// </summary>
        public static BookingM Instance
        {
            get
            {

                lock (Verrou)
                {
                    if (_instance == null)
                    {
                        //_instance = Load();
                    }

                    return _instance;
                }
            }
        }

        /// <summary>
        /// Don't use this constructor it is for JSON ONLY
        /// </summary>
        [JsonConstructor]

        public BookingM() { }

        private DateTime _bookingDate;
        /// <summary>
        /// Date de la réservation
        /// </summary>
        public DateTime BookingDate
        {
            get => _bookingDate;
            set => Set(ref _bookingDate, value);
        }
        private int _mealNumber;
        /// <summary>
        /// Nombre de plat
        /// </summary>
        public int MealNumber
        {
            get => _mealNumber;
            set => Set(ref _mealNumber, value);
        }
        private int _starter;
        /// <summary>
        /// Entrée
        /// </summary>
        public int Starter
        {
            get => _starter;
            set => Set(ref _starter, value);
        }
        private int _mainCourse;
        /// <summary>
        /// Plat
        /// </summary>
        public int MainCourse
        {
            get => _mainCourse;
            set => Set(ref _mainCourse, value);
        }
        private int _dessert;
        /// <summary>
        /// Dessert
        /// </summary>
        public int Dessert
        {
            get => _dessert;
            set => Set(ref _dessert, value);
        }
        private int _id_Client;
        /// <summary>
        /// Identifiant unique du client
        /// </summary>
        public int Id_Client
        {
            get => _id_Client;
            set => Set(ref _id_Client, value);
        }
        private int _id_Server;
        /// <summary>
        /// Identifiant unique du service
        /// </summary>
        public int Id_Server
        {
            get => _id_Server;
            set => Set(ref _id_Server, value);
        }

        /// <summary>
        /// Sauvegarde le modèle dans la clé BOOKING
        /// </summary>
        public void Save()
        {
            IRestaurantService service = new RestaurantService();
            service.CreateBooking(new Booking()
            {


            });

        }

        /// <summary>
        /// Load qui charge les réservations 
        /// </summary>
        /// <param name="idBooking"> Identifiant de la réservation</param>
        /// <returns></returns>
        public static BookingM Load(int idBooking)
        {
            try
            {
                return JsonSerializer.Deserialize<BookingM>(
                    ApplicationData.Current.LocalSettings.Values["BOOKING"] as string);
            }
            catch (Exception e)
            {
                return new BookingM();
            }

        }
    }
}
