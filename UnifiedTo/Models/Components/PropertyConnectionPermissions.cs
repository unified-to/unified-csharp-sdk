
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Unified.To.Models.Components
{
    using Newtonsoft.Json;
    using System;
    
    public enum PropertyConnectionPermissions
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
        [JsonProperty("accounting_invoice_read")]
        AccountingInvoiceRead,
        [JsonProperty("accounting_invoice_write")]
        AccountingInvoiceWrite,
        [JsonProperty("accounting_customer_read")]
        AccountingCustomerRead,
        [JsonProperty("accounting_customer_write")]
        AccountingCustomerWrite,
        [JsonProperty("accounting_payment_read")]
        AccountingPaymentRead,
        [JsonProperty("accounting_payment_write")]
        AccountingPaymentWrite,
        [JsonProperty("accounting_taxrate_read")]
        AccountingTaxrateRead,
        [JsonProperty("accounting_taxrate_write")]
        AccountingTaxrateWrite,
        [JsonProperty("accounting_organization_read")]
        AccountingOrganizationRead,
        [JsonProperty("accounting_item_read")]
        AccountingItemRead,
        [JsonProperty("ats_scorecard_read")]
        AtsScorecardRead,
        [JsonProperty("ats_scorecard_write")]
        AtsScorecardWrite,
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
        [JsonProperty("ats_document_read")]
        AtsDocumentRead,
        [JsonProperty("ats_document_write")]
        AtsDocumentWrite,
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
        [JsonProperty("crm_file_read")]
        CrmFileRead,
        [JsonProperty("crm_file_write")]
        CrmFileWrite,
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
        [JsonProperty("uc_call_read")]
        UcCallRead,
        [JsonProperty("storage_file_read")]
        StorageFileRead,
        [JsonProperty("storage_file_write")]
        StorageFileWrite,
        [JsonProperty("webhook")]
        Webhook,
    }

    public static class PropertyConnectionPermissionsExtension
    {
        public static string Value(this PropertyConnectionPermissions value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PropertyConnectionPermissions ToEnum(this string value)
        {
            foreach(var field in typeof(PropertyConnectionPermissions).GetFields())
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

                    if (enumVal is PropertyConnectionPermissions)
                    {
                        return (PropertyConnectionPermissions)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum PropertyConnectionPermissions");
        }
    }
}