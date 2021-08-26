using BO.Entity;
using ClientMobile.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace ClientMobile.ViewModels
{
    struct DayStruct
    {
        string Jour;
        string Entree;
        string Plat;
        string Dessert;

        public DayStruct(string jour, string entree, string plat, string dessert)
        {
            Jour = jour;
            Entree = entree;
            Plat = plat;
            Dessert = dessert;
        }
 
    };

    class MainVM : ViewModelBase
    {
        private WeekM semaineM = WeekM.Instance;
        //private ServiceM serviceM = ServiceM.Instance;
        private DateTime _currentDate;
        public DateTime CurrentDate
        {
            get => _currentDate;
            set {
                Set(ref _currentDate, value);
            }
        }

        private bool _midiSoirToogle;
        private ObservableCollection<DayStruct> _days;


        public async Task LoadSemaine(DateTime date, bool _midiSoir)
        {
            int serviceNumber = 0;
            if (_midiSoir)
            {
                serviceNumber = 1;
            }
            else
            {
                serviceNumber = 2;
            }
            semaineM = new WeekM(_currentDate, serviceNumber);
            //semaineM.Load(date);
            //I'm Here
            for (int i = 0; i < semaineM.ListService.Count; i++)
            {
                //semaineM.ListService[i]
                //ServiceM s = semaineM.ListService[i].ServiceList.Where(serv => serv.ServiceNumber == 1).FirstOrDefault();
            }            
            foreach (var service in semaineM.ListService)
            {
                //Service s = service.ServiceList.Where(serv => serv.ServiceNumber == 1).FirstOrDefault();
            }; 
        }
    }
}
