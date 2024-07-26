//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace UnifiedTo.Models.Requests
{
    using UnifiedTo.Models.Components;
    using UnifiedTo.Utils;
    
    public class PatchHrisCompanyRequest
    {

        /// <summary>
        /// ID of the connection
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=connection_id")]
        public string ConnectionId { get; set; } = default!;

        /// <summary>
        /// ID of the Company
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=id")]
        public string Id { get; set; } = default!;

        [SpeakeasyMetadata("request:mediaType=application/json")]
        public HrisCompany? HrisCompany { get; set; }
    }
}