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
    
    public enum AtsApplicationStatus
    {
        [JsonProperty("NEW")]
        New,
        [JsonProperty("REVIEWING")]
        Reviewing,
        [JsonProperty("SCREENING")]
        Screening,
        [JsonProperty("SUBMITTED")]
        Submitted,
        [JsonProperty("FIRST_INTERVIEW")]
        FirstInterview,
        [JsonProperty("SECOND_INTERVIEW")]
        SecondInterview,
        [JsonProperty("THIRD_INTERVIEW")]
        ThirdInterview,
        [JsonProperty("BACKGROUND_CHECK")]
        BackgroundCheck,
        [JsonProperty("OFFERED")]
        Offered,
        [JsonProperty("ACCEPTED")]
        Accepted,
        [JsonProperty("HIRED")]
        Hired,
        [JsonProperty("REJECTED")]
        Rejected,
        [JsonProperty("WITHDRAWN")]
        Withdrawn,
    }

    public static class AtsApplicationStatusExtension
    {
        public static string Value(this AtsApplicationStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static AtsApplicationStatus ToEnum(this string value)
        {
            foreach(var field in typeof(AtsApplicationStatus).GetFields())
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

                    if (enumVal is AtsApplicationStatus)
                    {
                        return (AtsApplicationStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum AtsApplicationStatus");
        }
    }

}