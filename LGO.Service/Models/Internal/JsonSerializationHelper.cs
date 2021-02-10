using System;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace LGO.Service.Models.Internal
{
    public static class JsonSerializationHelper
    {
        public static string GetPropertyName(Type memberOwner, string memberName)
        {
            return memberOwner.GetMember(memberName).FirstOrDefault()?.GetCustomAttribute<JsonPropertyAttribute>()?.PropertyName ?? memberName;
        }
    }
}