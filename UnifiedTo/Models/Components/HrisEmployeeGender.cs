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
    
    public enum HrisEmployeeGender
    {
        [JsonProperty("MALE")]
        Male,
        [JsonProperty("FEMALE")]
        Female,
        [JsonProperty("INTERSEX")]
        Intersex,
        [JsonProperty("TRANS")]
        Trans,
        [JsonProperty("NON_BINARY")]
        NonBinary,
    }

    public static class HrisEmployeeGenderExtension
    {
        public static string Value(this HrisEmployeeGender value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static HrisEmployeeGender ToEnum(this string value)
        {
            foreach(var field in typeof(HrisEmployeeGender).GetFields())
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

                    if (enumVal is HrisEmployeeGender)
                    {
                        return (HrisEmployeeGender)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum HrisEmployeeGender");
        }
    }

}