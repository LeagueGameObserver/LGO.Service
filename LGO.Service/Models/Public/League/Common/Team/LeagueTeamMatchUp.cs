namespace LGO.Service.Models.Public.League.Common.Team
{
    public record LeagueTeamMatchUp : LeagueMatchUp<LeagueTeam>
    {
        public static LeagueTeamMatchUp Null => new();
    }
}