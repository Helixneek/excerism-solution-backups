class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new int[] {0, 2, 5, 3, 7, 8, 4};

    public int Today() => birdsPerDay[^1];

    public void IncrementTodaysCount() => ++birdsPerDay[^1];

    public bool HasDayWithoutBirds() => birdsPerDay.Contains(0);

    public int CountForFirstDays(int numberOfDays)
    {
        int totalCount = 0;
        for(int i = 0; i < numberOfDays; i++) {
            totalCount += birdsPerDay[i];
        }

        return totalCount;
    }

    public int BusyDays() => birdsPerDay.Where(x => x >= 5).Count();
}
