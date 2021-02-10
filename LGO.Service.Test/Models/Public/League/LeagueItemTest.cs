using System;
using LGO.Service.Models.Internal;
using LGO.Service.Models.Public.League.Item;
using Newtonsoft.Json;
using NUnit.Framework;

namespace LGO.Service.Test.Models.Public.League
{
    public class LeagueItemTest
    {

        private static readonly LeagueItem Item = new()
                                                  {
                                                      Id = Guid.NewGuid(),
                                                      Name = "Item",
                                                      Price = 1337,
                                                      PathToImage = "/path/to/image",
                                                  };

        [Test]
        public void TestSerializeEverything()
        {
            var expectedJsonItem = @$"{{
  ""Id"": ""{Item.Id}"",
  ""Name"": ""Item"",
  ""Price"": 1337,
  ""Image"": ""/path/to/image""
}}";

            AssertSerializationResult(LgoLeagueItemRetrievalConfiguration.IncludeEverything, expectedJsonItem);
        }

        [Test]
        public void TestSerializeNothing()
        {
            var expectedJsonItem = @$"{{
  ""Id"": ""{Item.Id}""
}}";

            AssertSerializationResult(LgoLeagueItemRetrievalConfiguration.IncludeNothing, expectedJsonItem);
        }

        [Test]
        public void TestSerializeNameOnly()
        {
            var expectedJsonItem = @$"{{
  ""Id"": ""{Item.Id}"",
  ""Name"": ""Item""
}}";

            AssertSerializationResult(new LgoLeagueItemRetrievalConfiguration
                                      {
                                          IncludeName = true,
                                          IncludePrice = false,
                                          IncludeImage = false,
                                      },
                                      expectedJsonItem);
        }

        [Test]
        public void TestSerializePriceOnly()
        {
            var expectedJsonItem = @$"{{
  ""Id"": ""{Item.Id}"",
  ""Price"": 1337
}}";

            AssertSerializationResult(new LgoLeagueItemRetrievalConfiguration
                                      {
                                          IncludeName = false,
                                          IncludePrice = true,
                                          IncludeImage = false,
                                      },
                                      expectedJsonItem);
        }

        [Test]
        public void TestSerializeImageOnly()
        {
            var expectedJsonItem = @$"{{
  ""Id"": ""{Item.Id}"",
  ""Image"": ""/path/to/image""
}}";

            AssertSerializationResult(new LgoLeagueItemRetrievalConfiguration
                                      {
                                          IncludeName = false,
                                          IncludePrice = false,
                                          IncludeImage = true,
                                      },
                                      expectedJsonItem);
        }

        private static void AssertSerializationResult(LgoLeagueItemRetrievalConfiguration retrievalConfiguration, string expectedJson)
        {
            var requestContext = new RequestExecutionContext.Builder().With(retrievalConfiguration).Build();
            RequestExecutionContext.ExecuteWith(requestContext, () =>
                                                                {
                                                                    var actualJson = JsonConvert.SerializeObject(Item, Formatting.Indented);
                                                                    Assert.AreEqual(expectedJson, actualJson);
                                                                });
        }
    }
}