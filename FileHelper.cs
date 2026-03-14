class FileHelper
{
    private const string FilePath = "history.txt";

    public void SaveCalculation(string entry)
    {
        Console.WriteLine("(SaveCalculation coming in step 3)");
    }

    public string ReadHistory()
    {
        return "(ReadHistory coming in step 3)";
    }

    public void ClearHistory()
    {
        Console.WriteLine("ClearHistory coming in step 3");
    }

    public bool HistoryExists()
    {
        return false;
    }
}