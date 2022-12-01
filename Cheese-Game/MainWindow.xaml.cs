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

        int player1;
        int player2;
      



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


        // Method "OnClick" 
        public void OnClick(object sender, RoutedEventArgs e)
        {


            // This part of the code changes the color of the buttons interchangeably 

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





            // BlueViolet == Player 01

            // BOX 01

            int i = 0;
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
            //if (L1_1.IsEnabled == false && L1_2.IsEnabled == false && L1_3.IsEnabled == false && L1_4.IsEnabled == false && L1_5.IsEnabled == false && R1_1.IsEnabled == false && R1_2.IsEnabled == false && R1_3.IsEnabled == false && R1_4.IsEnabled == false && R1_5.IsEnabled == false && R2_1.IsEnabled == false && R2_2.IsEnabled == false && R2_3.IsEnabled == false && R2_4.IsEnabled == false && R2_5.IsEnabled == false
            //    && R3_1.IsEnabled == false && R3_2.IsEnabled == false && R3_3.IsEnabled == false && R3_4.IsEnabled == false && R3_5.IsEnabled == false && R4_1.IsEnabled == false && R4_2.IsEnabled == false && R4_3.IsEnabled == false && R4_4.IsEnabled == false && R4_5.IsEnabled == false && R5_1.IsEnabled == false && R5_2.IsEnabled == false && R5_3.IsEnabled == false && R5_4.IsEnabled == false && R5_5.IsEnabled == false
            //    && T1_1.IsEnabled == false && T1_2.IsEnabled == false && T1_3.IsEnabled == false && T1_4.IsEnabled == false && T1_5.IsEnabled == false && B1_1.IsEnabled == false && B1_2.IsEnabled == false && B1_3.IsEnabled == false && B1_4.IsEnabled == false && B1_5.IsEnabled == false && B2_1.IsEnabled == false && B2_2.IsEnabled == false && B2_3.IsEnabled == false && B2_4.IsEnabled == false && B2_5.IsEnabled == false
            //    && B3_1.IsEnabled == false && B3_2.IsEnabled == false && B3_3.IsEnabled == false && B3_4.IsEnabled == false && B3_5.IsEnabled == false && B4_1.IsEnabled == false && B4_2.IsEnabled == false && B4_3.IsEnabled == false && B4_4.IsEnabled == false && B4_5.IsEnabled == false && B5_1.IsEnabled == false && B5_2.IsEnabled == false && B5_3.IsEnabled == false && B5_4.IsEnabled == false && B5_5.IsEnabled == false
            //    )
            //{
            //    player1 = i;
            //    GetWinner();
            //}


            // Yellow Lines == Player 02



            // BOX 01

            int y = 0;

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

            if (L1_1.IsEnabled == false && L1_2.IsEnabled == false && L1_3.IsEnabled == false && L1_4.IsEnabled == false && L1_5.IsEnabled == false && R1_1.IsEnabled == false && R1_2.IsEnabled == false && R1_3.IsEnabled == false && R1_4.IsEnabled == false && R1_5.IsEnabled == false && R2_1.IsEnabled ==  false && R2_2.IsEnabled == false && R2_3.IsEnabled == false && R2_4.IsEnabled == false && R2_5.IsEnabled == false 
                && R3_1.IsEnabled == false && R3_2.IsEnabled == false && R3_3.IsEnabled == false && R3_4.IsEnabled == false && R3_5.IsEnabled == false && R4_1.IsEnabled == false && R4_2.IsEnabled == false && R4_3.IsEnabled == false && R4_4.IsEnabled == false && R4_5.IsEnabled == false && R5_1.IsEnabled == false && R5_2.IsEnabled == false && R5_3.IsEnabled == false && R5_4.IsEnabled == false && R5_5.IsEnabled == false 
                &&  T1_1.IsEnabled == false && T1_2.IsEnabled == false && T1_3.IsEnabled == false && T1_4.IsEnabled == false && T1_5.IsEnabled == false && B1_1.IsEnabled == false && B1_2.IsEnabled == false && B1_3.IsEnabled == false && B1_4.IsEnabled == false && B1_5.IsEnabled == false && B2_1.IsEnabled == false && B2_2.IsEnabled == false && B2_3.IsEnabled == false && B2_4.IsEnabled == false && B2_5.IsEnabled == false
                && B3_1.IsEnabled == false && B3_2.IsEnabled == false && B3_3.IsEnabled == false && B3_4.IsEnabled == false && B3_5.IsEnabled == false && B4_1.IsEnabled == false && B4_2.IsEnabled == false && B4_3.IsEnabled == false && B4_4.IsEnabled == false && B4_5.IsEnabled == false && B5_1.IsEnabled == false && B5_2.IsEnabled == false && B5_3.IsEnabled == false && B5_4.IsEnabled == false && B5_5.IsEnabled == false 
                )
            {
                player1 = i;
                player2 = y;
                GetWinner();
            }


            
        }

        // Determines wether player 1 oder player 2 has won
        public void GetWinner()
        {

         

            if(player1 > player2)
            {
                
             
                MessageBox.Show("PLAYER 1 HAS WON, CONGRATULATIONS!");
            }
            else if(player2 > player1)
            {
               
                MessageBox.Show("PLAYER 2 HAS WON, CONGRATULATIONS!");
            }

            else if (player1 == player2)
            {
                MessageBox.Show("NO ONE WON... TRY AGAIN? CLICK NEW GAME");
            }
         
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

            L1_1.IsEnabled = true;
            L1_1.Background = Brushes.Gray;

            L1_2.IsEnabled = true;
            L1_2.Background = Brushes.Gray;

            L1_3.IsEnabled = true;
            L1_3.Background = Brushes.Gray;

            L1_4.IsEnabled = true;
            L1_4.Background = Brushes.Gray;

            L1_5.IsEnabled = true;
            L1_5.Background = Brushes.Gray;

            R1_1.IsEnabled = true;
            R1_1.Background = Brushes.Gray;

            R1_2.IsEnabled = true;
            R1_2.Background = Brushes.Gray;

            R1_3.IsEnabled = true;
            R1_3.Background = Brushes.Gray;

            R1_4.IsEnabled = true;
            R1_4.Background = Brushes.Gray;

            R1_5.IsEnabled = true;
            R1_5.Background = Brushes.Gray;

            R2_1.IsEnabled = true;
            R2_1.Background = Brushes.Gray;

            R2_2.IsEnabled = true;
            R2_2.Background = Brushes.Gray;

            R2_3.IsEnabled = true;
            R2_3.Background = Brushes.Gray;

            R2_4.IsEnabled = true;
            R2_4.Background = Brushes.Gray;

            R2_5.IsEnabled = true;
            R2_5.Background = Brushes.Gray;

            R3_1.IsEnabled = true;
            R3_1.Background = Brushes.Gray;

            R3_2.IsEnabled = true;
            R3_2.Background = Brushes.Gray;

            R3_3.IsEnabled = true;
            R3_3.Background = Brushes.Gray;

            R3_4.IsEnabled = true;
            R3_4.Background = Brushes.Gray;

            R3_5.IsEnabled = true;
            R3_5.Background = Brushes.Gray;

            R4_1.IsEnabled = true;
            R4_1.Background = Brushes.Gray;

            R4_2.IsEnabled = true;
            R4_2.Background = Brushes.Gray;

            R4_3.IsEnabled = true;
            R4_3.Background = Brushes.Gray;

            R4_4.IsEnabled = true;
            R4_4.Background = Brushes.Gray;

            R4_5.IsEnabled = true;
            R4_5.Background = Brushes.Gray;

            R5_1.IsEnabled = true;
            R5_1.Background = Brushes.Gray;

            R5_2.IsEnabled = true;
            R5_2.Background = Brushes.Gray;

            R5_3.IsEnabled = true;
            R5_3.Background = Brushes.Gray;

            R5_4.IsEnabled = true;
            R5_4.Background = Brushes.Gray;

            R5_5.IsEnabled = true;
            R5_5.Background = Brushes.Gray;

            T1_1.IsEnabled = true;
            T1_1.Background = Brushes.Gray;

            T1_2.IsEnabled = true;
            T1_2.Background = Brushes.Gray;

            T1_3.IsEnabled = true;
            T1_3.Background = Brushes.Gray;

            T1_4.IsEnabled = true;
            T1_4.Background = Brushes.Gray;

            T1_5.IsEnabled = true;
            T1_5.Background = Brushes.Gray;

            B1_1.IsEnabled = true;
            B1_1.Background = Brushes.Gray;

            B1_2.IsEnabled = true;
            B1_2.Background = Brushes.Gray;

            B1_3.IsEnabled = true;
            B1_3.Background = Brushes.Gray;

            B1_4.IsEnabled = true;
            B1_4.Background = Brushes.Gray;

            B1_5.IsEnabled = true;
            B1_5.Background = Brushes.Gray;

            B2_1.IsEnabled = true;
            B2_1.Background = Brushes.Gray;

            B2_2.IsEnabled = true;
            B2_2.Background = Brushes.Gray;

            B2_3.IsEnabled = true;
            B2_3.Background = Brushes.Gray;

            B2_4.IsEnabled = true;
            B2_4.Background = Brushes.Gray;

            B2_5.IsEnabled = true;
            B2_5.Background = Brushes.Gray;

            B3_1.IsEnabled = true;
            B3_1.Background = Brushes.Gray;

            B3_2.IsEnabled = true;
            B3_2.Background = Brushes.Gray;

            B3_3.IsEnabled = true;
            B3_3.Background = Brushes.Gray;

            B3_4.IsEnabled = true;
            B3_4.Background = Brushes.Gray;

            B3_5.IsEnabled = true;
            B3_5.Background = Brushes.Gray;

            B4_1.IsEnabled = true;
            B4_1.Background = Brushes.Gray;

            B4_2.IsEnabled = true;
            B4_2.Background = Brushes.Gray;

            B4_3.IsEnabled = true;
            B4_3.Background = Brushes.Gray;

            B4_4.IsEnabled = true;
            B4_4.Background = Brushes.Gray;

            B4_5.IsEnabled = true;
            B4_5.Background = Brushes.Gray;

            B5_1.IsEnabled = true;
            B5_1.Background = Brushes.Gray;

            B5_2.IsEnabled = true;
            B5_2.Background = Brushes.Gray;

            B5_3.IsEnabled = true;
            B5_3.Background = Brushes.Gray;

            B5_4.IsEnabled = true;
            B5_4.Background = Brushes.Gray;

            B5_5.IsEnabled = true;
            B5_5.Background = Brushes.Gray;

            player1 = 0;
            player2 = 0;
            Player01.Content = player1;
            Player02.Content = player2;
        }
        // End of method "OnNewGame"
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