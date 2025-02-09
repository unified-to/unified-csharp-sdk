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
    
    public class AtsOffer
    {

        [JsonProperty("accepted_at")]
        public DateTime? AcceptedAt { get; set; }

        /// <summary>
        /// compensation details for the offer
        /// </summary>
        [JsonProperty("compensation")]
        public List<AtsCompensation>? Compensation { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("creator_user_id")]
        public string? CreatorUserId { get; set; }

        [JsonProperty("employee_user_id")]
        public string? EmployeeUserId { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("raw")]
        public AtsOfferRaw? Raw { get; set; }

        [JsonProperty("rejected_at")]
        public DateTime? RejectedAt { get; set; }

        [JsonProperty("sent_at")]
        public DateTime? SentAt { get; set; }

        [JsonProperty("start_at")]
        public DateTime? StartAt { get; set; }

        [JsonProperty("status")]
        public AtsOfferStatus? Status { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}