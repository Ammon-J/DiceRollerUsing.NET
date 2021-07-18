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
        // static fields are shared across all instances of a class
        static Random rand;

        static Die() // static consrtuctors are called once for all the instances
        {
            rand = new Random();
        }

        public Die()
        {

            // Roll die on creation to generate a random number 
            // to avoid getting zero
            Roll();
        }
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
            
            Value = (byte)rand.Next(1, 7);
            return Value;
        }
    }
}
