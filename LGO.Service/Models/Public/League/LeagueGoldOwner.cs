using System;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League
{
    public abstract record LeagueGoldOwner
    {
        [JsonProperty("Id")]
        public Guid Id { get; init; } = Guid.Empty;
        
        [JsonProperty("TotalGoldOwned")]
        public int  TotalGoldOwned { get; init; }
        
        [JsonProperty("UnspentKills")]
        public int  UnspentKills { get; init; }
        
        [JsonProperty("UnspentAssists")]
        public int  UnspentAssists { get; init; }
        
        [JsonProperty("UnspentDeaths")]
        public int  UnspentDeaths { get; init; }
        
        [JsonProperty("TotalKills")]
        public int  TotalKills { get; init; }
        
        [JsonProperty("TotalAssists")]
        public int  TotalAssists { get; init; }
        
        [JsonProperty("TotalDeaths")]
        public int  TotalDeaths { get; init; }
    }
}