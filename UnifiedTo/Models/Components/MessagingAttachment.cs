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
    using UnifiedTo.Utils;
    
    public class MessagingAttachment
    {

        [JsonProperty("content_identifier")]
        public string? ContentIdentifier { get; set; }

        [JsonProperty("content_type")]
        public string? ContentType { get; set; }

        [JsonProperty("download_url")]
        public string? DownloadUrl { get; set; }

        [JsonProperty("filename")]
        public string? Filename { get; set; }

        [JsonProperty("message_id")]
        public string? MessageId { get; set; }

        [JsonProperty("size")]
        public double? Size { get; set; }
    }
}