
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace UnifiedCsharpSDK.Models.Components
{
    using Newtonsoft.Json;
    
    public class MarketingEmail
    {

        [JsonProperty("email")]
        public string Email { get; set; } = default!;

        [JsonProperty("type")]
        public MarketingEmailType? Type { get; set; }
    }
}