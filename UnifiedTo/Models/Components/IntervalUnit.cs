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
    
    public enum IntervalUnit
    {
        [JsonProperty("YEAR")]
        Year,
        [JsonProperty("MONTH")]
        Month,
        [JsonProperty("WEEK")]
        Week,
        [JsonProperty("DAY")]
        Day,
    }

    public static class IntervalUnitExtension
    {
        public static string Value(this IntervalUnit value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static IntervalUnit ToEnum(this string value)
        {
            foreach(var field in typeof(IntervalUnit).GetFields())
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

                    if (enumVal is IntervalUnit)
                    {
                        return (IntervalUnit)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum IntervalUnit");
        }
    }

}