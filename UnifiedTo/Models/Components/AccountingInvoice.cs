
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Unified.To.Models.Components
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System;
    
    public class AccountingInvoice
    {

        [JsonProperty("balance_amount")]
        public double? BalanceAmount { get; set; }

        [JsonProperty("cancelled_at")]
        public DateTime? CancelledAt { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("customer_id")]
        public string? CustomerId { get; set; }

        [JsonProperty("discount_amount")]
        public double? DiscountAmount { get; set; }

        [JsonProperty("due_at")]
        public DateTime? DueAt { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

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

        [JsonProperty("raw")]
        public PropertyAccountingInvoiceRaw? Raw { get; set; }

        [JsonProperty("refund_amount")]
        public double? RefundAmount { get; set; }

        [JsonProperty("refund_reason")]
        public string? RefundReason { get; set; }

        [JsonProperty("refunded_at")]
        public DateTime? RefundedAt { get; set; }

        [JsonProperty("tax_amount")]
        public double? TaxAmount { get; set; }

        [JsonProperty("total_amount")]
        public double? TotalAmount { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}