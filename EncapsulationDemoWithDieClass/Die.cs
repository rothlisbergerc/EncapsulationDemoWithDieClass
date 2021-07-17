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
        /// <summary>
        /// The face-up value of the die.
        /// </summary>
        public byte Value { get; set; }

        /// <summary>
        /// Returns true if the die is currently held
        /// </summary>
        public bool IsHeld { get; set; }
    }
}
