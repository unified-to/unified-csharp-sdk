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
    using UnifiedTo.Utils;
    
    public class GenaiModel
    {

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("has_temperature")]
        public bool? HasTemperature { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("max_tokens")]
        public double? MaxTokens { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("web_url")]
        public string? WebUrl { get; set; }
    }
}