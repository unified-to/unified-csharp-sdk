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
    
    public class LmsTelephone
    {

        [JsonProperty("telephone")]
        public string Telephone { get; set; } = default!;

        [JsonProperty("type")]
        public LmsTelephoneType? Type { get; set; }
    }
}