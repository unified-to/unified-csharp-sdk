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
    
    public class AccountingInvoice
    {

        [JsonProperty("attachments")]
        public List<AccountingAttachment>? Attachments { get; set; }

        [JsonProperty("balance_amount")]
        public double? BalanceAmount { get; set; }

        [JsonProperty("cancelled_at")]
        public DateTime? CancelledAt { get; set; }

        [JsonProperty("contact_id")]
        public string? ContactId { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("discount_amount")]
        public double? DiscountAmount { get; set; }

        [JsonProperty("due_at")]
        public DateTime? DueAt { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("invoice_at")]
        public DateTime? InvoiceAt { get; set; }

        [JsonProperty("invoice_number")]
        public string? InvoiceNumber { get; set; }

        [JsonProperty("lineitems")]
        public List<AccountingLineitem>? Lineitems { get; set; }

        [JsonProperty("notes")]
        public string? Notes { get; set; }

        [JsonProperty("paid_amount")]
        public double? PaidAmount { get; set; }

        [JsonProperty("paid_at")]
        public DateTime? PaidAt { get; set; }

        [JsonProperty("payment_collection_method")]
        public PaymentCollectionMethod? PaymentCollectionMethod { get; set; }

        [JsonProperty("posted_at")]
        public DateTime? PostedAt { get; set; }

        [JsonProperty("raw")]
        public Dictionary<string, object>? Raw { get; set; }

        [JsonProperty("refund_amount")]
        public double? RefundAmount { get; set; }

        [JsonProperty("refund_reason")]
        public string? RefundReason { get; set; }

        [JsonProperty("refunded_at")]
        public DateTime? RefundedAt { get; set; }

        [JsonProperty("status")]
        public AccountingInvoiceStatus? Status { get; set; }

        [JsonProperty("tax_amount")]
        public double? TaxAmount { get; set; }

        [JsonProperty("total_amount")]
        public double? TotalAmount { get; set; }

        [JsonProperty("type")]
        public AccountingInvoiceType? Type { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }
    }
}