
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace UnifiedTo
{
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;
    using UnifiedTo.Models.Components;
    using UnifiedTo.Models.Requests;
    using UnifiedTo.Utils;

    public interface IAuth
    {

        /// <summary>
        /// Create connection indirectly
        /// 
        /// <remarks>
        /// Returns an authorization URL for the specified integration.  Once a successful authorization occurs, a new connection is created.
        /// </remarks>
        /// </summary>
        Task<GetUnifiedIntegrationAuthResponse> GetUnifiedIntegrationAuthAsync(GetUnifiedIntegrationAuthRequest request);

        /// <summary>
        /// Sign in a user
        /// 
        /// <remarks>
        /// Returns an authentication URL for the specified integration.  Once a successful authentication occurs, the name and email are returned inside a jwt parameter, which is a JSON web token that is base-64 encoded.
        /// </remarks>
        /// </summary>
        Task<GetUnifiedIntegrationLoginResponse> GetUnifiedIntegrationLoginAsync(GetUnifiedIntegrationLoginRequest request);
    }

    public class Auth: IAuth
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.12.6";
        private const string _sdkGenVersion = "2.283.1";
        private const string _openapiDocVersion = "1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.12.6 2.283.1 1.0 UnifiedTo";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;

        public Auth(ISpeakeasyHttpClient defaultClient, Func<Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<GetUnifiedIntegrationAuthResponse> GetUnifiedIntegrationAuthAsync(GetUnifiedIntegrationAuthRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/unified/integration/auth/{workspace_id}/{integration_type}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

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
                if(Utilities.IsContentTypeMatch("text/plain",response.ContentType))
                {
                    response.Res = await httpResponse.Content.ReadAsStringAsync();
                }

                return response;
            }
            return response;
        }


        public async Task<GetUnifiedIntegrationLoginResponse> GetUnifiedIntegrationLoginAsync(GetUnifiedIntegrationLoginRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/unified/integration/login/{workspace_id}/{integration_type}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

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
                if(Utilities.IsContentTypeMatch("text/plain",response.ContentType))
                {
                    response.Res = await httpResponse.Content.ReadAsStringAsync();
                }

                return response;
            }
            return response;
        }

    }
}