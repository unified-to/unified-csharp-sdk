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
    
    public class ScimGroup
    {

        [JsonProperty("displayName")]
        public string DisplayName { get; set; } = default!;

        [JsonProperty("externalId")]
        public string? ExternalId { get; set; }

        [JsonProperty("groupType")]
        public string? GroupType { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// An array of members
        /// </summary>
        [JsonProperty("members")]
        public List<ScimGroupMember>? Members { get; set; }

        [JsonProperty("meta")]
        public PropertyScimGroupMeta? Meta { get; set; }

        /// <summary>
        /// Array of schema URIs
        /// </summary>
        [JsonProperty("schemas")]
        public List<PropertyScimGroupSchemas>? Schemas { get; set; }
    }
}