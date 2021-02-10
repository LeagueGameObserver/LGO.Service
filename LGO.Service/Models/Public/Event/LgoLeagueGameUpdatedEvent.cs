using LGO.Service.Models.Public.Enum;
using LGO.Service.Models.Public.League.Game;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.Event
{
    public record LgoLeagueGameUpdatedEvent : LgoEvent
    {
        [JsonProperty("Type")]
        public override LgoEventType Type => LgoEventType.LeagueGameUpdated;

        [JsonProperty("Game")]
        public LeagueGame Game { get; init; } = LeagueGame.Null;

        public static LgoLeagueGameUpdatedEvent Null => new();
    }
}