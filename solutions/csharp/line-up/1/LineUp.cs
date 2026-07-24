public static class LineUp
{
    public static string Format(string name, int number)
    {
        string ordinalSuffix;
        string stringNumber = number.ToString();
        if(number == 1 || (stringNumber[^1] == '1' && !stringNumber[^2..].Equals("11")))  {
            ordinalSuffix = "st";
        } else if(number == 2 || (stringNumber[^1] == '2' && !stringNumber[^2..].Equals("12"))) {
            ordinalSuffix = "nd";
        } else if(number == 3 || (stringNumber[^1] == '3' && !stringNumber[^2..].Equals("13"))) {
            ordinalSuffix = "rd";
        } else {
            ordinalSuffix = "th";
        }

        return $"{name}, you are the {number}{ordinalSuffix} customer we serve today. Thank you!";
    }
}
