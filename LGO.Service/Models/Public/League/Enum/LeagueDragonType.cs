using LGO.Service.Models.Public.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Enum
{
    [JsonConverter(typeof(EnumJsonConverter<LeagueDragonType>))]
    public enum LeagueDragonType
    {
        [JsonProperty("Undefined")]
        Undefined,
        
        [JsonProperty("Infernal")]
        Infernal,
        
        [JsonProperty("Ocean")]
        Ocean,
        
        [JsonProperty("Mountain")]
        Mountain,
        
        [JsonProperty("Cloud")]
        Cloud,
    }
}