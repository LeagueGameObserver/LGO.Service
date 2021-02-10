using LGO.Service.Models.Public.League.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Timer
{
    [JsonConverter(typeof(LeaguePowerPlayTimerJsonConverter<LeagueElderDragonPowerPlayTimer>))]
    public record LeagueElderDragonPowerPlayTimer : LeaguePowerPlayTimer
    {
        public override LeagueTimerType Type => LeagueTimerType.ElderDragonPowerPlay;

        public static LeagueElderDragonPowerPlayTimer Null => new();
    }
}