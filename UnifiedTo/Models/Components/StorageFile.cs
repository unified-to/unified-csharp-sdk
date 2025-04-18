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
    
    public class StorageFile
    {

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("data")]
        public string? Data { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("download_url")]
        public string? DownloadUrl { get; set; }

        [JsonProperty("hash")]
        public string? Hash { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("mime_type")]
        public string? MimeType { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("parent_id")]
        public string? ParentId { get; set; }

        [JsonProperty("permissions")]
        public List<StoragePermission>? Permissions { get; set; }

        [JsonProperty("raw")]
        public Dictionary<string, object>? Raw { get; set; }

        [JsonProperty("size")]
        public double? Size { get; set; }

        [JsonProperty("type")]
        public StorageFileType? Type { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public string? UserId { get; set; }

        [JsonProperty("version")]
        public string? Version { get; set; }

        [JsonProperty("web_url")]
        public string? WebUrl { get; set; }
    }
}