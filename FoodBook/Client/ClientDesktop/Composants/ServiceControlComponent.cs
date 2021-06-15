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

        public ServiceControlComponent()
        {
            InitializeComponent();
            InitializeTest();
        }
        
        
        public void InitializeTest()
        {
            for (int i = 1; i < 8; i++)
            {
                //Service = service;
                ///Service.DayNumber = i;
                //WIP le i :
                Trace.WriteLine("Je suis dans la boucle for du ServiceControlComponent : " + i);
                var component = new DayServiceControlComponent();
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
