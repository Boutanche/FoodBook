using ClientMobile.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace ClientMobile.Views
{

    //Appeller firmule autrement

    //Mise à jour 16/08

    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class BookingPage : Page
    {
        private readonly BookingVM VMBooking = new BookingVM();
        /// <summary>
        /// Päge de réservation
        /// </summary>
        public BookingPage()
        {
            this.InitializeComponent();
        }
        /// <summary>
        /// Au clieck sur le bouton réserver
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            BookingVM.Booking();

            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
