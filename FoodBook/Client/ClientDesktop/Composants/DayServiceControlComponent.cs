﻿using BO.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private Service Service;

        public DayServiceControlComponent()
        {
            InitializeComponent();
        
        }
        public void Initialize(Service service, List<TypeOfDish> typesOfDish)
        {
            this.Service = service;
            typesOfDish.ForEach((type) =>
            {
                var component = new DishServiceControlComponent();
                MainTableService.Controls.Add(component);
                component.Initialize(service, type);
            });
        }
    }
}
