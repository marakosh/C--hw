﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Worker
{
    internal class Engineer : Worker
    {
        public override void Print()
        {
            Console.WriteLine("I'm the Engineer");
        }
    }
}
