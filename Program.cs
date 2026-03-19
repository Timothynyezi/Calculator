using System.ComponentModel.Design;
using System.Globalization;
using System.Security.Cryptography;

FileHelper fileHelper = new FileHelper();
bool isRunning = true;

showWelcome();

while (isRunning)
{
    Console.Clear();
    Console.WriteLine("==============================");
    Console.WriteLine("         CALCULATOR           ");
    Console.WriteLine("==============================");
    Console.WriteLine("  1. New Calculation");
    Console.WriteLine("  2. View History");
    Console.WriteLine("  3. Clear History");
    Console.WriteLine("  0. Exit");
    Console.WriteLine("------------------------------");
    Console.Write("  Choose an option: "); 

    string choice = Console.ReadLine()?.Trim();

    switch (choice)
    {
        case "1":
            StartCalculation(fileHelper);
            break;
        case "2":
            ViewHistory(fileHelper);
            break;
        case "3":
            ClearHistory(fileHelper);
            break;
        case "0":
            isRunning = false;
            ShowGoodbye();
            break;
        default:
            Console.WriteLine("\n Invalid option. Please choose 0 - 3.");
            Thread.Sleep(1500);
            break;

    }  
}

void showWelcome()
{
    Console.Clear();
    Console.WriteLine("==============================");
    Console.WriteLine("      WELCOME TO CALCULATOR   ");
    Console.WriteLine("==============================");
    Console.WriteLine("  Perform calculations and");
    Console.WriteLine("  keep track of your history.");
    Console.WriteLine("------------------------------");
    Console.WriteLine("  Press any key to start...");
    Console.ReadKey();
}

void ShowGoodbye()
{
    Console.Clear();
    Console.WriteLine("==============================");
    Console.WriteLine("         GOODBYE!             ");
    Console.WriteLine("==============================");
    Console.WriteLine("  Thanks for using Calculator.");
    Thread.Sleep(2000); 
}

void StartCalculation(FileHelper helper)
{
    Console.Clear();
    Console.WriteLine("==============================");
    Console.WriteLine("       NEW CALCULATION        ");
    Console.WriteLine("==============================\n");

    double firstNumber = GetNumber(" Enter first number : ");

    string operation = GetOperation();

    double secondNumber = GetNumber("\n Enter second number : ");

    if (operation == "Division")
    {
        while (secondNumber == 0)
        {
            Console.WriteLine("Cannot divide by zero!");
            secondNumber = GetNumber(" Enter a non-zero number: ");
        }
    }

    double? result = operation switch
    {
        "Addition"      => firstNumber + secondNumber,
        "Subtraction"   => firstNumber - secondNumber,
        "Multiplication"=> firstNumber * secondNumber,
        "Division"      => firstNumber / secondNumber,
        _               => null
    };

    Console.WriteLine("\n==============================");

    if (result == null)
    {
        Console.WriteLine("Something went wrong");
    }
    else
    {
        string symbol = operation switch
        {
            "Addition"      => "+",
            "Subtraction"   => "-",
            "Multiplication"=> "x",
            "Division"      => "/",
            _               => "?"
        };

        string resultLine = $" {firstNumber} {symbol} {secondNumber} = {result:F2}";
        Console.WriteLine(resultLine);
        Console.WriteLine("==============================");

        helper.SaveCalculation(resultLine);
    }

    Console.WriteLine("\n Press any key to return to the menu...");
    Console.ReadKey();

}

void ViewHistory(FileHelper helper)
{
    Console.Clear();
    Console.WriteLine("==============================");
    Console.WriteLine("          HISTORY             ");
    Console.WriteLine("==============================");

    string history = helper.ReadHistory();
    Console.WriteLine(history);

    Console.WriteLine("\n Press any key to return...");
    Console.ReadKey();
}

void ClearHistory(FileHelper helper)
{
    Console.Clear();
    Console.WriteLine("==============================");
    Console.WriteLine("        CLEAR HISTORY         ");
    Console.WriteLine("==============================\n");
}

double GetNumber(string prompt)
{
    Console.Write(prompt);
    double number;
    string input = Console.ReadLine()?.Trim();
    bool isValid = double.TryParse(input, out number);

    while (!isValid)
    {
        Console.Write("Please enter a valid number: ");
        input = Console.ReadLine()?.Trim();
        isValid = double.TryParse(input, out number);
    }
    return number;
}

string GetOperation()
{
    Console.WriteLine("\n  Select an operation:");
    Console.WriteLine("  1. Addition       (+)");
    Console.WriteLine("  2. Subtraction    (-)");
    Console.WriteLine("  3. Multiplication (x)");
    Console.WriteLine("  4. Division       (/)");
    Console.Write("\n  Choose: ");

    string choice = Console.ReadLine()?.Trim();

    while (choice != "1" && choice != "2" && choice != "3" && choice != "4")
    {
        Console.Write("Please choose 1, 2, 3, or 4: ");
        choice = Console.ReadLine()?.Trim();
    }

    return choice switch
    {
        "1" => "Addition",
        "2" => "Subtraction",
        "3" => "Multiplication",
        "4" => "Division",
        _   => "Unknown"
    };
}