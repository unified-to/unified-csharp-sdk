
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
    
    /// <summary>
    /// An item or product
    /// </summary>
    public class AccountingItem
    {

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("is_active")]
        public bool? IsActive { get; set; }

        [JsonProperty("is_taxable")]
        public bool? IsTaxable { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        [JsonProperty("price")]
        public double? Price { get; set; }

        [JsonProperty("public_description")]
        public string? PublicDescription { get; set; }

        [JsonProperty("quantity_on_hand")]
        public double? QuantityOnHand { get; set; }

        [JsonProperty("raw")]
        public PropertyAccountingItemRaw? Raw { get; set; }

        [JsonProperty("sku")]
        public string? Sku { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}