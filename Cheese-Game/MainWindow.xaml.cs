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
        // Connected to lines
        public Lines button = new();

        public MainWindow()
        {
            InitializeComponent();
        }
    

        // Is connected to the class "Lines", this changes the line colours.
        public void OnClick(object sender, RoutedEventArgs e)
        {

            button.OnClick(sender, e);
        
        }

        // By clicking the button "HELP" a website will pop up, that explains how the game works.
        private void OnHelp(object sender, RoutedEventArgs e)
        {
            const string webpageUrl = "https://saractrl.github.io/Cheese-Game/";
            System.Diagnostics.Process.Start("explorer.exe", webpageUrl);
        }

        private void OnNewGame(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
