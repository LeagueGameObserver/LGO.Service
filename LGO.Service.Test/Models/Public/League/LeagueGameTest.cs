using System;
using System.Linq;
using LGO.Service.Models.Internal;
using LGO.Service.Models.Public.League;
using LGO.Service.Models.Public.League.Enum;
using LGO.Service.Models.Public.League.Event;
using LGO.Service.Models.Public.League.Game;
using LGO.Service.Models.Public.League.Player;
using LGO.Service.Models.Public.League.Team;
using Newtonsoft.Json;
using NUnit.Framework;

namespace LGO.Service.Test.Models.Public.League
{
    public class LeagueGameTest
    {
        private static readonly LeagueGame Game = new()
                                                  {
                                                      Id = Guid.NewGuid(),
                                                      GameTimeInSeconds = 13.37d,
                                                      State = LeagueGameStateType.InProgress,
                                                      Mode = LeagueGameModeType.Classic5X5,
                                                      Teams = Enumerable.Empty<LeagueTeam>(),
                                                      Players = Enumerable.Empty<LeaguePlayer>(),
                                                      MatchUps = Enumerable.Empty<LeagueMatchUp>(),
                                                      Timers = Enumerable.Empty<LeagueTimer>(),
                                                      Events = Enumerable.Empty<LeagueGameEvent>(),
                                                      EventsSinceLastUpdate = Enumerable.Empty<LeagueGameEvent>(),
                                                  };

        [Test]
        public void TestSerializeEverything()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Game.Id}"",
  ""State"": ""InProgress"",
  ""GameTimeInSeconds"": 13.37,
  ""Mode"": ""Classic5X5"",
  ""Teams"": [],
  ""Players"": [],
  ""MatchUps"": [],
  ""Timers"": [],
  ""Events"": [],
  ""EventsSinceLastUpdate"": []
}}";
            
            AssertSerializationResult(LgoLeagueGameRetrievalConfiguration.IncludeEverything, expectedJson);
        }

        [Test]
        public void TestSerializeNothing()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Game.Id}"",
  ""State"": ""InProgress""
}}";
            
            AssertSerializationResult(LgoLeagueGameRetrievalConfiguration.IncludeNothing, expectedJson);
        }

        [Test]
        public void TestSerializeGameTimeInSecondsOnly()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Game.Id}"",
  ""State"": ""InProgress"",
  ""GameTimeInSeconds"": 13.37
}}";
            
            AssertSerializationResult(new LgoLeagueGameRetrievalConfiguration
                                      {
                                          IncludeGameTimeInSeconds = true,
                                          IncludeMode = false,
                                          IncludeTeams = false,
                                          IncludePlayers = false,
                                          IncludeMatchUps = false,
                                          IncludeTimers = false,
                                          IncludeEvents = false,
                                          IncludeEventsSinceLastUpdate = false,
                                      }, 
                                      expectedJson);
        }

        [Test]
        public void TestSerializeModeOnly()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Game.Id}"",
  ""State"": ""InProgress"",
  ""Mode"": ""Classic5X5""
}}";
            
            AssertSerializationResult(new LgoLeagueGameRetrievalConfiguration
                                      {
                                          IncludeGameTimeInSeconds = false,
                                          IncludeMode = true,
                                          IncludeTeams = false,
                                          IncludePlayers = false,
                                          IncludeMatchUps = false,
                                          IncludeTimers = false,
                                          IncludeEvents = false,
                                          IncludeEventsSinceLastUpdate = false,
                                      }, 
                                      expectedJson);
        }

        [Test]
        public void TestSerializeTeamsOnly()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Game.Id}"",
  ""State"": ""InProgress"",
  ""Teams"": []
}}";
            
            AssertSerializationResult(new LgoLeagueGameRetrievalConfiguration
                                      {
                                          IncludeGameTimeInSeconds = false,
                                          IncludeMode = false,
                                          IncludeTeams = true,
                                          IncludePlayers = false,
                                          IncludeMatchUps = false,
                                          IncludeTimers = false,
                                          IncludeEvents = false,
                                          IncludeEventsSinceLastUpdate = false,
                                      }, 
                                      expectedJson);
        }

        [Test]
        public void TestSerializePlayersOnly()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Game.Id}"",
  ""State"": ""InProgress"",
  ""Players"": []
}}";
            
            AssertSerializationResult(new LgoLeagueGameRetrievalConfiguration
                                      {
                                          IncludeGameTimeInSeconds = false,
                                          IncludeMode = false,
                                          IncludeTeams = false,
                                          IncludePlayers = true,
                                          IncludeMatchUps = false,
                                          IncludeTimers = false,
                                          IncludeEvents = false,
                                          IncludeEventsSinceLastUpdate = false,
                                      }, 
                                      expectedJson);
        }

        [Test]
        public void TestSerializeMatchUpsOnly()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Game.Id}"",
  ""State"": ""InProgress"",
  ""MatchUps"": []
}}";
            
            AssertSerializationResult(new LgoLeagueGameRetrievalConfiguration
                                      {
                                          IncludeGameTimeInSeconds = false,
                                          IncludeMode = false,
                                          IncludeTeams = false,
                                          IncludePlayers = false,
                                          IncludeMatchUps = true,
                                          IncludeTimers = false,
                                          IncludeEvents = false,
                                          IncludeEventsSinceLastUpdate = false,
                                      }, 
                                      expectedJson);
        }

        [Test]
        public void TestSerializeTimersOnly()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Game.Id}"",
  ""State"": ""InProgress"",
  ""Timers"": []
}}";
            
            AssertSerializationResult(new LgoLeagueGameRetrievalConfiguration
                                      {
                                          IncludeGameTimeInSeconds = false,
                                          IncludeMode = false,
                                          IncludeTeams = false,
                                          IncludePlayers = false,
                                          IncludeMatchUps = false,
                                          IncludeTimers = true,
                                          IncludeEvents = false,
                                          IncludeEventsSinceLastUpdate = false,
                                      }, 
                                      expectedJson);
        }

        [Test]
        public void TestSerializeEventsOnly()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Game.Id}"",
  ""State"": ""InProgress"",
  ""Events"": []
}}";
            
            AssertSerializationResult(new LgoLeagueGameRetrievalConfiguration
                                      {
                                          IncludeGameTimeInSeconds = false,
                                          IncludeMode = false,
                                          IncludeTeams = false,
                                          IncludePlayers = false,
                                          IncludeMatchUps = false,
                                          IncludeTimers = false,
                                          IncludeEvents = true,
                                          IncludeEventsSinceLastUpdate = false,
                                      }, 
                                      expectedJson);
        }

        [Test]
        public void TestSerializeEventsSinceLastUpdateOnly()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Game.Id}"",
  ""State"": ""InProgress"",
  ""EventsSinceLastUpdate"": []
}}";
            
            AssertSerializationResult(new LgoLeagueGameRetrievalConfiguration
                                      {
                                          IncludeGameTimeInSeconds = false,
                                          IncludeMode = false,
                                          IncludeTeams = false,
                                          IncludePlayers = false,
                                          IncludeMatchUps = false,
                                          IncludeTimers = false,
                                          IncludeEvents = false,
                                          IncludeEventsSinceLastUpdate = true,
                                      }, 
                                      expectedJson);
        }

        private static void AssertSerializationResult(LgoLeagueGameRetrievalConfiguration retrievalConfiguration, string expectedJson)
        {
            var requestContext = new RequestExecutionContext.Builder().With(retrievalConfiguration).Build();
            RequestExecutionContext.ExecuteWith(requestContext, () =>
                                                                {
                                                                    var actualJson = JsonConvert.SerializeObject(Game, Formatting.Indented);
                                                                    Assert.AreEqual(expectedJson, actualJson);
                                                                });
        }
    }
}