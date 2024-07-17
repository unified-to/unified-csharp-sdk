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
    using System;
    using UnifiedTo.Utils;
    
    public class PaymentLinkLineitem
    {

        [JsonProperty("account_id")]
        public string? AccountId { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("discount_amount")]
        public double? DiscountAmount { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("item_description")]
        public string? ItemDescription { get; set; }

        [JsonProperty("item_id")]
        public string? ItemId { get; set; }

        [JsonProperty("item_name")]
        public string? ItemName { get; set; }

        [JsonProperty("item_sku")]
        public string? ItemSku { get; set; }

        [JsonProperty("notes")]
        public string? Notes { get; set; }

        [JsonProperty("refund_amount")]
        public double? RefundAmount { get; set; }

        [JsonProperty("refunded_at")]
        public DateTime? RefundedAt { get; set; }

        [JsonProperty("tax_amount")]
        public double? TaxAmount { get; set; }

        [JsonProperty("taxrate_id")]
        public string? TaxrateId { get; set; }

        [JsonProperty("total_amount")]
        public double? TotalAmount { get; set; }

        [JsonProperty("unit_amount")]
        public double? UnitAmount { get; set; }

        [JsonProperty("unit_quantity")]
        public double? UnitQuantity { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}