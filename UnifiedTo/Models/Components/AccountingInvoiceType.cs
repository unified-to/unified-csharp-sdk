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
    
    public enum AccountingInvoiceType
    {
        [JsonProperty("BILL")]
        Bill,
        [JsonProperty("INVOICE")]
        Invoice,
        [JsonProperty("CREDITMEMO")]
        Creditmemo,
    }

    public static class AccountingInvoiceTypeExtension
    {
        public static string Value(this AccountingInvoiceType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static AccountingInvoiceType ToEnum(this string value)
        {
            foreach(var field in typeof(AccountingInvoiceType).GetFields())
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

                    if (enumVal is AccountingInvoiceType)
                    {
                        return (AccountingInvoiceType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum AccountingInvoiceType");
        }
    }

}