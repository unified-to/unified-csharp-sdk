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
    using System;
    using System.Collections.Generic;
    using UnifiedTo.Utils;
    
    public class ListCommerceCollectionsRequest
    {

        /// <summary>
        /// ID of the connection
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=connection_id")]
        public string ConnectionId { get; set; } = default!;

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

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// Query string to search. eg. email address or name
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=query")]
        public string? Query { get; set; }

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=sort")]
        public string? Sort { get; set; }

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=type")]
        public string? Type { get; set; }

        /// <summary>
        /// Return only results whose updated date is equal or greater to this value
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=updated_gte")]
        public DateTime? UpdatedGte { get; set; }
    }
}