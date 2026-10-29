using System;

namespace StructAssignment
{
    // 1. A struct called Number.
    //    A struct is a value type: a lightweight container for related data.
    struct Number
    {
        // A property called Amount with the data type decimal
        public decimal Amount { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 2. Create an object of data type Number
            Number number = new Number();

            // Assign an amount to it.
            // The 'm' suffix tells C# that this literal is a decimal value.
            number.Amount = 125.75m;

            // 3. Print the amount to the console
            Console.WriteLine("The amount is: " + number.Amount);

            // Keep the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}