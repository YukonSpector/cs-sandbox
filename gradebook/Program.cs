// These statements are used to tell the editor which namespaces to look 
// into for classes to be used elsewhere in the code.
using System;

// This `using` statement was added auto-magically after using `command+.`
// on the `List` type.
using System.Collections.Generic;

namespace gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here a new variable is being initialized using the var
            // key word. The could of also been written in the explicit:
            // 
            var numbers = new[] { 12.7, 10.3, 6.11, 4.1 };

            // List type is not found in the System namespace.
            // Select the word `List` and then hit `command+.` (macOS)
            // and vscode will bring up a menu of possible namespaces where
            // `List` is stored.
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            // With the List type we can add values to it.
            // Unlike Arrays that once they are setup become immutible.
            grades.Add(56.1);

            var result = 0.0;
            foreach (var number in numbers)
            {
                // Shortcut way of take the var and then add it to itself.
                result += number;
            }
            Console.WriteLine(result);

            // Example of a `if-else` control.
            if (args.Length > 0)
            {
                // When using the '$' like this it is called a  Interpolated String expression.
                // This is a shortcut for explicitly writting it as a concatenation.
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                // Console is a class found in the System namespace
                Console.WriteLine("Hello World!");
                // Could of also been explicitly written as:
                // System.Console.WriteLine("Hello World!")
            }

        }
    }
}
