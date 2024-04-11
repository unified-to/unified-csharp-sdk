
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
    
    public enum PropertyCrmEventTaskStatus
    {
        [JsonProperty("COMPLETED")]
        Completed,
        [JsonProperty("NOT_STARTED")]
        NotStarted,
        [JsonProperty("WORK_IN_PROGRESS")]
        WorkInProgress,
        [JsonProperty("DEFERRED")]
        Deferred,
    }

    public static class PropertyCrmEventTaskStatusExtension
    {
        public static string Value(this PropertyCrmEventTaskStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PropertyCrmEventTaskStatus ToEnum(this string value)
        {
            foreach(var field in typeof(PropertyCrmEventTaskStatus).GetFields())
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

                    if (enumVal is PropertyCrmEventTaskStatus)
                    {
                        return (PropertyCrmEventTaskStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum PropertyCrmEventTaskStatus");
        }
    }

}