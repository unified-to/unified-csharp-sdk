
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Unified.To.Models.Requests
{
    using Unified.To.Utils;
    
    public class GetUnifiedIntegrationRequest
    {

        /// <summary>
        /// Type of the supported integration
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=integration_type")]
        public string IntegrationType { get; set; } = default!;
    }
}