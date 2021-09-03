using App.Models;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientMobile.Models
{
    class WeekM : ModelBase
    {
        /// <summary>
        /// WeekM est un Singletion : 
        /// </summary>
        private static WeekM _instance;
        /// <summary>
        /// Lock
        /// </summary>
        private static readonly object Lock = new object();
        /// <summary>
        /// Instance static de WeekM
        /// </summary>
        public static WeekM Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (Lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new WeekM();
                        }
                    }
                }
                return _instance;
            }
        }
        /// <summary>
        /// Ctor par défaut
        /// </summary>
        public WeekM()
        {
        }
        /// <summary>
        /// Liste des services du WeekM (les 14)
        /// </summary>
        private List<ServiceM> _listService;
        public List<ServiceM> ListService
        {
            get => _listService;
            set { Set(ref _listService, value); }
        }
        /// <summary>
        /// Liste de services du Midi du WeekM
        /// </summary>
        private List<ServiceM> _listServiceMidi;
        public List<ServiceM> ListServiceMidi
        {
            get => _listServiceMidi;
            set { Set(ref _listServiceMidi, value); }
        }
        /// <summary>
        /// /// Liste de services du Soir du WeekM
        /// </summary>
        private List<ServiceM> _listServiceSoir;
        public List<ServiceM> ListServiceSoir
        {
            get => _listServiceSoir;
            set { Set(ref _listServiceSoir, value); }
        }
        /// <summary>
        /// Date du jour : 
        /// </summary>
        public DateTime CurrentDate { get; private set; }
        /// <summary>
        /// Ctor avec la date :
        /// </summary>
        /// <param name="currentDate"></param>
        public WeekM(DateTime currentDate)
        {
            Load(currentDate);
        }
        /// <summary>
        /// Charger le WeekM avec une date : 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public async Task Load(DateTime date)
        {
            CurrentDate = date;
            //Si pas de Date depuis DateTimePicker : alors on utilise date du pour comme date par défaut
            if (date == null)
            {
                date = DateTime.Now.Date;
            }
            //Trouver début de la semaine
            DateTime firstDayOfWeek = WhathIsTheFirstDay(date);
            //Prendre la semaine prochaine : 
            firstDayOfWeek = firstDayOfWeek.AddDays(7);
            //Retourner les 14 Services
            Task<List<ServiceM>> ListServiceM = GetAllServiceForNextWeekAsync(firstDayOfWeek);
            
            _listService = await ListServiceM;

        }
        /// <summary>
        /// Prendre la current Date et trouver le premier jour de la semaine
        /// </summary>
        /// <param name="currentDate"></param>
        /// <returns></returns>
        public DateTime WhathIsTheFirstDay(DateTime currentDate) 
        {
            Trace.WriteLine("Entrée dans la fonction : Trouver le premier jour de la semaine Client :");
            DateTime isMonday = currentDate;
            switch (currentDate.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    isMonday = currentDate;
                    break;
                case DayOfWeek.Tuesday:
                    isMonday = currentDate.AddDays(-1);
                    break;
                case DayOfWeek.Wednesday:
                    isMonday = currentDate.AddDays(-2);
                    break;
                case DayOfWeek.Friday:
                    isMonday = currentDate.AddDays(-3);
                    break;
                case DayOfWeek.Thursday:
                    isMonday = currentDate.AddDays(-4);
                    break;
                case DayOfWeek.Saturday:
                    isMonday = currentDate.AddDays(-5); ;
                    break;
                case DayOfWeek.Sunday:
                    isMonday = currentDate.AddDays(-6);
                    break; 
                default:
                    break;
            }
            Trace.WriteLine("La semaine commence le : " + isMonday);
            return isMonday;
        }
        /// <summary>
        /// Récupérer tous les services de la semaine à afficher : WeekM
        /// </summary>
        /// <param name="firstDayOfWeek"></param>
        /// <returns></returns>
        public async Task<List<ServiceM>> GetAllServiceForNextWeekAsync(DateTime firstDayOfWeek)
        {
            //Listes de ServiceM
            List<ServiceM> listServices = new List<ServiceM>();
            List<ServiceM> listServiceMidi = new List<ServiceM>();
            List<ServiceM> listServiceSoir = new List<ServiceM>();
            //Liste des Taches
            List<Task> servicesLoader = new List<Task>();
            //Pour chaque jour de la semaine
            for (int i = 0; i < 7; i++)
            {
                try
                {

                DateTime date = firstDayOfWeek.AddDays(i);
                //Service du Midi
                ServiceM serviceMMidi = new ServiceM();
                var ts = serviceMMidi.Load(date, true);
                listServiceMidi.Add(serviceMMidi);
                //Service du Soir
                ServiceM serviceMSoir = new ServiceM();
                var ts2 = serviceMSoir.Load(date, false);
                listServiceSoir.Add(serviceMSoir);
                //Ajouter à une liste des Services Soir et Midi
                listServices.AddRange(new List<ServiceM>() { serviceMMidi, serviceMSoir });
                //Ajouter à la liste des Taches
                servicesLoader.AddRange(new List<Task>() { ts, ts2 });
                }
                catch(Exception e)
                {
                    Trace.WriteLine(e.Message);
                }
            }

            await Task.WhenAll(servicesLoader);
            ListServiceMidi = listServiceMidi;
            ListServiceSoir = listServiceSoir;

            return listServices;
        }
    }
}
