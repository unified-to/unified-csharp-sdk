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
    using System.Net.Http;
    using UnifiedTo.Models.Components;
    using UnifiedTo.Utils;
    
    public class ListAccountingCreditmemoesResponse
    {

        /// <summary>
        /// Successful
        /// </summary>
        public List<AccountingCreditmemo>? AccountingCreditmemoes { get; set; }

        /// <summary>
        /// HTTP response content type for this operation
        /// </summary>
        public string? ContentType { get; set; } = default!;

        /// <summary>
        /// HTTP response status code for this operation
        /// </summary>
        public int StatusCode { get; set; } = default!;

        /// <summary>
        /// Raw HTTP response; suitable for custom response parsing
        /// </summary>
        public HttpResponseMessage RawResponse { get; set; } = default!;
    }
}