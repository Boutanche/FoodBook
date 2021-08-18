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
        public Service Service { get; private set; }
        List<DishServiceControlComponent> dishServiceControlComponents = new List<DishServiceControlComponent>();
        

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
        public void InitializeTest(Service service)
        {
            Service = service;

            for (int i = 1; i < 4; i++)
            {
                Trace.WriteLine("Je suis dans la boucle ForEach de Test : dayServiceControl : " + i);
                DishServiceControlComponent component = new DishServiceControlComponent(i);
                MainTableService.Controls.Add(component);
                dishServiceControlComponents.Add(component);
                component.InitializeTest(service, i);

            }
        }
        public void UpdateComponent(Service service)
        {
            Service = service;
            for (int i = 0; i < 3; i++)
            {
                dishServiceControlComponents[i].UpdateTest(service, i+1);
                //WIP : Repas :
            }
        }
    }
}
