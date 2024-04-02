
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

    public interface IInterview
    {

        /// <summary>
        /// Create a interview
        /// </summary>
        Task<CreateAtsInterviewResponse> CreateAtsInterviewAsync(string connectionId, AtsInterview? atsInterview = null);

        /// <summary>
        /// Retrieve a interview
        /// </summary>
        Task<GetAtsInterviewResponse> GetAtsInterviewAsync(string connectionId, string id, List<string>? fields = null);

        /// <summary>
        /// List all interviews
        /// </summary>
        Task<ListAtsInterviewsResponse> ListAtsInterviewsAsync(ListAtsInterviewsRequest request);

        /// <summary>
        /// Update a interview
        /// </summary>
        Task<PatchAtsInterviewResponse> PatchAtsInterviewAsync(string connectionId, string id, AtsInterview? atsInterview = null);

        /// <summary>
        /// Remove a interview
        /// </summary>
        Task<RemoveAtsInterviewResponse> RemoveAtsInterviewAsync(string connectionId, string id);

        /// <summary>
        /// Update a interview
        /// </summary>
        Task<UpdateAtsInterviewResponse> UpdateAtsInterviewAsync(string connectionId, string id, AtsInterview? atsInterview = null);
    }

    public class Interview: IInterview
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

        public Interview(ISpeakeasyHttpClient defaultClient, Func<Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<CreateAtsInterviewResponse> CreateAtsInterviewAsync(string connectionId, AtsInterview? atsInterview = null)
        {
            var request = new CreateAtsInterviewRequest()
            {
                ConnectionId = connectionId,
                AtsInterview = atsInterview,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ats/{connection_id}/interview", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "AtsInterview", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            var response = new CreateAtsInterviewResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if (response.StatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {                    
                    var obj = ResponseBodyDeserializer.Deserialize<AtsInterview>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    response.AtsInterview = obj;
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


        public async Task<GetAtsInterviewResponse> GetAtsInterviewAsync(string connectionId, string id, List<string>? fields = null)
        {
            var request = new GetAtsInterviewRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                Fields = fields,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ats/{connection_id}/interview/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            var response = new GetAtsInterviewResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if (response.StatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {                    
                    var obj = ResponseBodyDeserializer.Deserialize<AtsInterview>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    response.AtsInterview = obj;
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


        public async Task<ListAtsInterviewsResponse> ListAtsInterviewsAsync(ListAtsInterviewsRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ats/{connection_id}/interview", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            var response = new ListAtsInterviewsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if (response.StatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {                    
                    var obj = ResponseBodyDeserializer.Deserialize<List<AtsInterview>>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    response.AtsInterviews = obj;
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


        public async Task<PatchAtsInterviewResponse> PatchAtsInterviewAsync(string connectionId, string id, AtsInterview? atsInterview = null)
        {
            var request = new PatchAtsInterviewRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                AtsInterview = atsInterview,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ats/{connection_id}/interview/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Patch, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "AtsInterview", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            var response = new PatchAtsInterviewResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if (response.StatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {                    
                    var obj = ResponseBodyDeserializer.Deserialize<AtsInterview>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    response.AtsInterview = obj;
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


        public async Task<RemoveAtsInterviewResponse> RemoveAtsInterviewAsync(string connectionId, string id)
        {
            var request = new RemoveAtsInterviewRequest()
            {
                ConnectionId = connectionId,
                Id = id,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ats/{connection_id}/interview/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            var response = new RemoveAtsInterviewResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if (response.StatusCode >= 200 && response.StatusCode < 300)
            {

            }
            else if (response.StatusCode >= 400 && response.StatusCode < 500 || response.StatusCode >= 500 && response.StatusCode < 600)
            {
                throw new SDKException("API error occurred", (int)httpResponse.StatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);

            }
            else
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {                    
                    var obj = ResponseBodyDeserializer.Deserialize<string>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    response.String = obj;
                }
                else
                {
                throw new SDKException("API error occurred", (int)httpResponse.StatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }

            }
            return response;
        }


        public async Task<UpdateAtsInterviewResponse> UpdateAtsInterviewAsync(string connectionId, string id, AtsInterview? atsInterview = null)
        {
            var request = new UpdateAtsInterviewRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                AtsInterview = atsInterview,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ats/{connection_id}/interview/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "AtsInterview", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            var response = new UpdateAtsInterviewResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if (response.StatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {                    
                    var obj = ResponseBodyDeserializer.Deserialize<AtsInterview>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    response.AtsInterview = obj;
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