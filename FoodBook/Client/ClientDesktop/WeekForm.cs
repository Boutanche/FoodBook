using BO.Entity;
using ClientDesktop.Composants;
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
    public partial class WeekForm : Form
    {
        //State
        //private Menu weekMenu;
        private ServiceControlComponent componentMidday;
        private ServiceControlComponent componentEvening;


        //Constructeur
        /// <summary>
        /// Ctor
        /// </summary>
        public WeekForm()
        {
            //Avoir une instance de Calendar associée avec CultureInfo en Fr.
            CultureInfo myCI = new CultureInfo("fr-Fr");
            Calendar myCal = myCI.Calendar;
            //Règles sur le week-end :
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
            //Je veux que dateTimePicker_FDOW m'affiche -> la date de  -> Premier Jour De la Semaine :
            DateTime isToday = DateTime.Now;
            DateTime isMonday = IsMonday(isToday);
            //DOW = Day Of Week
            int weekNumber = myCI.Calendar.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW);
            int _currentWeekNumber = weekNumber;
            //Initialization des composants :
            InitializeComponent();
            //Afficher le numéro de la semaine
            tBWeek.Text = _currentWeekNumber.ToString();
            //Afficher la date du premier jour de la semaine
            //FDOW : First Day Of Week
            dateTimePicker_FDOW.Value = IsMonday(isMonday);
            //Initiatialisation pour les services et conrollers
            Initialize(isMonday);

            //TODO : Mettre le loading en place
            // /!\ : Le timer ne s'arrête jamais pour le moment !
            //********************************Start_Image_Loading*************************
            //***************************************************************************
            //Trop rapide pour être visible "Acutellement" voir -> TimerLoading_Tick();
            //timerLoading.Stop();
            //pictureBox_Loading.Dispose();
            //***************************************************************************
            //********************************End_Image_Loading***************************
        }
        //Fonction pour trouver le premier jour du début de la semaine
        /// <summary>
        /// Trouver le premier jour du début de la semaine à partir de la date du jour
        /// </summary>
        /// <param name="isToday"> date du jour</param>
        /// <returns></returns>
        private DateTime IsMonday(DateTime isToday)
        {
            Trace.WriteLine("Entrée dans la fonction : Trouver le premier jour de la semaine");
            DateTime isMonday = isToday;
            switch (isToday.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    isMonday = isToday;
                    break;
                case DayOfWeek.Tuesday:
                    isMonday = isToday.AddDays(-1);
                    break;
                case DayOfWeek.Wednesday:
                    isMonday = isToday.AddDays(-2);
                    break;
                case DayOfWeek.Friday:
                    isMonday = isToday.AddDays(-3);
                    break;
                case DayOfWeek.Thursday:
                    isMonday = isToday.AddDays(-4);
                    break;
                case DayOfWeek.Saturday:
                    isMonday = isToday.AddDays(-5); ;
                    break;
                case DayOfWeek.Sunday:
                    isMonday = isToday.AddDays(-6);
                    break;
                default:
                    break;
            }
            return isMonday;
        }
        //Fonction pour Initiialiser les Control Component
        /// <summary>
        /// Initialisation des Control Component sur chaque service
        /// </summary>
        public void Initialize(DateTime isMonday)
        {
            Trace.WriteLine("Tu es sur le weekForm et tu veux initialiser.");
            componentMidday = new ServiceControlComponent(1, isMonday);
            componentEvening = new ServiceControlComponent(2, isMonday);
            
            // /!\ : Menu n'existe plus !!
            // /!\ : Menu n'existe plus !!


            tlpMidday.Controls.Add(componentMidday);
            tlpEvening.Controls.Add(componentEvening);
        }
        //Ensemble des controles sur les Btn Next & Previous ([>>] & [<<])
        #region Btn Previous and Next
        /// <summary>
        /// Click sur Btn Next
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_next_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Tu viens de cliquer sur : button_next ");
            int actualWeek = Int32.Parse(tBWeek.Text);
            DateTime isToday = dateTimePicker_FDOW.Value; 
            actualWeek++;
            isToday = isToday.AddDays(+7);
            if (actualWeek > 52)
            {
                Trace.WriteLine("L'application à changée d'année et ne fonctionne plus");
                actualWeek = 1;
            }
            tBWeek.Text = actualWeek.ToString();
            dateTimePicker_FDOW.Value = isToday;
            //Initialize(isToday);
            componentMidday.UpdateComponent(1, isToday);
            componentEvening.UpdateComponent(2, isToday);

        }
        /// <summary>
        /// Click sur Btn Previous
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_previous_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Tu viens de cliquer sur : button_previous ");
            int actualWeek = Int32.Parse(tBWeek.Text);
            DateTime isToday = dateTimePicker_FDOW.Value;
            actualWeek--;
            isToday = isToday.AddDays(-7);
            if (actualWeek < 1)
            {
                Trace.WriteLine("L'application à changée d'année et ne fonctionne plus");
                actualWeek = 52;
            }
            tBWeek.Text = actualWeek.ToString();
            dateTimePicker_FDOW.Value = isToday;
            //Initialize(isToday);
            componentMidday.UpdateComponent(1, isToday);
            componentEvening.UpdateComponent(2, isToday);

        }
        #endregion
        // /!\ : Menu n'existe plus !!

        //Se produit au chargement de la page : 
        /// <summary>
        /// Lancement du Timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeekForm_Load(object sender, EventArgs e)
        {
            Trace.WriteLine("Lancement du Timer");
            timerLoading.Start();
        }
        //Se produit au click sur Btn CreateDish
        /// <summary>
        /// Création d'un plat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_createDish_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Tu viens de cliquer sur : button_createDish ");
            DishForm dishForm = new();
            dishForm.Show();
        }
        //
        public void UpdateComponent(DateTime isMonday)
        {
            Trace.WriteLine("Mise à jour des Component Midday et Evening");
            componentMidday.UpdateComponent(1, isMonday);
            componentEvening.UpdateComponent(2, isMonday);
        }
    }
}

