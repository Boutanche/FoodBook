using App.Models;
using BLLC.Services;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClientMobile.Models
{
    class ServiceM : ModelBase
    {
        //On veut utiliser notre RestaurantService BLLC :
        private IRestaurantService _restaurantService = new RestaurantService();
       
        public ServiceM() { }

        private Service _service;
        public Service Service
        {
            get => _service;
            set { Set(ref _service, value); }
        }

        //MIDI OU SOIR
        private int _serviceNumber;
        public int ServiceNumber
        {
            get => _serviceNumber;
            set { Set(ref _serviceNumber, value); }
        }

        /// <summary>
        /// Id unique du service Modèle
        /// </summary>
        private int? _id;
        public int? Id
        {
            get => _id;
            set { Set(ref _id, value); }
        }


        private DateTime _dateService;
        public DateTime DateService
        {
            get => _dateService;
            set { Set(ref _dateService, value); }
        }

        //ObservableCollection<Dish> ??? Ou List ???
        private List<Dish> _listOfDish = new List<Dish>();
        public List<Dish> ListOfDish
        {
            get => _listOfDish;
            set { Set(ref _listOfDish, value); }
        }


        /// <summary>
        /// Charge le modèle
        /// </summary>
        /// <param name="date"></param>
        /// <param name="isMidi"></param>
        /// <returns></returns>
        public async Task Load(DateTime date, bool isMidi)
        {

            List<Service> services = await _restaurantService.GetServiceByDate(date);
            var service = (isMidi) ? services[0] : services[1];

            if (service != null)
            {
                Service = service;
                Id = service.Id;
                DateService = service.DateService;
                ListOfDish = service.ListOfDish;
                ServiceNumber = service.ServiceNumber;
            }
        }


    }
}
