using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using System.Xml.Linq;

namespace Cheese_Game
{
    public class Lines
    {
        //private bool turn = true;




        // Changes the player color
        public void OnClick(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;



            if (this.turn)
            {

                b.Background = new SolidColorBrush(Color.FromRgb(0xC3, 0x00, 0xFF));

            }
            else
            {
                b.Background = new SolidColorBrush(Color.FromRgb(0xE7, 0xFF, 0x08));
            }

            b.IsEnabled = false;
            this.turn = !this.turn;



            // Sets turn back to false, so the color changes again.

            //public void BoxDetect()
            //{ 


          //}






        //public void OnNewGame(object sender, RoutedEventArgs e)
        //{


            //}
        }

    }
}