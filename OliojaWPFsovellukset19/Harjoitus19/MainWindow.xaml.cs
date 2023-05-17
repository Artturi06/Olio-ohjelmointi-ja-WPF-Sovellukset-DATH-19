using System;
using System.Windows;
using System.Windows.Controls;

namespace HissiWPF
{
    public partial class MainWindow : Window
    {
        private int kerros;

        public int Kerros
        {
            get { return kerros; }
            set { kerros = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                int valittuKerros = Int32.Parse(button.Content.ToString());
                if (valittuKerros >= 1 && valittuKerros <= 6)
                {
                    Kerros = valittuKerros;
                    MessageBox.Show("Siirrytään kerrokseen " + Kerros);
                }
                else
                {
                    MessageBox.Show("Virheellinen kerrosvalinta!");
                }
            }
        }
    }
}
