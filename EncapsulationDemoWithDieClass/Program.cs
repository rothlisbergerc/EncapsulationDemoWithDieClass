﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemoWithDieClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Die die1 = new Die();
            Console.WriteLine(die1.Value);
            die1.Roll();
            Console.WriteLine(die1.Value);
            die1.Roll();
            Console.WriteLine(die1.Value);

            Console.ReadKey();
        }
    }
}
