using BLLC.Services;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientDesktop
{
    public partial class DishForm : Form
    {
        private readonly IRestaurantService _restaurantService;
        //Connexion aux données 
        private BindingSource bindingSourceIngredients = new BindingSource();
        private BindingSource bindingSourceList = new BindingSource();

        //Initialise une liste d'ingrédients côté client.
        private List<ListOfIngredient> listIngredients = new();
        //HACK : Pour la liste d'ingrédients
        private ListOfIngredient fictifIngredient = new();
        public DishForm()
        {   
            //Service qui gère le restaurant
            _restaurantService = new RestaurantService();
            InitializeComponent();
            //Chargement de la liste d'ingrédients : 
            LoadIngredients();
            //Chargement de la liste d'ingrédient de ce plat      
            //Durant la première initialisation la liste des ingrédients de ce plat est vide...
            //TODO : Boucle (if is fictifIngredient){do autre chose.}
            LoadListOfIngredient(fictifIngredient);
        }
        //En attente : on tente autre chose.
        //Il faut que cette methode me produise la liste des ingrédients pour le plat sélectionné.
        private void LoadListOfIngredient(ListOfIngredient listOfIngredient)
        {
            dataGridView_DishComposedBy.DataSource = null;
            if(listOfIngredient != null)
            {
                listIngredients.Add(listOfIngredient);
            }

            bindingSourceList.DataSource = listIngredients;
            dataGridView_DishComposedBy.DataSource = bindingSourceList;

            //dataGridView_DishComposedBy.Rows.Clear();
            //dataGridView_DishComposedBy.Update();
            //dataGridView_DishComposedBy.Refresh();
            
        }

        //Fonction : trouer un id_Type à partir de la comboBox
        private int IsMyTypeOfDish()
        {
            if (comboBox_TypeDish.Text == "Entrée") {
                return 1;
            }
            else if (comboBox_TypeDish.Text == "Plat") {
                return 2;
            }
            return 3;
        }
        private async void LoadIngredients()
        {
            Task<List<Ingredients>> ingredientsTask = _restaurantService.GetAllIngredients();
            List<Ingredients> ingredients = await ingredientsTask;

            bindingSourceIngredients.DataSource = ingredients;
            dataGridView_ingredients.DataSource = bindingSourceIngredients;
            dataGridView_ingredients.Columns["id"].Visible = false;
        }

        private void button_createIngredient_Click(object sender, EventArgs e)
        {
            CreateIngredientForm createIngredientForm = new CreateIngredientForm();
            createIngredientForm.Show();
        }

        private void dataGridView_ingredients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
  
            //Quand tu cliques tu m'ajoutes l'id de l'ingrédient à la liste temporaire.
            ListOfIngredient newIngredient = new(null, Int32.Parse(dataGridView_ingredients.CurrentRow.Cells["id"].Value.ToString()), 1);
            LoadListOfIngredient(newIngredient);

            //Pour Tester : 
            //textBox_PopularityDish.Text = dataGridView_ingredients.CurrentRow.Cells["id"].Value.ToString();
            //Cela semble fonctionner

            // TODO : Lire la documentation !!!
        }

        private void button_ConfirmDish_Click(object sender, EventArgs e)
        {
            // 1
            //Création d'un nouveau plat
            Dish newDish = new();
            {
                newDish.Name = textBox_NameDish.Text;
                newDish.IdType = IsMyTypeOfDish();
                newDish.Popularity = 0;
            }
            Task<Dish> dishTask = _restaurantService.CreateDish(newDish);
      
            //récupérer l'id du plat.

            //Update liste des ingrédients du plat.

            // 2
            //Création de la liste des ingrédients pour ce plat.
        }
    }









    //********************************* CODE POUBELLE A EFFACER AVANT RELEASE *******************************************************
    /*
     *  1 : - Un test sur convertir une liste en data-table : Qui n'était pas utile en fait ça le fait tout seul.
     * 
     */
    
    // 1 :
    ////Ne sert à rien au final.
    ///// <summary>
    ///// Stackoverflow : how to convert a list into data-table ?
    ///// </summary>
    ///// <typeparam name="T"></typeparam>
    ///// <param name="items"></param>
    ///// <returns></returns>
    //public static DataTable ToDataTable<T>(List<T> items)
    //{
    //    DataTable dataTable = new DataTable(typeof(T).Name);

    //    //Get all the properties
    //    PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
    //    foreach (PropertyInfo prop in Props)
    //    {
    //        //Defining type of data column gives proper data table 
    //        var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
    //        //Setting column names as Property names
    //        dataTable.Columns.Add(prop.Name, type);
    //    }
    //    foreach (T item in items)
    //    {
    //        var values = new object[Props.Length];
    //        for (int i = 0; i < Props.Length; i++)
    //        {
    //            //inserting property values to datatable rows
    //            values[i] = Props[i].GetValue(item, null);
    //        }
    //        dataTable.Rows.Add(values);
    //    }
    //    //put a breakpoint here and check datatable
    //    return dataTable;
    //}
}
