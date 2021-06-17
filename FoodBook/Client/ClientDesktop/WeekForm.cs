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
        private String stringWeekNumber;
        private Menu weekMenu;
        internal Service serviceMidday;
        public Service serviceEvening;

        public WeekForm()
        {
            //Afficher le numéro de la semaine : 
            int _currentWeekNumber = CWeekNumber();



            InitializeComponent();
            tBWeek.Text = _currentWeekNumber.ToString();
            Initialize();
            CreateClientMenu();

            //Trop rapide pour être visible "Acutellement" voir -> TimerLoading_Tick();
            //timerLoading.Stop();
            //pictureBox_Loading.Dispose();
        }

        private int CWeekNumber()
        {
            //HACK : Problême du nombre de semaine dans une année à cause des "Leap" year. 
            int weekNumber = 1 + CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
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
            //TODO : Effectuer un controle sur actualweek pour éviter d'être >52
            //Si >52 alors changer alors years++
            actualWeek++;
            tBWeek.Text = actualWeek.ToString();
            CreateClientMenu();
        }
        private void Button_previous_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Tu viens de cliquer sur : button_previous ");
            int actualWeek = Int32.Parse(tBWeek.Text);
            //TODO : Effectuer un controle sur actualweek pour éviter d'être <1
            //Si <1 alors changer alors years--; .
            actualWeek--;
            tBWeek.Text = actualWeek.ToString();
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

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            //timerLoading.Stop();
            //pictureBox_Loading.Dispose();
        }
    }
}
