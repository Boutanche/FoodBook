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
            // TODO : Si le numéro de la semaine n'existe pas afficher le menu existant le plus proche.
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
        //HACK : La fonction actuelle ne prend pas en compte la bonne semaine, il a donc était nécessaire d'incrémenter de 1 la semaine retournée. 
        /// <summary>
        /// Permet de récurer la numéro de la semaine courrante
        /// </summary>
        /// <returns>int numéro de la semaine</returns>
        private int CurrentWeekNumber()
        {
            int weekNumber = 1 + CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFullWeek, DayOfWeek.Sunday);
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
            actualWeek--;
            textBox_week.Text = actualWeek.ToString();
        }
    }
}
