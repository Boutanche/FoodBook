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
        private TypeOfDish MyTypeOfDish { get; set; }
        private int IntTypeOfDish { get; set; }
        private Dish Dish { get; set; }
        private Menu Menu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="typeOdDishInInt"></param>
        public DishServiceControlComponent(int typeOdDishInInt)
        {
            Trace.WriteLine("Initialisation du DishServiceControlComponen");
            InitializeComponent();
        }

        public void Initialize (Service service, TypeOfDish typeOfDish)
        {
            Service = service;
            MyTypeOfDish = typeOfDish;
        }
        public void InitializeTest (Service service, int typeOfDish)
        {
            Service = service;
            IntTypeOfDish = typeOfDish;
            
        }
        public void UpdateTest(Service service, int typeOfDish)
        {
            Service = service;
            IntTypeOfDish = typeOfDish;
        }



        private void AddBtn_Click(object sender, EventArgs e)
        {
            String StringDate = Service.DateService.ToString();
            Trace.WriteLine("Tu viens de cliquer sur un Btn Add");
            Trace.WriteLine("Concerne le service numéro : (doit me renvoyer null) : " + Service.Id.ToString() );
            Trace.WriteLine("Concerne le jour service date  : (doit me renvoyer une date) : " + StringDate);
            using (var dialog = new DishSelectorForm(Service))
            {
                var dialogResult = dialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    //Tu prends le plat et tu le lies avec son service dans la table ! isComposed.
                    //Pour créer un IsComposed j'ai besoin du Dish.Id qui m'est donné par le DishSelectorForm

                    IsComposed isComposed = new IsComposed(1, Service.Id);
                    
                    //Si il n'existe pas tu crées le menu de la semaine.
                    //SI le menu de la semaine existe déjà : Tu ajoute un service ou tu modifie l'existant.                    
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
