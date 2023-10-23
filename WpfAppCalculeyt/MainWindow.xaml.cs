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

namespace WpfAppCalculeyt
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>();
        public int temp;
        public int county;
        public string? operators;

        private void Silme(object sender, RoutedEventArgs e)
        {
            TextB.Text = TextB.Text.Substring(0, TextB.Text.Length - 1);
        }

        private void Yeddi(object sender, RoutedEventArgs e)
        {
            TextB.Text += "7";
        }

        private void Sekkiz(object sender, RoutedEventArgs e)
        {
            TextB.Text += "8";
        }

        private void Doqquz(object sender, RoutedEventArgs e)
        {
           
            if (TextB.Text==temp.ToString())
            {
                TextB.Text = "";
                TextB.Text += "9";
            }
            else
            {
                TextB.Text += "9";
            }
            
        }

        private void Vurma(object sender, RoutedEventArgs e)
        {
            
            if (operators == "*" || temp!=0)
            {
                TextB.Text = (temp * int.Parse(TextB.Text.Substring(0, TextB.Text.Length))).ToString();
                operators = "*";
                temp = int.Parse(TextB.Text.ToString());
            }
            else if (operators == "/" || temp != 0)
            {
                TextB.Text = (temp / int.Parse(TextB.Text.Substring(0, TextB.Text.Length))).ToString();
                operators = "*";
                temp = int.Parse(TextB.Text.ToString()); 
            }
            else if (operators == "+" || temp != 0)
            {
                TextB.Text = (temp + int.Parse(TextB.Text.Substring(0, TextB.Text.Length))).ToString();
                operators = "*";
                temp = int.Parse(TextB.Text.ToString());
                
            }
            else if (operators == "-" || temp != 0)
            {
                TextB.Text = (temp - int.Parse(TextB.Text.Substring(0, TextB.Text.Length))).ToString();
                operators = "*";
                temp = int.Parse(TextB.Text.ToString());
                
            }
            else
            {
                temp = int.Parse(TextB.Text.Substring(0, TextB.Text.Length));
                TextB.Text = "";
            }
            
            
        }

        private void Dord(object sender, RoutedEventArgs e)
        {
            TextB.Text += "4";
        }

        private void Bes(object sender, RoutedEventArgs e)
        {
            TextB.Text += "5";
        }

        private void Alti(object sender, RoutedEventArgs e)
        {
            TextB.Text += "6";
        }

        private void Cixma(object sender, RoutedEventArgs e)
        {
            if (operators == "*" || temp != 0)
            {
                TextB.Text = (temp * int.Parse(TextB.Text.Substring(0, TextB.Text.Length))).ToString();
                operators = "-";
                temp = int.Parse(TextB.Text.ToString());
            }
            else if (operators == "/" || temp != 0)
            {
                TextB.Text = (temp / int.Parse(TextB.Text.Substring(0, TextB.Text.Length))).ToString();
                operators = "-";
                temp = int.Parse(TextB.Text.ToString());
            }
            else if (operators == "+" || temp != 0)
            {
                TextB.Text = (temp + int.Parse(TextB.Text.Substring(0, TextB.Text.Length))).ToString();
                operators = "-";
                temp = int.Parse(TextB.Text.ToString());

            }
            else if (operators == "-" || temp != 0)
            {
                TextB.Text = (temp - int.Parse(TextB.Text.Substring(0, TextB.Text.Length))).ToString();
                operators = "-";
                temp = int.Parse(TextB.Text.ToString());

            }
            else
            {
                temp = int.Parse(TextB.Text.Substring(0, TextB.Text.Length));
                TextB.Text = "";
            }
        }

        private void Bir(object sender, RoutedEventArgs e)
        {
            TextB.Text += "1";
        }

        private void Iki(object sender, RoutedEventArgs e)
        {
            TextB.Text += "2";
        }

        private void Uc(object sender, RoutedEventArgs e)
        {
            TextB.Text += "3";
        }

        private void Toplama(object sender, RoutedEventArgs e)
        {
            if (operators == "*" || temp != 0)
            {
                TextB.Text = (temp * int.Parse(TextB.Text.Substring(0, TextB.Text.Length))).ToString();
                operators = "+";
                temp = int.Parse(TextB.Text.ToString());
            }
            else if (operators == "/" || temp != 0)
            {
                TextB.Text = (temp / int.Parse(TextB.Text.Substring(0, TextB.Text.Length))).ToString();
                operators = "+";
                temp = int.Parse(TextB.Text.ToString());
            }
            else if (operators == "+" || temp != 0)
            {
                TextB.Text = (temp + int.Parse(TextB.Text.Substring(0, TextB.Text.Length))).ToString();
                operators = "+";
                temp = int.Parse(TextB.Text.ToString());

            }
            else if (operators == "-" || temp != 0)
            {
                TextB.Text = (temp - int.Parse(TextB.Text.Substring(0, TextB.Text.Length))).ToString();
                operators = "+";
                temp = int.Parse(TextB.Text.ToString());

            }
            else
            {
                temp = int.Parse(TextB.Text.Substring(0, TextB.Text.Length));
                TextB.Text = "";
            }
        }

        private void Sifir(object sender, RoutedEventArgs e)
        {
            TextB.Text += "0";
        }

        private void Beraberdir(object sender, RoutedEventArgs e)
        {
            if (operators == "*" || temp != 0)
            {
                TextB.Text = (temp * int.Parse(TextB.Text.Substring(0, TextB.Text.Length))).ToString();
                operators = "";
                temp = int.Parse(TextB.Text.ToString());
            }
            else if (operators == "/" || temp != 0)
            {
                TextB.Text = (temp / int.Parse(TextB.Text.Substring(0, TextB.Text.Length))).ToString();
                operators = "";
                temp = int.Parse(TextB.Text.ToString());
            }
            else if (operators == "+" || temp != 0)
            {
                TextB.Text = (temp + int.Parse(TextB.Text.Substring(0, TextB.Text.Length))).ToString();
                operators = "";
                temp = int.Parse(TextB.Text.ToString());

            }
            else if (operators == "-" || temp != 0)
            {
                TextB.Text = (temp - int.Parse(TextB.Text.Substring(0, TextB.Text.Length))).ToString();
                operators = "";
                temp = int.Parse(TextB.Text.ToString());

            }
            else
            {
                temp = int.Parse(TextB.Text.Substring(0, TextB.Text.Length));
                TextB.Text = "";
            }
        }
    }
}
