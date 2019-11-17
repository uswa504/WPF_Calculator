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

namespace Calculator
{
    /// <summary>
    /// doubleeraction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double a;
        double b;
        double c;
        string op;
        bool flag=false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                textview.Text = "";
                flag = false;
                Button btn = (Button)sender;
                textview.Text += btn.Content.ToString();

            }
            else
            {
                Button btn = (Button)sender;
                textview.Text += btn.Content.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textview.Text = "";
        }

        private void b_add_Click(object sender, RoutedEventArgs e)
        {
            if (textview.Text == "")
            {
                int c = 0;
                c++;
            }
            else
            {
                if (flag == true)
                {
                    a = double.Parse(textview.Text);
                    op = "+";
                    textview.Text = "";
                }
                else
                {
                    a = double.Parse(textview.Text);
                    op = "+";
                    textview.Text = "";
                }
            }
        }

        private void b_sub_Click(object sender, RoutedEventArgs e)
        {

            if (textview.Text == "")
            {
                int c = 0;
                c++;
            }
            else
            {
                if (flag == true)
                {
                    a = double.Parse(textview.Text);
                    op = "-";
                    textview.Text = "";
                }
                else
                {
                    a = double.Parse(textview.Text);
                    op = "-";
                    textview.Text = "";
                }
            }
        }

        private void b_div_Click(object sender, RoutedEventArgs e)
        {

            if (textview.Text == "")
            {
                int c = 0;
                c++;
            }
            else
            {
                if (flag == true)
                {
                    a = double.Parse(textview.Text);
                    op = "/";
                    textview.Text = "";
                }
                else
                {
                    a = double.Parse(textview.Text);
                    op = "/";
                    textview.Text = "";
                }
            }
        }

        private void b_mul_Click(object sender, RoutedEventArgs e)
        {

            if (textview.Text == "")
            {
                int c = 0;
                c++;
            }
            else
            {
                if (flag == true)
                {
                    a = double.Parse(textview.Text);
                    op = "*";
                    textview.Text = "";
                }
                else
                {
                    a = double.Parse(textview.Text);
                    op = "*";
                    textview.Text = "";
                }
            }
        }

        private void b_equal_Click(object sender, RoutedEventArgs e)
        {
            if (textview.Text == "")
            {
                int c = 0;
                c++;
            }
            else
            {
                flag = true;
                b = double.Parse(textview.Text);
                if (op == "+")
                {
                    c = a + b;
                    textview.Text = c.ToString();
                }
                else if (op == "-")
                {
                    c = a - b;
                    textview.Text = c.ToString();
                }
                if (op == "/")
                {
                    if (b != 0)
                    {
                        c = a / b;
                        textview.Text = c.ToString();
                    }
                    else
                        textview.Text = "Division by Zero is an Error";
                }
                if (op == "*")
                {
                    c = a * b;
                    textview.Text = c.ToString();
                }
            }
        }
        private void btn_erase_Click(object sender, RoutedEventArgs e)
        {
            if (textview.Text.Length > 0)
            {
                textview.Text = textview.Text.Substring(0, textview.Text.Length - 1);
            } 
        }
    }
}
