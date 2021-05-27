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
        /// <summary>
        /// Constructeur de la Fenêtre "DishForm"
        /// </summary>
        public DishForm()
        {   
            //Service qui gère le restaurant
            _restaurantService = new RestaurantService();
            InitializeComponent();
            //Chargement de la liste d'ingrédients : 
            LoadIngredients();


        }
        /// <summary>
        /// Chargement de la liste des ingrédients qui composent le plat ! 
        /// </summary>
        /// <param name="listOfIngredient"></param>
        private void LoadListOfIngredient(ListOfIngredient listOfIngredient)
        {
            dataGridView_DishComposedBy.DataSource = null;
            if(listOfIngredient != null)
            {
                listIngredients.Add(listOfIngredient);
            }

            bindingSourceList.DataSource = listIngredients;
            dataGridView_DishComposedBy.DataSource = bindingSourceList;
            //Enlever la colone idDish du dataGridView
            dataGridView_DishComposedBy.Columns["idDish"].Visible = false;

            //TODO : Ajouter un colone "Nom de l'ingrédient" et Afficher cette colonne à la place de "idIngredient"
        }

        /// <summary>
        /// Trouver l'iD à partir de la comboBox TypeDish
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Récupérer l'ensemble des ingrédients de la base de données.
        /// </summary>
        private async void LoadIngredients()
        {
            Task<List<Ingredients>> ingredientsTask = _restaurantService.GetAllIngredients();
            List<Ingredients> ingredients = await ingredientsTask;

            bindingSourceIngredients.DataSource = ingredients;
            dataGridView_ingredients.DataSource = bindingSourceIngredients;
            dataGridView_ingredients.Columns["id"].Visible = false;
        }
        /// <summary>
        /// Afficher la fenêtre pour créer un ingrédient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_createIngredient_Click(object sender, EventArgs e)
        {
            CreateIngredientForm createIngredientForm = new CreateIngredientForm();
            createIngredientForm.Show();
        }
        /// <summary>
        /// Quand on clique sur un ingrédient de la datagridview l'ingrédient s'ajoute à la liste des ingrédients qui composent le plat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_ingredients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Quand tu cliques tu m'ajoutes l'id de l'ingrédient à la liste temporaire.
            ListOfIngredient newIngredient = new( Int32.Parse(dataGridView_ingredients.CurrentRow.Cells["id"].Value.ToString()), 0, 1);
            LoadListOfIngredient(newIngredient);
        }
        /// <summary>
        /// Ce boutton va créer un plat à partir des premières informations : IMPLEMENTATION : OK.
        /// PUIS : ce bouton va compléter la table de liaison ListOfIngredient de la BDD.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button_ConfirmDish_ClickAsync(object sender, EventArgs e)
        {
            // Etape : 1
            //Création d'un nouveau plat
            Dish newDish = new();
            {
                newDish.Name = textBox_NameDish.Text;
                newDish.IdType = IsMyTypeOfDish();
                newDish.Popularity = 0;
            }
            Task<Dish> dishTask = _restaurantService.CreateDish(newDish);
            //OK!
            

            //TODO : les deux méthodes n'ont pas été codée encore.
            //GetDishByName
            //CreateListOfIngredient

            //Etape 1.5 : 
            //Récupérer l'id du plat.
            //WIP : 27/05/2020 : 12h30
            
            Dish MyNewDish = await dishTask;

            //Etape 2 :
            //Création de la liste des ingrédients pour ce plat.
            foreach (var item in dataGridView_DishComposedBy.Rows)
            {
                ListOfIngredient listOfIngredient = new();
                {
                    listOfIngredient.IdDish = MyNewDish.Id;
                    listOfIngredient.IdIngredient = Int32.Parse(
                        dataGridView_DishComposedBy.CurrentRow.Cells["idIngredient"].Value.ToString());
                    listOfIngredient.Quantity = Int32.Parse(
                        dataGridView_DishComposedBy.CurrentRow.Cells["quantity"].Value.ToString());
                }
                Task<ListOfIngredient> listOfIngredientTask = _restaurantService.CreateListOfIngredient(listOfIngredient);
            }
        }
    }








    //*******************************************************************************************************************************
    //******************************************* CODE POUBELLE A EFFACER AVANT RELEASE *********************************************
    /*
     *  1 : - Un test sur convertir une liste en data-table : Qui n'était pas utile en fait ça le fait tout seul.
     * 
     */
    //*******************************************************************************************************************************
    //*** Une pensée émue pour l'ensemble des codes qui finissent à la poubelle alors qu'ils ont été écris avec patience les dev. ***
    //
    //
    //
    //
    // 1 : Coonvertir une liste en data-table : 
    //
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
