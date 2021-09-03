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
        /// <summary>
        /// Instance de RestaurantService : BLLC
        /// </summary>
        private IRestaurantService _restaurantService = new RestaurantService();

        /// <summary>
        /// Ctor par défaut 
        /// Objet ServiceM qui posséde des prorpiétes : 
        /// </summary>
        public ServiceM() { }

        /// <summary>
        /// Service du Service Model
        /// </summary>
        private Service _service;
        public Service Service
        {
            get => _service;
            set { Set(ref _service, value); }
        }
        /// <summary>
        /// Midi(1) ou Soir(2) du Service Model
        /// </summary>
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

        /// <summary>
        /// Date du service Modèle
        /// </summary>
        private DateTime _dateService;
        public DateTime DateService
        {
            get => _dateService;
            set { Set(ref _dateService, value); }
        }

        /// <summary>
        /// List of Dish du Service Modèle
        /// </summary>
        private List<Dish> _listOfDish = new List<Dish>();
        public List<Dish> ListOfDish
        {
            get => _listOfDish;
            set { Set(ref _listOfDish, value); }
        }


        /// <summary>
        /// Charge le modèle en fonction du service demandé
        /// </summary>
        /// <param name="date"></param>
        /// <param name="isMidi"></param>
        /// <returns></returns>
        public async Task Load(DateTime date, bool isMidi)
        {
            var isMidiServiceNumber = (isMidi) ? 1 : 2;
            List<Service> services = await _restaurantService.GetServiceByDate(date);
            var service = services.Where(s => s.ServiceNumber == isMidiServiceNumber).FirstOrDefault();

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
