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
        public Lines button = new();
        public Lines newgame = new();
        private bool turn = true;
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

                    if (indexRow == 0)                    {
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


            //for (int i = 0; i <= 5; i++)
            //{
            //    elements.Add(new List<Element>());
            //}
            //foreach (Element element in elements)
            //{
            //    int index = elements.FindIndex(e => e.Equals(element));

            //    element.Right = new Site();

            //    if (index == 0)
            //    {
            //        element.Left = new Site();
            //    }
            //    else
            //    {

            //        element.Left = element[index - 1].Right;
            //    }
            //}

            //for (int i = 0; i <= 5; i++)
            //{
            //    elements.Add(new List<Element>());
            //}
            //foreach (Element element in elements)
            //{
            //    int index = elements.FindIndex(e => e.Equals(element));

            //    element.Bottom = new Site();

            //    if (index == 0)
            //    {
            //        element.Bottom = new Site();
            //    }
            //    else
            //    {
            //        element.Top = elements[index - 1].Bottom;
            //    }
            //}



            DataContext = elements;
        }


        // Is connected to the class "Lines", this changes the line colours.
        public void OnClick(object sender, RoutedEventArgs e)
        {

            //_ = sender;
            //button.OnClick(sender, e);
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

            //public Element()
            //{
            //    Color = Brushes.Pink;
            //}

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

            //public void Clicked(bool turn)
            //{
            //    Color = turn ? Brushes.Blue : Brushes.Red;
            //}

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