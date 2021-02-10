using System;
using LGO.Service.Models.Internal;
using LGO.Service.Models.Public.League.Champion;
using Newtonsoft.Json;
using NUnit.Framework;

namespace LGO.Service.Test.Models.Public.League
{
    public class LeagueChampionTest
    {
        private static readonly LeagueChampion Champion = new()
                                                          {
                                                              Id = Guid.NewGuid(),
                                                              Name = "Champion",
                                                              PathToTileImage = "/path/to/tile",
                                                              PathToSplashImage = "/path/to/splash",
                                                              PathToLoadingImage = "/path/to/loading",
                                                          };

        [Test]
        public void TestSerializeEverything()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Champion.Id}"",
  ""Name"": ""Champion"",
  ""TileImage"": ""/path/to/tile"",
  ""SplashImage"": ""/path/to/splash"",
  ""LoadingImage"": ""/path/to/loading""
}}";
            
            AssertSerializationResult(LgoLeagueChampionRetrievalConfiguration.IncludeEverything, expectedJson);
        }

        [Test]
        public void TestSerializeNothing()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Champion.Id}""
}}";
            
            AssertSerializationResult(LgoLeagueChampionRetrievalConfiguration.IncludeNothing, expectedJson);
        }

        [Test]
        public void TestSerializeNameOnly()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Champion.Id}"",
  ""Name"": ""Champion""
}}";
            
            AssertSerializationResult(new LgoLeagueChampionRetrievalConfiguration
                                      {
                                          IncludeName = true,
                                          IncludeTileImage = false,
                                          IncludeSplashImage = false,
                                          IncludeLoadingImage = false,
                                      }, expectedJson);
        }

        [Test]
        public void TestSerializeTileImageOnly()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Champion.Id}"",
  ""TileImage"": ""/path/to/tile""
}}";
            
            AssertSerializationResult(new LgoLeagueChampionRetrievalConfiguration
                                      {
                                          IncludeName = false,
                                          IncludeTileImage = true,
                                          IncludeSplashImage = false,
                                          IncludeLoadingImage = false,
                                      }, expectedJson);
        }

        [Test]
        public void TestSerializeSplashImageOnly()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Champion.Id}"",
  ""SplashImage"": ""/path/to/splash""
}}";
            
            AssertSerializationResult(new LgoLeagueChampionRetrievalConfiguration
                                      {
                                          IncludeName = false,
                                          IncludeTileImage = false,
                                          IncludeSplashImage = true,
                                          IncludeLoadingImage = false,
                                      }, expectedJson);
        }

        [Test]
        public void TestSerializeLoadingImageOnly()
        {
            var expectedJson = $@"{{
  ""Id"": ""{Champion.Id}"",
  ""LoadingImage"": ""/path/to/loading""
}}";
            
            AssertSerializationResult(new LgoLeagueChampionRetrievalConfiguration
                                      {
                                          IncludeName = false,
                                          IncludeTileImage = false,
                                          IncludeSplashImage = false,
                                          IncludeLoadingImage = true,
                                      }, expectedJson);
        }
        
        private static void AssertSerializationResult(LgoLeagueChampionRetrievalConfiguration retrievalConfiguration, string expectedJson)
        {
            var requestContext = new RequestExecutionContext.Builder().With(retrievalConfiguration).Build();
            RequestExecutionContext.ExecuteWith(requestContext, () =>
                                                                {
                                                                    var actualJson = JsonConvert.SerializeObject(Champion, Formatting.Indented);
                                                                    Assert.AreEqual(expectedJson, actualJson);
                                                                });
        }
    }
}