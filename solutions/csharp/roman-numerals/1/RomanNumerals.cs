using System;
using System.Text;

public static class RomanNumeralExtension
{
    public static readonly (int Value, string Token)[] ArabicToRomanMap = new[]
    {
            (1000, "M"),
            (900, "CM"),
            (500, "D"),
            (400, "CD"),
            (100, "C"),
            (90, "XC"),
            (50, "L"),
            (40, "XL"),
            (10, "X"),
            (9, "IX"),
            (5, "V"),
            (4, "IV"),
            (1, "I")
    };
    
    public static string ToRoman(this int value)
    {
        if(value < 1 || value > 3999) return "Invalid input";

        var sb = new StringBuilder();

        foreach(var pair in ArabicToRomanMap) {
            while(value >= pair.Value) {
                sb.Append(pair.Token);
                value -= pair.Value;
            }
        }

        return sb.ToString();
    }
}