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
    
    public class CommerceItemMedia
    {

        [JsonProperty("alt")]
        public string? Alt { get; set; }

        [JsonProperty("height")]
        public double? Height { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("metadata")]
        public List<CommerceItemMetadata>? Metadata { get; set; }

        [JsonProperty("position")]
        public double? Position { get; set; }

        [JsonProperty("type")]
        public CommerceItemMediaType? Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; } = default!;

        [JsonProperty("width")]
        public double? Width { get; set; }
    }
}