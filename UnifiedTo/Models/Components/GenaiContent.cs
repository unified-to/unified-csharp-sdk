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
    
    public class GenaiContent
    {

        [JsonProperty("content")]
        public string Content { get; set; } = default!;

        [JsonProperty("role")]
        public Role? Role { get; set; }
    }
}