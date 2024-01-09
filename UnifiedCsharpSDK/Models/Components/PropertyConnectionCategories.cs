
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
    
    public enum PropertyConnectionCategories
    {
        [JsonProperty("passthrough")]
        Passthrough,
        [JsonProperty("hris")]
        Hris,
        [JsonProperty("ats")]
        Ats,
        [JsonProperty("auth")]
        Auth,
        [JsonProperty("crm")]
        Crm,
        [JsonProperty("enrich")]
        Enrich,
        [JsonProperty("martech")]
        Martech,
        [JsonProperty("ticketing")]
        Ticketing,
        [JsonProperty("uc")]
        Uc,
        [JsonProperty("accounting")]
        Accounting,
        [JsonProperty("storage")]
        Storage,
    }

    public static class PropertyConnectionCategoriesExtension
    {
        public static string Value(this PropertyConnectionCategories value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PropertyConnectionCategories ToEnum(this string value)
        {
            foreach(var field in typeof(PropertyConnectionCategories).GetFields())
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

                    if (enumVal is PropertyConnectionCategories)
                    {
                        return (PropertyConnectionCategories)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum PropertyConnectionCategories");
        }
    }

}