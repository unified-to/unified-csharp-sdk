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
    
    public class LmsMedia
    {

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        [JsonProperty("type")]
        public LmsMediaType? Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; } = default!;
    }
}