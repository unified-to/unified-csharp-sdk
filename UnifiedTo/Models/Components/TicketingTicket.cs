
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
    
    public class TicketingTicket
    {

        [JsonProperty("category")]
        public string? Category { get; set; }

        [JsonProperty("closed_at")]
        public DateTime? ClosedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("customer_id")]
        public string? CustomerId { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("priority")]
        public string? Priority { get; set; }

        [JsonProperty("raw")]
        public Dictionary<string, object>? Raw { get; set; }

        [JsonProperty("source")]
        public string? Source { get; set; }

        [JsonProperty("source_ref")]
        public string? SourceRef { get; set; }

        [JsonProperty("status")]
        public TicketingTicketStatus? Status { get; set; }

        [JsonProperty("subject")]
        public string? Subject { get; set; }

        [JsonProperty("tags")]
        public List<string>? Tags { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public string? UserId { get; set; }
    }
}