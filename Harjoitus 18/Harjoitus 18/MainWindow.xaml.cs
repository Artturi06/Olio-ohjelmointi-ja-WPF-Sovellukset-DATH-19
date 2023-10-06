using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfLaskin
{
    public partial class MainWindow : Window
    {
        private object buttonsumma;
        private object textBoxNumero2;
        private object textBlockTulos;
        private object buttonErotus;
        private object buttonKertolasku;
        private object buttonJakolasku;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double numero1, numero2;
            if (double.TryParse(textBoxNumero1.Text, out numero1) && double.TryParse(textBoxNumero2.Text, out numero2))
            {
                if (sender == buttonsumma)
                {
                    double tulos = Laskin.Summa(numero1, numero2);
                    textBlockTulos = tulos.ToString();
                }
                else if (sender == buttonErotus)
                {
                    double tulos = Laskin.Erotus(numero1, numero2);
                    textBlockTulos = tulos.ToString();
                }
                else if (sender == buttonKertolasku)
                {
                    double tulos = Laskin.Kertolasku(numero1, numero2);
                    textBlockTulos = tulos.ToString();
                }
                else if (sender == buttonJakolasku)
                {
                    if (numero2 != 0)
                    {
                        double tulos = Laskin.Jakolasku(numero1, numero2);
                        textBlockTulos = tulos.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Nollalla jakaminen ei ole sallittua.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Virheellinen syöte. Syötä numerot oikeassa muodossa.");
            }
        }
    }

    public static class Laskin
    {
        public static double Summa(double a, double b)
        {
            return a + b;
        }

        public static double Erotus(double a, double b)
        {
            return a - b;
        }

        public static double Kertolasku(double a, double b)
        {
            return a * b;
        }

        public static double Jakolasku(double a, double b)
        {
            return a / b;
        }
    }
}
