
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
    
    public class AtsStatus
    {

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("original_status")]
        public string? OriginalStatus { get; set; }

        [JsonProperty("raw")]
        public PropertyAtsStatusRaw? Raw { get; set; }

        [JsonProperty("status")]
        public AtsStatusStatus? Status { get; set; }
    }
}