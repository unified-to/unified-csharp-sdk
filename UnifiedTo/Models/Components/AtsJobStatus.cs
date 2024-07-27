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
    
    public enum AtsJobStatus
    {
        [JsonProperty("ARCHIVED")]
        Archived,
        [JsonProperty("PENDING")]
        Pending,
        [JsonProperty("DRAFT")]
        Draft,
        [JsonProperty("OPEN")]
        Open,
        [JsonProperty("CLOSED")]
        Closed,
    }

    public static class AtsJobStatusExtension
    {
        public static string Value(this AtsJobStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static AtsJobStatus ToEnum(this string value)
        {
            foreach(var field in typeof(AtsJobStatus).GetFields())
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

                    if (enumVal is AtsJobStatus)
                    {
                        return (AtsJobStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum AtsJobStatus");
        }
    }

}