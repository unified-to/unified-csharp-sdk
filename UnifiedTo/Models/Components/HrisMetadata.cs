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
    using UnifiedTo.Models.Components;
    using UnifiedTo.Utils;
    
    public class HrisMetadata
    {

        [JsonProperty("extra_data")]
        public HrisMetadataExtraData? ExtraData { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("key")]
        public string? Key { get; set; }

        [JsonProperty("namespace")]
        public string? Namespace { get; set; }

        [JsonProperty("slug")]
        public string? Slug { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("value")]
        public HrisMetadataValue? Value { get; set; }
    }
}