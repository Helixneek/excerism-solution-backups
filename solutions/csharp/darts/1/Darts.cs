public static class Darts
{
    public static int Score(double x, double y)
    {
        if(IsPointInCircle(x, y, 1)) {
            return 10;
        } else if(IsPointInCircle(x, y, 5)) {
            return 5;
        } else if(IsPointInCircle(x, y, 10)){
            return 1;
        } else {
            return 0;
        }
    }

    public static bool IsPointInCircle(double x, double y, double r) {
        double pointDistance = (x * x) + (y * y);

        return pointDistance <= (r * r);
    }
}
