
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
    using UnifiedTo.Models.Components;
    
    public class AtsTelephone
    {

        [JsonProperty("telephone")]
        public string Telephone { get; set; } = default!;

        [JsonProperty("type")]
        public AtsTelephoneType? Type { get; set; }
    }
}