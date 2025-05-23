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
    
    public class AtsApplication
    {

        [JsonProperty("answers")]
        public List<AtsApplicationAnswer>? Answers { get; set; }

        [JsonProperty("applied_at")]
        public DateTime? AppliedAt { get; set; }

        [JsonProperty("candidate_id")]
        public string? CandidateId { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("hired_at")]
        public DateTime? HiredAt { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("job_id")]
        public string? JobId { get; set; }

        [JsonProperty("metadata")]
        public List<AtsMetadata>? Metadata { get; set; }

        [JsonProperty("offers")]
        public List<AtsOffer>? Offers { get; set; }

        [JsonProperty("original_status")]
        public string? OriginalStatus { get; set; }

        [JsonProperty("raw")]
        public Dictionary<string, object>? Raw { get; set; }

        [JsonProperty("rejected_at")]
        public DateTime? RejectedAt { get; set; }

        [JsonProperty("rejected_reason")]
        public string? RejectedReason { get; set; }

        [JsonProperty("source")]
        public string? Source { get; set; }

        [JsonProperty("status")]
        public AtsApplicationStatus? Status { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}