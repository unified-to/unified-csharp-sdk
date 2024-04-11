
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
    using UnifiedTo.Utils;
    
    public class HrisTimeoff
    {

        [JsonProperty("approved_at")]
        public DateTime? ApprovedAt { get; set; }

        [JsonProperty("approver_user_id")]
        public string? ApproverUserId { get; set; }

        [JsonProperty("comments")]
        public string? Comments { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("end_at")]
        public DateTime? EndAt { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("raw")]
        public Dictionary<string, object>? Raw { get; set; }

        [JsonProperty("start_at")]
        public DateTime StartAt { get; set; } = default!;

        [JsonProperty("status")]
        public HrisTimeoffStatus? Status { get; set; }

        [JsonProperty("type")]
        public HrisTimeoffType? Type { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; } = default!;
    }
}