
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
    
    public class UcCall
    {

        [JsonProperty("contact_id")]
        public string? ContactId { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("end_at")]
        public DateTime? EndAt { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The raw data returned by the integration for this call
        /// </summary>
        [JsonProperty("raw")]
        public Dictionary<string, object>? Raw { get; set; }

        [JsonProperty("start_at")]
        public DateTime? StartAt { get; set; }

        /// <summary>
        /// The telephone number called
        /// </summary>
        [JsonProperty("telephone")]
        public PropertyUcCallTelephone? Telephone { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public string? UserId { get; set; }
    }
}