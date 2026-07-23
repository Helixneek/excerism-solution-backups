static class LogLine
{
    public static string Message(string logLine) {
        int startIndex = logLine.IndexOf("]") + 2;

        return logLine[startIndex..].Trim();
    }

    public static string LogLevel(string logLine)
    {
        int startIndex = logLine.IndexOf("[") + 1;
        int endIndex = logLine.IndexOf("]");

        int length = endIndex - startIndex;

        return logLine.Substring(startIndex, length).ToLower();
    }

    public static string Reformat(string logLine)
    {
        int startIndex = logLine.IndexOf("[") + 1;
        int endIndex = logLine.IndexOf("]");

        int length = endIndex - startIndex;
        string logType = logLine.Substring(startIndex, length).ToLower();

        return $"{logLine[(endIndex + 2)..].Trim()} ({logType})";
    }
}
