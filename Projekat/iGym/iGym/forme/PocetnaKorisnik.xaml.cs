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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace iGym
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PocetnaKorisnik : Page
    {
        public PocetnaKorisnik()
        {
            this.InitializeComponent();
        }

        private void klikNaProfilKorisnika(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ProfilKorisnik));
        }

        private void klikNaPlanIshrane(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PlanIshrane));
        }

        private void DugmePlanVjezbanja_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PlanVjezbanja));
        }

        private void klikNaSavjeti(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Savjeti));
        }

        private void klikNaZabiljeske(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Zabiljeske));
        }
    }
}
