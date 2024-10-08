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
    using System.Collections.Generic;
    using UnifiedTo.Models.Components;
    using UnifiedTo.Utils;
    
    public class Issue
    {

        [JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("importance")]
        public double? Importance { get; set; }

        [JsonProperty("resolution_time")]
        public double? ResolutionTime { get; set; }

        [JsonProperty("size")]
        public double? Size { get; set; }

        [JsonProperty("status")]
        public IssueStatus Status { get; set; } = default!;

        [JsonProperty("ticket_ref")]
        public string TicketRef { get; set; } = default!;

        [JsonProperty("title")]
        public string Title { get; set; } = default!;

        [JsonProperty("type")]
        public List<string>? Type { get; set; }

        [JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }

        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; set; } = default!;
    }
}