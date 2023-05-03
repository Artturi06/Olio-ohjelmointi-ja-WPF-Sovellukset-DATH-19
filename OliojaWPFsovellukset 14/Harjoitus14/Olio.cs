using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus14
{
    class Olio
    {
        private string filename;

        public Olio(string filename)
        {
            this.filename = filename;
        }

        public void CreateNote()
        {
            Console.WriteLine("Syötä uusi muistiinpano:");
            string note = Console.ReadLine();
            using (StreamWriter writer = File.AppendText(this.filename))
            {
                writer.WriteLine(note);
            }
        }

        public void PrintNotes()
        {
            Console.WriteLine("Tiedoston sisältö:");
            using (StreamReader reader = new StreamReader(this.filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        public void ClearNotes()
        {
            File.WriteAllText(this.filename, string.Empty);
            Console.WriteLine("Muistiinpanot on tyhjennetty.");
        }
    }
}

