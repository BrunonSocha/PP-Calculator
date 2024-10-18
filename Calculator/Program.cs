// Declaration and initialization (to 0) of variables
double num1 = 0; double num2 = 0;

/* Title display in the console
What's the point in putting \r at the end of a WriteLine method if it
starts at the beginning of a new line, and the carriage return 
moves the cursor to the beginning of the line anyway?
*/
Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------\n");

// Accepts the first user input
Console.WriteLine("Type a number and press Enter:");
num1 = Convert.ToDouble(Console.ReadLine());

// Accepts the second user input
Console.WriteLine("Type another number and press Enter:");
num2 = Convert.ToDouble(Console.ReadLine());

// Ask which operation to perform
Console.WriteLine("Choose which operation to perform from the list:");
Console.Write("\ta - Add\n\ts - Substract\n\tm - Multiply\n\td - Divide\nYour choice? ");

// Perform the operation using a switch statement
switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your result: {num1} + {num2} = {num1 + num2}");
        break;
    case "s":
        Console.WriteLine($"Your result: {num1} - {num2} = {num1 - num2}");
        break;
    case "m":
        Console.WriteLine($"Your result: {num1} * {num2} = {num1 * num2}");
        break;
    case "d":
        // Makes sure the user cannot input 0 as a divisor
        while (num2 == 0)
        {
            Console.WriteLine("Enter a non-zero divisor: ");
            num2 = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine($"Your result: {num1} / {num2} = {num1 / num2}");
        break;
}

// Ask before closing the app.
Console.Write("Press any key to close the Calculator console app.");
Console.ReadKey();