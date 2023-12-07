
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
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;
    using UnifiedCsharpSDK.Models.Components;
    using UnifiedCsharpSDK.Models.Requests;
    using UnifiedCsharpSDK.Utils;

    public interface IJob
    {

        /// <summary>
        /// Create a job
        /// </summary>
        Task<CreateAtsJobResponse> CreateAtsJobAsync(string connectionId, AtsJob? atsJob = null);

        /// <summary>
        /// Retrieve a job
        /// </summary>
        Task<GetAtsJobResponse> GetAtsJobAsync(string connectionId, string id, List<string>? fields = null);

        /// <summary>
        /// List all jobs
        /// </summary>
        Task<ListAtsJobsResponse> ListAtsJobsAsync(ListAtsJobsRequest? request = null);

        /// <summary>
        /// Update a job
        /// </summary>
        Task<PatchAtsJobResponse> PatchAtsJobAsync(string connectionId, string id, AtsJob? atsJob = null);

        /// <summary>
        /// Remove a job
        /// </summary>
        Task<RemoveAtsJobResponse> RemoveAtsJobAsync(string connectionId, string id);

        /// <summary>
        /// Update a job
        /// </summary>
        Task<UpdateAtsJobResponse> UpdateAtsJobAsync(string connectionId, string id, AtsJob? atsJob = null);
    }

    public class Job: IJob
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.1.2";
        private const string _sdkGenVersion = "2.210.6";
        private const string _openapiDocVersion = "1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.1.2 2.210.6 1.0 Unified-csharp-sdk";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public Job(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<CreateAtsJobResponse> CreateAtsJobAsync(string connectionId, AtsJob? atsJob = null)
        {
            var request = new CreateAtsJobRequest()
            {
                ConnectionId = connectionId,
                AtsJob = atsJob,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ats/{connection_id}/job", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "AtsJob", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new CreateAtsJobResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.AtsJob = JsonConvert.DeserializeObject<AtsJob>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetAtsJobResponse> GetAtsJobAsync(string connectionId, string id, List<string>? fields = null)
        {
            var request = new GetAtsJobRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                Fields = fields,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ats/{connection_id}/job/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetAtsJobResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.AtsJob = JsonConvert.DeserializeObject<AtsJob>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<ListAtsJobsResponse> ListAtsJobsAsync(ListAtsJobsRequest? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ats/{connection_id}/job", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new ListAtsJobsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.AtsJobs = JsonConvert.DeserializeObject<List<AtsJob>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<PatchAtsJobResponse> PatchAtsJobAsync(string connectionId, string id, AtsJob? atsJob = null)
        {
            var request = new PatchAtsJobRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                AtsJob = atsJob,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ats/{connection_id}/job/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Patch, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "AtsJob", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new PatchAtsJobResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.AtsJob = JsonConvert.DeserializeObject<AtsJob>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<RemoveAtsJobResponse> RemoveAtsJobAsync(string connectionId, string id)
        {
            var request = new RemoveAtsJobRequest()
            {
                ConnectionId = connectionId,
                Id = id,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ats/{connection_id}/job/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new RemoveAtsJobResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            throw new InvalidOperationException("API returned unexpected status code or content type");
        }
        

        public async Task<UpdateAtsJobResponse> UpdateAtsJobAsync(string connectionId, string id, AtsJob? atsJob = null)
        {
            var request = new UpdateAtsJobRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                AtsJob = atsJob,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ats/{connection_id}/job/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "AtsJob", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new UpdateAtsJobResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.AtsJob = JsonConvert.DeserializeObject<AtsJob>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        
    }
}