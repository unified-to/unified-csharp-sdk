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
    using UnifiedTo.Utils;
    
    public class ListCalendarBusiesRequest
    {

        /// <summary>
        /// The calendar ID to filter by
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=calendar_id")]
        public string? CalendarId { get; set; }

        /// <summary>
        /// ID of the connection
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=connection_id")]
        public string ConnectionId { get; set; } = default!;

        /// <summary>
        /// The end date to filter by
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=end_le")]
        public string? EndLe { get; set; }

        /// <summary>
        /// Comma-delimited fields to return
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=fields")]
        public List<string>? Fields { get; set; }

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=limit")]
        public double? Limit { get; set; }

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=offset")]
        public double? Offset { get; set; }

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=order")]
        public string? Order { get; set; }

        /// <summary>
        /// Query string to search. eg. email address or name
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=query")]
        public string? Query { get; set; }

        /// <summary>
        /// Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&amp;zoo=bar -&gt; raw=foo%3Dbar%26zoo%3Dbar
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=raw")]
        public string? Raw { get; set; }

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=sort")]
        public string? Sort { get; set; }

        /// <summary>
        /// The start date to filter by
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=start_gte")]
        public string? StartGte { get; set; }

        /// <summary>
        /// Return only results whose updated date is equal or greater to this value
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=updated_gte")]
        public string? UpdatedGte { get; set; }

        /// <summary>
        /// The user/employee ID to filter by
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=user_id")]
        public string? UserId { get; set; }
    }
}