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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Arvestus_Ragnar_Kolomets
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
 

        public MainPage()
        {
            this.InitializeComponent();
        }
        private int attempt = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string kasutajanimi = "user";
            string parool = "SecretPassword";

            if (attempt < 3)
            {
                if (textbox1.Text == kasutajanimi && password1.Password == parool)
                {
                    this.Frame.Navigate(typeof(Content));
                }
                else
                {
                    textblock1.Text = "Sisselogimine ebaõnnestus!";
                    attempt++;
                }
            }
            else
            {
                textblock1.Text = "Sisselogimise katsed on otsas!";
            }
        }
    }
}
