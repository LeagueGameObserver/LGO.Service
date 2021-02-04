namespace LGO.Service.Models.Public.League.Team
{
    public record LeagueTeamMatchUp : LeagueMatchUp<LeagueTeam>
    {
        public static LeagueTeamMatchUp Null => new();
    }
}