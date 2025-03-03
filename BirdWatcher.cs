class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    // Task 1: Return last week's counts: [0, 2, 5, 3, 7, 8, 4]
    public static int[] LastWeek()
    {
        int[] lastWeekCounts = {0, 2, 5, 3, 7, 8, 4};
        return lastWeekCounts;
    }

    // Task 2: Return today's count (last element in the array)
    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1];
    }

    // Task 3: Increment today's count
    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++;
    }

    // Task 4: Check if there was a day with no visiting birds
    public bool HasDayWithoutBirds()
    {
        foreach(var visitbirdsPerDay in birdsPerDay)
          {
              
              if (visitbirdsPerDay==0)
                {
                    return true;
                }
          }
        return false;
    }

    // Task 5: Calculate the number of visiting birds for the first number of days
    public int CountForFirstDays(int numberOfDays)
    {
        int sum=0;
        for(int i=0; i<numberOfDays && i<birdsPerDay.Length; i++)
          {
              sum+=birdsPerDay[i];
          }
        return sum;
    }

    // Task 6: Calculate the number of busy days (5 or more birds)
    public int BusyDays()
    {
        int count=0;
        for(int i=0; i<birdsPerDay.Length; i++)
          {
              if(birdsPerDay[i]>=5)
                {
                    count++;
                }
          }
        return count;
    }
}