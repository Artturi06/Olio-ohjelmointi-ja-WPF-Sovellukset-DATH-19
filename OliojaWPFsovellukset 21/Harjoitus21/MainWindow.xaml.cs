using System.Windows;
using System.Windows.Controls;

namespace Ostoskärry

{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            // Lisää tuote TextBlockina StockPaneliin
            TextBlock productTextBlock = new TextBlock();
            productTextBlock.Text = checkBox.Content.ToString();
            stockPanel.Children.Add(productTextBlock);
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            // Poista tuote TextBlock StockPanelista
            foreach (TextBlock textBlock in stockPanel.Children)
            {
                if (textBlock.Text == checkBox.Content.ToString())
                {
                    stockPanel.Children.Remove(textBlock);
                    break;
                }
            }
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            // Tyhjennä valitut CheckBox-kontrollit
            checkBox1.IsChecked = false;
            checkBox2.IsChecked = false;
            checkBox3.IsChecked = false;
            checkBox4.IsChecked = false;

            // Tyhjennä tuotteet StockPanelista
            stockPanel.Children.Clear();
        }
    }
}
