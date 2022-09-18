﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Device
{
    internal class Car : Device
    {
        public override void Desc()
        {
            Console.WriteLine("for movement");
        }

        public override void Show()
        {
            Console.WriteLine("Car");
        }

        public override void Sound()
        {
            Console.WriteLine("vrum - vrum");
        }
    }
}
