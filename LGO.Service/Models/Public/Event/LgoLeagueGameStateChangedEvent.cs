using LGO.Service.Models.Public.Enum;
using LGO.Service.Models.Public.League.Enum;
using LGO.Service.Models.Public.League.Game;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.Event
{
    public record LgoLeagueGameStateChangedEvent : LgoEvent
    {
        [JsonProperty("Type")]
        public override LgoEventType Type => LgoEventType.LeagueGameStateChanged;

        [JsonProperty("OldState")]
        public LeagueGameStateType OldState { get; init; } = LeagueGameStateType.Undefined;

        [JsonProperty("NewState")]
        public LeagueGameStateType NewState { get; init; } = LeagueGameStateType.Undefined;

        [JsonProperty("Game")]
        public LeagueGame Game { get; init; } = LeagueGame.Null;

        public static LgoLeagueGameStateChangedEvent Null => new();
    }
}