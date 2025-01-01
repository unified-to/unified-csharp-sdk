//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace UnifiedTo.Models.Requests
{
    using Newtonsoft.Json;
    using System;
    using UnifiedTo.Utils;
    
    public enum Scopes
    {
        [JsonProperty("auth_login")]
        AuthLogin,
        [JsonProperty("accounting_account_read")]
        AccountingAccountRead,
        [JsonProperty("accounting_account_write")]
        AccountingAccountWrite,
        [JsonProperty("accounting_transaction_read")]
        AccountingTransactionRead,
        [JsonProperty("accounting_transaction_write")]
        AccountingTransactionWrite,
        [JsonProperty("accounting_journal_read")]
        AccountingJournalRead,
        [JsonProperty("accounting_journal_write")]
        AccountingJournalWrite,
        [JsonProperty("accounting_invoice_read")]
        AccountingInvoiceRead,
        [JsonProperty("accounting_invoice_write")]
        AccountingInvoiceWrite,
        [JsonProperty("accounting_contact_read")]
        AccountingContactRead,
        [JsonProperty("accounting_contact_write")]
        AccountingContactWrite,
        [JsonProperty("accounting_taxrate_read")]
        AccountingTaxrateRead,
        [JsonProperty("accounting_taxrate_write")]
        AccountingTaxrateWrite,
        [JsonProperty("accounting_organization_read")]
        AccountingOrganizationRead,
        [JsonProperty("accounting_order_read")]
        AccountingOrderRead,
        [JsonProperty("accounting_order_write")]
        AccountingOrderWrite,
        [JsonProperty("payment_payment_read")]
        PaymentPaymentRead,
        [JsonProperty("payment_payment_write")]
        PaymentPaymentWrite,
        [JsonProperty("payment_payout_read")]
        PaymentPayoutRead,
        [JsonProperty("payment_refund_read")]
        PaymentRefundRead,
        [JsonProperty("payment_link_read")]
        PaymentLinkRead,
        [JsonProperty("payment_link_write")]
        PaymentLinkWrite,
        [JsonProperty("payment_subscription_read")]
        PaymentSubscriptionRead,
        [JsonProperty("payment_subscription_write")]
        PaymentSubscriptionWrite,
        [JsonProperty("commerce_item_read")]
        CommerceItemRead,
        [JsonProperty("commerce_item_write")]
        CommerceItemWrite,
        [JsonProperty("commerce_collection_read")]
        CommerceCollectionRead,
        [JsonProperty("commerce_collection_write")]
        CommerceCollectionWrite,
        [JsonProperty("commerce_inventory_read")]
        CommerceInventoryRead,
        [JsonProperty("commerce_inventory_write")]
        CommerceInventoryWrite,
        [JsonProperty("commerce_location_read")]
        CommerceLocationRead,
        [JsonProperty("commerce_location_write")]
        CommerceLocationWrite,
        [JsonProperty("ats_activity_read")]
        AtsActivityRead,
        [JsonProperty("ats_activity_write")]
        AtsActivityWrite,
        [JsonProperty("ats_application_read")]
        AtsApplicationRead,
        [JsonProperty("ats_application_write")]
        AtsApplicationWrite,
        [JsonProperty("ats_applicationstatus_read")]
        AtsApplicationstatusRead,
        [JsonProperty("ats_candidate_read")]
        AtsCandidateRead,
        [JsonProperty("ats_candidate_write")]
        AtsCandidateWrite,
        [JsonProperty("ats_interview_read")]
        AtsInterviewRead,
        [JsonProperty("ats_interview_write")]
        AtsInterviewWrite,
        [JsonProperty("ats_job_read")]
        AtsJobRead,
        [JsonProperty("ats_job_write")]
        AtsJobWrite,
        [JsonProperty("ats_company_read")]
        AtsCompanyRead,
        [JsonProperty("ats_document_read")]
        AtsDocumentRead,
        [JsonProperty("ats_document_write")]
        AtsDocumentWrite,
        [JsonProperty("ats_scorecard_read")]
        AtsScorecardRead,
        [JsonProperty("ats_scorecard_write")]
        AtsScorecardWrite,
        [JsonProperty("crm_company_read")]
        CrmCompanyRead,
        [JsonProperty("crm_company_write")]
        CrmCompanyWrite,
        [JsonProperty("crm_contact_read")]
        CrmContactRead,
        [JsonProperty("crm_contact_write")]
        CrmContactWrite,
        [JsonProperty("crm_deal_read")]
        CrmDealRead,
        [JsonProperty("crm_deal_write")]
        CrmDealWrite,
        [JsonProperty("crm_event_read")]
        CrmEventRead,
        [JsonProperty("crm_event_write")]
        CrmEventWrite,
        [JsonProperty("crm_lead_read")]
        CrmLeadRead,
        [JsonProperty("crm_lead_write")]
        CrmLeadWrite,
        [JsonProperty("crm_pipeline_read")]
        CrmPipelineRead,
        [JsonProperty("crm_pipeline_write")]
        CrmPipelineWrite,
        [JsonProperty("martech_list_read")]
        MartechListRead,
        [JsonProperty("martech_list_write")]
        MartechListWrite,
        [JsonProperty("martech_member_read")]
        MartechMemberRead,
        [JsonProperty("martech_member_write")]
        MartechMemberWrite,
        [JsonProperty("ticketing_customer_read")]
        TicketingCustomerRead,
        [JsonProperty("ticketing_customer_write")]
        TicketingCustomerWrite,
        [JsonProperty("ticketing_ticket_read")]
        TicketingTicketRead,
        [JsonProperty("ticketing_ticket_write")]
        TicketingTicketWrite,
        [JsonProperty("ticketing_note_read")]
        TicketingNoteRead,
        [JsonProperty("ticketing_note_write")]
        TicketingNoteWrite,
        [JsonProperty("hris_employee_read")]
        HrisEmployeeRead,
        [JsonProperty("hris_employee_write")]
        HrisEmployeeWrite,
        [JsonProperty("hris_group_read")]
        HrisGroupRead,
        [JsonProperty("hris_group_write")]
        HrisGroupWrite,
        [JsonProperty("hris_payslip_read")]
        HrisPayslipRead,
        [JsonProperty("hris_payslip_write")]
        HrisPayslipWrite,
        [JsonProperty("hris_timeoff_read")]
        HrisTimeoffRead,
        [JsonProperty("hris_timeoff_write")]
        HrisTimeoffWrite,
        [JsonProperty("hris_company_read")]
        HrisCompanyRead,
        [JsonProperty("hris_company_write")]
        HrisCompanyWrite,
        [JsonProperty("hris_location_read")]
        HrisLocationRead,
        [JsonProperty("hris_location_write")]
        HrisLocationWrite,
        [JsonProperty("uc_call_read")]
        UcCallRead,
        [JsonProperty("uc_contact_read")]
        UcContactRead,
        [JsonProperty("uc_contact_write")]
        UcContactWrite,
        [JsonProperty("storage_file_read")]
        StorageFileRead,
        [JsonProperty("storage_file_write")]
        StorageFileWrite,
        [JsonProperty("webhook")]
        Webhook,
        [JsonProperty("genai_model_read")]
        GenaiModelRead,
        [JsonProperty("genai_prompt_read")]
        GenaiPromptRead,
        [JsonProperty("genai_prompt_write")]
        GenaiPromptWrite,
        [JsonProperty("messaging_message_read")]
        MessagingMessageRead,
        [JsonProperty("messaging_message_write")]
        MessagingMessageWrite,
        [JsonProperty("messaging_channel_read")]
        MessagingChannelRead,
        [JsonProperty("kms_space_read")]
        KmsSpaceRead,
        [JsonProperty("kms_space_write")]
        KmsSpaceWrite,
        [JsonProperty("kms_page_read")]
        KmsPageRead,
        [JsonProperty("kms_page_write")]
        KmsPageWrite,
        [JsonProperty("kms_comment_read")]
        KmsCommentRead,
        [JsonProperty("kms_comment_write")]
        KmsCommentWrite,
        [JsonProperty("task_project_read")]
        TaskProjectRead,
        [JsonProperty("task_project_write")]
        TaskProjectWrite,
        [JsonProperty("task_task_read")]
        TaskTaskRead,
        [JsonProperty("task_task_write")]
        TaskTaskWrite,
        [JsonProperty("scim_users_read")]
        ScimUsersRead,
        [JsonProperty("scim_users_write")]
        ScimUsersWrite,
        [JsonProperty("scim_groups_read")]
        ScimGroupsRead,
        [JsonProperty("scim_groups_write")]
        ScimGroupsWrite,
        [JsonProperty("lms_course_read")]
        LmsCourseRead,
        [JsonProperty("lms_course_write")]
        LmsCourseWrite,
        [JsonProperty("lms_class_read")]
        LmsClassRead,
        [JsonProperty("lms_class_write")]
        LmsClassWrite,
        [JsonProperty("lms_student_read")]
        LmsStudentRead,
        [JsonProperty("lms_student_write")]
        LmsStudentWrite,
        [JsonProperty("lms_instructor_read")]
        LmsInstructorRead,
        [JsonProperty("lms_instructor_write")]
        LmsInstructorWrite,
        [JsonProperty("repo_organization_read")]
        RepoOrganizationRead,
        [JsonProperty("repo_organization_write")]
        RepoOrganizationWrite,
        [JsonProperty("repo_repository_read")]
        RepoRepositoryRead,
        [JsonProperty("repo_repository_write")]
        RepoRepositoryWrite,
        [JsonProperty("repo_branch_read")]
        RepoBranchRead,
        [JsonProperty("repo_branch_write")]
        RepoBranchWrite,
        [JsonProperty("repo_commit_read")]
        RepoCommitRead,
        [JsonProperty("repo_commit_write")]
        RepoCommitWrite,
        [JsonProperty("repo_pullrequest_read")]
        RepoPullrequestRead,
        [JsonProperty("repo_pullrequest_write")]
        RepoPullrequestWrite,
        [JsonProperty("metadata_metadata_read")]
        MetadataMetadataRead,
        [JsonProperty("metadata_metadata_write")]
        MetadataMetadataWrite,
    }

    public static class ScopesExtension
    {
        public static string Value(this Scopes value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static Scopes ToEnum(this string value)
        {
            foreach(var field in typeof(Scopes).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is Scopes)
                    {
                        return (Scopes)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum Scopes");
        }
    }

}