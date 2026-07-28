public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        if(sum % 2 != 0) yield break;

        // A can never be bigger than 1/3 of the triplet
        int maxA = sum / 3;

        for(int a = 1; a < maxA; a++) {
            // Derive (b = sum - a - c) from (a^2 + b^2 = c^2)
            int numerator = (sum * sum) - (2 * sum * a);
            int denominator = (2 * sum) - (2 * a);

            if(numerator % denominator == 0) {
                int b = numerator/denominator;
                int c = sum - a - b;

                if(b > a && c > b) {
                    yield return ValueTuple.Create(a, b, c);
                }
            }
        }
    }
}