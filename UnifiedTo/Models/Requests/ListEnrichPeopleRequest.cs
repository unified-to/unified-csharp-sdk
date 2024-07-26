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
    using UnifiedTo.Utils;
    
    public class ListEnrichPeopleRequest
    {

        /// <summary>
        /// The name of the company the person is associated with.  Not valid by itself.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=company_name")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// ID of the connection
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=connection_id")]
        public string ConnectionId { get; set; } = default!;

        /// <summary>
        /// The email of the person to search
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=email")]
        public string? Email { get; set; }

        /// <summary>
        /// The LinkedIn URL of the person to search
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=linkedin_url")]
        public string? LinkedinUrl { get; set; }

        /// <summary>
        /// The name of the person to search
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=name")]
        public string? Name { get; set; }

        /// <summary>
        /// The twitter handle of the person to search
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=twitter")]
        public string? Twitter { get; set; }
    }
}