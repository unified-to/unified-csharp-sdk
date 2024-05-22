//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
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
    using System;
    using UnifiedTo.Utils;
    
    public class KmsSpace
    {

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        [JsonProperty("is_active")]
        public bool? IsActive { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        [JsonProperty("parent_space_id")]
        public string? ParentSpaceId { get; set; } = "sp";

        [JsonProperty("raw")]
        public Dictionary<string, object>? Raw { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public string? UserId { get; set; }
    }
}