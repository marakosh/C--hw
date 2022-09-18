using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Musical_Instrument
{
    internal class Trombone : MusicalInstrument
    {
        public override void Desc()
        {
            Console.WriteLine("diverse in strokes and technically mobile instrument, it has a bright, brilliant timbre in the middle and upper registers, gloomy in the lower.📯");
        }

        public override void History()
        {
            Console.WriteLine("created in 1865");
        }

        public override void Show()
        {
            Console.WriteLine("Trombone");
        }

        public override void Sound()
        {
            Console.WriteLine("PUUUUUMMM - PUUUEEEWWW");
        }
    }
}
