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
    
    public class AtsJob
    {

        [JsonProperty("addresses")]
        public List<AtsAddress>? Addresses { get; set; }

        [JsonProperty("closed_at")]
        public DateTime? ClosedAt { get; set; }

        [JsonProperty("company_id")]
        public string? CompanyId { get; set; }

        [JsonProperty("compensation")]
        public List<AtsCompensation>? Compensation { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// @deprecated Use `groups` instead
        /// </summary>
        [JsonProperty("departments")]
        public List<string>? Departments { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("employment_type")]
        public EmploymentType? EmploymentType { get; set; }

        /// <summary>
        /// The departments/divisions/teams that this job belongs to
        /// </summary>
        [JsonProperty("groups")]
        public List<AtsGroup>? Groups { get; set; }

        [JsonProperty("hiring_manager_ids")]
        public List<string>? HiringManagerIds { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("language_locale")]
        public string? LanguageLocale { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("number_of_openings")]
        public double? NumberOfOpenings { get; set; }

        /// <summary>
        /// Public job postings
        /// </summary>
        [JsonProperty("postings")]
        public List<AtsJobPosting>? Postings { get; set; }

        /// <summary>
        /// URLs for pages containing public listings for the job
        /// </summary>
        [JsonProperty("public_job_urls")]
        public List<string>? PublicJobUrls { get; set; }

        [JsonProperty("questions")]
        public List<AtsJobQuestion>? Questions { get; set; }

        [JsonProperty("raw")]
        public AtsJobRaw? Raw { get; set; }

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