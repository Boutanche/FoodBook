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
        private int IntIdService;
        private readonly IRestaurantService _restaurantService;
        //Connexion aux données 
        private readonly BindingSource bindingSourceDishes = new();
        
        public DishSelectorForm(Service service, int IntTypeOfDish)
        {
            //Mon service ici n'a pas encore id !!! C'est le service "Client" qui n'a pas été créé dans la bdd.
            
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
            int idDish = Int32.Parse(dataGridViewDishes.CurrentRow.Cells["id"].Value.ToString());
            //Id service n'exite pas encore : 
            int idService = 1;
            //J'ai pas d'id service
            //WIP : Supression de l'entité isComposed
            //
            IsComposed newIsComposed = new(idDish, idService);

            //1 : Vérifier si le service existe

            //Select service where dateService = Service.dateService && serviceNumber = service.serviceNumber
            //Cette requête va me renvoyer soit 0, soit 1.

            //2 : Vérifier si ce service est lié à un plat de même type de plat ***IntTypeOfDish*** : "Table : iscomposed"
            //Faire une requête sur une vue Service triées par type de plat... 
            //Attention ça ne règle pas le problème du Melon... !! Le melon est un ingrédient on peut créer un plat Melon Dessert : Melon Entrée

            //2.5 : Si Le service n'existe pas et/ou s'il n'est pas lié à une table : "is composed" :
            //Alors : Créer le service et lier le plat à ce ce service.

            //WIP : IsComposed
            //Task<IsComposed> TaskIsComposed = _restaurantService.CreateIsComposed(newIsComposed);
            
            //Sinon Si : Le service existe mais il n'y a pas de table is composed .
            //Alors : Créer seulement la liaison.

            //Sinon : Il faut réaliser un update du plat c'est à dire : modifier la table is composed.
            // /!\ Réaliser un update sur une table de liaison où l'id est composée de deux clès étrangères. 
            
        }

        //Récupération du numéro de la semaine depuis mainForm:
        private void DishSelectorForm_Load(object sender, EventArgs e)
        {
            //Test Affichage de la semaine : 
            labelWeekNumber.Text = localWeek;

        }
    }
}
