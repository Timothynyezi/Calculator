class FileHelper
{
    private const string FilePath = "history.txt";

    public void SaveCalculation(string entry)
    {
        string timestamp = DateTime.Now.ToString("dd MMM yyy HH:mm:sss");
        string line = $"[{timestamp}] {entry.Trim()}{Environment.NewLine}";
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