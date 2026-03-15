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
    
      
}
