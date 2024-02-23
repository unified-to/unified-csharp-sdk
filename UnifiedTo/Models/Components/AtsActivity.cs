
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
    
    public class AtsActivity
    {

        [JsonProperty("application_id")]
        public string? ApplicationId { get; set; }

        [JsonProperty("candidate_id")]
        public string? CandidateId { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("document_id")]
        public string? DocumentId { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("interview_id")]
        public string? InterviewId { get; set; }

        [JsonProperty("is_private")]
        public bool? IsPrivate { get; set; }

        [JsonProperty("job_id")]
        public string? JobId { get; set; }

        [JsonProperty("raw")]
        public Dictionary<string, object>? Raw { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; } = default!;

        [JsonProperty("type")]
        public AtsActivityType? Type { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("user_ids")]
        public List<string>? UserIds { get; set; }
    }
}