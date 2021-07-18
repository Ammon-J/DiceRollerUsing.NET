using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerWithEncapsulation
{
    /// <summary>
    /// Represents an individual dice
    /// </summary>
    class Die
    {
        /// <summary>
        /// Face value of die
        /// </summary>
        public byte Value { get; private set; }

        public bool IsHeld { get; set; }

        /// <summary>
        /// Roll a new rindom value between 1 - 6
        /// and return the newly rolled value
        /// </summary>
        public byte Roll()
        {
            Random rand = new Random();
            Value = (byte)rand.Next(1, 7);
            return Value;
        }
    }
}
