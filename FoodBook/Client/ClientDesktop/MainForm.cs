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

        public String weekNumber;
        
        //Connexion aux données

        //WIP : Connexion à la BDD : Récupération des Menus
        //private readonly IRestaurantService _restaurantService;
        //private readonly BindingSource bidingSource = new();

        public MainForm()
        {

        int _currentWeekNumber = CurrentWeekNumber();

            //WIP : Connexion à la BDD : Récupération des Menus
            //_restaurantService = new RestaurantService();
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
            DishForm dishForm = new();
            dishForm.Show();
        }

        //TODO : Gestion de l'année.
        //HACK : La fonction actuelle ne prend pas en compte la bonne semaine,
        // il a donc était nécessaire d'incrémenter de 1 la semaine retournée. 
        /// <summary>
        /// Permet de récurer la numéro de la semaine courrante
        /// </summary>
        /// <returns>int numéro de la semaine</returns>
        private static int CurrentWeekNumber()
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
        //TODO : C'est chiant à développer : Trouver une autre méthode :
        //TODO : 130 button à customiser et duplication de code !!!

        //HACK MainForm 1 : Cursor.Position
        // Utilisation de la position du curseur pour déterminer la date, le service le type de plat ?
        // -> Impose d'interdire le resize des fenètres.
        // https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.cursor.position?view=net-5.0

        //HACK MainForm 2 : MainFormDesigner.cs
        // Passer par la zone interdite du designer et faire des boucles de génération d'item ?
        // -> "Tu as pas le droit" il a dit M. Microsoft.

        //HACK MainForm 3 : Google : 
        //Etat actuel : J'affiche des semaines des jours le restaurateur quand il clique ça va ajouter un menu avec un plat -> Création en BDD.
        //Faire l'inverse ? Créer un menu (DTO?) à chaque affichage. Cela doit être plus facile pour récupérer les variables.
        //Quid des buttons et comment on gére leurs noms. 

        //HACK MainForm 4 : Fabien :

        // TODO : Demander à Fabien comment lui il ferait dans ce cas : 

        //TODO Faire la même chose avec les buttons :  Remove Starter / Dish / Dessert 
        //TODO Faire la même chose avec les buttons : Modify Starter / Dish / Dessert

        //FIXME : Modifier ou Réparer ...l'ensemble des Buttons Add... 

        //Fonction Ouverture fenètre DishSelectorForm()
        private void OpenDishSelectorForm()
        {
            //Récupération du numéro de semaine.
            weekNumber = textBox_week.Text;
            DishSelectorForm dishSelectorForm = new();
            dishSelectorForm.localWeek = weekNumber;
            dishSelectorForm.Show();
        }

        #region Add Starter
        //Tous les boutons Ajouter un Starter :

        //Service 1 : 
        //Day 1 :

        private void Button_AddS1D1_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        //Day 2: 
        private void button_AddS1D2_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }

        //Day 3:
        private void button_AddS1D3_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }

        //Day 4:
        private void button_AddS1D4_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }

        //Day 5:
        private void button_AddS1D5_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }

        //Day 6:
        private void button_AddS1D6_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }

        //Day 7: 
        private void button_AddS1D7_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }

        //Service 2 :
        //Day 1:

        private void button_AddStarterS2D1_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }

        //Day 2: 
        private void button_AddStarterS2D2_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }

        //Day 3:
        private void button_AddStarterS2D3_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        //Day 4:
        private void button_AddStarterS2D4_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }

        //Day 5:
        private void button_AddStarterS2D5_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        //Day 6:
        private void button_AddStarterS2D6_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }

        //Day 7:
        private void button_AddStarterS2D7_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        #endregion
        #region Add Dish
        //Tous les plats :
        
        //Service 1 :
        private void button_AddDishS1D1_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        private void button_AddDishS1D2_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        private void button_AddDishS1D3_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        private void button_AddDishS1D4_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        private void button_AddDishS1D5_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        private void button_AddDishS1D6_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        private void button_AddDishS1D7_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        //Service 2 : 
        private void button_AddDishS2D1_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        private void button_AddDishS2D2_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        private void button_AddDishS2D3_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        private void button_AddDishS2D4_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        private void button_AddDishS2D5_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        private void button_AddDishS2D6_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        private void button_AddDishS2D7_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        #endregion
        #region Add Dessert
        //Tous les desserts :

        //Service 1 :
        private void button_AddS1D1Dessert_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        private void button_AddS1D2Dessert_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        private void button_AddS1D3Dessert_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        private void button_AddS1D4Dessert_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        private void button_AddS1D5Dessert_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        private void button_AddS1D6Dessert_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        private void button_AddS1D7Dessert_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        //Service 2
        private void button_AddS2D1Dessert_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        private void button_AddS2D2Dessert_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        private void button_AddS2D3Dessert_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        private void button_AddS2D4Dessert_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        private void button_AddS2D5Dessert_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        private void button_AddS2D6Dessert_Click(object sender, EventArgs e)
        {
            OpenDishSelectorForm();
        }
        private void button_AddS2D7Dessert_Click(object sender, EventArgs e)
        { 
            OpenDishSelectorForm(); 
        }


        #endregion


    }
}
