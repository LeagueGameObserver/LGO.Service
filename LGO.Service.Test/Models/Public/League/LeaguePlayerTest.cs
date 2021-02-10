using System;
using System.Linq;
using LGO.Service.Models.Internal;
using LGO.Service.Models.Public.League.Enum;
using LGO.Service.Models.Public.League.Item;
using LGO.Service.Models.Public.League.Player;
using Newtonsoft.Json;
using NUnit.Framework;

namespace LGO.Service.Test.Models.Public.League
{
    public class LeaguePlayerTest
    {
        private static readonly LeaguePlayer Player = new()
                                                      {
                                                          Id = Guid.NewGuid(),
                                                          TotalGoldOwned = 1337,
                                                          UnspentKills = 5,
                                                          UnspentAssists = 1,
                                                          UnspentDeaths = 2,
                                                          TotalKills = 10,
                                                          TotalAssists = 4,
                                                          TotalDeaths = 4,
                                                          SummonerName = "Summoner Name",
                                                          Team = LeagueTeamType.Blue,
                                                          Champion = null!,
                                                          Items = Enumerable.Empty<LeagueItem>(),
                                                      };

        [Test]
        public void TestSerializeEverything()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Player.Id}"",
  ""TotalGoldOwned"": 1337,
  ""UnspentKills"": 5,
  ""UnspentAssists"": 1,
  ""UnspentDeaths"": 2,
  ""TotalKills"": 10,
  ""TotalAssists"": 4,
  ""TotalDeaths"": 4,
  ""SummonerName"": ""Summoner Name"",
  ""Team"": ""Blue"",
  ""Champion"": null,
  ""Items"": []
}}";

            AssertSerializationResult(LgoLeaguePlayerRetrievalConfiguration.IncludeEverything, expectedJson);
        }

        [Test]
        public void TestSerializeNothing()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Player.Id}"",
  ""TotalGoldOwned"": 1337,
  ""UnspentKills"": 5,
  ""UnspentAssists"": 1,
  ""UnspentDeaths"": 2,
  ""TotalKills"": 10,
  ""TotalAssists"": 4,
  ""TotalDeaths"": 4
}}";

            AssertSerializationResult(LgoLeaguePlayerRetrievalConfiguration.IncludeNothing, expectedJson);
        }

        [Test]
        public void TestSerializeSummonerNameOnly()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Player.Id}"",
  ""TotalGoldOwned"": 1337,
  ""UnspentKills"": 5,
  ""UnspentAssists"": 1,
  ""UnspentDeaths"": 2,
  ""TotalKills"": 10,
  ""TotalAssists"": 4,
  ""TotalDeaths"": 4,
  ""SummonerName"": ""Summoner Name""
}}";

            AssertSerializationResult(new LgoLeaguePlayerRetrievalConfiguration
                                      {
                                          IncludeSummonerName = true,
                                          IncludeTeam = false,
                                          IncludeChampion = false,
                                          IncludeItems = false,
                                      },
                                      expectedJson);
        }

        [Test]
        public void TestSerializeTeamOnly()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Player.Id}"",
  ""TotalGoldOwned"": 1337,
  ""UnspentKills"": 5,
  ""UnspentAssists"": 1,
  ""UnspentDeaths"": 2,
  ""TotalKills"": 10,
  ""TotalAssists"": 4,
  ""TotalDeaths"": 4,
  ""Team"": ""Blue""
}}";

            AssertSerializationResult(new LgoLeaguePlayerRetrievalConfiguration
                                      {
                                          IncludeSummonerName = false,
                                          IncludeTeam = true,
                                          IncludeChampion = false,
                                          IncludeItems = false,
                                      },
                                      expectedJson);
        }

        [Test]
        public void TestSerializeChampionOnly()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Player.Id}"",
  ""TotalGoldOwned"": 1337,
  ""UnspentKills"": 5,
  ""UnspentAssists"": 1,
  ""UnspentDeaths"": 2,
  ""TotalKills"": 10,
  ""TotalAssists"": 4,
  ""TotalDeaths"": 4,
  ""Champion"": null
}}";

            AssertSerializationResult(new LgoLeaguePlayerRetrievalConfiguration
                                      {
                                          IncludeSummonerName = false,
                                          IncludeTeam = false,
                                          IncludeChampion = true,
                                          IncludeItems = false,
                                      },
                                      expectedJson);
        }

        [Test]
        public void TestSerializeItemsOnly()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Player.Id}"",
  ""TotalGoldOwned"": 1337,
  ""UnspentKills"": 5,
  ""UnspentAssists"": 1,
  ""UnspentDeaths"": 2,
  ""TotalKills"": 10,
  ""TotalAssists"": 4,
  ""TotalDeaths"": 4,
  ""Items"": []
}}";

            AssertSerializationResult(new LgoLeaguePlayerRetrievalConfiguration
                                      {
                                          IncludeSummonerName = false,
                                          IncludeTeam = false,
                                          IncludeChampion = false,
                                          IncludeItems = true,
                                      }, expectedJson);
        }

        private static void AssertSerializationResult(LgoLeaguePlayerRetrievalConfiguration retrievalConfiguration, string expectedJson)
        {
            var requestContext = new RequestExecutionContext.Builder().With(retrievalConfiguration).Build();
            RequestExecutionContext.ExecuteWith(requestContext, () =>
                                                                {
                                                                    var actualJson = JsonConvert.SerializeObject(Player, Formatting.Indented);
                                                                    Assert.AreEqual(expectedJson, actualJson);
                                                                });
        }
    }
}