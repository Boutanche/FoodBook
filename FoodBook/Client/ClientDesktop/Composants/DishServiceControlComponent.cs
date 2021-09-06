using BLLC.Services;
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
        private readonly IRestaurantService _restaurantService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="typeOdDishInInt"></param>
        public DishServiceControlComponent(int typeOdDishInInt)
        {
            _restaurantService = new RestaurantService();
            InitializeComponent();
        }

        public async void InitializeTest (Service service, int typeOfDish)
        {
            
            Service = service;
            IntTypeOfDish = typeOfDish;

            //HACK : 001 : N'affiche pas la date courrante : Hack avec performClick()
            //Trouver le bug sur la date.  

            Task<List<Service>> serviceList = _restaurantService.GetServiceByDate(service.DateService);
            List<Service> newServiceList = await serviceList;
            
            //Si newSerrviceList.Count supérieur à zéro et n'est pas null.
            if (newServiceList != null)
            {
                if (newServiceList.Count > 0)
                {
                    //List<Service> newServiceList = await serviceList; 
                    foreach (var item in newServiceList)
                    {
                        if (item.ServiceNumber == service.ServiceNumber)
                        {
                            foreach (var dish in item.ListOfDish)
                            {
                                if (dish.TypeofDish.Id == typeOfDish)
                                {
                                    labelDish.Text = dish.Name;
                                }
                            }
                        }
                    }
                }
                //Si newSerrviceList.Count = zéro ou est null.
                else if ((await serviceList).Count == 0)
                {
                    labelDish.Text = "Not completed yet";
                }

            }

            ///DishComboBox.DataBindings.; 
        }
        public void UpdateTest(Service service, int typeOfDish)
        {

            //Selectionner le plat et afficher dans la DishCombo box
            Service = service;
            IntTypeOfDish = typeOfDish;
            InitializeTest(service, typeOfDish);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            String StringDate = Service.DateService.ToString();
            
            using var dialog = new DishSelectorForm(Service, IntTypeOfDish);

            var dialogResult = dialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                //Tu prends le plat et tu le lies avec son service dans la table ! isComposed.
                //Pour créer un IsComposed j'ai besoin du Dish.Id qui m'est donné par le DishSelectorForm


                //Si il n'existe pas tu crées le menu de la semaine.
                //SI le menu de la semaine existe déjà : Tu ajoute un service ou tu modifie l'existant.                    
            }
            else
            {

                //Annuler
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
        private async Task<Dish> SelectDish(int typeOfDish, Service service)
        {
            Trace.WriteLine("Tu es entré dans la fonction SelectDish");
            int? idDish = null;
            //Select isComposed where idService.
            Task<List<IsComposed>> taskIsComposed = _restaurantService.GetIsComposedByIdService(service.Id);
            List<IsComposed> composition = await taskIsComposed;
            if (composition != null)
            {
                foreach (var item in composition)
                {
                    if (service.ServiceNumber == typeOfDish)
                    {
                        idDish = item.IdDish;
                    }
                }
            }
            
            //Select Dish
            Task<Dish> dish = _restaurantService.GetDishById(idDish);

            return await dish;
        }
    }
}
