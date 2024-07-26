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
    
    /// <summary>
    /// A company object from an enrichment integration
    /// </summary>
    public class EnrichCompany
    {

        /// <summary>
        /// The address of the company
        /// </summary>
        [JsonProperty("address")]
        public PropertyEnrichCompanyAddress? Address { get; set; }

        [JsonProperty("alexa_rank")]
        public double? AlexaRank { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("crunchbase_url")]
        public string? CrunchbaseUrl { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("domain")]
        public string? Domain { get; set; }

        [JsonProperty("employees")]
        public string? Employees { get; set; }

        [JsonProperty("exchange")]
        public string? Exchange { get; set; }

        [JsonProperty("facebook_url")]
        public string? FacebookUrl { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("industry")]
        public string? Industry { get; set; }

        [JsonProperty("instagram_url")]
        public string? InstagramUrl { get; set; }

        [JsonProperty("linkedin_url")]
        public string? LinkedinUrl { get; set; }

        [JsonProperty("logo_url")]
        public string? LogoUrl { get; set; }

        [JsonProperty("naics_code")]
        public double? NaicsCode { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The raw data returned by the integration for this company
        /// </summary>
        [JsonProperty("raw")]
        public Dictionary<string, object>? Raw { get; set; }

        [JsonProperty("revenue")]
        public string? Revenue { get; set; }

        [JsonProperty("sic_code")]
        public double? SicCode { get; set; }

        [JsonProperty("stock")]
        public string? Stock { get; set; }

        /// <summary>
        /// An array of telephones for this company
        /// </summary>
        [JsonProperty("telephones")]
        public List<EnrichTelephone>? Telephones { get; set; }

        [JsonProperty("twitter_handle")]
        public string? TwitterHandle { get; set; }

        [JsonProperty("twitter_url")]
        public string? TwitterUrl { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("year_founded")]
        public double? YearFounded { get; set; }

        [JsonProperty("yelp_url")]
        public string? YelpUrl { get; set; }

        [JsonProperty("youtube_url")]
        public string? YoutubeUrl { get; set; }
    }
}