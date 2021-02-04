using LGO.Service.Models.Public.League.Common.Enum;

namespace LGO.Service.Models.Public.League.Common.Timer
{
    public record LeagueBaronNashorPowerPlayTimer : LeaguePowerPlayTimer
    {
        public override LeagueTimerType Type => LeagueTimerType.BaronNashorPowerPlay;

        public static LeagueBaronNashorPowerPlayTimer Null => new();
    }
}