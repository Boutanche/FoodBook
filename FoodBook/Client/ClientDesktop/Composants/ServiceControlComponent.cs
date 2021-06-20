using BO.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientDesktop.Composants
{
    public partial class ServiceControlComponent : UserControl
    {
        //State 
        //private Service Service;

        public ServiceControlComponent(int serviceNumber, DateTime isMonday)
        {
            InitializeComponent();
            InitializeTest(serviceNumber, isMonday);
        }
        
        
        public void InitializeTest(int serviceNumber, DateTime isMonday)
        {
            for (int i = 0; i < 7; i++)
            {
                //Quand je passe ici je peux connaitre les dates :
                //Je peux donc créer mes entités Service :
                //Je récupère le numéro de service
                //Et ici la date.
                Service service = new Service();
                service.ServiceNumber = serviceNumber;
                service.DateService = isMonday.AddDays(i);
               
                Trace.WriteLine("Je suis dans la boucle for du ServiceControlComponent : " + i);
                var component = new DayServiceControlComponent(service);
                tLP_ServiceByMenu.Controls.Add(component);
                component.InitializeTest();
            }
        }



        //public void Initialize(Service service, List<TypeOfDish> typesOfDish)
        //{
        //    //this.service = service;
        //    for (int i = 1; i < 8; i++)
        //    {
        //        //WIP le i :
        //        Trace.WriteLine("Je suis dans la boucle for du ServiceControlComponent" + i);
        //        var component = new DayServiceControlComponent();
        //        tLP_ServiceByMenu.Controls.Add(component);
        //        component.Initialize(service, typesOfDish);
        //    }
        //}
    }
}
