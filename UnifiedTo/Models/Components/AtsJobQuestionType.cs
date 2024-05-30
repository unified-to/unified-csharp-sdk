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
    using UnifiedTo.Utils;
    
    public enum AtsJobQuestionType
    {
        [JsonProperty("TEXT")]
        Text,
        [JsonProperty("NUMBER")]
        Number,
        [JsonProperty("DATE")]
        Date,
        [JsonProperty("BOOLEAN")]
        Boolean,
        [JsonProperty("MULTIPLE_CHOICE")]
        MultipleChoice,
        [JsonProperty("FILE")]
        File,
        [JsonProperty("TEXTAREA")]
        Textarea,
        [JsonProperty("MULTIPLE_SELECT")]
        MultipleSelect,
        [JsonProperty("UNIVERSITY")]
        University,
        [JsonProperty("YES_NO")]
        YesNo,
        [JsonProperty("CURRENCY")]
        Currency,
        [JsonProperty("URL")]
        Url,
    }

    public static class AtsJobQuestionTypeExtension
    {
        public static string Value(this AtsJobQuestionType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static AtsJobQuestionType ToEnum(this string value)
        {
            foreach(var field in typeof(AtsJobQuestionType).GetFields())
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

                    if (enumVal is AtsJobQuestionType)
                    {
                        return (AtsJobQuestionType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum AtsJobQuestionType");
        }
    }

}