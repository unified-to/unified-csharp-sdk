
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
    using System;
    using UnifiedTo.Models.Components;
    using UnifiedTo.Utils;
    
    public class HrisPayslip
    {

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("details")]
        public List<HrisPayslipDetail>? Details { get; set; }

        [JsonProperty("end_at")]
        public DateTime? EndAt { get; set; }

        [JsonProperty("gross_amount")]
        public double? GrossAmount { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("net_amount")]
        public double? NetAmount { get; set; }

        [JsonProperty("paid_at")]
        public DateTime? PaidAt { get; set; }

        [JsonProperty("payment_type")]
        public PaymentType? PaymentType { get; set; }

        [JsonProperty("raw")]
        public Dictionary<string, object> Raw { get; set; } = default!;

        [JsonProperty("start_at")]
        public DateTime? StartAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; } = default!;
    }
}