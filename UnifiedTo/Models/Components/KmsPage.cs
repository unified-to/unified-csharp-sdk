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
    using System;
    using UnifiedTo.Models.Components;
    using UnifiedTo.Utils;
    
    public class KmsPage
    {

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; } = default!;

        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        [JsonProperty("is_active")]
        public bool? IsActive { get; set; }

        [JsonProperty("parent_page_id")]
        public string? ParentPageId { get; set; }

        [JsonProperty("raw")]
        public Dictionary<string, object>? Raw { get; set; }

        [JsonProperty("space_id")]
        public string SpaceId { get; set; } = default!;

        [JsonProperty("title")]
        public string Title { get; set; } = default!;

        [JsonProperty("type")]
        public KmsPageType Type { get; set; } = default!;

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public string? UserId { get; set; }
    }
}