using BO.Entity;
using ClientMobile.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace ClientMobile.ViewModels
{
    public enum TypePlat
    {
        ENTREE,
        PLAT,
        DESSERT

    }
    struct DayStruct
    {
        public string Jour { get; private set; }
        public string Entree { get; private set; }
        public string Plat { get; private set; }
        public string Dessert { get; private set; }

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
                LoadSemaine();
            }
        }
        private List<DayStruct> _listOfDay;
        public List<DayStruct> ListOfDay
        {
            get => _listOfDay;
            set
            {
                Set(ref _listOfDay, value);
            }
        }
        private bool _midiSoirToogle = false;
        public bool MidiSoirToogle
        {
            get => _midiSoirToogle;
            set
            {
                Set(ref _midiSoirToogle, value);
                LoadSemaine();
                
            }
        }
        private ObservableCollection<ServiceM> _days;
        public ObservableCollection<ServiceM> Days
        {
            get => _days;
            set
            {
                Set(ref _days, value);
            }
        }
        /// <summary>
        /// Charger une semaine
        /// </summary>
        /// <returns></returns>
        public async Task LoadSemaine()
        {
            int serviceNumber = 0;
            _listOfDay = new List<DayStruct>(); 

            if(CurrentDate != null && CurrentDate != semaineM.CurrentDate)
            {
                semaineM = new WeekM(_currentDate);
                await semaineM.Load(_currentDate);
            }
            else if(CurrentDate != DateTime.Now.Date)
            {

                CurrentDate = DateTime.Now.Date;

            }
            if (_midiSoirToogle && semaineM?.ListServiceMidi != null)
            {
                Days = new ObservableCollection<ServiceM>(semaineM.ListServiceMidi);
                serviceNumber = 1;
            }
            else if(!_midiSoirToogle && semaineM?.ListServiceSoir!= null)
            {
                serviceNumber = 2;
                Days = new ObservableCollection<ServiceM>(semaineM.ListServiceSoir);
            }
            if(Days != null)
            {
                foreach (var item in Days)
                {

                    string jour = item.DateService.Day.ToString();
                    string entree = item.ListOfDish.Where( p => p.TypeofDish.Wording == "Entrée").FirstOrDefault()?.Name.ToString();
                    string plat = item.ListOfDish.Where(p => p.TypeofDish.Wording == "Plat").FirstOrDefault()?.Name.ToString();
                    string dessert = item.ListOfDish.Where(p => p.TypeofDish.Wording == "Dessert").FirstOrDefault()?.Name.ToString();

                    DayStruct myDay = new DayStruct(jour, entree, plat, dessert);
                    _listOfDay.Add(myDay);
                }

            }
            //Rafraichir sur une fonction... 
            OnPropertyChanged("GetDayOrDefault");
        }

        /// <summary>
        /// Récupérer un jour : ou par défaut une chaine de caractère vide.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="type"></param>
        /// <returns>string</returns>
        public string GetDayOrDefault(int index, TypePlat type)
        {
            switch (type)
            {
                case TypePlat.ENTREE:
                    return ListOfDay?.ElementAtOrDefault(index).Entree;
                case TypePlat.PLAT:
                    return ListOfDay?.ElementAtOrDefault(index).Plat;
                case TypePlat.DESSERT:
                    return ListOfDay?.ElementAtOrDefault(index).Dessert;
                default:
                    return null;
            }
        }
    }
}
