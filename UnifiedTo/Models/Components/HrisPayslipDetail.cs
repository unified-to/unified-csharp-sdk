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
    using UnifiedTo.Models.Components;
    using UnifiedTo.Utils;
    
    public class HrisPayslipDetail
    {

        [JsonProperty("amount")]
        public double Amount { get; set; } = default!;

        [JsonProperty("company_amount")]
        public double? CompanyAmount { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("employee_amount")]
        public double? EmployeeAmount { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("type")]
        public HrisPayslipDetailType? Type { get; set; }
    }
}