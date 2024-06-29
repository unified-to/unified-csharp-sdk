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
    using UnifiedTo.Models.Components;
    using UnifiedTo.Utils;
    
    public class MessagingMessage
    {

        [JsonProperty("attachments")]
        public List<MessagingAttachment>? Attachments { get; set; }

        [JsonProperty("author_member")]
        public PropertyMessagingMessageAuthorMember? AuthorMember { get; set; }

        [JsonProperty("channel_id")]
        public string? ChannelId { get; set; }

        [JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        [JsonProperty("destination_members")]
        public List<MessagingMember>? DestinationMembers { get; set; }

        [JsonProperty("hidden_members")]
        public List<MessagingMember>? HiddenMembers { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("mentioned_members")]
        public List<MessagingMember>? MentionedMembers { get; set; }

        [JsonProperty("message")]
        public string? Message { get; set; }

        [JsonProperty("message_html")]
        public string? MessageHtml { get; set; }

        [JsonProperty("parent_message_id")]
        public string? ParentMessageId { get; set; }

        [JsonProperty("raw")]
        public Dictionary<string, object>? Raw { get; set; }

        [JsonProperty("subject")]
        public string? Subject { get; set; }

        [JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }

        [JsonProperty("web_url")]
        public string? WebUrl { get; set; }
    }
}