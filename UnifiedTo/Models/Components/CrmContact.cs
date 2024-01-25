
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
    
    /// <summary>
    /// A contact represents a person that optionally is associated with a deal and/or a company
    /// </summary>
    public class CrmContact
    {

        [JsonProperty("address")]
        public PropertyCrmContactAddress? Address { get; set; }

        [JsonProperty("company")]
        public string? Company { get; set; }

        /// <summary>
        /// An array of company IDs associated with this contact
        /// </summary>
        [JsonProperty("company_ids")]
        public List<string>? CompanyIds { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// An array of deal IDs associated with this contact
        /// </summary>
        [JsonProperty("deal_ids")]
        public List<string>? DealIds { get; set; }

        /// <summary>
        /// An array of email addresses for this contact
        /// </summary>
        [JsonProperty("emails")]
        public List<CrmEmail>? Emails { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The raw data returned by the integration for this contact
        /// </summary>
        [JsonProperty("raw")]
        public PropertyCrmContactRaw? Raw { get; set; }

        /// <summary>
        /// An array of telephones for this contact
        /// </summary>
        [JsonProperty("telephones")]
        public List<CrmTelephone>? Telephones { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public string? UserId { get; set; }
    }
}