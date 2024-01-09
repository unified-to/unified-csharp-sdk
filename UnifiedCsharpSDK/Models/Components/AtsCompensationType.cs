
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
    
    public enum AtsCompensationType
    {
        [JsonProperty("SALARY")]
        Salary,
        [JsonProperty("BONUS")]
        Bonus,
        [JsonProperty("STOCK_OPTIONS")]
        StockOptions,
        [JsonProperty("EQUITY")]
        Equity,
        [JsonProperty("OTHER")]
        Other,
    }

    public static class AtsCompensationTypeExtension
    {
        public static string Value(this AtsCompensationType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static AtsCompensationType ToEnum(this string value)
        {
            foreach(var field in typeof(AtsCompensationType).GetFields())
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

                    if (enumVal is AtsCompensationType)
                    {
                        return (AtsCompensationType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum AtsCompensationType");
        }
    }

}