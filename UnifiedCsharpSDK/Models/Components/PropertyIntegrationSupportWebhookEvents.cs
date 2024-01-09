
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
    
    public enum PropertyIntegrationSupportWebhookEvents
    {
        [JsonProperty("updated")]
        Updated,
        [JsonProperty("created")]
        Created,
    }

    public static class PropertyIntegrationSupportWebhookEventsExtension
    {
        public static string Value(this PropertyIntegrationSupportWebhookEvents value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PropertyIntegrationSupportWebhookEvents ToEnum(this string value)
        {
            foreach(var field in typeof(PropertyIntegrationSupportWebhookEvents).GetFields())
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

                    if (enumVal is PropertyIntegrationSupportWebhookEvents)
                    {
                        return (PropertyIntegrationSupportWebhookEvents)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum PropertyIntegrationSupportWebhookEvents");
        }
    }

}