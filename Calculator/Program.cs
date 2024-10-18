using System.Text.RegularExpressions;

class Calculator
{
    public static double DoOperation(double num1, double num2, string op)
    {
        // Default value is not a number
        double result = double.NaN; 
        
        // Switch statement to perform the operation
        switch (op)
        {
            case "a":
                result = num1 + num2;
                break; 
            case "s":
                result = num1 - num2;
                break;
            case "m":
                result = num1 * num2;
                break;
            case "d":
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                break;
            default:
                break;
        }
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;
        // Display the title of the app.

        Console.WriteLine("Console Calculator in C#");
        Console.WriteLine("------------------------\n");

        while (!endApp)
        {
            // Declaration and initialization of variables to 0, using Nullable types
            string? numInput1 = "";
            string? numInput2 = "";
            double result = 0;

            // Request the first number from the user
            Console.Write("Type a number and press Enter: ");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("This is not a valid input. Please enter a number: ");
                numInput1 = Console.ReadLine();
            }

            //Request the second number from the user
            Console.Write("Type another number and press Enter: ");
            numInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.Write("This is not a valid input. Please enter a number: ");
                numInput2 = Console.ReadLine();
            }

            // Ask which operation to perform
            Console.WriteLine("Choose which operation to perform from the list:");
            Console.Write("\ta - Add\n\ts - Substract\n\tm - Multiply\n\td - Divide\nYour choice? ");

            string? op = Console.ReadLine();

            // Check if the input is not null and if it's one of the options
            if (op == null || !Regex.IsMatch(op, "[a|s|m|d]"))
            {
                Console.WriteLine("Error: Unrecognized input.");
            }
            else
            {
                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in an error.");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"An exception occured trying to do the math.\n - Detalis: {e.Message}");
                }
            }
            Console.WriteLine("---------------------");

            // Ask the user if he wants to exit. 
            Console.Write("Press 'n' if you want to exit, or press any other key and Enter to continue: ");
            if (Console.ReadLine() == "n") endApp = true;
            Console.WriteLine("\n");
        }
        return;
    }
}

