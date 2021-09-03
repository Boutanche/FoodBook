using BLLC.Services;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        //Private
        private Service LocalService;
        private int IntIdService;
        private int IntServiceNumber;
        private DateTime DateTimeService;
        private readonly IRestaurantService _restaurantService;
        //Connexion aux données 
        private readonly BindingSource bindingSourceDishes = new();
        public DishSelectorForm(Service service, int IntTypeOfDish)
        {
            //Mon service ici n'a pas encore id !!! C'est le service "Client" qui n'a pas été créé dans la bdd.
            _restaurantService = new RestaurantService();
            IntServiceNumber = service.ServiceNumber;
            DateTimeService = service.DateService;
            LocalService = service;
            InitializeComponent();
            //J'ai récupéré IntTypeOfDish pour effectuer un tri plus tard.
            LoadDishes(service.DateService) ;
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
        private async void DataGridViewDishes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idDish = Int32.Parse(dataGridViewDishes.CurrentRow.Cells["id"].Value.ToString());
            IsComposed newIsComposed = null;
            //Vérifier si le service existe
            //Je cherche tous les services de la date sélectionnée : 
            Task<List<Service>> serviceTask = _restaurantService.GetServiceByDate(DateTimeService);   
            if ((await serviceTask).Count == 0)
            {
                Trace.WriteLine("GetServiceBydate a renvoyé un null.");
                //Si le service n'existe pas : Il faut le créer.
                Trace.WriteLine("Tentative : création du Service.");
                Task<Service> newService = _restaurantService.CreateService(LocalService);
                Service createdService = await newService;
                //Faut ensuite ajouter le plat à la liste service côté client.
                Task<Dish> dish = _restaurantService.GetDishById(idDish);
                Dish newDish = await dish;
                createdService.ListOfDish.Add(newDish);
                //Maintenant je peux faire un AddDishToService(service)
                Task<Service> leRetourDuService = _restaurantService.AddDishToService(createdService);
                Service laVengeanceDuService = await leRetourDuService;
                Trace.WriteLine("Ici, si tout va bien, la table isComposed de la BDD a été complétée.");
            }
            else
            {
                //Si le service de cette date existe... C'est la grosse merde !!!
                Trace.WriteLine("GetServiceBydate n'a pas renvoyé null.");
                //J'ai la liste de tous mes services de ce jour
                //List<Service> services = await serviceTask;
                Trace.WriteLine("services contient : serviceTask " + serviceTask);
                List<Service> listService = await serviceTask;
                Trace.WriteLine("services contient : listSerbvice " + listService);
                //Je cherche dans cette liste de service le même serviceNumber que celui que je veux créer
                foreach (Service item in listService)
                {
                    Trace.WriteLine("item contient : " + item.Id);
                    //Si mon numéro de service est le même que celui que le client on est sur la bonne piste.
                    if (item.ServiceNumber == IntServiceNumber)
                    {

                        //Je récupére l'id_type du plat 
                        int idType = Int32.Parse(dataGridViewDishes.CurrentRow.Cells["idType"].Value.ToString());
                        //Je récupére la liste IsComposed du service en question  :
                        Task <List<IsComposed>> taskIsComposed = _restaurantService.GetIsComposedByIdService(item.Id);
                        //S'il n'y pas de liste : Tout va bien : Création de isComposed avec ce plat et ce service.
                        if (await taskIsComposed == null)
                        {
                            newIsComposed = new(idDish, IntServiceNumber);
                        }
                        //S'il y a une liste : est ce que ce type existe ?
                        else
                        {
                            List<IsComposed> listIsComposed = await taskIsComposed;
                            //ATTENTION // Pas aussi simple.
                            foreach (IsComposed composition in listIsComposed)
                            {
                                Task<Dish> dish = _restaurantService.GetDishById(composition.IdDish);
                                Dish dishHere = await dish;
                                //Si ce type n'existe pas : création de isComposed avec ce plat et ce service.
                                if (dishHere.IdType != idType)
                                {
                                    //
                                }
                                //S'il ce type existe : mise à jour du isComposed en modifiant l'id_dish.
                                else
                                {
                                    //Faire un update
                                }
                            }
                        }
                        //Ou alors il fallait que le boutton soit disable et on se posait pas la question...

                        newIsComposed = new(idDish, item.Id);   
                    }
                    //Si ce n'est pas le même numéro de service :
                    else
                    {
                        //Ne rien faire et continuer la boucle.
                        Trace.WriteLine("Ce n'était pas le service que nous souhaitions créer");
                    }
                }
                //Fermer la fenêtre avec un resultat OK.
                button1.PerformClick();
            }
        }

        //Récupération du numéro de la semaine depuis mainForm:
        private void DishSelectorForm_Load(object sender, EventArgs e)
        {
            //Test Affichage de la semaine : 
            labelWeekNumber.Text = localWeek;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
