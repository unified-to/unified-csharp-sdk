
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
    using System.Collections.Generic;
    using UnifiedTo.Models.Components;
    using UnifiedTo.Utils;
    
    public class PaymentPayout
    {

        [JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("notes")]
        public string? Notes { get; set; }

        [JsonProperty("raw")]
        public Dictionary<string, object>? Raw { get; set; }

        [JsonProperty("status")]
        public PaymentPayoutStatus? Status { get; set; }

        [JsonProperty("total_amount")]
        public double TotalAmount { get; set; } = default!;

        [JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }
    }
}