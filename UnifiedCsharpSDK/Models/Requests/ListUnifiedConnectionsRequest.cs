
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
    using System.Collections.Generic;
    using System;
    using UnifiedCsharpSDK.Utils;
    
    public class ListUnifiedConnectionsRequest
    {

        /// <summary>
        /// Filter the results on these categories
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=categories")]
        public List<Categories>? Categories { get; set; }

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=env")]
        public string? Env { get; set; }

        /// <summary>
        /// Filter the results to only those integrations for your user referenced by this value
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=external_xref")]
        public string? ExternalXref { get; set; }

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=limit")]
        public double? Limit { get; set; }

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=offset")]
        public double? Offset { get; set; }

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=order")]
        public string? Order { get; set; }

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=sort")]
        public string? Sort { get; set; }

        /// <summary>
        /// Return only results whose updated date is equal or greater to this value
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=updated_gte")]
        public DateTime? UpdatedGte { get; set; }
    }
}