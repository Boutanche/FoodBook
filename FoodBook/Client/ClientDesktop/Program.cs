using System;
using System.Windows.Forms;

namespace ClientDesktop
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Ajouter ici un problème si pas de connexion bdd ?
            Application.Run(new WeekForm());
        }
    }
}
