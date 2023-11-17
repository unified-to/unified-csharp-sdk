
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace UnifiedCsharpSDK
{
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;
    using UnifiedCsharpSDK.Models.Requests;
    using UnifiedCsharpSDK.Utils;

    public interface IAuth
    {

        /// <summary>
        /// Create connection indirectly
        /// 
        /// <remarks>
        /// Returns an authorization URL for the specified integration.  Once a successful authorization occurs, a new connection is created.
        /// </remarks>
        /// </summary>
        Task<GetUnifiedIntegrationAuthResponse> GetUnifiedIntegrationAuthAsync(GetUnifiedIntegrationAuthRequest? request = null);

        /// <summary>
        /// Sign in a user
        /// 
        /// <remarks>
        /// Returns an authentication URL for the specified integration.  Once a successful authentication occurs, the name and emails are returned.
        /// </remarks>
        /// </summary>
        Task<GetUnifiedIntegrationLoginResponse> GetUnifiedIntegrationLoginAsync(GetUnifiedIntegrationLoginRequest? request = null);
    }

    public class Auth: IAuth
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.1.0";
        private const string _sdkGenVersion = "2.194.1";
        private const string _openapiDocVersion = "1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.1.0 2.194.1 1.0 Unified-csharp-sdk";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public Auth(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
        }
        

        public async Task<GetUnifiedIntegrationAuthResponse> GetUnifiedIntegrationAuthAsync(GetUnifiedIntegrationAuthRequest? request = null)
        {
            string baseUrl = this.Config.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/unified/integration/auth/{workspace_id}/{integration_type}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetUnifiedIntegrationAuthResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Res = await httpResponse.Content.ReadAsStringAsync();
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetUnifiedIntegrationLoginResponse> GetUnifiedIntegrationLoginAsync(GetUnifiedIntegrationLoginRequest? request = null)
        {
            string baseUrl = this.Config.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/unified/integration/login/{workspace_id}/{integration_type}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetUnifiedIntegrationLoginResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Res = await httpResponse.Content.ReadAsStringAsync();
                }
                
                return response;
            }
            return response;
        }
        
    }
}