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
                LoadSemaine();
            }
        }

        private bool _midiSoirToogle;
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

        public async Task LoadSemaine()
        {
            int serviceNumber = 0;

            if(CurrentDate != semaineM.CurrentDate)
            {
                semaineM = new WeekM(_currentDate);
                await semaineM.Load(_currentDate);
            }
            if (_midiSoirToogle)
            {
                serviceNumber = 1;
                Days = new ObservableCollection<ServiceM>(semaineM.ListServiceMidi);
            }
            else
            {
                serviceNumber = 2;
                Days = new ObservableCollection<ServiceM>(semaineM.ListServiceSoir);
            }

        }
    }
}
