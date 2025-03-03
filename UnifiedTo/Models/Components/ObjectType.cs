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
    using UnifiedTo.Utils;
    
    public enum ObjectType
    {
        [JsonProperty("accounting_account")]
        AccountingAccount,
        [JsonProperty("accounting_transaction")]
        AccountingTransaction,
        [JsonProperty("accounting_journal")]
        AccountingJournal,
        [JsonProperty("accounting_contact")]
        AccountingContact,
        [JsonProperty("accounting_invoice")]
        AccountingInvoice,
        [JsonProperty("accounting_taxrate")]
        AccountingTaxrate,
        [JsonProperty("accounting_organization")]
        AccountingOrganization,
        [JsonProperty("accounting_order")]
        AccountingOrder,
        [JsonProperty("payment_payment")]
        PaymentPayment,
        [JsonProperty("payment_link")]
        PaymentLink,
        [JsonProperty("payment_payout")]
        PaymentPayout,
        [JsonProperty("payment_refund")]
        PaymentRefund,
        [JsonProperty("payment_subscription")]
        PaymentSubscription,
        [JsonProperty("commerce_item")]
        CommerceItem,
        [JsonProperty("commerce_collection")]
        CommerceCollection,
        [JsonProperty("commerce_inventory")]
        CommerceInventory,
        [JsonProperty("commerce_location")]
        CommerceLocation,
        [JsonProperty("ats_activity")]
        AtsActivity,
        [JsonProperty("ats_application")]
        AtsApplication,
        [JsonProperty("ats_applicationstatus")]
        AtsApplicationstatus,
        [JsonProperty("ats_candidate")]
        AtsCandidate,
        [JsonProperty("ats_document")]
        AtsDocument,
        [JsonProperty("ats_interview")]
        AtsInterview,
        [JsonProperty("ats_job")]
        AtsJob,
        [JsonProperty("ats_scorecard")]
        AtsScorecard,
        [JsonProperty("ats_company")]
        AtsCompany,
        [JsonProperty("crm_company")]
        CrmCompany,
        [JsonProperty("crm_contact")]
        CrmContact,
        [JsonProperty("crm_deal")]
        CrmDeal,
        [JsonProperty("crm_event")]
        CrmEvent,
        [JsonProperty("crm_lead")]
        CrmLead,
        [JsonProperty("crm_pipeline")]
        CrmPipeline,
        [JsonProperty("hris_employee")]
        HrisEmployee,
        [JsonProperty("hris_group")]
        HrisGroup,
        [JsonProperty("hris_payslip")]
        HrisPayslip,
        [JsonProperty("hris_timeoff")]
        HrisTimeoff,
        [JsonProperty("hris_company")]
        HrisCompany,
        [JsonProperty("hris_location")]
        HrisLocation,
        [JsonProperty("martech_list")]
        MartechList,
        [JsonProperty("martech_member")]
        MartechMember,
        [JsonProperty("passthrough")]
        Passthrough,
        [JsonProperty("ticketing_note")]
        TicketingNote,
        [JsonProperty("ticketing_ticket")]
        TicketingTicket,
        [JsonProperty("ticketing_customer")]
        TicketingCustomer,
        [JsonProperty("uc_contact")]
        UcContact,
        [JsonProperty("uc_call")]
        UcCall,
        [JsonProperty("enrich_person")]
        EnrichPerson,
        [JsonProperty("enrich_company")]
        EnrichCompany,
        [JsonProperty("storage_file")]
        StorageFile,
        [JsonProperty("genai_model")]
        GenaiModel,
        [JsonProperty("genai_prompt")]
        GenaiPrompt,
        [JsonProperty("messaging_message")]
        MessagingMessage,
        [JsonProperty("messaging_channel")]
        MessagingChannel,
        [JsonProperty("kms_space")]
        KmsSpace,
        [JsonProperty("kms_page")]
        KmsPage,
        [JsonProperty("kms_comment")]
        KmsComment,
        [JsonProperty("task_project")]
        TaskProject,
        [JsonProperty("task_task")]
        TaskTask,
        [JsonProperty("task_comment")]
        TaskComment,
        [JsonProperty("scim_users")]
        ScimUsers,
        [JsonProperty("scim_groups")]
        ScimGroups,
        [JsonProperty("lms_course")]
        LmsCourse,
        [JsonProperty("lms_class")]
        LmsClass,
        [JsonProperty("lms_student")]
        LmsStudent,
        [JsonProperty("lms_instructor")]
        LmsInstructor,
        [JsonProperty("repo_organization")]
        RepoOrganization,
        [JsonProperty("repo_repository")]
        RepoRepository,
        [JsonProperty("repo_branch")]
        RepoBranch,
        [JsonProperty("repo_commit")]
        RepoCommit,
        [JsonProperty("repo_pullrequest")]
        RepoPullrequest,
        [JsonProperty("metadata_metadata")]
        MetadataMetadata,
        [JsonProperty("calendar_calendar")]
        CalendarCalendar,
        [JsonProperty("calendar_event")]
        CalendarEvent,
        [JsonProperty("calendar_busy")]
        CalendarBusy,
        [JsonProperty("calendar_link")]
        CalendarLink,
        [JsonProperty("calendar_recording")]
        CalendarRecording,
    }

    public static class ObjectTypeExtension
    {
        public static string Value(this ObjectType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ObjectType ToEnum(this string value)
        {
            foreach(var field in typeof(ObjectType).GetFields())
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

                    if (enumVal is ObjectType)
                    {
                        return (ObjectType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ObjectType");
        }
    }

}