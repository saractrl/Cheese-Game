using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace Cheese_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        // This part of the code interchanges the colors after very turn the player takes.

        public void OnClick(object sender, RoutedEventArgs e)
        {

            bool turn = true;

            Button b = (Button)sender;

            if (turn)
            {
                b.Background = new SolidColorBrush(Color.FromRgb(0xC3, 0x00, 0xFF));
                
            }
            else
            {
                b.Background = new SolidColorBrush(Color.FromRgb(0xE7, 0xFF, 0x08));
            }

            turn = !turn;
            // Sets turn back to false, so the color changes again.


        }

        private void OnHelp(object sender, RoutedEventArgs e)
        {
            //const string webpageUrl = "https://google.com/";

            //System.Diagnostics.Process.Start("https://google.com/");   

        }
    }
}
