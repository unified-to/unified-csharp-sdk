
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace UnifiedTo.Models.Requests
{
    using UnifiedTo.Utils;
    
    public class ListUnifiedApicallsSecurity
    {

        [SpeakeasyMetadata("security:scheme=true,type=apiKey,subType=header,name=authorization")]
        public string Jwt { get; set; } = default!;
    }
}