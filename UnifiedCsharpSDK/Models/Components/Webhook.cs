
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace UnifiedCsharpSDK.Models.Components
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// A webhook is used to POST new/updated information to your server.
    /// </summary>
    public class Webhook
    {

        [JsonProperty("checked_at")]
        public DateTime? CheckedAt { get; set; }

        [JsonProperty("connection_id")]
        public string? ConnectionId { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("environment")]
        public string? Environment { get; set; }

        [JsonProperty("event")]
        public Models.Components.Event Event { get; set; } = default!;

        [JsonProperty("events")]
        public List<PropertyWebhookEvents> Events { get; set; } = default!;

        [JsonProperty("fields")]
        public string? Fields { get; set; }

        [JsonProperty("hook_url")]
        public string HookUrl { get; set; } = default!;

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("include_raw")]
        public bool? IncludeRaw { get; set; }

        [JsonProperty("integration_type")]
        public string? IntegrationType { get; set; }

        [JsonProperty("interval")]
        public double Interval { get; set; } = default!;

        [JsonProperty("is_healthy")]
        public bool? IsHealthy { get; set; }

        [JsonProperty("meta")]
        public PropertyWebhookMeta? Meta { get; set; }

        [JsonProperty("object_type")]
        public ObjectType ObjectType { get; set; } = default!;

        /// <summary>
        /// An array of the most revent virtual webhook runs
        /// </summary>
        [JsonProperty("runs")]
        public List<string>? Runs { get; set; }

        /// <summary>
        /// integration-specific subscriptions IDs
        /// </summary>
        [JsonProperty("subscriptions")]
        public List<string>? Subscriptions { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("webhook_type")]
        public WebhookWebhookType? WebhookType { get; set; }

        [JsonProperty("workspace_id")]
        public string? WorkspaceId { get; set; }
    }
}