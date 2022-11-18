Team team = new Team();
team.TeamName = "Jaguars";
team.Id = 1;



Console.WriteLine(team);

System.Console.WriteLine("-------Constructor------------");
Team team2 = new Team("Cowboys", new List<Player>
{
    new Player()
    {
        Id=1,
        Name= "Emmit Smith"
    },
    new Player()
    {
        Id=2,
        Name= "Deion Sanders"
    }
});

System.Console.WriteLine(team2);
Console.ReadKey();
