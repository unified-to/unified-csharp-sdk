
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace UnifiedCsharpSDK.Models.Components
{
    using Newtonsoft.Json;
    using System;
    
    public enum EnrichTelephoneType
    {
        [JsonProperty("WORK")]
        Work,
        [JsonProperty("HOME")]
        Home,
        [JsonProperty("OTHER")]
        Other,
        [JsonProperty("FAX")]
        Fax,
        [JsonProperty("MOBILE")]
        Mobile,
    }

    public static class EnrichTelephoneTypeExtension
    {
        public static string Value(this EnrichTelephoneType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static EnrichTelephoneType ToEnum(this string value)
        {
            foreach(var field in typeof(EnrichTelephoneType).GetFields())
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

                    if (enumVal is EnrichTelephoneType)
                    {
                        return (EnrichTelephoneType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum EnrichTelephoneType");
        }
    }
}