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
        //private String stringWeekNumber;
        private Menu weekMenu;
        internal Service serviceMidday;
        public Service serviceEvening;

        public WeekForm()
        {
            //Afficher le numéro de la semaine : 
            //int _currentWeekNumber = CWeekNumber();
            //Avoir une instance de Calendar associée avec CultureInfo en Fr.
            CultureInfo myCI = new CultureInfo("fr-Fr");
            Calendar myCal = myCI.Calendar;
            //Règles sur le week-end :
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
            //Je veux que dateTimePicker_FDOW m'affiche -> la date de  -> Premier Jour De la Semaine :
            DateTime isToday = DateTime.Now;
            DateTime isMonday = IsMonday(isToday);
            
            //TODO : Afficher date : Premier jour de la semaine.

            int weekNumber = myCI.Calendar.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW);
            int _currentWeekNumber = weekNumber;
            
            InitializeComponent();
            tBWeek.Text = _currentWeekNumber.ToString();
            dateTimePicker_FDOW.Value = IsMonday(isMonday);

            Initialize();
            CreateClientMenu();

            //Trop rapide pour être visible "Acutellement" voir -> TimerLoading_Tick();
            //timerLoading.Stop();
            //pictureBox_Loading.Dispose();
        }

        private DateTime IsMonday(DateTime isToday)
        {
            DateTime isMonday = isToday;
            switch (isToday.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    isMonday = isToday;
                    break;
                case DayOfWeek.Tuesday:
                    isMonday = isToday.AddDays(-2);
                    break;
                case DayOfWeek.Wednesday:
                    isMonday = isToday.AddDays(-3);
                    break;
                case DayOfWeek.Friday:
                    isMonday = isToday.AddDays(-4);
                    break;
                case DayOfWeek.Thursday:
                    isMonday = isToday.AddDays(-5);
                    break;
                case DayOfWeek.Saturday:
                    isMonday = isToday.AddDays(-6); ;
                    break;
                case DayOfWeek.Sunday:
                    isMonday = isToday.AddDays(-7);
                    break;
                default:
                    break;
            }
            return isMonday;
        }

        private int CWeekNumber()
        {
            //HACK : Problême du nombre de semaine dans une année à cause des "Leap" year. 
            int weekNumber = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                DateTime.Now, CalendarWeekRule.FirstFullWeek, DayOfWeek.Sunday);
            return weekNumber;
        }

        public void Initialize()
        {
            Trace.WriteLine("Tu es sur le weekForm et tu veux initialiser tes component.");
            var componentMidday = new ServiceControlComponent();
            var componentEvening = new ServiceControlComponent();



            //Si le menu existe dans la BDD alors il existe au moins un service midi ou soir sinon aucun service n'existe.
            //Si Menu n'existe pas dans la BDD : 
            serviceMidday = new Service()
            {
                ServiceNumber = 1,
            };
            serviceEvening = new Service()
            {
                ServiceNumber = 2,
            };
            
            //Si Menu existe il faut chercher  
            //Si Service existe dans la BDD


            tlpMidday.Controls.Add(componentMidday);
            
            tlpEvening.Controls.Add(componentEvening);

        }

        #region Btn Previous and Next
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
            CreateClientMenu();
        }
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
            CreateClientMenu();
        }
        #endregion

        private void CreateClientMenu()
        {
            //Création du Menu côté client : 
            weekMenu = new Menu()
            {
                Year = DateTime.Parse("01/01/2021"),
                WeekNumber = Int32.Parse(tBWeek.Text),
            };
            Trace.WriteLine("Création du Menu Client numéro " + weekMenu.WeekNumber);
            //Ajouter un control : Si existe déjà ne fait pas un new ?
        }
        
        //Se produit au chargement de la page : 
        private void WeekForm_Load(object sender, EventArgs e)
        {
            timerLoading.Start();

        }

        private void TimerLoading_Tick(object sender, EventArgs e)
        {
            //timerLoading.Stop();
            //pictureBox_Loading.Dispose();
        }

        private void Button_createDish_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Tu viens de cliquer sur : button_createDish ");
            DishForm dishForm = new();
            dishForm.Show();
        }
    }
}
