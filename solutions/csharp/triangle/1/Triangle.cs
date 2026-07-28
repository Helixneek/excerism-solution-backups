public static class Triangle
{
    public static bool IsScalene(double side1, double side2, double side3)
    {
        if(side1 <= 0 || side2 <= 0 || side3 <= 0) return false;

        double[] sides = { side1, side2, side3 };
        Array.Sort(sides);

        bool inequal = sides[0] + sides[1] > sides[2];

        // Check equal sides
        bool noSameSides = sides.Distinct().Count() >= 3;

        return inequal && noSameSides;
    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        if(side1 <= 0 || side2 <= 0 || side3 <= 0) return false;

        // Check inequality
        double[] sides = { side1, side2, side3};
        Array.Sort(sides);

        bool inequal = sides[0] + sides[1] > sides[2];

        // Check equal sides
        bool hasSameSides = sides.Distinct().Count() < 3;

        return inequal && hasSameSides;
    }

    public static bool IsEquilateral(double side1, double side2, double side3) 
    {
        if(side1 <= 0 || side2 <= 0 || side3 <= 0) return false;
        return side1 == side2 && side2 == side3 && side1 == side3;
    }
}