using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Musical_Instrument
{
    internal class Violin : MusicalInstrument
    {
        public override void Desc()
        {
            Console.WriteLine("bowed musical instrument with four strings tuned in fifths 🎻");
        }

        public override void History()
        {
            Console.WriteLine("created in 1730");
        }

        public override void Show()
        {
            Console.WriteLine("Violin");
        }

        public override void Sound()
        {
            Console.WriteLine("Vyuuuewww - vyying");
        }
    }
}
