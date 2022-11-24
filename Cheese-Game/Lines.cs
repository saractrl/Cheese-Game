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




<<<<<<< HEAD
        //// Changes the player color
        //public void OnClick(object sender, RoutedEventArgs e)
=======
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
>>>>>>> 233395718a5e25246b18f8510580f1d9874eae03
        //{
        //    Button b = (Button)sender;


<<<<<<< HEAD

        //    if (this.turn)
        //    {

        //        b.Background = new SolidColorBrush(Color.FromRgb(0xC3, 0x00, 0xFF));

        //    }
        //    else
        //    {
        //        b.Background = new SolidColorBrush(Color.FromRgb(0xE7, 0xFF, 0x08));
        //    }

        //    b.IsEnabled = false;
        //    this.turn = !this.turn;


        //}
=======
            //}
        }

>>>>>>> 233395718a5e25246b18f8510580f1d9874eae03
    }
}