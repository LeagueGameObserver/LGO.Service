using LGO.Service.Models.Public.League.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Player
{
    public record LeaguePlayerMatchUp : LeagueMatchUp<LeaguePlayer>
    {
        [JsonProperty("Position")]
        public LeaguePositionType Position { get; init; } = LeaguePositionType.Undefined;
        
        public static LeaguePlayerMatchUp Null => new();
    }
}