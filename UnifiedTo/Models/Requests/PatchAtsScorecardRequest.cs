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
    using System.Collections.Generic;
    using UnifiedTo.Models.Components;
    using UnifiedTo.Utils;
    
    public class PatchAtsScorecardRequest
    {

        /// <summary>
        /// ID of the connection
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=connection_id")]
        public string ConnectionId { get; set; } = default!;

        /// <summary>
        /// ID of the Scorecard
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=id")]
        public string Id { get; set; } = default!;

        [SpeakeasyMetadata("request:mediaType=application/json")]
        public AtsScorecard? AtsScorecard { get; set; }

        /// <summary>
        /// Comma-delimited fields to return
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=fields")]
        public List<string>? Fields { get; set; }
    }
}