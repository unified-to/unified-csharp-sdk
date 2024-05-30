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
    using System;
    using UnifiedTo.Utils;
    
    public enum HrisPayslipDetailType
    {
        [JsonProperty("EARNING_SALARY")]
        EarningSalary,
        [JsonProperty("EARNING_OVERTIME")]
        EarningOvertime,
        [JsonProperty("EARNING_TIP")]
        EarningTip,
        [JsonProperty("EARNING_BONUS")]
        EarningBonus,
        [JsonProperty("EARNING_COMMISSION")]
        EarningCommission,
        [JsonProperty("EARNING_ADJUSTMENT")]
        EarningAdjustment,
        [JsonProperty("EARNING")]
        Earning,
        [JsonProperty("PRETAX_DEDUCTION")]
        PretaxDeduction,
        [JsonProperty("PRETAX_DEDUCTION_HEALTH_INSURANCE")]
        PretaxDeductionHealthInsurance,
        [JsonProperty("PRETAX_DEDUCTION_RETIREMENT")]
        PretaxDeductionRetirement,
        [JsonProperty("PRETAX_DEDUCTION_HRA")]
        PretaxDeductionHra,
        [JsonProperty("TAX_FEDERAL")]
        TaxFederal,
        [JsonProperty("TAX_REGION")]
        TaxRegion,
        [JsonProperty("TAX_LOCAL")]
        TaxLocal,
        [JsonProperty("POSTTAX_BENEFIT")]
        PosttaxBenefit,
        [JsonProperty("POSTTAX_GARNISHMENT")]
        PosttaxGarnishment,
        [JsonProperty("REIMBURSEMENT")]
        Reimbursement,
    }

    public static class HrisPayslipDetailTypeExtension
    {
        public static string Value(this HrisPayslipDetailType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static HrisPayslipDetailType ToEnum(this string value)
        {
            foreach(var field in typeof(HrisPayslipDetailType).GetFields())
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

                    if (enumVal is HrisPayslipDetailType)
                    {
                        return (HrisPayslipDetailType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum HrisPayslipDetailType");
        }
    }

}