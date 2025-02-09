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
    
    public class AccountingJournal
    {

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// new field name
        /// </summary>
        [JsonProperty("lineitems")]
        public List<AccountingJournalLineitem>? Lineitems { get; set; }

        [JsonProperty("raw")]
        public AccountingJournalRaw? Raw { get; set; }

        [JsonProperty("reference")]
        public string? Reference { get; set; }

        [JsonProperty("tax_amount")]
        public double? TaxAmount { get; set; }

        [JsonProperty("taxrate_id")]
        public string? TaxrateId { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}