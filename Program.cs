using System;

namespace DiceRollerWithEncapsulation
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
            die1.Roll();
            Console.WriteLine(die1.Value);
            die1.Roll();
            Console.WriteLine(die1.Value);
        }
    }
}
