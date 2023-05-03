using System.Windows;

namespace Ajoneuvolaskuri
{
    public partial class MainWindow : Window
    {
        private int henkiloautot = 0;
        private int kuormaautot = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnHenkiloauto_Click(object sender, RoutedEventArgs e)
        {
            henkiloautot++;
            txtHenkiloautot.Text = henkiloautot.ToString();
        }

        private void btnKuormaauto_Click(object sender, RoutedEventArgs e)
        {
            kuormaautot++;
            txtKuormaautot.Text = kuormaautot.ToString();
        }
    }
}
