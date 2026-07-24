public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string text, string delimiter) {
        int startIndex = text.IndexOf(delimiter) + (delimiter.Length);

        return text.Substring(startIndex);
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string text, string firstDelimiter, string secondDelimiter) {
        int startIndex = text.IndexOf(firstDelimiter) + firstDelimiter.Length - 1;
        int endIndex = text.IndexOf(secondDelimiter);

        return text.Substring(startIndex + 1, (endIndex - (startIndex + 1)));
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string text) {
        int startIndex = text.IndexOf("]:") + 1;

        return text.Substring(startIndex + 1).Trim();
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string text) {
        int startIndex = text.IndexOf("[");
        int endIndex = text.IndexOf("]:");

        return text.Substring(startIndex + 1, (endIndex - (startIndex + 1)));
    }
}