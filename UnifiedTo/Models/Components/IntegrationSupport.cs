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
    
    public class IntegrationSupport
    {

        [JsonProperty("inbound_fields")]
        public Dictionary<string, object>? InboundFields { get; set; }

        [JsonProperty("list_account_id")]
        public bool? ListAccountId { get; set; }

        [JsonProperty("list_application_id")]
        public bool? ListApplicationId { get; set; }

        [JsonProperty("list_candidate_id")]
        public bool? ListCandidateId { get; set; }

        [JsonProperty("list_channel_id")]
        public bool? ListChannelId { get; set; }

        [JsonProperty("list_collection_id")]
        public bool? ListCollectionId { get; set; }

        [JsonProperty("list_company_id")]
        public bool? ListCompanyId { get; set; }

        [JsonProperty("list_contact_id")]
        public bool? ListContactId { get; set; }

        [JsonProperty("list_customer_id")]
        public bool? ListCustomerId { get; set; }

        [JsonProperty("list_deal_id")]
        public bool? ListDealId { get; set; }

        [JsonProperty("list_interview_id")]
        public bool? ListInterviewId { get; set; }

        [JsonProperty("list_invoice_id")]
        public bool? ListInvoiceId { get; set; }

        [JsonProperty("list_item_id")]
        public bool? ListItemId { get; set; }

        [JsonProperty("list_job_id")]
        public bool? ListJobId { get; set; }

        [JsonProperty("list_limit")]
        public bool? ListLimit { get; set; }

        [JsonProperty("list_link_id")]
        public bool? ListLinkId { get; set; }

        [JsonProperty("list_list_id")]
        public bool? ListListId { get; set; }

        [JsonProperty("list_location_id")]
        public bool? ListLocationId { get; set; }

        [JsonProperty("list_offset")]
        public bool? ListOffset { get; set; }

        [JsonProperty("list_order")]
        public bool? ListOrder { get; set; }

        [JsonProperty("list_parent_id")]
        public bool? ListParentId { get; set; }

        [JsonProperty("list_query")]
        public bool? ListQuery { get; set; }

        [JsonProperty("list_sort_by_created_at")]
        public bool? ListSortByCreatedAt { get; set; }

        [JsonProperty("list_sort_by_name")]
        public bool? ListSortByName { get; set; }

        [JsonProperty("list_sort_by_updated_at")]
        public bool? ListSortByUpdatedAt { get; set; }

        [JsonProperty("list_space_id")]
        public bool? ListSpaceId { get; set; }

        [JsonProperty("list_ticket_id")]
        public bool? ListTicketId { get; set; }

        [JsonProperty("list_type")]
        public bool? ListType { get; set; }

        [JsonProperty("list_updated_gte")]
        public bool? ListUpdatedGte { get; set; }

        [JsonProperty("list_user_id")]
        public bool? ListUserId { get; set; }

        [JsonProperty("methods")]
        public Dictionary<string, bool>? Methods { get; set; }

        [JsonProperty("outbound_fields")]
        public Dictionary<string, object>? OutboundFields { get; set; }

        [JsonProperty("search_domain")]
        public bool? SearchDomain { get; set; }

        [JsonProperty("search_email")]
        public bool? SearchEmail { get; set; }

        [JsonProperty("search_linkedinurl")]
        public bool? SearchLinkedinurl { get; set; }

        [JsonProperty("search_name")]
        public bool? SearchName { get; set; }

        [JsonProperty("search_twitter")]
        public bool? SearchTwitter { get; set; }

        [JsonProperty("webhook_events")]
        public PropertyIntegrationSupportWebhookEvents? WebhookEvents { get; set; }
    }
}