using BO.Entity;
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
    public partial class DishServiceControlComponent : UserControl
    {
        // State of component
        private Service Service { get; set; }
        private TypeOfDish TypeOfDish { get; set; }

        public DishServiceControlComponent()
        {
            InitializeComponent();
        }

        public void Initialize (Service service, TypeOfDish typeOfDish)
        {
            Service = service;
            TypeOfDish = typeOfDish;

            AddBtn.Click += PerformAddClick;
            DelBtn.Click += PerformRemoveClick;
            ModifyBtn.Click += PerformModifyClick;


        }

        private void PerformAddClick(object sender, EventArgs e)
        {
            using( var dialog = new DishSelectorForm())
            {
                var dialogResult = dialog.ShowDialog();
                if(dialogResult == DialogResult.OK)
                {
                    // finis
                }
                else
                {
                    //Annuler
                }
            }
            //Doit me faire un click un type/ UN jour / 
        }

        private void PerformRemoveClick(object sender, EventArgs e)
        {
            //Doit me faire un click un type/ UN jour / 
        }

        private void PerformModifyClick(object sender, EventArgs e)
        {
            //Doit me faire un click un type/ UN jour / 
        }
    }
}
