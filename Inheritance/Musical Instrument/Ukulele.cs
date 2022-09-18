using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Musical_Instrument
{
    internal class Ukulele : MusicalInstrument
    {
        public override void Desc()
        {
            Console.WriteLine("Hawaiian four-string guitar used for chordal accompaniment of songs and solo playing.");
        }

        public override void History()
        {
            Console.WriteLine("created in 1999");
        }

        public override void Show()
        {
            Console.WriteLine("Ukulele");
        }

        public override void Sound()
        {
            Console.WriteLine("trin - trun");
        }
    }
}
