
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
    using UnifiedCsharpSDK.Utils;
    
    public class ListUnifiedIntegrationsRequest
    {

        /// <summary>
        /// Filter the results for only the workspace&apos;s active integrations
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Filter the results on these categories
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=categories")]
        public List<ListUnifiedIntegrationsQueryParamCategories>? Categories { get; set; }

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=env")]
        public string? Env { get; set; }

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=limit")]
        public double? Limit { get; set; }

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=offset")]
        public double? Offset { get; set; }

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=order")]
        public string? Order { get; set; }

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=sort")]
        public string? Sort { get; set; }

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=summary")]
        public bool? Summary { get; set; }

        /// <summary>
        /// Filter the results for only this integration type
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=type")]
        public string? Type { get; set; }

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=updated_gte")]
        public string? UpdatedGte { get; set; }
    }
}