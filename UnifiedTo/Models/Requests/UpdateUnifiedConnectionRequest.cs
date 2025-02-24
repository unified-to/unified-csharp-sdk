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
    
    public class UpdateUnifiedConnectionRequest
    {

        /// <summary>
        /// A connection represents a specific authentication of an integration.
        /// </summary>
        [SpeakeasyMetadata("request:mediaType=application/json")]
        public Models.Components.Connection Connection { get; set; } = default!;

        /// <summary>
        /// ID of the Connection
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=id")]
        public string Id { get; set; } = default!;
    }
}