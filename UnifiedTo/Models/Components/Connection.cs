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
    /// A connection represents a specific authentication of an integration.
    /// </summary>
    public class Connection
    {

        /// <summary>
        /// An authentication object that represents a specific authorized user&apos;s connection to an integration.
        /// </summary>
        [JsonProperty("auth")]
        public PropertyConnectionAuth? Auth { get; set; }

        [JsonProperty("auth_aws_arn")]
        public string? AuthAwsArn { get; set; }

        /// <summary>
        /// The Integration categories that this connection supports
        /// </summary>
        [JsonProperty("categories")]
        public List<PropertyConnectionCategories> Categories { get; set; } = default!;

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("environment")]
        public string? Environment { get; set; } = "Production";

        [JsonProperty("external_xref")]
        public string? ExternalXref { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("integration_name")]
        public string? IntegrationName { get; set; }

        [JsonProperty("integration_type")]
        public string IntegrationType { get; set; } = default!;

        [JsonProperty("is_paused")]
        public bool? IsPaused { get; set; }

        [JsonProperty("last_healthy_at")]
        public DateTime? LastHealthyAt { get; set; }

        [JsonProperty("last_unhealthy_at")]
        public DateTime? LastUnhealthyAt { get; set; }

        [JsonProperty("permissions")]
        public List<PropertyConnectionPermissions> Permissions { get; set; } = default!;

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("workspace_id")]
        public string? WorkspaceId { get; set; }
    }
}