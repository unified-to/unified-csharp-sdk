//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
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
    
    public class CreateUnifiedWebhookRequest
    {

        /// <summary>
        /// A webhook is used to POST new/updated information to your server.
        /// </summary>
        [SpeakeasyMetadata("request:mediaType=application/json")]
        public Models.Components.Webhook Webhook { get; set; } = default!;

        /// <summary>
        /// When set, all of the existing data will sent back to your server.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=include_all")]
        public bool? IncludeAll { get; set; }
    }
}