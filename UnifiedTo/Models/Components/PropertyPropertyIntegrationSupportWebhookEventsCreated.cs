//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.com). DO NOT EDIT.
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
    
    public enum PropertyPropertyIntegrationSupportWebhookEventsCreated
    {
        [JsonProperty("virtual")]
        Virtual,
        [JsonProperty("native")]
        Native,
    }

    public static class PropertyPropertyIntegrationSupportWebhookEventsCreatedExtension
    {
        public static string Value(this PropertyPropertyIntegrationSupportWebhookEventsCreated value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PropertyPropertyIntegrationSupportWebhookEventsCreated ToEnum(this string value)
        {
            foreach(var field in typeof(PropertyPropertyIntegrationSupportWebhookEventsCreated).GetFields())
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

                    if (enumVal is PropertyPropertyIntegrationSupportWebhookEventsCreated)
                    {
                        return (PropertyPropertyIntegrationSupportWebhookEventsCreated)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum PropertyPropertyIntegrationSupportWebhookEventsCreated");
        }
    }

}