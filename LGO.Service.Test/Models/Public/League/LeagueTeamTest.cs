using System;
using System.Linq;
using LGO.Service.Models.Internal;
using LGO.Service.Models.Public.League.Enum;
using LGO.Service.Models.Public.League.Team;
using Newtonsoft.Json;
using NUnit.Framework;

namespace LGO.Service.Test.Models.Public.League
{
    public class LeagueTeamTest
    {
        private static readonly LeagueTeam Team = new()
                                                  {
                                                      Id = Guid.NewGuid(),
                                                      TotalGoldOwned = 1337,
                                                      UnspentKills = 5,
                                                      UnspentAssists = 2,
                                                      UnspentDeaths = 1,
                                                      TotalKills = 10,
                                                      TotalAssists = 4,
                                                      TotalDeaths = 4,
                                                      Side = LeagueTeamType.Blue,
                                                      DragonsKilled = new[]
                                                                      {
                                                                          LeagueDragonType.Infernal,
                                                                          LeagueDragonType.Mountain,
                                                                      },
                                                      NumberOfRiftHeraldsKilled = 0,
                                                      NumberOfBaronNashorsKilled = 1,
                                                      TurretsDestroyed = new[]
                                                                         {
                                                                             LeagueTurretTier.BottomOuter,
                                                                             LeagueTurretTier.MiddleOuter,
                                                                             LeagueTurretTier.TopInhibitor,
                                                                         },
                                                      InhibitorsDestroyed = Enumerable.Empty<LeagueInhibitorTierType>(),
                                                  };

        [Test]
        public void TestSerializeEverything()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Team.Id}"",
  ""TotalGoldOwned"": 1337,
  ""UnspentKills"": 5,
  ""UnspentAssists"": 2,
  ""UnspentDeaths"": 1,
  ""TotalKills"": 10,
  ""TotalAssists"": 4,
  ""TotalDeaths"": 4,
  ""Side"": ""Blue"",
  ""DragonsKilled"": [
    ""Infernal"",
    ""Mountain""
  ],
  ""NumberOfRiftHeraldsKilled"": 0,
  ""NumberOfBaronNashorsKilled"": 1,
  ""TurretsDestroyed"": [
    ""BottomOuter"",
    ""MiddleOuter"",
    ""TopInhibitor""
  ],
  ""InhibitorsDestroyed"": []
}}";
            
            AssertSerializationResult(LgoLeagueTeamRetrievalConfiguration.IncludeEverything, expectedJson);
        }

        [Test]
        public void TestSerializeNothing()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Team.Id}"",
  ""TotalGoldOwned"": 1337,
  ""UnspentKills"": 5,
  ""UnspentAssists"": 2,
  ""UnspentDeaths"": 1,
  ""TotalKills"": 10,
  ""TotalAssists"": 4,
  ""TotalDeaths"": 4
}}";
            
            AssertSerializationResult(LgoLeagueTeamRetrievalConfiguration.IncludeNothing, expectedJson);
        }

        [Test]
        public void TestSerializeSideOnly()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Team.Id}"",
  ""TotalGoldOwned"": 1337,
  ""UnspentKills"": 5,
  ""UnspentAssists"": 2,
  ""UnspentDeaths"": 1,
  ""TotalKills"": 10,
  ""TotalAssists"": 4,
  ""TotalDeaths"": 4,
  ""Side"": ""Blue""
}}";
            
            AssertSerializationResult(new LgoLeagueTeamRetrievalConfiguration
                                      {
                                          IncludeSide = true,
                                          IncludeDragonsKilled = false,
                                          IncludeNumberOfRiftHeraldsKilled = false,
                                          IncludeNumberOfBaronNashorsKilled = false,
                                          IncludeTurretsDestroyed = false,
                                          IncludeInhibitorsDestroyed = false,
                                      }, 
                                      expectedJson);
        }

        [Test]
        public void TestSerializeDragonsKilledOnly()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Team.Id}"",
  ""TotalGoldOwned"": 1337,
  ""UnspentKills"": 5,
  ""UnspentAssists"": 2,
  ""UnspentDeaths"": 1,
  ""TotalKills"": 10,
  ""TotalAssists"": 4,
  ""TotalDeaths"": 4,
  ""DragonsKilled"": [
    ""Infernal"",
    ""Mountain""
  ]
}}";
            
            AssertSerializationResult(new LgoLeagueTeamRetrievalConfiguration
                                      {
                                          IncludeSide = false,
                                          IncludeDragonsKilled = true,
                                          IncludeNumberOfRiftHeraldsKilled = false,
                                          IncludeNumberOfBaronNashorsKilled = false,
                                          IncludeTurretsDestroyed = false,
                                          IncludeInhibitorsDestroyed = false,
                                      }, 
                                      expectedJson);
        }

        [Test]
        public void TestSerializeNumberOfRiftHeraldsKilledOnly()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Team.Id}"",
  ""TotalGoldOwned"": 1337,
  ""UnspentKills"": 5,
  ""UnspentAssists"": 2,
  ""UnspentDeaths"": 1,
  ""TotalKills"": 10,
  ""TotalAssists"": 4,
  ""TotalDeaths"": 4,
  ""NumberOfRiftHeraldsKilled"": 0
}}";
            
            AssertSerializationResult(new LgoLeagueTeamRetrievalConfiguration
                                      {
                                          IncludeSide = false,
                                          IncludeDragonsKilled = false,
                                          IncludeNumberOfRiftHeraldsKilled = true,
                                          IncludeNumberOfBaronNashorsKilled = false,
                                          IncludeTurretsDestroyed = false,
                                          IncludeInhibitorsDestroyed = false,
                                      }, 
                                      expectedJson);
        }

        [Test]
        public void TestSerializeNumberOfBaronNashorsKilledOnly()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Team.Id}"",
  ""TotalGoldOwned"": 1337,
  ""UnspentKills"": 5,
  ""UnspentAssists"": 2,
  ""UnspentDeaths"": 1,
  ""TotalKills"": 10,
  ""TotalAssists"": 4,
  ""TotalDeaths"": 4,
  ""NumberOfBaronNashorsKilled"": 1
}}";
            
            AssertSerializationResult(new LgoLeagueTeamRetrievalConfiguration
                                      {
                                          IncludeSide = false,
                                          IncludeDragonsKilled = false,
                                          IncludeNumberOfRiftHeraldsKilled = false,
                                          IncludeNumberOfBaronNashorsKilled = true,
                                          IncludeTurretsDestroyed = false,
                                          IncludeInhibitorsDestroyed = false,
                                      }, 
                                      expectedJson);
        }

        [Test]
        public void TestSerializeTurretsDestroyedOnly()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Team.Id}"",
  ""TotalGoldOwned"": 1337,
  ""UnspentKills"": 5,
  ""UnspentAssists"": 2,
  ""UnspentDeaths"": 1,
  ""TotalKills"": 10,
  ""TotalAssists"": 4,
  ""TotalDeaths"": 4,
  ""TurretsDestroyed"": [
    ""BottomOuter"",
    ""MiddleOuter"",
    ""TopInhibitor""
  ]
}}";
            
            AssertSerializationResult(new LgoLeagueTeamRetrievalConfiguration
                                      {
                                          IncludeSide = false,
                                          IncludeDragonsKilled = false,
                                          IncludeNumberOfRiftHeraldsKilled = false,
                                          IncludeNumberOfBaronNashorsKilled = false,
                                          IncludeTurretsDestroyed = true,
                                          IncludeInhibitorsDestroyed = false,
                                      }, 
                                      expectedJson);
        }

        [Test]
        public void TestSerializeInhibitorsDestroyedOnly()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Team.Id}"",
  ""TotalGoldOwned"": 1337,
  ""UnspentKills"": 5,
  ""UnspentAssists"": 2,
  ""UnspentDeaths"": 1,
  ""TotalKills"": 10,
  ""TotalAssists"": 4,
  ""TotalDeaths"": 4,
  ""InhibitorsDestroyed"": []
}}";
            
            AssertSerializationResult(new LgoLeagueTeamRetrievalConfiguration
                                      {
                                          IncludeSide = false,
                                          IncludeDragonsKilled = false,
                                          IncludeNumberOfRiftHeraldsKilled = false,
                                          IncludeNumberOfBaronNashorsKilled = false,
                                          IncludeTurretsDestroyed = false,
                                          IncludeInhibitorsDestroyed = true,
                                      }, 
                                      expectedJson);
        }
        
        private static void AssertSerializationResult(LgoLeagueTeamRetrievalConfiguration retrievalConfiguration, string expectedJson)
        {
            var requestContext = new RequestExecutionContext.Builder().With(retrievalConfiguration).Build();
            RequestExecutionContext.ExecuteWith(requestContext, () =>
                                                                {
                                                                    var actualJson = JsonConvert.SerializeObject(Team, Formatting.Indented);
                                                                    Assert.AreEqual(expectedJson, actualJson);
                                                                });
        }
    }
}