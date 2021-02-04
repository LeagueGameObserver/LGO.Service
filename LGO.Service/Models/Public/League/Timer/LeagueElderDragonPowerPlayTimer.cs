using LGO.Service.Models.Public.League.Enum;

namespace LGO.Service.Models.Public.League.Timer
{
    public record LeagueElderDragonPowerPlayTimer : LeaguePowerPlayTimer
    {
        public override LeagueTimerType Type => LeagueTimerType.ElderDragonPowerPlay;

        public static LeagueElderDragonPowerPlayTimer Null => new();
    }
}