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
    public partial class DishServiceControlComponent : UserControl
    {
        // State of component
        private Service Service { get; set; }
        private TypeOfDish TypeOfDish { get; set; }
        private Dish Dish { get; set; }
        private Menu Menu { get; set; }

        public DishServiceControlComponent(int typeOdDishInInt)
        {
            Trace.WriteLine("Initialisation du DishServiceControlComponen");
            InitializeComponent();
        }

        public void Initialize (Service service, TypeOfDish typeOfDish)
        {
            Service = service;
            TypeOfDish = typeOfDish;

        }



        private void AddBtn_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Tu viens de cliquer sur un Btn Add");
            using (var dialog = new DishSelectorForm())
            {
                var dialogResult = dialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    //Tu prends le plat et tu le lies avec son service dans la table ! isComposed.
                    IsComposed isComposed = new IsComposed(1, Service.Id);
                    
                    //Si il n'existe pas tu crées le menu de la semaine.

                    //SI le menu de la semaine existe déjà : Tu ajoute un service ou tu modifie l'existant

                    
                }
                else
                {
                    //Annuler
                }
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Tu viens de cliquer sur un Btn Del");
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Tu viens de cliquer sur un Btn Modify");
        }
    }
}
