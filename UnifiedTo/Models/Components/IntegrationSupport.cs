//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.com). DO NOT EDIT.
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
    
    public class IntegrationSupport
    {

        [JsonProperty("from_webhook")]
        public FromWebhook? FromWebhook { get; set; }

        [JsonProperty("inbound_fields")]
        public Dictionary<string, object>? InboundFields { get; set; }

        [JsonProperty("list_account_id")]
        public ListAccountId? ListAccountId { get; set; }

        [JsonProperty("list_application_id")]
        public ListApplicationId? ListApplicationId { get; set; }

        [JsonProperty("list_candidate_id")]
        public ListCandidateId? ListCandidateId { get; set; }

        [JsonProperty("list_channel_id")]
        public ListChannelId? ListChannelId { get; set; }

        [JsonProperty("list_collection_id")]
        public ListCollectionId? ListCollectionId { get; set; }

        [JsonProperty("list_company_id")]
        public ListCompanyId? ListCompanyId { get; set; }

        [JsonProperty("list_contact_id")]
        public ListContactId? ListContactId { get; set; }

        [JsonProperty("list_customer_id")]
        public ListCustomerId? ListCustomerId { get; set; }

        [JsonProperty("list_deal_id")]
        public ListDealId? ListDealId { get; set; }

        [JsonProperty("list_interview_id")]
        public ListInterviewId? ListInterviewId { get; set; }

        [JsonProperty("list_invoice_id")]
        public ListInvoiceId? ListInvoiceId { get; set; }

        [JsonProperty("list_item_id")]
        public ListItemId? ListItemId { get; set; }

        [JsonProperty("list_item_variant_id")]
        public ListItemVariantId? ListItemVariantId { get; set; }

        [JsonProperty("list_job_id")]
        public ListJobId? ListJobId { get; set; }

        [JsonProperty("list_limit")]
        public ListLimit? ListLimit { get; set; }

        [JsonProperty("list_link_id")]
        public ListLinkId? ListLinkId { get; set; }

        [JsonProperty("list_list_id")]
        public ListListId? ListListId { get; set; }

        [JsonProperty("list_location_id")]
        public ListLocationId? ListLocationId { get; set; }

        [JsonProperty("list_offset")]
        public ListOffset? ListOffset { get; set; }

        [JsonProperty("list_order")]
        public ListOrder? ListOrder { get; set; }

        [JsonProperty("list_parent_id")]
        public ListParentId? ListParentId { get; set; }

        [JsonProperty("list_project_id")]
        public ListProjectId? ListProjectId { get; set; }

        [JsonProperty("list_query")]
        public ListQuery? ListQuery { get; set; }

        [JsonProperty("list_sort_by_created_at")]
        public ListSortByCreatedAt? ListSortByCreatedAt { get; set; }

        [JsonProperty("list_sort_by_name")]
        public ListSortByName? ListSortByName { get; set; }

        [JsonProperty("list_sort_by_updated_at")]
        public ListSortByUpdatedAt? ListSortByUpdatedAt { get; set; }

        [JsonProperty("list_space_id")]
        public ListSpaceId? ListSpaceId { get; set; }

        [JsonProperty("list_ticket_id")]
        public ListTicketId? ListTicketId { get; set; }

        [JsonProperty("list_type")]
        public ListType? ListType { get; set; }

        [JsonProperty("list_updated_gte")]
        public ListUpdatedGte? ListUpdatedGte { get; set; }

        [JsonProperty("list_user_id")]
        public ListUserId? ListUserId { get; set; }

        [JsonProperty("methods")]
        public Dictionary<string, bool>? Methods { get; set; }

        [JsonProperty("outbound_fields")]
        public Dictionary<string, object>? OutboundFields { get; set; }

        /// <summary>
        /// objects that we map from in the integration
        /// </summary>
        [JsonProperty("raw_objects")]
        public List<string>? RawObjects { get; set; }

        [JsonProperty("search_domain")]
        public SearchDomain? SearchDomain { get; set; }

        [JsonProperty("search_email")]
        public SearchEmail? SearchEmail { get; set; }

        [JsonProperty("search_linkedinurl")]
        public SearchLinkedinurl? SearchLinkedinurl { get; set; }

        [JsonProperty("search_name")]
        public SearchName? SearchName { get; set; }

        [JsonProperty("search_twitter")]
        public SearchTwitter? SearchTwitter { get; set; }

        [JsonProperty("webhook_events")]
        public PropertyIntegrationSupportWebhookEvents? WebhookEvents { get; set; }
    }
}