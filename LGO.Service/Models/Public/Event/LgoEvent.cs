using LGO.Service.Models.Public.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.Event
{
    public abstract record LgoEvent
    {
        [JsonProperty("Type")]
        public abstract LgoEventType Type { get; }
    }
}