using LGO.Service.Models.Public.League.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Timer
{
    [JsonConverter(typeof(LeagueTimerJsonConverter<LeagueDragonRespawnTimer>))]
    public record LeagueDragonRespawnTimer : LeagueTimer
    {
        public override LeagueTimerType Type => LeagueTimerType.DragonRespawn;

        public static LeagueDragonRespawnTimer Null => new();
    }
}