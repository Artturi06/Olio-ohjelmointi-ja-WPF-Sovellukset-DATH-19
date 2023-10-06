using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace HissiSovellus
{
    public partial class MainWindow : Window
    {
        private int nykyinenKerros = 1;

        public MainWindow()
        {
            InitializeComponent();
            PäivitäNykyinenKerrosTeksti();

            // Liitetään PreviewTextInput-tapahtuma kutsujonoon
            kerrosTextBox.PreviewTextInput += KerrosTextBox_PreviewTextInput;
        }

        private void MeneKerrokseen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int haluttuKerros = int.Parse(kerrosTextBox.Text);

                if (haluttuKerros >= 1 && haluttuKerros <= 6)
                {
                    nykyinenKerros = haluttuKerros;
                    PäivitäNykyinenKerrosTeksti();
                }
                else
                {
                    MessageBox.Show("Virheellinen kerros. Valitse kerros väliltä 1-6.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Virheellinen syöte. Anna numero väliltä 1-6.");
            }
        }

        private void PäivitäNykyinenKerrosTeksti()
        {
            nykyinenKerrosTextBlock.Text = "Nykyinen kerros: " + nykyinenKerros;
        }

        // Tapahtumankäsittelijä PreviewTextInput-tapahtumalle
        private void KerrosTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Käytetään säännöllistä lauseketta tarkistamaan, että syöte on numero
            e.Handled = !IsNumeric(e.Text);
        }

        // Apumetodi tarkistamaan, onko syöte numero
        private bool IsNumeric(string input)
        {
            return Regex.IsMatch(input, "^[0-9]+$");
        }
    }
}
