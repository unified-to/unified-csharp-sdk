
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
    using UnifiedCsharpSDK.Utils;
    
    public class GetUnifiedIntegrationLoginRequest
    {

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=env")]
        public string? Env { get; set; }

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

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=redirect")]
        public bool? Redirect { get; set; }

        /// <summary>
        /// Extra state to send back to your success URL
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=state")]
        public string? State { get; set; }

        /// <summary>
        /// The URL where you want the user to be redirect to after a successful authentication/sign-in.  A &quot;jwt&quot; parameter will be appended to the URL which will contain a name and email of the user who just signed-in.
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