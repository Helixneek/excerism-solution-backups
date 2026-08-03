public static class SquareRoot
{
    public static int Root(int number)
    {
        if(number < 0) throw new ArgumentException("Cannot calculate square root of a negative number.");
        if(number == 0) return 0;
        if(number == 1) return 1;

        int left = 1;
        int right = number / 2;
        int result = 0;

        while(left <= right) {
            int mid = left + (right - left) / 2;
            long square = (long)mid * mid;

            // If this guess is correct
            if(square == number) {
                return mid;
            }
            // Guess is lower than actual numbre
            else if(square < number) {
                // Shift the left up to the middle to narrow the search
                result = mid; // Store potential floor answer
                left = mid + 1;
            // Guess is higher than actual number
            }else {
                // Shift the right down to the middle narrow the searrch
                right = mid - 1;
            }
        }

        return result;
    }
}
