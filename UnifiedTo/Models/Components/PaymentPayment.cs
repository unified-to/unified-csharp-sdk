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
    using UnifiedTo.Utils;
    
    public class PaymentPayment
    {

        [JsonProperty("account_id")]
        public string? AccountId { get; set; }

        [JsonProperty("contact_id")]
        public string? ContactId { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("currency")]
        public string? Currency { get; set; } = "USD";

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("invoice_id")]
        public string? InvoiceId { get; set; }

        [JsonProperty("notes")]
        public string? Notes { get; set; }

        [JsonProperty("payment_method")]
        public string? PaymentMethod { get; set; }

        [JsonProperty("raw")]
        public Dictionary<string, object>? Raw { get; set; }

        [JsonProperty("reference")]
        public string? Reference { get; set; }

        [JsonProperty("total_amount")]
        public double? TotalAmount { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}