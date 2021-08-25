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
        /// <summary>
        /// WTF ?! 
        /// </summary>
        private WeekM semaineM;
        private ServiceM serviceM = ServiceM.Instance;
   

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


        public async Task LoadSemaine(DateTime date)
        {

            //Refaire retrouver le premier jour de la semaine
            //J'affiche des sermaines donc quel que soit le jour il faut que je retrouve le lundi dont il est question...
            //Et si je le fais dans WeekM ? 
            
            
            semaineM = new WeekM(_currentDate);
            semaineM.Load(date);

            
            //foreach(days in semaineM.days )
            //{

            //}; 
        }
    }
}
