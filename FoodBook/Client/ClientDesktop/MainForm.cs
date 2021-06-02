using BLLC.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientDesktop
{
    public partial class MainForm : Form
    {
        //Connexion aux données
        private readonly IRestaurantService _restaurantService;
        private BindingSource bidingSource = new BindingSource();

        public MainForm()
        {
        int _currentWeekNumber = CurrentWeekNumber();
        int thisWeekNumber = _currentWeekNumber;

        _restaurantService = new RestaurantService();
            InitializeComponent();
            //Charge le menu de la semaine
            //TODO : Si le numéro de la semaine n'existe pas :
            //afficher le menu existant le plus proche.
            textBox_week.Text = _currentWeekNumber.ToString();
        }
        /// <summary>
        /// ouverture du menu créer un plat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void button_createDish_Click(object sender, EventArgs e)
        {
            DishForm dishForm = new DishForm();
            dishForm.Show();
        }

        //TODO : Gestion de l'année.
        //HACK : La fonction actuelle ne prend pas en compte la bonne semaine,
        // il a donc était nécessaire d'incrémenter de 1 la semaine retournée. 
        /// <summary>
        /// Permet de récurer la numéro de la semaine courrante
        /// </summary>
        /// <returns>int numéro de la semaine</returns>
        private int CurrentWeekNumber()
        {
            int weekNumber = 1 + CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                DateTime.Now, CalendarWeekRule.FirstFullWeek, DayOfWeek.Sunday);
            return weekNumber; 
        }
        /// <summary>
        /// Ajouter 1 à la semaine affichée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_next_Click(object sender, EventArgs e)
        {
            int actualWeek = Int32.Parse(textBox_week.Text);
            //TODO : Effectuer un controle sur actualweek pour éviter d'être >52
            actualWeek++;
            textBox_week.Text = actualWeek.ToString();         
        }
        /// <summary>
        /// Retirer 1 à la semaine affichée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_previous_Click(object sender, EventArgs e)
        {
            int actualWeek = Int32.Parse(textBox_week.Text);
            //TODO : Effectuer un controle sur actualweek pour éviter d'être <1
            actualWeek--;
            textBox_week.Text = actualWeek.ToString();
        }

        //TODO Faire la même chose avec les buttons :  Remove Starter / Dish / Dessert 
        //TODO Faire la même chose avec les buttons : Modify Starter / Dish / Dessert
        #region Add Starter
        //Tous les boutons Ajouter un Starter :
        //TODO : Ajouter une entrée
        //Service 1 : 
        //Day 1 :
        private void button_AddS1D1_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();

        }
        //Day 2: 
        private void button_AddS1D2_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }

        //Day 3:
        private void button_AddS1D3_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }

        //Day 4:
        private void button_AddS1D4_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }

        //Day 5:
        private void button_AddS1D5_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }

        //Day 6:
        private void button_AddS1D6_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }

        //Day 7: 
        private void button_AddS1D7_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }

        //Service 2 :
        //Day 1:

        private void button_AddStarterS2D1_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }

        //Day 2: 
        private void button_AddStarterS2D2_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }

        //Day 3:
        private void button_AddStarterS2D3_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        //Day 4:
        private void button_AddStarterS2D4_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }

        //Day 5:
        private void button_AddStarterS2D5_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        //Day 6:
        private void button_AddStarterS2D6_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }

        //Day 7:
        private void button_AddStarterS2D7_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        #endregion
        #region Add Dish
        //Service 1 :
        private void button_AddDishS1D1_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        private void button_AddDishS1D2_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        private void button_AddDishS1D3_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        private void button_AddDishS1D4_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        private void button_AddDishS1D5_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        private void button_AddDishS1D6_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        private void button_AddDishS1D7_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        //Service 2 : 
        private void button_AddDishS2D1_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        private void button_AddDishS2D2_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        private void button_AddDishS2D3_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        private void button_AddDishS2D4_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        private void button_AddDishS2D5_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        private void button_AddDishS2D6_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        private void button_AddDishS2D7_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        #endregion
        #region Add Dessert
        //Service 1 :
        private void button_AddS1D1Dessert_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        private void button_AddS1D2Dessert_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        private void button_AddS1D3Dessert_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        private void button_AddS1D4Dessert_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        private void button_AddS1D5Dessert_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        private void button_AddS1D6Dessert_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        private void button_AddS1D7Dessert_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        //Service 2
        private void button_AddS2D1Dessert_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        private void button_AddS2D2Dessert_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        private void button_AddS2D3Dessert_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        private void button_AddS2D4Dessert_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        private void button_AddS2D5Dessert_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        private void button_AddS2D6Dessert_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }
        private void button_AddS2D7Dessert_Click(object sender, EventArgs e)
        {
            DishSelectorForm dishSelectorForm = new DishSelectorForm();
            dishSelectorForm.Show();
        }


        #endregion
    }
}
