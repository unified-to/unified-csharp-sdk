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
    using System.Collections.Generic;
    using UnifiedTo.Models.Components;
    using UnifiedTo.Utils;
    
    public class PropertyIntegrationSupportWebhookEvents
    {

        [JsonProperty("created")]
        public List<PropertyIntegrationSupportWebhookEventsCreated>? Created { get; set; }

        [JsonProperty("deleted")]
        public List<PropertyIntegrationSupportWebhookEventsDeleted>? Deleted { get; set; }

        [JsonProperty("updated")]
        public List<PropertyIntegrationSupportWebhookEventsUpdated>? Updated { get; set; }
    }
}