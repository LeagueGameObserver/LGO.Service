using LGO.Service.Models.Public.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public
{
    public abstract record LgoDataRetrievalConfiguration
    {
        [JsonProperty("Type")]
        public abstract LgoDataRetrievalConfigurationType Type { get; }
    }
}