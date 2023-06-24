namespace classes;
public class BirdCount
{
    private List<int> _birds = new List<int>();

    public BirdCount(List<int> birds)
    {
        _birds = birds;
    }

    public void SetBirds(List<int> birds)
    {
        birds.Clear();
        _birds.Clear();
        for (int i = 0; i < 7; i++)
        {
            birds.Add(Convert.ToInt32(Console.ReadLine()));
        }
        _birds = birds;
    }

    public void LastWeek()
    {
        Console.WriteLine("[" + string.Join(", ", _birds) + "]");
    }

    public void VisitedToday()
    {
        Console.WriteLine(_birds.Last());
    }

    public void TodaysCount()
    {
        Console.WriteLine(_birds.Last() + 1);w
    }

    public void DayWithNoVisitingBirds()
    {
        bool allTrue = _birds.Contains(0);
        Console.WriteLine(allTrue);
    }

    public void CountForFirstDays(int limit)
    {
        Console.WriteLine(_birds.Take(limit).Sum());
    }

    public void BusyDays()
    {
        Console.WriteLine(_birds.Where(x => x >= 5).Count());
    }
}