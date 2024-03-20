
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
    
    /// <summary>
    /// A member represents a person
    /// </summary>
    public class MarketingMember
    {

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// An array of email addresses for this member
        /// </summary>
        [JsonProperty("emails")]
        public List<MarketingEmail>? Emails { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// An array of list IDs associated with this member
        /// </summary>
        [JsonProperty("list_ids")]
        public List<string>? ListIds { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The raw data returned by the integration for this member
        /// </summary>
        [JsonProperty("raw")]
        public Dictionary<string, object>? Raw { get; set; }

        /// <summary>
        /// An array of tags associated with this member
        /// </summary>
        [JsonProperty("tags")]
        public List<string>? Tags { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}