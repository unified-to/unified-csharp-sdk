
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace UnifiedCsharpSDK.Models.Requests
{
    using UnifiedCsharpSDK.Models.Components;
    using UnifiedCsharpSDK.Utils;
    
    public class CreateMartechListRequest
    {

        /// <summary>
        /// ID of the connection
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=connection_id")]
        public string ConnectionId { get; set; } = default!;

        /// <summary>
        /// Mailing List
        /// </summary>
        [SpeakeasyMetadata("request:mediaType=application/json")]
        public MarketingList? MarketingList { get; set; }
    }
}