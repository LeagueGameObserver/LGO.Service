namespace LGO.Service.Models.Public.League.Event
{
    public abstract record LeagueKillerGameEvent : LeagueGameEvent
    {
        public string KillerName { get; init; } = string.Empty;
    }
}