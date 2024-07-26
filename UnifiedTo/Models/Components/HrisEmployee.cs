//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.com). DO NOT EDIT.
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
    
    public class HrisEmployee
    {

        [JsonProperty("address")]
        public PropertyHrisEmployeeAddress? Address { get; set; }

        [JsonProperty("bio")]
        public string? Bio { get; set; }

        [JsonProperty("company_id")]
        public string? CompanyId { get; set; }

        [JsonProperty("compensation")]
        public List<HrisCompensation>? Compensation { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("date_of_birth")]
        public DateTime? DateOfBirth { get; set; }

        [JsonProperty("department")]
        public string? Department { get; set; }

        [JsonProperty("division")]
        public string? Division { get; set; }

        [JsonProperty("emails")]
        public List<HrisEmail>? Emails { get; set; }

        [JsonProperty("employee_number")]
        public string? EmployeeNumber { get; set; }

        [JsonProperty("employee_roles")]
        public List<PropertyHrisEmployeeEmployeeRoles>? EmployeeRoles { get; set; }

        [JsonProperty("employment_status")]
        public EmploymentStatus? EmploymentStatus { get; set; }

        [JsonProperty("employment_type")]
        public HrisEmployeeEmploymentType? EmploymentType { get; set; }

        [JsonProperty("gender")]
        public HrisEmployeeGender? Gender { get; set; }

        [JsonProperty("hired_at")]
        public DateTime? HiredAt { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("image_url")]
        public string? ImageUrl { get; set; }

        [JsonProperty("language_locale")]
        public string? LanguageLocale { get; set; }

        [JsonProperty("location")]
        public string? Location { get; set; }

        [JsonProperty("manager_id")]
        public string? ManagerId { get; set; }

        [JsonProperty("marital_status")]
        public MaritalStatus? MaritalStatus { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("pronouns")]
        public string? Pronouns { get; set; }

        [JsonProperty("raw")]
        public Dictionary<string, object>? Raw { get; set; }

        [JsonProperty("salutation")]
        public string? Salutation { get; set; }

        [JsonProperty("ssn_sin")]
        public string? SsnSin { get; set; }

        [JsonProperty("telephones")]
        public List<HrisTelephone>? Telephones { get; set; }

        [JsonProperty("terminated_at")]
        public DateTime? TerminatedAt { get; set; }

        [JsonProperty("timezone")]
        public string? Timezone { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}