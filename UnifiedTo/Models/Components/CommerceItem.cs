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
    using System;
    using UnifiedTo.Models.Components;
    using UnifiedTo.Utils;
    
    public class CommerceItem
    {

        [JsonProperty("collection_ids")]
        public List<string>? CollectionIds { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("is_active")]
        public bool? IsActive { get; set; }

        [JsonProperty("is_taxable")]
        public bool? IsTaxable { get; set; }

        [JsonProperty("media")]
        public List<CommerceItemMedia>? Media { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("public_description")]
        public string? PublicDescription { get; set; }

        [JsonProperty("public_name")]
        public string? PublicName { get; set; }

        [JsonProperty("raw")]
        public Dictionary<string, object>? Raw { get; set; }

        [JsonProperty("slug")]
        public string? Slug { get; set; }

        [JsonProperty("tags")]
        public List<string>? Tags { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// first variant is the default variant
        /// </summary>
        [JsonProperty("variants")]
        public List<CommerceItemVariant>? Variants { get; set; }

        [JsonProperty("vendor_name")]
        public string? VendorName { get; set; }
    }
}