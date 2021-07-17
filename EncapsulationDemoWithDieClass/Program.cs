using System;
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
            // Create an array of 5 individual dice
            Die[] dice = new Die[5];

            // loop to set each element in the array
            for (int i = 0; i < dice.Length; i++)
            {
                //Create the die (random number)
                dice[i] = new Die();
                Console.WriteLine(dice[i].Value);
            }



            //Die die1 = new Die();
            //Console.WriteLine(die1.Value);
            //die1.Roll();
            //Console.WriteLine(die1.Value);
            //die1.Roll();
            //Console.WriteLine(die1.Value);

            Console.ReadKey();
        }
    }
}
