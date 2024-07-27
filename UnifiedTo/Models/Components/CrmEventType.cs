//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace UnifiedTo.Models.Components
{
    using Newtonsoft.Json;
    using System;
    using UnifiedTo.Utils;
    
    public enum CrmEventType
    {
        [JsonProperty("NOTE")]
        Note,
        [JsonProperty("EMAIL")]
        Email,
        [JsonProperty("TASK")]
        Task,
        [JsonProperty("MEETING")]
        Meeting,
        [JsonProperty("CALL")]
        Call,
    }

    public static class CrmEventTypeExtension
    {
        public static string Value(this CrmEventType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static CrmEventType ToEnum(this string value)
        {
            foreach(var field in typeof(CrmEventType).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is CrmEventType)
                    {
                        return (CrmEventType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum CrmEventType");
        }
    }

}