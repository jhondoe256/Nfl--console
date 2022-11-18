
public class Team
{
    //2.Constructor -> A fast way to create a team 
    // we do this through 'overloads'
    public Team()
    {
    }

    //full constructor
    public Team(string teamName, List<Player> players)
    {
        TeamName = teamName;
        Players = players;
    }

    public Team(string teamName)
    {
        TeamName = teamName;
    }
    
    //1. properties -> attributes that makeup a team
    // what you think the object should have
    public int Id { get; set; }
    public string TeamName { get; set; }
    public List<Player> Players { get; set; } = new List<Player>();

    public override string ToString()
    {
        string str = $"Id: {Id}\nTeamName: {TeamName}\n";
        str += "-----------Players------------------\n";

        if (Players.Count > 0)
        {
            //Players is a List<Player>
            //the only way we can get to the in List is to use a loop
            foreach (Player p in Players)
            {
                str += $"{p.Id} - {p.Name}\n";
                str += "-------------------------\n";
            }
        }
        else
        {
            str += "No Teammates!";
        }
        return str;
    }
}
