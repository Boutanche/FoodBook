using App.Models;
using BLLC.Services;
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
    public class BookingM : ModelBase
    {
        private static BookingM _instance;

        private static readonly object Verrou = new object();


        public static BookingM Instance
        {
            get
            {

                lock (Verrou)
                {
                    if (_instance == null)
                    {
                        _instance = Load();
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
        public DateTime BookingDate
        {
            get => _bookingDate;
            set => Set(ref _bookingDate, value);
        }
        private int _mealNumber;
        public int MealNumber
        {
            get => _mealNumber;
            set => Set(ref _mealNumber, value);
        }
        private int _starter;
        public int Starter
        {
            get => _starter;
            set => Set(ref _starter, value);
        }
        private int _mainCourse;
        public int MainCourse
        {
            get => _mainCourse;
            set => Set(ref _mainCourse, value);
        }
        private int _dessert;
        public int Dessert
        {
            get => _dessert;
            set => Set(ref _dessert, value);
        }
        private int _id_Client;
        public int Id_Client
        {
            get => _id_Client;
            set => Set(ref _id_Client, value);
        }
        private int _id_Server;
        public int Id_Server
        {
            get => _id_Server;
            set => Set(ref _id_Server, value);
        }
        ////Sauvegarde le modèle dans la clé BOOKING
        public void Save()
        {
            IRestaurantService service = new RestaurantService();
            service.CreateBooking(new Booking()
            {


            });

        }

        //load qui charge les settings
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
