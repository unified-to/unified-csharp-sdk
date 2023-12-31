
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace UnifiedCsharpSDK.Models.Components
{
    using Newtonsoft.Json;
    using System;
    
    public enum ObjectType
    {
        [JsonProperty("accounting_account")]
        AccountingAccount,
        [JsonProperty("accounting_transaction")]
        AccountingTransaction,
        [JsonProperty("accounting_customer")]
        AccountingCustomer,
        [JsonProperty("accounting_invoice")]
        AccountingInvoice,
        [JsonProperty("accounting_payment")]
        AccountingPayment,
        [JsonProperty("accounting_taxrate")]
        AccountingTaxrate,
        [JsonProperty("accounting_organization")]
        AccountingOrganization,
        [JsonProperty("accounting_item")]
        AccountingItem,
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
        [JsonProperty("crm_company")]
        CrmCompany,
        [JsonProperty("crm_contact")]
        CrmContact,
        [JsonProperty("crm_deal")]
        CrmDeal,
        [JsonProperty("crm_event")]
        CrmEvent,
        [JsonProperty("crm_file")]
        CrmFile,
        [JsonProperty("crm_lead")]
        CrmLead,
        [JsonProperty("crm_pipeline")]
        CrmPipeline,
        [JsonProperty("hris_employee")]
        HrisEmployee,
        [JsonProperty("hris_group")]
        HrisGroup,
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