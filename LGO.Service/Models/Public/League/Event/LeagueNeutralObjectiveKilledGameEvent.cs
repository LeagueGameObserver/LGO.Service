namespace LGO.Service.Models.Public.League.Event
{
    public abstract record LeagueNeutralObjectiveKilledGameEvent : LeagueKillerWithAssistersGameEvent
    {
        public bool WasStolen { get; init; } = false;
    }
}