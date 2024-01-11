
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
    
    public class IntegrationSupport
    {

        [JsonProperty("inbound_fields")]
        public PropertyIntegrationSupportInboundFields? InboundFields { get; set; }

        [JsonProperty("list_application_id")]
        public bool? ListApplicationId { get; set; }

        [JsonProperty("list_candidate_id")]
        public bool? ListCandidateId { get; set; }

        [JsonProperty("list_company_id")]
        public bool? ListCompanyId { get; set; }

        [JsonProperty("list_contact_id")]
        public bool? ListContactId { get; set; }

        [JsonProperty("list_customer_id")]
        public bool? ListCustomerId { get; set; }

        [JsonProperty("list_deal_id")]
        public bool? ListDealId { get; set; }

        [JsonProperty("list_invoice_id")]
        public bool? ListInvoiceId { get; set; }

        [JsonProperty("list_job_id")]
        public bool? ListJobId { get; set; }

        [JsonProperty("list_limit")]
        public bool? ListLimit { get; set; }

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

        [JsonProperty("list_updated_gte")]
        public bool? ListUpdatedGte { get; set; }

        [JsonProperty("list_user_id")]
        public bool? ListUserId { get; set; }

        [JsonProperty("methods")]
        public Dictionary<string, bool>? Methods { get; set; }

        [JsonProperty("outbound_fields")]
        public PropertyIntegrationSupportOutboundFields? OutboundFields { get; set; }

        [JsonProperty("search_domain")]
        public bool? SearchDomain { get; set; }

        [JsonProperty("search_email")]
        public bool? SearchEmail { get; set; }

        [JsonProperty("search_linkedin_url")]
        public bool? SearchLinkedinUrl { get; set; }

        [JsonProperty("search_name")]
        public bool? SearchName { get; set; }

        [JsonProperty("search_twitter")]
        public bool? SearchTwitter { get; set; }

        [JsonProperty("webhook_events")]
        public List<PropertyIntegrationSupportWebhookEvents>? WebhookEvents { get; set; }

        [JsonProperty("webhook_type")]
        public WebhookType? WebhookType { get; set; }
    }
}