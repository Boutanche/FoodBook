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
        //Ici Faire un Singleton 
        private static ServiceM _instance;
        //Avec un lock ?
        private static readonly object Verrou = new object();

        public static ServiceM Instance
        {
            get {
                if (_instance == null)
                {
                    lock (Verrou)
                    {
                        if (_instance == null)
                        {
                            _instance = new ServiceM();
                        }                     
                    }
                }
                return _instance;
            }
        }

        public ServiceM() { }

        private List<Service> _serviceList;
        public List<Service> ServiceList 
        {
            get => _serviceList;
            set { Set(ref _serviceList, value); }
        }
        //Je pense que Service ne sert à rien du coup...
        //D'ailleurs on va le retirer pour le moment.
        //private Service _service;
        //public Service Service
        //{
        //    get => _service;
        //    set { Set(ref _service, value); }
        //}


        private int? _id;
        public int? Id
        {
            get => _id;
            set { Set(ref _id, value); }
        }

        private int _serviceNumber;
        public int ServiceNumber
        {
            get => _serviceNumber;
            set { Set(ref _serviceNumber, value); }
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
        //C'est l'occasion de voir la différence : (But pédagogique)
        private ObservableCollection<Dish> _obCollDish = new ObservableCollection<Dish>();
        public ObservableCollection<Dish> ObCollDish
        {
            get => _obCollDish;
            set => Set(ref _obCollDish, value);
        }

        public static ServiceM Load(int idService)
        {
            return new ServiceM();
        }
        public async Task<List<Service>> LoadServiceByDate(DateTime date)
        {
            ObCollDish.Clear();

            List<Service> service = await _restaurantService.GetServiceByDate(date);
            if (service != null)
            {
                ServiceList = service;
                foreach (var item in ServiceList)
                {
                    foreach (var itemDish in item.ListOfDish)
                    {
                        ObCollDish.Add(itemDish);
                    }
                }
            }
            return service;
            
        }

    }
}
