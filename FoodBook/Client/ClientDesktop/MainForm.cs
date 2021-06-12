using BLLC.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        public int dayNumber;
        public int serviceNumber;
        public int typeNumber;
        
        //Connexion aux données
        //WIP : Connexion à la BDD : Récupération des Menus
        //private readonly IRestaurantService _restaurantService;
        //private readonly BindingSource bidingSource = new();

        public MainForm()
        {
            //Si le numéro de la semaine ne correspond à aucun menu alors afficher une page vierge.
            int _currentWeekNumber = CurrentWeekNumber();
            InitializeComponent();
            textBox_week.Text = _currentWeekNumber.ToString();
            //_restaurantService = new RestaurantService();
        }

        //TODO : Gestion de l'année.
        //Ecrire une fonction qui me permette de remplir le champ year de la table menu. 
        //Il faudra que cette fonction s'actualise avec le click sur les button "next" and "previous".

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

        //Fonction Ouverture fenètre DishSelectorForm()
        /// <summary>
        /// Fonction qui se lance au click sur un button "Add" et qui permet de passer les valeurs à la fenêtre DishSelectorForm
        /// </summary>
        private void OpenDishSelectorForm()
        {
            //Récupération de l'enesmelbe des information nécessaires à la DishForm
            weekNumber = textBox_week.Text;
            DishSelectorForm dishSelectorForm = new();
            dishSelectorForm.localWeek = weekNumber;
            dishSelectorForm.localDay = dayNumber;
            dishSelectorForm.localService = serviceNumber;
            dishSelectorForm.localType = typeNumber;
            dishSelectorForm.Show();
        }
        #region Header Button
        /// <summary>
        /// ouverture du menu créer un plat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void Button_createDish_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Tu viens de cliquer sur : button_createDish ");
            DishForm dishForm = new();
            dishForm.Show();
        }
        /// <summary>
        /// Ajouter 1 à la semaine affichée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_next_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Tu viens de cliquer sur : button_next ");
            int actualWeek = Int32.Parse(textBox_week.Text);
            //TODO : Effectuer un controle sur actualweek pour éviter d'être >52
            //Si >52 alors changer alors years++
            actualWeek++;
            textBox_week.Text = actualWeek.ToString();         
        }
        /// <summary>
        /// Retirer 1 à la semaine affichée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_previous_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Tu viens de cliquer sur : button_previous ");
            int actualWeek = Int32.Parse(textBox_week.Text);
            //TODO : Effectuer un controle sur actualweek pour éviter d'être <1
            //Si <1 alors changer alors years--; .
            actualWeek--;
            textBox_week.Text = actualWeek.ToString();
        }
        /// <summary>
        /// Afficher les statistiques 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_status_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Tu viens de cliquer sur : Le bouton des statistiques ");
        }
        #endregion
        #region Add Starter
        //Tous les boutons Ajouter un Starter :

        //Service 1 : 
        //Day 1 :

        private void Button_AddS1D1_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Tu viens de cliquer sur : **Button_AddS1D1_Click**");
            typeNumber = 1;
            dayNumber = 1;
            serviceNumber = 1;
            OpenDishSelectorForm();
        }
        //Day 2: 
        private void Button_AddS1D2_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Tu viens de cliquer sur : **Button_AddS1D2_Click**");
            typeNumber = 1;
            dayNumber = 2;
            serviceNumber = 1;
            OpenDishSelectorForm();
        }

        //Day 3:
        private void Button_AddS1D3_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Tu viens de cliquer sur : **Button_AddS1D3_Click**");
            typeNumber = 1;
            dayNumber = 3;
            serviceNumber = 1;
            OpenDishSelectorForm();
        }
        //Day 4 : 
        private void Button_AddS1D4_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Tu viens de cliquer sur : **Button_AddS1D4_Click**");
            typeNumber = 1;
            dayNumber = 3;
            serviceNumber = 1;
            OpenDishSelectorForm();
        }

        //Day 5:
        private void Button_AddS1D5_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Tu viens de cliquer sur : **Button_AddS1D5_Click**");
            typeNumber = 1;
            dayNumber = 5;
            serviceNumber = 1;
            OpenDishSelectorForm();
        }

        //Day 6:
        private void Button_AddS1D6_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Tu viens de cliquer sur : **Button_AddS1D6_Click**");
            typeNumber = 1;
            dayNumber = 6;
            serviceNumber = 1;
            OpenDishSelectorForm();
        }

        //Day 7: 
        private void Button_AddS1D7_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Tu viens de cliquer sur : **Button_AddS1D7_Click**");
            typeNumber = 1;
            dayNumber = 7;
            serviceNumber = 1;
            OpenDishSelectorForm();
        }

        //Service 2 :
        //Day 1:

        private void Button_AddStarterS2D1_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Tu viens de cliquer sur : **Button_AddStarterS2D1_Click**");
            typeNumber = 1;
            dayNumber = 1;
            serviceNumber = 2;
            OpenDishSelectorForm();
        }

        //Day 2: 
        private void Button_AddStarterS2D2_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Tu viens de cliquer sur : **Button_AddStarterS2D2_Click**");
            typeNumber = 1;
            dayNumber = 2;
            serviceNumber = 2;
            OpenDishSelectorForm();
        }

        //Day 3:
        private void Button_AddStarterS2D3_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Tu viens de cliquer sur : **Button_AddStarterS2D3_Click**");
            typeNumber = 1;
            dayNumber = 3;
            serviceNumber = 2;
            OpenDishSelectorForm();
        }
        //Day 4:
        private void Button_AddStarterS2D4_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Tu viens de cliquer sur : **Button_AddStarterS2D4_Click**");
            typeNumber = 1;
            dayNumber = 4;
            serviceNumber = 2;
            OpenDishSelectorForm();
        }

        //Day 5:
        private void Button_AddStarterS2D5_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Tu viens de cliquer sur : **Button_AddStarterS2D5_Click**");
            typeNumber = 1;
            dayNumber = 5;
            serviceNumber = 2;
            OpenDishSelectorForm();
        }
        //Day 6:
        private void Button_AddStarterS2D6_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Tu viens de cliquer sur : **Button_AddStarterS2D6_Click**");
            typeNumber = 1;
            dayNumber = 6;
            serviceNumber = 2;
            OpenDishSelectorForm();
        }

        //Day 7:
        private void Button_AddStarterS2D7_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Tu viens de cliquer sur : **Button_AddStarterS2D6_Click**");
            typeNumber = 1;
            dayNumber = 7;
            serviceNumber = 2;
            OpenDishSelectorForm();
        }
        #endregion
        #region Add Dish
        //Tous les plats :
        
        //Service 1 :
        private void Button_AddDishS1D1_Click(object sender, EventArgs e)
        {
            typeNumber = 2;
            dayNumber = 1;
            serviceNumber = 1;
            OpenDishSelectorForm();
        }
        private void Button_AddDishS1D2_Click(object sender, EventArgs e)
        {
            typeNumber = 2;
            dayNumber = 2;
            serviceNumber = 1;
            OpenDishSelectorForm();
        }
        private void Button_AddDishS1D3_Click(object sender, EventArgs e)
        {
            typeNumber = 2;
            dayNumber = 3;
            serviceNumber = 1;
            OpenDishSelectorForm();
        }
        private void Button_AddDishS1D4_Click(object sender, EventArgs e)
        {
            typeNumber = 2;
            dayNumber = 4;
            serviceNumber = 1;
            OpenDishSelectorForm();
        }
        private void Button_AddDishS1D5_Click(object sender, EventArgs e)
        {
            typeNumber = 2;
            dayNumber = 5;
            serviceNumber = 1;
            OpenDishSelectorForm();
        }
        private void Button_AddDishS1D6_Click(object sender, EventArgs e)
        {
            typeNumber = 2;
            dayNumber = 6;
            serviceNumber = 1;
            OpenDishSelectorForm();
        }
        private void Button_AddDishS1D7_Click(object sender, EventArgs e)
        {
            typeNumber = 2;
            dayNumber = 7;
            serviceNumber = 1; 
            OpenDishSelectorForm();
        }
        //Service 2 : 
        private void Button_AddDishS2D1_Click(object sender, EventArgs e)
        {
            typeNumber = 2;
            dayNumber = 1;
            serviceNumber = 2;
            OpenDishSelectorForm();
        }
        private void Button_AddDishS2D2_Click(object sender, EventArgs e)
        {
            typeNumber = 2;
            dayNumber = 2;
            serviceNumber = 2;
            OpenDishSelectorForm();
        }
        private void Button_AddDishS2D3_Click(object sender, EventArgs e)
        {
            typeNumber = 2;
            dayNumber = 3;
            serviceNumber = 2;
            OpenDishSelectorForm();
        }
        private void Button_AddDishS2D4_Click(object sender, EventArgs e)
        {
            typeNumber = 2;
            dayNumber = 4;
            serviceNumber = 2;
            OpenDishSelectorForm();
        }
        private void Button_AddDishS2D5_Click(object sender, EventArgs e)
        {
            typeNumber = 2;
            dayNumber = 5;
            serviceNumber = 2;
            OpenDishSelectorForm();
        }
        private void Button_AddDishS2D6_Click(object sender, EventArgs e)
        {
            typeNumber = 2;
            dayNumber = 6;
            serviceNumber = 2;
            OpenDishSelectorForm();
        }
        private void Button_AddDishS2D7_Click(object sender, EventArgs e)
        {
            typeNumber = 2;
            dayNumber = 7;
            serviceNumber = 2;
            OpenDishSelectorForm();
        }
        #endregion
        #region Add Dessert
        //Tous les desserts :

        //Service 1 :
        private void Button_AddS1D1Dessert_Click(object sender, EventArgs e)
        {
            typeNumber = 3;
            dayNumber = 1;
            serviceNumber = 1;
            OpenDishSelectorForm();
        }
        private void Button_AddS1D2Dessert_Click(object sender, EventArgs e)
        {
            typeNumber = 3;
            dayNumber = 2;
            serviceNumber = 1;
            OpenDishSelectorForm();
        }
        private void Button_AddS1D3Dessert_Click(object sender, EventArgs e)
        {
            typeNumber = 3;
            dayNumber = 3;
            serviceNumber = 1;
            OpenDishSelectorForm();
        }
        private void Button_AddS1D4Dessert_Click(object sender, EventArgs e)
        {
            typeNumber = 3;
            dayNumber = 4;
            serviceNumber = 1;
            OpenDishSelectorForm();
        }
        private void Button_AddS1D5Dessert_Click(object sender, EventArgs e)
        {
            typeNumber = 3;
            dayNumber = 5;
            serviceNumber = 1;
            OpenDishSelectorForm();
        }
        private void Button_AddS1D6Dessert_Click(object sender, EventArgs e)
        {
            typeNumber = 3;
            dayNumber = 6;
            serviceNumber = 1;
            OpenDishSelectorForm();
        }
        private void Button_AddS1D7Dessert_Click(object sender, EventArgs e)
        {
            typeNumber = 3;
            dayNumber = 7;
            serviceNumber = 1;
            OpenDishSelectorForm();
        }
        //Service 2
        private void Button_AddS2D1Dessert_Click(object sender, EventArgs e)
        {
            typeNumber = 3;
            dayNumber = 1;
            serviceNumber = 2;
            OpenDishSelectorForm();
        }
        private void Button_AddS2D2Dessert_Click(object sender, EventArgs e)
        {
            typeNumber = 3;
            dayNumber = 2;
            serviceNumber = 2;
            OpenDishSelectorForm();
        }
        private void Button_AddS2D3Dessert_Click(object sender, EventArgs e)
        {
            typeNumber = 3;
            dayNumber = 3;
            serviceNumber = 2;
            OpenDishSelectorForm();
        }
        private void Button_AddS2D4Dessert_Click(object sender, EventArgs e)
        {
            typeNumber = 3;
            dayNumber = 4;
            serviceNumber = 2;
            OpenDishSelectorForm();
        }
        private void Button_AddS2D5Dessert_Click(object sender, EventArgs e)
        {
            typeNumber = 3;
            dayNumber = 5;
            serviceNumber = 2;
            OpenDishSelectorForm();
        }
        private void Button_AddS2D6Dessert_Click(object sender, EventArgs e)
        {
            typeNumber = 3;
            dayNumber = 6;
            serviceNumber = 2;
            OpenDishSelectorForm();
        }
        private void Button_AddS2D7Dessert_Click(object sender, EventArgs e)
        {
            typeNumber = 3;
            dayNumber = 7;
            serviceNumber = 2;
            OpenDishSelectorForm(); 
        }





        #endregion

    }
}
