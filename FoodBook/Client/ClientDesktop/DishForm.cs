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
        private BindingSource bindingSource = new BindingSource();
        public DishForm()
        {
            //Service qui gère le restaurant
            _restaurantService = new RestaurantService();
            InitializeComponent();
            //Chargement de ma liste d'ingrédients : 
            this.LoadIngredients();
        }
        private async void LoadIngredients()
        {
            Task<List<Ingredients>> ingredientsTask = _restaurantService.GetAllIngredients();
            List<Ingredients> ingredients = await ingredientsTask;

            //Problême + solution :
            //How to convert a list into data-table ?
            //https://stackoverflow.com/questions/18100783/how-to-convert-a-list-into-data-table

            bindingSource.DataSource = ingredients;
            //bindingSource.DataSource = ToDataTable(ingredients);

            dataGridView_ingredients.DataSource = bindingSource;
            dataGridView_ingredients.Columns["id_ingredient"].Visible = false;

        }
        //Ne sert à rien au final.
        /// <summary>
        /// Stackoverflow : how to convert a list into data-table ?
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table 
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
    }
}
