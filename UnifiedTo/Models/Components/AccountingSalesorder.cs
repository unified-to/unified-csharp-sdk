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
    using System;
    using System.Collections.Generic;
    using UnifiedTo.Models.Components;
    using UnifiedTo.Utils;
    
    public class AccountingSalesorder
    {

        [JsonProperty("account_id")]
        public string? AccountId { get; set; }

        [JsonProperty("billing_address")]
        public PropertyAccountingSalesorderBillingAddress? BillingAddress { get; set; }

        [JsonProperty("contact_id")]
        public string? ContactId { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("lineitems")]
        public List<AccountingLineitem>? Lineitems { get; set; }

        [JsonProperty("posted_at")]
        public DateTime? PostedAt { get; set; }

        [JsonProperty("raw")]
        public Dictionary<string, object>? Raw { get; set; }

        [JsonProperty("shipping_address")]
        public PropertyAccountingSalesorderShippingAddress? ShippingAddress { get; set; }

        [JsonProperty("status")]
        public AccountingSalesorderStatus? Status { get; set; }

        [JsonProperty("total_amount")]
        public double? TotalAmount { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}