
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
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;
    using UnifiedTo.Models.Components;
    using UnifiedTo.Models.Errors;
    using UnifiedTo.Models.Requests;
    using UnifiedTo.Utils;

    public interface IApicall
    {

        /// <summary>
        /// Retrieve specific API Call by its ID
        /// </summary>
        Task<GetUnifiedApicallResponse> GetUnifiedApicallAsync(string id);

        /// <summary>
        /// Returns API Calls
        /// </summary>
        Task<ListUnifiedApicallsResponse> ListUnifiedApicallsAsync(ListUnifiedApicallsRequest request);
    }

    public class Apicall: IApicall
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.14.0";
        private const string _sdkGenVersion = "2.295.1";
        private const string _openapiDocVersion = "1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.14.0 2.295.1 1.0 UnifiedTo";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;

        public Apicall(ISpeakeasyHttpClient defaultClient, Func<Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<GetUnifiedApicallResponse> GetUnifiedApicallAsync(string id)
        {
            var request = new GetUnifiedApicallRequest()
            {
                Id = id,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/unified/apicall/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            var response = new GetUnifiedApicallResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if (response.StatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {                    
                    var obj = ResponseBodyDeserializer.Deserialize<ApiCall>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    response.ApiCall = obj;
                }
                else
                {
                throw new SDKException("API error occurred", (int)httpResponse.StatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }

            }
            else if (response.StatusCode >= 400 && response.StatusCode < 500 || response.StatusCode >= 500 && response.StatusCode < 600)
            {
                throw new SDKException("API error occurred", (int)httpResponse.StatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);

            }
            else
            {
                throw new SDKException("unknown status code received", (int)httpResponse.StatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            return response;
        }


        public async Task<ListUnifiedApicallsResponse> ListUnifiedApicallsAsync(ListUnifiedApicallsRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/unified/apicall", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            var response = new ListUnifiedApicallsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if (response.StatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {                    
                    var obj = ResponseBodyDeserializer.Deserialize<List<ApiCall>>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    response.ApiCalls = obj;
                }
                else
                {
                throw new SDKException("API error occurred", (int)httpResponse.StatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }

            }
            else if (response.StatusCode >= 400 && response.StatusCode < 500 || response.StatusCode >= 500 && response.StatusCode < 600)
            {
                throw new SDKException("API error occurred", (int)httpResponse.StatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);

            }
            else
            {
                throw new SDKException("unknown status code received", (int)httpResponse.StatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            return response;
        }

    }
}