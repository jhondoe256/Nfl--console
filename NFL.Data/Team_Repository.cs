
public class Team_Repository
{
    //the 32 will go here:
    private readonly List<Team> _teamDb = new List<Team>();
    private int _count;

    //Create Method -> add to the database (Team)
    //Methods are just small machines that do work
    //Somes they just do work (dont return anything) [void]
    //In this case we will return true or false (bool)
    public bool AddTeamToDb(Team team)
    {
        if (team is null)
        {
            return false;
        }
        else
        {
            _count++;
            team.Id = _count;
            _teamDb.Add(team);
            return true;
        }
    }

    //Read method -> get all of the data (Everything about all of the teams)
    public List<Team> GetAllTeams()
    {
        return _teamDb;
    }

    //Read method -> get one team by its unique identifier
    public Team GetTeam(int id)
    {
        //loop through database
        foreach (Team team in _teamDb)
        {
            //if team (one of many) in the database has the matching id
            if (team.Id == id)
            {
                //return all of that teams data
                return team;
            }
        }
        //return nothing
        return null;
    }

    //Update -> Clears out all the data except the Id
    public bool UpdateTeamData(int id, Team updatedTeamData)
    {
        Team teamInDb = GetTeam(id);
        if (teamInDb != null)
        {
            teamInDb.TeamName = updatedTeamData.TeamName;
            teamInDb.Players = updatedTeamData.Players;
            return true;
        }
        return false;
    }

    //Delete -> removes an existing team by it unique identifier
    public bool DeleteTeamData(int id)
    {
        Team teamInDb = GetTeam(id);
        return _teamDb.Remove(teamInDb);
    }
}
