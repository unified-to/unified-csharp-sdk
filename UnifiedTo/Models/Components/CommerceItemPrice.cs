
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
    
    public class CommerceItemPrice
    {

        [JsonProperty("compare_at_price")]
        public double? CompareAtPrice { get; set; }

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; } = default!;
    }
}