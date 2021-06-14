using BO.Entity;
using ClientDesktop.Composants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientDesktop
{
    public partial class WeekForm : Form
    {
        //State 
        private Service Service;

        public WeekForm()
        {
            InitializeComponent();
        }
        public void Initialize(Service service, List<TypeOfDish> typesOfDish)
        {
            this.Service = service;
            for (int i = 1; i < 8; i++)
            {
                //WIP le i :
                var component = new DayServiceControlComponent();
                tlpMidday.Controls.Add(component);
                component.Initialize(service, typesOfDish);
            }
        }
    }
}
