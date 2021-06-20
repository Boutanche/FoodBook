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
    public partial class DayServiceControlComponent : UserControl
    {
        //State 
        
        public DayServiceControlComponent(Service service)
        {
            InitializeComponent();
        }
        //public void Initialize(Service service, List<TypeOfDish> typesOfDish)
        //{
        //    this.Service = service;
        //    typesOfDish.ForEach((typeOfDish) =>
        //    {
        //        int typeOfDishInt = 1;
        //        Trace.WriteLine("Je suis dans la boucle ForEach dayServiceControl" + typeOfDish);
        //        var component = new DishServiceControlComponent(typeOfDishInt);
        //        MainTableService.Controls.Add(component);
        //        component.Initialize(service, typeOfDish);
        //    });
        //}
        public void InitializeTest()
        {
            for (int i = 1; i < 4; i++)
            {
                Trace.WriteLine("Je suis dans la boucle ForEach de Test : dayServiceControl" + i);
                var component = new DishServiceControlComponent(i);
                MainTableService.Controls.Add(component);

            }
        }
    }
}
