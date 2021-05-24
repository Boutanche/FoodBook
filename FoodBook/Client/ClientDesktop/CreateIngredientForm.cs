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
        }

        private void button_validate_Click(object sender, EventArgs e)
        {
            Ingredients ingredient = new Ingredients();
            {
                ingredient.Name = textBox_ingredientName.Text;
                ingredient.Price = decimal.Parse(textBox_ingredientPrice.Text);
            }
            
            Task<Ingredients> ingredientsTask = _restaurantService.CreateIngredients(ingredient);

        }
    }
}
