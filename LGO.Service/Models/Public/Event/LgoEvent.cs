using LGO.Service.Models.Public.Enum;

namespace LGO.Service.Models.Public.Event
{
    public abstract record LgoEvent
    {
        public abstract LgoEventType Type { get; }
    }
}