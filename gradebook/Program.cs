// These statements are used to tell the editor which namespaces to look 
// into for classes to be used elsewhere in the code.
using System;

// This `using` statement was added auto-magically after using `command+.`
// on the `List` type.
using System.Collections.Generic;

/* Defining a name space like this is not vital but is a really good idea.
If not defined then everything will get put explicity into the global namespace.
By creating your own it eliminates, or hopefully limits, collisions. */
namespace gradebook
{
    /* Creating a new class aka "type" to be used:
        class Book
        {
            
        }
    Its good form to only have one class per file. 
    The Book type will be stored in the file Book.cs and call 
    inside of Program.cs */
    class Program
    {
        static void Main(string[] args)
        {
            // Calling on the new type created in the statement `class Book`.
            var book = new Book();
            book.AddGrade(89.1);
            // Example of a basic variable initialization.
            // in this case we are saying the var `x` has a type of `double`.
            double x;
            x = 34.1;
            // Single line form of basic initialization.
            double y = 10.3;
            // Here a new variable is being initialized using the var
            var addReturn = x + y;
            Console.WriteLine(addReturn);
            
            /* Initializing a new Array.
            The key word `new` is part of how an Array gets Initialized.
            In this example a new Array is created with an explicit size
            of four and four values are provided. */ 
            var numbers = new double[4] { 12.7, 10.3, 6.11, 4.1 };


            /* List type is not found in the System namespace.
            Select the word `List` and then hit `command+.` (macOS)
            and vscode will bring up a menu of possible namespaces where
            `List` is stored. Can be expicity written as:
            `List<double> grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };`*/
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            // With the List type we can add values to it.
            // Unlike Arrays that once they are setup become immutible.
            grades.Add(56.1);
            // Add is a Method because the paranthases are used to pass in a value.

            var result = 0.0;
            foreach (var number in grades)
            {
                // Shortcut way of take the var and then add it to itself.
                result += number;
            }
            result /= grades.Count;
            // Count is an attribute 
            Console.WriteLine($"The average grade is {result}.");
            // A way to format the number.
            Console.WriteLine($"The average grade formatted {result:N3}.");

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
