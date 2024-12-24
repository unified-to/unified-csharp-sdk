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
    
    /// <summary>
    /// A contact represents a person that optionally is associated with a call
    /// </summary>
    public class UcContact
    {

        [JsonProperty("company")]
        public string? Company { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// An array of email addresses for this contact
        /// </summary>
        [JsonProperty("emails")]
        public List<UcEmail>? Emails { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The raw data returned by the integration for this contact
        /// </summary>
        [JsonProperty("raw")]
        public Dictionary<string, object>? Raw { get; set; }

        /// <summary>
        /// An array of telephones for this contact
        /// </summary>
        [JsonProperty("telephones")]
        public List<UcTelephone>? Telephones { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}