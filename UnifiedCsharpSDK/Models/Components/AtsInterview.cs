
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace UnifiedCsharpSDK.Models.Components
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System;
    
    public class AtsInterview
    {

        [JsonProperty("application_id")]
        public string? ApplicationId { get; set; }

        [JsonProperty("candidate_id")]
        public string? CandidateId { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("end_at")]
        public DateTime? EndAt { get; set; }

        [JsonProperty("external_event_xref")]
        public string? ExternalEventXref { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("job_id")]
        public string? JobId { get; set; }

        [JsonProperty("location")]
        public string? Location { get; set; }

        [JsonProperty("raw")]
        public PropertyAtsInterviewRaw? Raw { get; set; }

        [JsonProperty("start_at")]
        public DateTime? StartAt { get; set; }

        [JsonProperty("status")]
        public AtsInterviewStatus? Status { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("user_ids")]
        public List<string>? UserIds { get; set; }
    }
}