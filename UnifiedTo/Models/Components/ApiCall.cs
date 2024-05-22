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
    using System;
    using UnifiedTo.Models.Components;
    using UnifiedTo.Utils;
    
    public class ApiCall
    {

        [JsonProperty("connection_id")]
        public string? ConnectionId { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("environment")]
        public string? Environment { get; set; } = "Production";

        [JsonProperty("error")]
        public string? Error { get; set; }

        [JsonProperty("external_xref")]
        public string? ExternalXref { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("integration_type")]
        public string IntegrationType { get; set; } = default!;

        [JsonProperty("ip_address")]
        public string? IpAddress { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; } = default!;

        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        [JsonProperty("path")]
        public string Path { get; set; } = default!;

        [JsonProperty("size")]
        public double? Size { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; } = default!;

        [JsonProperty("type")]
        public ApiCallType Type { get; set; } = default!;

        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; set; } = default!;
    }
}