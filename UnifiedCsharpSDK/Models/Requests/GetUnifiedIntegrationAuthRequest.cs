
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
    
    public class GetUnifiedIntegrationAuthRequest
    {

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=env")]
        public string? Env { get; set; }

        /// <summary>
        /// Your user identifier to associate with the new Integration
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=external_xref")]
        public string? ExternalXref { get; set; }

        /// <summary>
        /// The URL where you want the user to be redirect to after an unsuccessful authentication. An &quot;error&quot; variable will be appended.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=failure_redirect")]
        public string? FailureRedirect { get; set; }

        /// <summary>
        /// Type of the supported integration
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=integration_type")]
        public string IntegrationType { get; set; } = default!;

        /// <summary>
        /// Language: en, fr, es, it, pt, zh, hi
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=lang")]
        public string? Lang { get; set; }

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=redirect")]
        public bool? Redirect { get; set; }

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=scopes")]
        public List<Scopes>? Scopes { get; set; }

        /// <summary>
        /// Extra state to send back to your success URL
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=state")]
        public string? State { get; set; }

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=subdomain")]
        public string? Subdomain { get; set; }

        /// <summary>
        /// The URL where you want the user to be redirect to after a successful authentication.  The connection ID will be appended with (id=&lt;connectionId&gt;) to this URL, as will the state that was provided.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=success_redirect")]
        public string? SuccessRedirect { get; set; }

        /// <summary>
        /// The ID of the workspace
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=workspace_id")]
        public string WorkspaceId { get; set; } = default!;
    }
}