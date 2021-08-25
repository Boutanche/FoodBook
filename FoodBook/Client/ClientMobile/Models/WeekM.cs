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
        private static WeekM _instance;
        //Lock
        private static readonly object Lock = new object();
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
        public WeekM()
        {

        }
        private List<Service> _listService;
        public List<Service> ListService
        {
            get => _listService;
            set { Set(ref _listService, value); }
        }

        public WeekM(DateTime currentDate)
        {
            //S'il n'y a pas de currentDate (qui vient du dateTimePicker alors, prend la date du jour.)
            if (currentDate == null)
            {
                currentDate = DateTime.Now.Date;
            }
            //fonction trouver la date de début de semaine avec currentDate.
            DateTime firstDayOfWeek = WhathIsTheFirstDay(currentDate);
            //fonction pour récupérer les dates des 7 jours de la semaine. 
            Task<List<ServiceM>> ServiceListOfThisWeek = GetAllServiceForNextWeekAsync(firstDayOfWeek);

            //fonction pour charger les 14 services.
        }
        public WeekM Load(DateTime date)
        {
            return new WeekM(date);
        }
        public DateTime WhathIsTheFirstDay(DateTime currentDate) 
        {
            Trace.WriteLine("Entrée dans la fonction : Trouver le premier jour de la semaine");
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
            return isMonday;
        }
        public async Task<List<ServiceM>> GetAllServiceForNextWeekAsync(DateTime firstDayOfWeek)
        {
            List<ServiceM> listServiceM = null;
            //Récupérer un service 
            for (int i = 0; i < 7; i++)
            {
                DateTime date = firstDayOfWeek.AddDays(i);
                ServiceM service = new ServiceM();
                await service.LoadServiceByDate(date);
                listServiceM.Add(service);
                
            }
            return listServiceM;
        }
    }
}
