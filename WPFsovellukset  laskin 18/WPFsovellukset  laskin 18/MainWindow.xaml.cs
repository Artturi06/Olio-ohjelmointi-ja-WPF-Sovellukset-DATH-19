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

namespace WPFlaskin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double temp = 0;

        string operation = "Minus";

        string output = "";

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;


        }

        private void NumBtn_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;

            switch (name)
            {
                case "OneBtn":
                    output += "1";
                    OutPutTextBlock.Text = output;
                    break;

                case "TwoBtn":
                    output += "2";
                    OutPutTextBlock.Text = output;
                    break;

                case "ThreeBtn":
                    output += "3";
                    OutPutTextBlock.Text = output;
                    break;

                case "FourBtn":
                    output += "4";
                    OutPutTextBlock.Text = output;
                    break;

                case "FiveBtn":
                    output += "5";
                    OutPutTextBlock.Text = output;
                    break;

                case "SixBtn":
                    output += "6";
                    OutPutTextBlock.Text = output;
                    break;

                case "SevenBtn":
                    output += "7";
                    OutPutTextBlock.Text = output;
                    break;

                case "EightBtn":
                    output += "8";
                    OutPutTextBlock.Text = output;
                    break;

                case "NineBtn":
                    output += "9";
                    OutPutTextBlock.Text = output;
                    break;

                case "ZeroBtn":
                    output += "0";
                    OutPutTextBlock.Text = output;
                    break;
            }
        }

        private void MinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "Minus";
            }
        }

        private void EqualsBtn_Click(object sender, RoutedEventArgs e)
        {
            double outputTemp;
            switch (operation)
            {
                case "Minus":
                    outputTemp = temp - double.Parse(output);
                    output = outputTemp.ToString();
                    OutPutTextBlock.Text = output;
                    break;

                case "Plus":
                    outputTemp = temp + double.Parse(output);
                    output = outputTemp.ToString();
                    OutPutTextBlock.Text = output;
                    break;

                case "Times":
                    outputTemp = temp * double.Parse(output);
                    output = outputTemp.ToString();
                    OutPutTextBlock.Text = output;
                    break;

                case "Divide":
                    if (double.Parse(output) != 0)
                    {
                        outputTemp = temp / double.Parse(output);
                        output = outputTemp.ToString();
                        OutPutTextBlock.Text = output;
                    }

                    break;

            }
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "Plus";
            }
        }

        private void TimesBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "Times";
            }
        }

        private void DivideBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "Divide";
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            output = "";

            OutPutTextBlock.Text = output;
        }
    }
}
