class FileHelper
{
    private const string FilePath = "history.txt";

    public void SaveCalculation(string entry)
    {
        string timestamp = DateTime.Now.ToString("dd MMM yyy HH:mm:sss");
        string line = $"[{timestamp}] {entry.Trim()}{Environment.NewLine}";

        File.AppendAllText(FilePath, line);
    }

    public string ReadHistory()
    {
        if (!File.Exists(FilePath))
        {
            return " No history found. Make a calculation first!";
        }
        string contents = File.ReadAllText(FilePath);
        
        // Hanlde the cause where the file exists but is empty
        if (string.IsNullOrWhiteSpace(contents))
        {
            return " History is empty.";
        }
        return contents;
    
    }

    public void ClearHistory()
    {
        if (!File.Exists(FilePath))
        {
            return; // nothing to clear - exit the method early
        }

    
    }

    public bool HistoryExists()
    {
        return false;
    }
}