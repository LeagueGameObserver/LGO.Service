using LGO.Service.Models.Public.League.Enum;

namespace LGO.Service.Models.Public.League.Timer
{
    public record LeagueBaronNashorPowerPlayTimer : LeaguePowerPlayTimer
    {
        public override LeagueTimerType Type => LeagueTimerType.BaronNashorPowerPlay;

        public static LeagueBaronNashorPowerPlayTimer Null => new();
    }
}