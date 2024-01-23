
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
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
    
    public enum Origin
    {
        [JsonProperty("AGENCY")]
        Agency,
        [JsonProperty("APPLIED")]
        Applied,
        [JsonProperty("INTERNAL")]
        Internal,
        [JsonProperty("REFERRED")]
        Referred,
        [JsonProperty("SOURCED")]
        Sourced,
        [JsonProperty("UNIVERSITY")]
        University,
    }

    public static class OriginExtension
    {
        public static string Value(this Origin value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static Origin ToEnum(this string value)
        {
            foreach(var field in typeof(Origin).GetFields())
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

                    if (enumVal is Origin)
                    {
                        return (Origin)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum Origin");
        }
    }

}