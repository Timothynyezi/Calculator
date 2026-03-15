using System.ComponentModel.Design;

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
