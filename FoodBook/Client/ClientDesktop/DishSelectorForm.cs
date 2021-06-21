using BLLC.Services;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientDesktop
{
    public partial class DishSelectorForm : Form
    {
        //Passage de paramètre entre deux fenètres.
        public String localWeek;
        public int localDay;
        public int localService;
        public int localType;
        //
        private readonly IRestaurantService _restaurantService;
        //Connexion aux données 
        private readonly BindingSource bindingSourceDishes = new();
        
        public DishSelectorForm(Service service)
        {
            _restaurantService = new RestaurantService();
            InitializeComponent();
            LoadDishes(service.DateService);
        }

        private async void LoadDishes(DateTime dateService)
        {
            //TODO : Au clic il faut afficher le jour concerné.

            Task<List<Dish>> dishTask = _restaurantService.GetAllDish();
            List<Dish> dishes = await dishTask;

            bindingSourceDishes.DataSource = dishes;
            dataGridViewDishes.DataSource = bindingSourceDishes;
            dateTimePicker_ConvertWeekAndDayInDate.Value = dateService;
            //dataGridViewDishes.Columns["id"].Visible = false;
        }

        private void DataGridViewDishes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //bool menuExist = false;
            //TODO : Controle avec demande de confirmation

            //TODO : Récupération de l'année : 


            //Menu newMenu = new();
            //{
            //    newMenu.Year = DateTime.Parse("01/01/2021");
            //    newMenu.WeekNumber = Int32.Parse(localWeek);
            //}

            //TODO : Je peux : envoyer un get AllMenu et faire alogo pour trouver cette semaine ici.
            //Je peux : Faire un getMenuByYears and Week ... Cette solution m'ennuie par le fait qu'on doit faire une requête et envoyer deux paramètres.
            //Je peux faire la moitié des deux : Faire une requette sur la liste des menu par année. Et faire le trairement de cette liste et rechercher uniquement la semaine qui m'intéresse ici. 

            ////TODO : Création du menu s'il n'existe pas.
            //if (menuExist != true)
            //{
            //    Task<Menu> menuTask = _restaurantService.CreateMenu(newMenu);
               
            //}
            //else
            //{
            //    //
            //}
            ////TODO : Ajout du plat à ce jour de la semaine au service demandé.


        }

        //Récupération du numéro de la semaine depuis mainForm:
        private void DishSelectorForm_Load(object sender, EventArgs e)
        {
            //Test Affichage de la semaine : 
            labelWeekNumber.Text = localWeek;

        }
    }
}
