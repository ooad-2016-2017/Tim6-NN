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
    public sealed partial class Prijava : Page
    {
        String ime;
        String sifra;
        public Prijava()
        {
            this.InitializeComponent();
            
        }

        

        private void prijavaDugme_Click(object sender, RoutedEventArgs e)
        {
            ime = PrijavaIme.Text;
            sifra = PrijavaSifra.Password;
            if (ime == Teretana.admin && sifra == Teretana.sifra)
                this.Frame.Navigate(typeof(PocetnaUposlenik));

            else if (ime == Teretana.imeTest && sifra == Teretana.sifraTest)
                this.Frame.Navigate(typeof(PocetnaKorisnik));

        }
    }
}
