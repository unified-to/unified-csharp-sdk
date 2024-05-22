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
    
    /// <summary>
    /// A deal represents an opportunity with companies and/or contacts
    /// </summary>
    public class CrmDeal
    {

        [JsonProperty("amount")]
        public double? Amount { get; set; }

        [JsonProperty("closed_at")]
        public DateTime? ClosedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("lost_reason")]
        public string? LostReason { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("pipeline")]
        public string? Pipeline { get; set; }

        [JsonProperty("probability")]
        public double? Probability { get; set; }

        /// <summary>
        /// The raw data returned by the integration for this deal
        /// </summary>
        [JsonProperty("raw")]
        public Dictionary<string, object>? Raw { get; set; }

        [JsonProperty("source")]
        public string? Source { get; set; }

        [JsonProperty("stage")]
        public string? Stage { get; set; }

        [JsonProperty("tags")]
        public List<string>? Tags { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public string? UserId { get; set; }

        [JsonProperty("won_reason")]
        public string? WonReason { get; set; }
    }
}