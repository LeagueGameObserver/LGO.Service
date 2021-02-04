namespace LGO.Service.Models.Public.League.Common.Event
{
    public abstract record LeagueNeutralObjectiveKilledGameEvent : LeagueKillerWithAssistersGameEvent
    {
        public bool WasStolen { get; init; } = false;
    }
}