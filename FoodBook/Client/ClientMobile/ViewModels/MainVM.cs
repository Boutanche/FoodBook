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

        private WeekM semaineM;

   

        private DateTime _currentDate;
        public DateTime CurrentDate
        {
            get => _currentDate;
            set {
                Set(ref _currentDate, value);
                LoadSemaine();
            }
        }

        private bool _midiSoirToogle;
        private ObservableCollection<DayStruct> _days;


        public async Task LoadSemaine()
        {

            semaineM = new WeekM(_currentDate);
            await semaineM.Load();

            
            //foreach(days in semaineM.days )
            //{

            //}; 
        }
    }
}
