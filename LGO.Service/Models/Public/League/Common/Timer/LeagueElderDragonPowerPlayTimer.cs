using LGO.Service.Models.Public.League.Common.Enum;

namespace LGO.Service.Models.Public.League.Common.Timer
{
    public record LeagueElderDragonPowerPlayTimer : LeaguePowerPlayTimer
    {
        public override LeagueTimerType Type => LeagueTimerType.ElderDragonPowerPlay;

        public static LeagueElderDragonPowerPlayTimer Null => new();
    }
}