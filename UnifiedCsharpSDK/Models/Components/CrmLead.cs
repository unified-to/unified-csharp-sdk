
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
    
    public class CrmLead
    {

        [JsonProperty("address")]
        public PropertyCrmLeadAddress? Address { get; set; }

        [JsonProperty("company_id")]
        public string? CompanyId { get; set; }

        [JsonProperty("contact_id")]
        public string? ContactId { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("creator_user_id")]
        public string? CreatorUserId { get; set; }

        [JsonProperty("emails")]
        public List<CrmEmail>? Emails { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("is_active")]
        public bool? IsActive { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("raw")]
        public PropertyCrmLeadRaw? Raw { get; set; }

        [JsonProperty("source")]
        public string? Source { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("telephones")]
        public List<CrmTelephone>? Telephones { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public string? UserId { get; set; }
    }
}