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
    
    public enum ListInstructorId
    {
        [JsonProperty("supported-required")]
        SupportedRequired,
        [JsonProperty("supported")]
        Supported,
        [JsonProperty("not-supported")]
        NotSupported,
    }

    public static class ListInstructorIdExtension
    {
        public static string Value(this ListInstructorId value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ListInstructorId ToEnum(this string value)
        {
            foreach(var field in typeof(ListInstructorId).GetFields())
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

                    if (enumVal is ListInstructorId)
                    {
                        return (ListInstructorId)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ListInstructorId");
        }
    }

}