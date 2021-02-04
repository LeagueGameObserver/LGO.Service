using LGO.Service.Models.Public.Enum;
using LGO.Service.Models.Public.League.Enum;
using LGO.Service.Models.Public.League.Game;

namespace LGO.Service.Models.Public.Event
{
    public record LgoLeagueGameStateChangedEvent : LgoEvent
    {
        public override LgoEventType Type => LgoEventType.LeagueGameStateChanged;

        public LeagueGameStateType OldState { get; init; } = LeagueGameStateType.Undefined;

        public LeagueGameStateType NewState { get; init; } = LeagueGameStateType.Undefined;

        public LeagueGame Game { get; init; } = LeagueGame.Null;

        public static LgoLeagueGameStateChangedEvent Null => new();
    }
}