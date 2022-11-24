using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Linq;
using static Cheese_Game.MainWindow;

namespace Cheese_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Connected to lines
        //public Lines button = new();
        //public Lines newgame = new();
        private bool turn = true;
        // List in List
        List<List<Element>> elements = new List<List<Element>>();


        public MainWindow()
        {
            InitializeComponent();

            foreach (List<Element> listElement in elements)
            {
                // Row
                int indexRow = elements.FindIndex(e => e.Equals(listElement));

                foreach (Element element in listElement)
                {
                    // Column
                    int indexColumn = listElement.FindIndex(e => e.Equals(element));

                    element.Bottom = new Site();

                    if (indexRow == 0)
                    {
                        element.Top = new Site();
                    }
                    else
                    {
                        element.Top = elements[indexRow - 1][indexColumn].Bottom;
                    }
                    element.Right = new Site();

                    if (indexColumn == 0)
                    {
                        element.Left = new Site();
                    }
                    else
                    {
                        element.Left = listElement[indexColumn - 1].Right;
                    }
                }
            }



            DataContext = elements;

            //foreach(List<Element> listElement in elements)
            //{
            //    foreach(Element element in listElement)
            //    {
            //        if (element. == )
            //        {

            //            Player01.Content = ;
            //        }
            //        else if (Left.Color == && Right.Color == && Top.Color == && Bottom.Color ==)
            //        {
            //            Player02.Content = i;
            //        }
            //    }
               
            //}

            


        }


        // Method "OnClick" that changes the colours of the buttons.
        public void OnClick(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
=======

            //_ = sender;
            //button.OnClick(sender, e);
            Button b = (Button)sender;
>>>>>>> 233395718a5e25246b18f8510580f1d9874eae03


            Button b = (Button)sender;

            if (this.turn)
            {

                //b.Background = new SolidColorBrush(Color.FromRgb(0xC3, 0x00, 0xFF));

                b.Background = Brushes.BlueViolet;

            }
            else
            {
                //b.Background = new SolidColorBrush(Color.FromRgb(0xE7, 0xFF, 0x08));

                b.Background = Brushes.Yellow;
            }

            b.IsEnabled = false;
            this.turn = !this.turn;

<<<<<<< HEAD
            int i = 0;


            // BlueViolet

            // BOX 01

            if (T1_1.Background == Brushes.BlueViolet && B1_1.Background == Brushes.BlueViolet && L1_1.Background == Brushes.BlueViolet && R1_1.Background == Brushes.BlueViolet)
            {
                i = i + 1;
                Player01.Content = i;
            }

            // BOX 02

            if (T1_2.Background == Brushes.BlueViolet && B1_2.Background == Brushes.BlueViolet && R1_1.Background == Brushes.BlueViolet && R1_2.Background == Brushes.BlueViolet)
            {
                i = i + 1;
                Player01.Content = i;

            }



            // BOX 03

            if (T1_3.Background == Brushes.BlueViolet && B1_3.Background == Brushes.BlueViolet && R1_3.Background == Brushes.BlueViolet && R1_2.Background == Brushes.BlueViolet)
            {
                i = i + 1;
                Player01.Content = i;
            }


            // BOX 04
            if (T1_4.Background == Brushes.BlueViolet && B1_4.Background == Brushes.BlueViolet && R1_3.Background == Brushes.BlueViolet && R1_4.Background == Brushes.BlueViolet)
            {
                i = i + 1;
                Player01.Content = i;
            }

            // BOX 05
            if (T1_5.Background == Brushes.BlueViolet && B1_5.Background == Brushes.BlueViolet && R1_5.Background == Brushes.BlueViolet && R1_4.Background == Brushes.BlueViolet)
            {
                i = i + 1;
                Player01.Content = i;
            }

            // BOX 06
            if (B1_1.Background == Brushes.BlueViolet && B2_1.Background == Brushes.BlueViolet && L1_2.Background == Brushes.BlueViolet && R2_1.Background == Brushes.BlueViolet)
            {
                i = i + 1;
                Player01.Content = i;
            }

            // BOX 07 
            if (B1_2.Background == Brushes.BlueViolet && B2_2.Background == Brushes.BlueViolet && R2_2.Background == Brushes.BlueViolet && R2_1.Background == Brushes.BlueViolet)
            {
                i = i + 1;
                Player01.Content = i;
            }


            // BOX 08
            if (B1_3.Background == Brushes.BlueViolet && B2_3.Background == Brushes.BlueViolet && R2_2.Background == Brushes.BlueViolet && R2_3.Background == Brushes.BlueViolet)
            {
                i = i + 1;
                Player01.Content = i;
            }

            // BOX 09
            if (B1_4.Background == Brushes.BlueViolet && B2_4.Background == Brushes.BlueViolet && R2_4.Background == Brushes.BlueViolet && R2_3.Background == Brushes.BlueViolet)
            {
                i = i + 1;
                Player01.Content = i;
            }

            // BOX 10
            if (B1_5.Background == Brushes.BlueViolet && B2_5.Background == Brushes.BlueViolet && R2_4.Background == Brushes.BlueViolet && R2_5.Background == Brushes.BlueViolet)
            {
                i = i + 1;
                Player01.Content = i;
            }


            // BOX 11
            if (B3_1.Background == Brushes.BlueViolet && B2_1.Background == Brushes.BlueViolet && L1_3.Background == Brushes.BlueViolet && R3_1.Background == Brushes.BlueViolet)
            {
                i = i + 1;
                Player01.Content = i;
            }


            // BOX 12
            if (B3_2.Background == Brushes.BlueViolet && B2_2.Background == Brushes.BlueViolet && R3_1.Background == Brushes.BlueViolet && R3_2.Background == Brushes.BlueViolet)
            {
                i = i + 1;
                Player01.Content = i;
            }


            // BOX 13
            if (B3_3.Background == Brushes.BlueViolet && B2_3.Background == Brushes.BlueViolet && R3_3.Background == Brushes.BlueViolet && R3_2.Background == Brushes.BlueViolet)
            {
                i = i + 1;
                Player01.Content = i;
            }

            // BOX 14
            if (B3_4.Background == Brushes.BlueViolet && B2_4.Background == Brushes.BlueViolet && R3_3.Background == Brushes.BlueViolet && R3_4.Background == Brushes.BlueViolet)
            {
                i = i + 1;
                Player01.Content = i;
            }

            // BOX 15
            if (B3_5.Background == Brushes.BlueViolet && B2_5.Background == Brushes.BlueViolet && R3_5.Background == Brushes.BlueViolet && R3_4.Background == Brushes.BlueViolet)
            {
                i = i + 1;
                Player01.Content = i;
            }

            // BOX 16
            if (B3_1.Background == Brushes.BlueViolet && B4_1.Background == Brushes.BlueViolet && L1_4.Background == Brushes.BlueViolet && R4_1.Background == Brushes.BlueViolet)
            {
                i = i + 1;
                Player01.Content = i;
            }

            // BOX 17
            if (B3_2.Background == Brushes.BlueViolet && B4_2.Background == Brushes.BlueViolet && R4_2.Background == Brushes.BlueViolet && R4_1.Background == Brushes.BlueViolet)
            {
                i = i + 1;
                Player01.Content = i;
            }


            // BOX 18
            if (B3_3.Background == Brushes.BlueViolet && B4_3.Background == Brushes.BlueViolet && R4_2.Background == Brushes.BlueViolet && R4_3.Background == Brushes.BlueViolet)
            {
                i = i + 1;
                Player01.Content = i;
            }


            // BOX 19
            if (B3_4.Background == Brushes.BlueViolet && B4_4.Background == Brushes.BlueViolet && R4_4.Background == Brushes.BlueViolet && R4_3.Background == Brushes.BlueViolet)
            {
                i = i + 1;
                Player01.Content = i;
            }


            // BOX 20
            if (B3_5.Background == Brushes.BlueViolet && B4_5.Background == Brushes.BlueViolet && R4_4.Background == Brushes.BlueViolet && R4_5.Background == Brushes.BlueViolet)
            {
                i = i + 1;
                Player01.Content = i;
            }

            // BOX 21
            if (B4_1.Background == Brushes.BlueViolet && B5_1.Background == Brushes.BlueViolet && L1_5.Background == Brushes.BlueViolet && R5_1.Background == Brushes.BlueViolet)
            {
                i = i + 1;
                Player01.Content = i;
            }

            // BOX 22
            if (B4_2.Background == Brushes.BlueViolet && B5_2.Background == Brushes.BlueViolet && R5_1.Background == Brushes.BlueViolet && R5_2.Background == Brushes.BlueViolet)
            {
                i = i + 1;
                Player01.Content = i;
            }

            // BOX 23
            if (B4_3.Background == Brushes.BlueViolet && B5_3.Background == Brushes.BlueViolet && R5_2.Background == Brushes.BlueViolet && R5_3.Background == Brushes.BlueViolet)
            {
                i = i + 1;
                Player01.Content = i;
            }

            // BOX 24
            if (B4_4.Background == Brushes.BlueViolet && B5_4.Background == Brushes.BlueViolet && R5_4.Background == Brushes.BlueViolet && R5_3.Background == Brushes.BlueViolet)
            {
                i = i + 1;
                Player01.Content = i;
            }


            // BOX 25
            if (B4_5.Background == Brushes.BlueViolet && B5_5.Background == Brushes.BlueViolet && R5_4.Background == Brushes.BlueViolet && R5_5.Background == Brushes.BlueViolet)
            {
                i = i + 1;
                Player01.Content = i;
            }
            else
            {
                GetWinner();
            }


            // Yellow

            int y = 0;

            // BOX 01

            if (T1_1.Background == Brushes.Yellow && B1_1.Background == Brushes.Yellow && L1_1.Background == Brushes.Yellow && R1_1.Background == Brushes.Yellow)
            {
                y = y + 1;
                Player02.Content = y;
            }

            // BOX 02

            if (T1_2.Background == Brushes.Yellow && B1_2.Background == Brushes.Yellow && R1_1.Background == Brushes.Yellow && R1_2.Background == Brushes.Yellow)
            {
                y = y + 1;
                Player02.Content = y;

            }



            // BOX 03

            if (T1_3.Background == Brushes.Yellow && B1_3.Background == Brushes.Yellow && R1_3.Background == Brushes.Yellow && R1_2.Background == Brushes.Yellow)
            {
                y = y + 1;
                Player02.Content = y;
            }


            // BOX 04
            if (T1_4.Background == Brushes.Yellow && B1_4.Background == Brushes.Yellow && R1_3.Background == Brushes.Yellow && R1_4.Background == Brushes.Yellow)
            {
                y = y + 1;
                Player02.Content = y;
            }

            // BOX 05
            if (T1_5.Background == Brushes.Yellow && B1_5.Background == Brushes.Yellow && R1_5.Background == Brushes.Yellow && R1_4.Background == Brushes.Yellow)
            {
                y = y + 1;
                Player02.Content = y;
            }

            // BOX 06
            if (B1_1.Background == Brushes.Yellow && B2_1.Background == Brushes.Yellow && L1_2.Background == Brushes.Yellow && R2_1.Background == Brushes.Yellow)
            {
                y = y + 1;
                Player02.Content = y;
            }

            // BOX 07 
            if (B1_2.Background == Brushes.Yellow && B2_2.Background == Brushes.Yellow && R2_2.Background == Brushes.Yellow && R2_1.Background == Brushes.Yellow)
            {
                y = y + 1;
                Player02.Content = y;
            }


            // BOX 08
            if (B1_3.Background == Brushes.Yellow && B2_3.Background == Brushes.Yellow && R2_2.Background == Brushes.Yellow && R2_3.Background == Brushes.Yellow)
            {
                y = y + 1;
                Player02.Content = y;
            }

            // BOX 09
            if (B1_4.Background == Brushes.Yellow && B2_4.Background == Brushes.Yellow && R2_4.Background == Brushes.Yellow && R2_3.Background == Brushes.Yellow)
            {
                y = y + 1;
                Player02.Content = y;
            }

            // BOX 10
            if (B1_5.Background == Brushes.Yellow && B2_5.Background == Brushes.Yellow && R2_4.Background == Brushes.Yellow && R2_5.Background == Brushes.Yellow)
            {
                y = y + 1;
                Player02.Content = y;
            }


            // BOX 11
            if (B3_1.Background == Brushes.Yellow && B2_1.Background == Brushes.Yellow && L1_3.Background == Brushes.Yellow && R3_1.Background == Brushes.Yellow)
            {
                y = y + 1;
                Player02.Content = y;
            }


            // BOX 12
            if (B3_2.Background == Brushes.Yellow && B2_2.Background == Brushes.Yellow && R3_1.Background == Brushes.Yellow && R3_2.Background == Brushes.Yellow)
            {
                y = y + 1;
                Player02.Content = y;
            }


            // BOX 13
            if (B3_3.Background == Brushes.Yellow && B2_3.Background == Brushes.Yellow && R3_3.Background == Brushes.Yellow && R3_2.Background == Brushes.Yellow)
            {
                y = y + 1;
                Player02.Content = y;
            }

            // BOX 14
            if (B3_4.Background == Brushes.Yellow && B2_4.Background == Brushes.Yellow && R3_3.Background == Brushes.Yellow && R3_4.Background == Brushes.Yellow)
            {
                y = y + 1;
                Player02.Content = y;
            }

            // BOX 15
            if (B3_5.Background == Brushes.Yellow && B2_5.Background == Brushes.Yellow && R3_5.Background == Brushes.Yellow && R3_4.Background == Brushes.Yellow)
            {
                y = y + 1;
                Player02.Content = y;
            }

            // BOX 16
            if (B3_1.Background == Brushes.Yellow && B4_1.Background == Brushes.Yellow && L1_4.Background == Brushes.Yellow && R4_1.Background == Brushes.Yellow)
            {
                y = y + 1;
                Player02.Content = y;
            }

            // BOX 17
            if (B3_2.Background == Brushes.Yellow && B4_2.Background == Brushes.Yellow && R4_2.Background == Brushes.Yellow && R4_1.Background == Brushes.Yellow)
            {
                y = y + 1;
                Player02.Content = y;
            }


            // BOX 18
            if (B3_3.Background == Brushes.Yellow && B4_3.Background == Brushes.Yellow && R4_2.Background == Brushes.Yellow && R4_3.Background == Brushes.Yellow)
            {
                y = y + 1;
                Player02.Content = y;
            }


            // BOX 19
            if (B3_4.Background == Brushes.Yellow && B4_4.Background == Brushes.Yellow && R4_4.Background == Brushes.Yellow && R4_3.Background == Brushes.Yellow)
            {
                y = y + 1;
                Player02.Content = y;
            }


            // BOX 20
            if (B3_5.Background == Brushes.Yellow && B4_5.Background == Brushes.Yellow && R4_4.Background == Brushes.Yellow && R4_5.Background == Brushes.Yellow)
            {
                y = y + 1;
                Player02.Content = y;
            }

            // BOX 21
            if (B4_1.Background == Brushes.Yellow && B5_1.Background == Brushes.Yellow && L1_5.Background == Brushes.Yellow && R5_1.Background == Brushes.Yellow)
            {
                y = y + 1;
                Player02.Content = y;
            }

            // BOX 22
            if (B4_2.Background == Brushes.Yellow && B5_2.Background == Brushes.Yellow && R5_1.Background == Brushes.Yellow && R5_2.Background == Brushes.Yellow)
            {
                y = y + 1;
                Player02.Content = y;
            }

            // BOX 23
            if (B4_3.Background == Brushes.Yellow && B5_3.Background == Brushes.Yellow && R5_2.Background == Brushes.Yellow && R5_3.Background == Brushes.Yellow)
            {
                y = y + 1;
                Player02.Content = y;
            }

            // BOX 24
            if (B4_4.Background == Brushes.Yellow && B5_4.Background == Brushes.Yellow && R5_4.Background == Brushes.Yellow && R5_3.Background == Brushes.Yellow)
            {
                y = y + 1;
                Player02.Content = y;
            }


            // BOX 25
            if (B4_5.Background == Brushes.Yellow && B5_5.Background == Brushes.Yellow && R5_4.Background == Brushes.Yellow && R5_5.Background == Brushes.Yellow)
            {
                y = y + 1;
                Player02.Content = y;
            }
            else
            {
                GetWinner();
            }

=======
>>>>>>> 233395718a5e25246b18f8510580f1d9874eae03

        }


        public void GetWinner()
        {

        }



        // End of "OnClick"

        // By clicking the button "HELP" a website will pop up, that explains how the game works.
        private void OnHelp(object sender, RoutedEventArgs e)
        {
            const string webpageUrl = "https://saractrl.github.io/Cheese-Game/";
            System.Diagnostics.Process.Start("explorer.exe", webpageUrl);
        }
        // End of method "OnHelp"

        // By clicking "NewGame" a new game will start, so the score goes back to zero for both players.
       private void OnNewGame(object sender, RoutedEventArgs e)
       {
          
       }
        public class Element : INotifyPropertyChanged
        {
            public Site Left { get; set; }

            public Site Right { get; set; }

            public Site Bottom { get; set; }

            public Site Top { get; set; }

            public Brush Color
            {
                get
                {
                    return this.color;
                }
                set
                {
                    this.color = value;
                    NotifyPropertyChanged();
                }
            }
            private Brush color;

         

            public event PropertyChangedEventHandler? PropertyChanged;

            private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        }
        public class Site : INotifyPropertyChanged
        {
            public Brush Color
            {
                get
                {
                    return this.color;
                }
                set
                {
                    this.color = value;
                    NotifyPropertyChanged();
                }
            }
            private Brush color;

            public Site()
            {
                Color = Brushes.Gray;
            }

            public void Clicked(bool turn)
            {
               Color = turn ? Brushes.BlueViolet : Brushes.YellowGreen;
            }

            public event PropertyChangedEventHandler? PropertyChanged;

            private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        }
    }
}