
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
    
    public class HrisGroup
    {

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("is_active")]
        public bool? IsActive { get; set; }

        [JsonProperty("manager_ids")]
        public List<string>? ManagerIds { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("parent_id")]
        public string? ParentId { get; set; }

        [JsonProperty("raw")]
        public PropertyHrisGroupRaw? Raw { get; set; }

        [JsonProperty("type")]
        public HrisGroupType? Type { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("user_ids")]
        public List<string>? UserIds { get; set; }
    }
}