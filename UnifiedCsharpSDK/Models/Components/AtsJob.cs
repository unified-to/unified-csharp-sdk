
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
    
    public class AtsJob
    {

        [JsonProperty("addresses")]
        public List<AtsAddress>? Addresses { get; set; }

        [JsonProperty("closed_at")]
        public DateTime? ClosedAt { get; set; }

        [JsonProperty("compensation")]
        public List<AtsCompensation>? Compensation { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("departments")]
        public List<string>? Departments { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("employment_type")]
        public EmploymentType? EmploymentType { get; set; }

        [JsonProperty("hiring_manager_ids")]
        public List<string>? HiringManagerIds { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("language_locale")]
        public string? LanguageLocale { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("public_job_urls")]
        public List<string>? PublicJobUrls { get; set; }

        [JsonProperty("raw")]
        public PropertyAtsJobRaw? Raw { get; set; }

        [JsonProperty("recruiter_ids")]
        public List<string>? RecruiterIds { get; set; }

        [JsonProperty("remote")]
        public bool? Remote { get; set; }

        [JsonProperty("status")]
        public AtsJobStatus? Status { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}