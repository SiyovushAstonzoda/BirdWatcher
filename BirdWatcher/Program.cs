using classes;

var birds = new List<int>();
for(int i = 0; i < 7; i++)
{
    birds.Add(Convert.ToInt32(Console.ReadLine()));
}
var birdCount = new BirdCount(birds);
birdCount.LastWeek();

birdCount.SetBirds(birds);
birdCount.LastWeek();
birdCount.VisitedToday();
birdCount.TodaysCount();
birdCount.DayWithNoVisitingBirds();
birdCount.CountForFirstDays(4);
birdCount.BusyDays();
