//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace UnifiedTo.Models.Requests
{
    using Newtonsoft.Json;
    using System;
    using UnifiedTo.Utils;
    
    public enum Categories
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
        [JsonProperty("commerce")]
        Commerce,
        [JsonProperty("payment")]
        Payment,
        [JsonProperty("genai")]
        Genai,
        [JsonProperty("messaging")]
        Messaging,
        [JsonProperty("kms")]
        Kms,
        [JsonProperty("task")]
        Task,
        [JsonProperty("scim")]
        Scim,
        [JsonProperty("lms")]
        Lms,
        [JsonProperty("repo")]
        Repo,
        [JsonProperty("metadata")]
        Metadata,
        [JsonProperty("calendar")]
        Calendar,
    }

    public static class CategoriesExtension
    {
        public static string Value(this Categories value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static Categories ToEnum(this string value)
        {
            foreach(var field in typeof(Categories).GetFields())
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

                    if (enumVal is Categories)
                    {
                        return (Categories)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum Categories");
        }
    }

}