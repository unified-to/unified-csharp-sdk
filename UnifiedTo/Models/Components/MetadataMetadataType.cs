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
    
    public enum MetadataMetadataType
    {
        [JsonProperty("TEXT")]
        Text,
        [JsonProperty("NUMBER")]
        Number,
        [JsonProperty("DATE")]
        Date,
        [JsonProperty("BOOLEAN")]
        Boolean,
        [JsonProperty("FILE")]
        File,
        [JsonProperty("TEXTAREA")]
        Textarea,
        [JsonProperty("SINGLE_SELECT")]
        SingleSelect,
        [JsonProperty("MULTIPLE_SELECT")]
        MultipleSelect,
        [JsonProperty("MEASUREMENT")]
        Measurement,
        [JsonProperty("PRICE")]
        Price,
        [JsonProperty("YES_NO")]
        YesNo,
        [JsonProperty("CURRENCY")]
        Currency,
        [JsonProperty("URL")]
        Url,
    }

    public static class MetadataMetadataTypeExtension
    {
        public static string Value(this MetadataMetadataType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static MetadataMetadataType ToEnum(this string value)
        {
            foreach(var field in typeof(MetadataMetadataType).GetFields())
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

                    if (enumVal is MetadataMetadataType)
                    {
                        return (MetadataMetadataType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum MetadataMetadataType");
        }
    }

}