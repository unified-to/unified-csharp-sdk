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
    
    public class AccountingTransaction
    {

        [JsonProperty("account_id")]
        public string? AccountId { get; set; }

        [JsonProperty("contact_id")]
        public string? ContactId { get; set; }

        [JsonProperty("contacts")]
        public List<AccountingTransactionContact>? Contacts { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("customer_message")]
        public string? CustomerMessage { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("lineitems")]
        public List<AccountingTransactionLineItem>? Lineitems { get; set; }

        [JsonProperty("memo")]
        public string? Memo { get; set; }

        [JsonProperty("payment_method")]
        public string? PaymentMethod { get; set; }

        [JsonProperty("payment_terms")]
        public string? PaymentTerms { get; set; }

        [JsonProperty("raw")]
        public Dictionary<string, object>? Raw { get; set; }

        [JsonProperty("reference")]
        public string? Reference { get; set; }

        [JsonProperty("split_account_id")]
        public string? SplitAccountId { get; set; }

        [JsonProperty("sub_total_amount")]
        public double? SubTotalAmount { get; set; }

        [JsonProperty("tax_amount")]
        public double? TaxAmount { get; set; }

        [JsonProperty("total_amount")]
        public double? TotalAmount { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}