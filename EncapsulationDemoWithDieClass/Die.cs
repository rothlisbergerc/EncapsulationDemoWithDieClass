using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemoWithDieClass
{
    /// <summary>
    /// Represents a single six-sided game die.
    /// </summary>
    class Die
    {
        // Static fields are shared accross all instances of a class
        static Random rand;

        // Static constructors are called once for all instances of this class
        static Die()
        {
            rand = new Random(); 
        }


        public Die()
        {            
            // Roll die on creation to generate first random number to avoid a value of 0.
            Roll(); 
        }

        /// <summary>
        /// The face-up value of the die.
        /// </summary>
        // private set; means the Value can only be set inside this class
        public byte Value { get; private set; } 

        /// <summary>
        /// Returns true if the die is currently held
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Rolls a new random value between 1 - 6
        /// and returns the newly rolled value.
        /// </summary>
        public byte Roll()
        {            
            Value = (byte)rand.Next(1, 7);
            return Value;
        }

    }
}
