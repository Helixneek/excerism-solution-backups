public static class Bob
{
    public static string Response(string statement)
    {
        string trimmedStatement = statement.Trim();
        
        // Check if silent
        if(string.IsNullOrWhiteSpace(trimmedStatement)) return "Fine. Be that way!";
        
        // Check if question
        if(trimmedStatement[^1] == '?') {
            // Check if its yelling
            if(trimmedStatement.Any(char.IsUpper) && !trimmedStatement.Any(char.IsLower)) {
                return "Calm down, I know what I'm doing!";
            }
            else {
                return "Sure.";
            }
        }

        // Check if yelling normally
        if(trimmedStatement.Any(char.IsUpper) && !trimmedStatement.Any(char.IsLower)) return "Whoa, chill out!";

        return "Whatever.";
    }
}