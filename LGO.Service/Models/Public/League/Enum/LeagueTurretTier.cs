using LGO.Service.Models.Public.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Enum
{
    [JsonConverter(typeof(EnumJsonConverter<LeagueTurretTier>))]
    public enum LeagueTurretTier
    {
        [JsonProperty("Undefined")]
        Undefined,
        
        [JsonProperty("TopOuter")]
        TopOuter,
        
        [JsonProperty("TopInner")]
        TopInner,
        
        [JsonProperty("TopInhibitor")]
        TopInhibitor,
        
        [JsonProperty("MiddleOuter")]
        MiddleOuter,
        
        [JsonProperty("MiddleInner")]
        MiddleInner,
        
        [JsonProperty("MiddleInhibitor")]
        MiddleInhibitor,
        
        [JsonProperty("MiddleNexusTop")]
        MiddleNexusTop,
        
        [JsonProperty("MiddleNexusBottom")]
        MiddleNexusBottom,
        
        [JsonProperty("BottomOuter")]
        BottomOuter,
        
        [JsonProperty("BottomInner")]
        BottomInner,
        
        [JsonProperty("BottomInhibitor")]
        BottomInhibitor,
    }
}