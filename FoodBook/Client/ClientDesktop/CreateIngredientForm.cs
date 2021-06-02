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
    public partial class CreateIngredientForm : Form
    {
        private readonly IRestaurantService _restaurantService;
        //Connexion aux données 
        private BindingSource bindingSource = new BindingSource();
        public CreateIngredientForm()
        {
            InitializeComponent();
            _restaurantService = new RestaurantService();
        }

        private void button_validate_Click(object sender, EventArgs e)
        {
            // TODO : Controle sur les données entrantes :
            // Il ne faut pas que l'utilisateur puisse entrer n'importe quoi.
            Ingredients ingredient = new Ingredients();
            {
             
                ingredient.Name = textBox_ingredientName.Text;
                ingredient.Price = decimal.Parse(textBox_ingredientPrice.Text);
            }

            Task<Ingredients> ingredientsTask = _restaurantService.CreateIngredients(ingredient);
            // TODO : A la sortie : Afficher OK ou Afficher Erreur. 
            // TODO : Réfraichir les données.
        }
        //TODO : Button Cancel !
        private void button_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
