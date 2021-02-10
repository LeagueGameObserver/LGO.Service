using LGO.Service.Models.Internal;
using Newtonsoft.Json;
using NUnit.Framework;

namespace LGO.Service.Test.Models.Internal
{
    public class JsonSerializationHelperTest
    {
        private enum TestEnum
        {
            EntryWithoutAnnotation,

            [JsonProperty("AnnotatedEntry")]
            EntryWithAnnotation,
        }

        private record TestRecord
        {
            public string PropertyWithoutAnnotation { get; init; } = nameof(PropertyWithoutAnnotation);

            [JsonProperty("AnnotatedProperty")]
            public string PropertyWithAnnotation { get; init; } = nameof(PropertyWithAnnotation);
        }

        [Test]
        public void TestGetPropertyNameRespectsAnnotation()
        {
            Assert.AreEqual("AnnotatedEntry", JsonSerializationHelper.GetPropertyName(typeof(TestEnum), nameof(TestEnum.EntryWithAnnotation)));
            Assert.AreEqual("AnnotatedProperty", JsonSerializationHelper.GetPropertyName(typeof(TestRecord), nameof(TestRecord.PropertyWithAnnotation)));
        }

        [Test]
        public void TestGetPropertyNameFallsBackToPropertyName()
        {
            Assert.AreEqual(nameof(TestEnum.EntryWithoutAnnotation), JsonSerializationHelper.GetPropertyName(typeof(TestEnum), nameof(TestEnum.EntryWithoutAnnotation)));
            Assert.AreEqual(nameof(TestRecord.PropertyWithoutAnnotation), JsonSerializationHelper.GetPropertyName(typeof(TestRecord), nameof(TestRecord.PropertyWithoutAnnotation)));
        }
    }
}