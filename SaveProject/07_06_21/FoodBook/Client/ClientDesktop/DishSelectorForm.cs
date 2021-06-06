using BLLC.Services;
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

namespace ClientDesktop
{
    public partial class DishSelectorForm : Form
    {
        private readonly IRestaurantService _restaurantService;
        //Connexion aux données 
        private readonly BindingSource bindingSourceDishes = new();
        
        public DishSelectorForm()
        {
            _restaurantService = new RestaurantService();
            InitializeComponent();
            LoadDishes();
        }

        private async void LoadDishes()
        {
            Task<List<Dish>> dishTask = _restaurantService.GetAllDish();
            List<Dish> dishes = await dishTask;

            bindingSourceDishes.DataSource = dishes;
            dataGridViewDishes.DataSource = bindingSourceDishes;
            //dataGridViewDishes.Columns["id"].Visible = false;
        }

        private void dataGridViewDishes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //TODO : Controle avec demande de confirmation
            
            //TODO : Création du menu s'il n'existe pas.

            //TODO : Ajout du plat à ce jour de la semaine au service demandé.
        }
    }
}
