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
    
    public class Group
    {

        [JsonProperty("displayName")]
        public string? DisplayName { get; set; }

        [JsonProperty("externalId")]
        public string? ExternalId { get; set; }

        [JsonProperty("groupType")]
        public string? GroupType { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("members")]
        public List<Undefined>? Members { get; set; }

        [JsonProperty("meta")]
        public PropertyGroupMeta? Meta { get; set; }

        [JsonProperty("schemas")]
        public List<PropertyGroupSchemas>? Schemas { get; set; }
    }
}