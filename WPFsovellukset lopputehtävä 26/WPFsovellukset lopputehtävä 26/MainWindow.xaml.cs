using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using static Varastonhallinta.MainWindow;

namespace Varastonhallinta
{
    public class Tuote
    {
        public string Nimi { get; set; }
        public int Maara { get; set; }

        public Tuote(string nimi, int maara)
        {
            Nimi = nimi;
            Maara = maara;
        }

        public void LisaaMaara(int maara)
        {
            if (maara < 0)
                throw new ArgumentException("Määrän täytyy olla positiivinen luku.");

            Maara += maara;
        }

        public void VahennaMaara(int maara)
        {
            if (maara < 0)
                throw new ArgumentException("Määrän täytyy olla positiivinen luku.");

            if (Maara < maara)
                throw new InvalidOperationException("Ei tarpeeksi varastossa.");

            Maara -= maara;
        }
    }

    public class Varasto
    {
        public List<Tuote> Tuotteet { get; set; }

        public Varasto()
        {
            Tuotteet = new List<Tuote>();
        }

        public void LisaaTuote(Tuote tuote)
        {
            Tuotteet.Add(tuote);
        }

        public void PoistaTuote(string nimi)
        {
            Tuote poistettavaTuote = Tuotteet.Find(t => t.Nimi == nimi);

            if (poistettavaTuote != null)
                Tuotteet.Remove(poistettavaTuote);
            else
                throw new InvalidOperationException("Tuotetta ei löydy varastosta.");
        }
    }

    public partial class MainWindow : Window
    {
        public class Varasto
        {
            public List<Tuote> Tuotteet { get; set; } 

            public Varasto()
            {
                Tuotteet = new List<Tuote>();
                LataaTuotteet(); // Lataa tuotteet tiedostosta kun varasto luodaan
            }

            public void LisaaTuote(Tuote tuote)
            {
                Tuotteet.Add(tuote);
                TallennaTuotteet(); // Tallenna tuotteet tiedostoon aina kun tuote lisätään
            }

            public void PoistaTuote(string nimi)
            {
                Tuote poistettavaTuote = Tuotteet.Find(t => t.Nimi == nimi);

                if (poistettavaTuote != null)
                {
                    Tuotteet.Remove(poistettavaTuote);
                    TallennaTuotteet(); // Tallenna tuotteet tiedostoon aina kun tuote poistetaan
                }
                else
                {
                    throw new InvalidOperationException("Tuotetta ei löydy varastosta.");
                }
            }

            private void TallennaTuotteet()
            {
                using (StreamWriter sw = new StreamWriter("tuotteet.txt"))
                {
                    foreach (Tuote tuote in Tuotteet)
                    {
                        sw.WriteLine($"{tuote.Nimi},{tuote.Maara}");
                    }
                }
            }

            private void LataaTuotteet()
            {
                if (File.Exists("tuotteet.txt"))
                {
                    string[] rivit = File.ReadAllLines("tuotteet.txt");

                    foreach (string rivi in rivit)
                    {
                        string[] tiedot = rivi.Split(',');
                        if (tiedot.Length == 2)
                        {
                            string nimi = tiedot[0];
                            int maara = int.Parse(tiedot[1]);
                            Tuotteet.Add(new Tuote(nimi, maara));
                        }
                    }
                }
            }
            private void PaivitaTuoteListBox()
            {
                TuoteListBox.Items.Clear();

                foreach (Tuote tuote in varasto.Tuotteet)
                {
                    TuoteListBox.Items.Add($"{tuote.Nimi}: {tuote.Maara}");
                }
            }

            private void LisaaTuote_Click(object sender, RoutedEventArgs e)
            {
                try
                {
                    string nimi = TuoteNimiTextBox.Text;
                    int maara = int.Parse(TuoteMaaraTextBox.Text);

                    Tuote uusiTuote = new Tuote(nimi, maara);
                    varasto.LisaaTuote(uusiTuote);

                    TuoteNimiTextBox.Clear();
                    TuoteMaaraTextBox.Clear();

                    PaivitaTuoteListBox(); // Päivitä näkyvä tuotelista
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Virhe", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            private void PoistaTuote_Click(object sender, RoutedEventArgs e)
            {
                try
                {
                    string nimi = TuoteNimiTextBox.Text;
                    varasto.PoistaTuote(nimi);

                    TuoteNimiTextBox.Clear();
                    TuoteMaaraTextBox.Clear();

                    PaivitaTuoteListBox(); // Päivitä näkyvä tuotelista
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Virhe", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }



    }





}
