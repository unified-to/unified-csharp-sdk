
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
    
    public class AccountingTransactionLineitem
    {

        [JsonProperty("customer_id")]
        public string? CustomerId { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("invoice_id")]
        public string? InvoiceId { get; set; }

        [JsonProperty("payment_id")]
        public string? PaymentId { get; set; }

        [JsonProperty("tax_amount")]
        public double? TaxAmount { get; set; }

        [JsonProperty("total_amount")]
        public double TotalAmount { get; set; } = default!;
    }
}