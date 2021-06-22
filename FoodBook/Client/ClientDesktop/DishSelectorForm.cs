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
        
        public DishSelectorForm(Service service, int IntTypeOfDish)
        {
            _restaurantService = new RestaurantService();
            InitializeComponent();
            //J'ai récupéré IntTypeOfDish pour effectuer un tri plus tard.
            LoadDishes(service.DateService);
        }

        private async void LoadDishes(DateTime dateService)
        {

            Task<List<Dish>> dishTask = _restaurantService.GetAllDish();
            List<Dish> dishes = await dishTask;

            bindingSourceDishes.DataSource = dishes;
            dataGridViewDishes.DataSource = bindingSourceDishes;
            dateTimePicker_ConvertWeekAndDayInDate.Value = dateService;
            dataGridViewDishes.Columns["id"].Visible = false;
            dataGridViewDishes.Columns["idType"].Visible = false;
        }

        private void DataGridViewDishes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //1 : Vérifier si le service existe
            //2 : Vérifier si ce service est lié à un plat : "Table : iscomposed"

            //2.5 : Si Le service n'existe pas et/ou s'il n'est pas lié à une table : "is composed" :
            //Alors : Créer le service et lier le plat à ce ce service.
            //Sinon Si : Le service existe mais il n'y a pas de table is composed .
            //Alors : Créer seulement la liaison.
            //Sinon : Il faut réaliser un update du plat c'est à dire : modifier la table is composed.
            


        }

        //Récupération du numéro de la semaine depuis mainForm:
        private void DishSelectorForm_Load(object sender, EventArgs e)
        {
            //Test Affichage de la semaine : 
            labelWeekNumber.Text = localWeek;

        }
    }
}
