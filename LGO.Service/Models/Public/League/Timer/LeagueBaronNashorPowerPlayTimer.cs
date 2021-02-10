using LGO.Service.Models.Public.League.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Timer
{
    [JsonConverter(typeof(LeaguePowerPlayTimerJsonConverter<LeagueBaronNashorPowerPlayTimer>))]
    public record LeagueBaronNashorPowerPlayTimer : LeaguePowerPlayTimer
    {
        public override LeagueTimerType Type => LeagueTimerType.BaronNashorPowerPlay;

        public static LeagueBaronNashorPowerPlayTimer Null => new();
    }
}