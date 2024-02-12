
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
    
    public class Issue
    {

        [JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("resolution_time")]
        public double? ResolutionTime { get; set; }

        [JsonProperty("status")]
        public IssueStatus Status { get; set; } = default!;

        [JsonProperty("title")]
        public string Title { get; set; } = default!;

        [JsonProperty("type")]
        public IssueType Type { get; set; } = default!;

        [JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }

        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; set; } = default!;
    }
}