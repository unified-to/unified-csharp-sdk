//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.com). DO NOT EDIT.
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
    
    public class AtsScorecardQuestion
    {

        [JsonProperty("answer")]
        public string? Answer { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; } = default!;
    }
}