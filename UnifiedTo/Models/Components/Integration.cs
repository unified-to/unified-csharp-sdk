
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
    
    /// <summary>
    /// Informational object for supported integrations.
    /// </summary>
    public class Integration
    {

        [JsonProperty("api_docs_url")]
        public string? ApiDocsUrl { get; set; }

        [JsonProperty("beta")]
        public bool? Beta { get; set; }

        /// <summary>
        /// The categories of support solutions that this integration has
        /// </summary>
        [JsonProperty("categories")]
        public List<PropertyIntegrationCategories> Categories { get; set; } = default!;

        [JsonProperty("color")]
        public string? Color { get; set; }

        [JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        [JsonProperty("fa_icon")]
        public string? FaIcon { get; set; }

        [JsonProperty("in_progress")]
        public bool InProgress { get; set; } = default!;

        [JsonProperty("is_active")]
        public bool? IsActive { get; set; }

        [JsonProperty("logo_url")]
        public string? LogoUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        [JsonProperty("rate_limit_description")]
        public string? RateLimitDescription { get; set; }

        [JsonProperty("support")]
        public Dictionary<string, IntegrationSupport> Support { get; set; } = default!;

        [JsonProperty("tested_at")]
        public DateTime? TestedAt { get; set; }

        [JsonProperty("text_color")]
        public string? TextColor { get; set; }

        /// <summary>
        /// instructions for the user on how to find the token/key
        /// </summary>
        [JsonProperty("token_instructions")]
        public List<string>? TokenInstructions { get; set; }

        /// <summary>
        /// if auth_types = &apos;token&apos;
        /// </summary>
        [JsonProperty("token_names")]
        public List<string>? TokenNames { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; } = default!;

        [JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }

        [JsonProperty("web_url")]
        public string? WebUrl { get; set; }
    }
}