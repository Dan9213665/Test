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

namespace _20160713WPF_Calculator_HW
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

        double valone;
        double valtwo;
        char opp;
        double res;

        private void Btn1_OnClick(object sender, RoutedEventArgs e)
        {
            TxtbOutput.Text += "1";
        }

        private void Btn2_OnClick(object sender, RoutedEventArgs e)
        {
            TxtbOutput.Text += "2";
        }

        private void Btn3_OnClick(object sender, RoutedEventArgs e)
        {
            TxtbOutput.Text += "3";
        }

        private void Btn4_OnClick(object sender, RoutedEventArgs e)
        {
            TxtbOutput.Text += "4";
        }

        private void Btn5_OnClick(object sender, RoutedEventArgs e)
        {
            TxtbOutput.Text += "5";
        }

        private void Btn6_OnClick(object sender, RoutedEventArgs e)
        {
            TxtbOutput.Text += "6";
        }

        private void Btn7_OnClick(object sender, RoutedEventArgs e)
        {
            TxtbOutput.Text += "7";
        }

        private void Btn8_OnClick(object sender, RoutedEventArgs e)
        {
            TxtbOutput.Text += "8";
        }

        private void Btn9_OnClick(object sender, RoutedEventArgs e)
        {
            TxtbOutput.Text += "9";
        }

        private void Btn0_OnClick(object sender, RoutedEventArgs e)
        {
            TxtbOutput.Text += "0";
        }

        private void BtnClear_OnClick(object sender, RoutedEventArgs e)
        {
            TxtbOutput.Text = "";
        }

        private void BtnDot_OnClick(object sender, RoutedEventArgs e)
        {
            TxtbOutput.Text += ".";
        }

        private void BtnMult_OnClick(object sender, RoutedEventArgs e)
        {
            splt = TxtbOutput.Text;
            opp = '*';
            TxtbOutput.Text += "x";
            
        }

        private void BtnPlus_OnClick(object sender, RoutedEventArgs e)
        {
            splt = TxtbOutput.Text;
            TxtbOutput.Text += "+";
            opp = '+';
        }

        private void Btnminus_OnClick(object sender, RoutedEventArgs e)
        {
            splt = TxtbOutput.Text;
            TxtbOutput.Text += "-";
            opp = '-';
        }

        private void BtnDivide_OnClick(object sender, RoutedEventArgs e)
        {
            splt = TxtbOutput.Text;
            TxtbOutput.Text += "/";
            opp = '/';
        }

        string splt;
        string splt2;
        private void BtnEquals_OnClick(object sender, RoutedEventArgs e)
        {
            splt2 = TxtbOutput.Text.Remove(0, splt.Length + 1);

            valone = double.Parse(splt);
            valtwo = double.Parse(splt2);

            switch (opp)
            {
                case '+':
                    res = valone + valtwo;
                    TxtbOutput.Text += "=";

                    TxtbOutput.Text += res;
                    break;
                case '-':
                    res = valone - valtwo;
                    TxtbOutput.Text += "=";

                    TxtbOutput.Text += res;

                    break;
                case '*':
                    res = valone * valtwo;
                    TxtbOutput.Text += "=";

                    TxtbOutput.Text += res;

                    break;
                case '/':
                    if (valtwo > 0)
                    {
                        res = valone / valtwo;
                        TxtbOutput.Text += "=";

                        TxtbOutput.Text += res;
                    }
                    
                    else
                    {
                       MessageBox.Show("Cannot Divide by zero !!!");
                        TxtbOutput.Text = "";
                    }
                    break;
            }
          


        }
    }
}
