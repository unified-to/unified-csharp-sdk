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
    
    public class AtsScorecard
    {

        [JsonProperty("application_id")]
        public string? ApplicationId { get; set; }

        [JsonProperty("candidate_id")]
        public string? CandidateId { get; set; }

        [JsonProperty("comment")]
        public string? Comment { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("interview_id")]
        public string? InterviewId { get; set; }

        [JsonProperty("interviewer_id")]
        public string? InterviewerId { get; set; }

        [JsonProperty("job_id")]
        public string? JobId { get; set; }

        [JsonProperty("questions")]
        public List<AtsScorecardQuestion>? Questions { get; set; }

        [JsonProperty("raw")]
        public Dictionary<string, object>? Raw { get; set; }

        [JsonProperty("recommendation")]
        public Recommendation? Recommendation { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}