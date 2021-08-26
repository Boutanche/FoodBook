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
        private List<ServiceM> _listServiceMidi;
        private List<ServiceM> _listServiceSoir;

        public List<ServiceM> ListServiceMidi
        {
            get => _listServiceMidi;
            set { Set(ref _listServiceMidi, value); }
        }
        public List<ServiceM> ListServiceSoir
        {
            get => _listServiceSoir;
            set { Set(ref _listServiceSoir, value); }
        }
        public WeekM(DateTime currentDate, int serviceNumber)
        {
            //S'il n'y a pas de currentDate (qui vient du dateTimePicker alors, prend la date du jour.)
            if (currentDate == null)
            {
                currentDate = DateTime.Now.Date;
            }
            //fonction trouver la date de début de semaine avec currentDate.
            DateTime firstDayOfWeek = WhathIsTheFirstDay(currentDate);
            //fonction pour récupérer les dates des 7 jours de la semaine et les 14 services
            //Et seulement le service Midi ou service Soir en fonction de serviceNumber
            Task<List<Service>> ListServiceM = GetAllServiceForNextWeekAsync(firstDayOfWeek, serviceNumber);

        }
        
        public WeekM Load(DateTime date, int serviceNumber)
        {
            return new WeekM(date, serviceNumber);
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
        public async Task<List<Service>> GetAllServiceForNextWeekAsync(DateTime firstDayOfWeek, int serviceNumber)
        {
            //J'ai rien compris : Pourquoi j'utilise un ServiceM "model" si j'utilise des Services ?
            List<ServiceM> listServiceM = new List<ServiceM>();
            List<Service> listServiceByServiceNumber = new List<Service>();
            //Récupérer un service 
            for (int i = 0; i < 7; i++)
            {
                DateTime date = firstDayOfWeek.AddDays(i);
                ServiceM service = new ServiceM();
                await service.LoadServiceByDate(date);
                listServiceM.Add(service);
                //Ici j'ai les 14 services de la semaine dans listServiceM.
                Service se = listServiceM[i].ServiceList.Where(serv => serv.ServiceNumber == serviceNumber).FirstOrDefault();
                listServiceByServiceNumber.Add(se);
            }
            //Service s = listServiceM[0].ServiceList.Where(serv => serv.ServiceNumber == serviceNumber).FirstOrDefault();

            return listServiceByServiceNumber;
        }
    }
}
