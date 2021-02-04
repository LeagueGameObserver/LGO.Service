using LGO.Service.Models.Public.Enum;
using LGO.Service.Models.Public.League.Game;

namespace LGO.Service.Models.Public.Event
{
    public record LgoLeagueGameUpdatedEvent : LgoEvent
    {
        public override LgoEventType Type => LgoEventType.LeagueGameUpdated;

        public LeagueGame Game { get; init; } = LeagueGame.Null;

        public static LgoLeagueGameUpdatedEvent Null => new();
    }
}