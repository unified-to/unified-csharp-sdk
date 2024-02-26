
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
    using UnifiedTo.Models.Requests;
    using UnifiedTo.Utils;

    public interface ICandidate
    {

        /// <summary>
        /// Create a candidate
        /// </summary>
        Task<CreateAtsCandidateResponse> CreateAtsCandidateAsync(CreateAtsCandidateSecurity security, string connectionId, AtsCandidate? atsCandidate = null);

        /// <summary>
        /// Retrieve a candidate
        /// </summary>
        Task<GetAtsCandidateResponse> GetAtsCandidateAsync(GetAtsCandidateSecurity security, string connectionId, string id, List<string>? fields = null);

        /// <summary>
        /// List all candidates
        /// </summary>
        Task<ListAtsCandidatesResponse> ListAtsCandidatesAsync(ListAtsCandidatesSecurity security, ListAtsCandidatesRequest request);

        /// <summary>
        /// Update a candidate
        /// </summary>
        Task<PatchAtsCandidateResponse> PatchAtsCandidateAsync(PatchAtsCandidateSecurity security, string connectionId, string id, AtsCandidate? atsCandidate = null);

        /// <summary>
        /// Remove a candidate
        /// </summary>
        Task<RemoveAtsCandidateResponse> RemoveAtsCandidateAsync(RemoveAtsCandidateSecurity security, string connectionId, string id);

        /// <summary>
        /// Update a candidate
        /// </summary>
        Task<UpdateAtsCandidateResponse> UpdateAtsCandidateAsync(UpdateAtsCandidateSecurity security, string connectionId, string id, AtsCandidate? atsCandidate = null);
    }

    public class Candidate: ICandidate
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.11.1";
        private const string _sdkGenVersion = "2.272.4";
        private const string _openapiDocVersion = "1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.11.1 2.272.4 1.0 UnifiedTo";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;

        public Candidate(ISpeakeasyHttpClient defaultClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<CreateAtsCandidateResponse> CreateAtsCandidateAsync(CreateAtsCandidateSecurity security, string connectionId, AtsCandidate? atsCandidate = null)
        {
            var request = new CreateAtsCandidateRequest()
            {
                ConnectionId = connectionId,
                AtsCandidate = atsCandidate,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ats/{connection_id}/candidate", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "AtsCandidate", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new CreateAtsCandidateResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.AtsCandidate = JsonConvert.DeserializeObject<AtsCandidate>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<GetAtsCandidateResponse> GetAtsCandidateAsync(GetAtsCandidateSecurity security, string connectionId, string id, List<string>? fields = null)
        {
            var request = new GetAtsCandidateRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                Fields = fields,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ats/{connection_id}/candidate/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new GetAtsCandidateResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.AtsCandidate = JsonConvert.DeserializeObject<AtsCandidate>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<ListAtsCandidatesResponse> ListAtsCandidatesAsync(ListAtsCandidatesSecurity security, ListAtsCandidatesRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ats/{connection_id}/candidate", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new ListAtsCandidatesResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.AtsCandidates = JsonConvert.DeserializeObject<List<AtsCandidate>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<PatchAtsCandidateResponse> PatchAtsCandidateAsync(PatchAtsCandidateSecurity security, string connectionId, string id, AtsCandidate? atsCandidate = null)
        {
            var request = new PatchAtsCandidateRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                AtsCandidate = atsCandidate,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ats/{connection_id}/candidate/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Patch, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "AtsCandidate", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new PatchAtsCandidateResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.AtsCandidate = JsonConvert.DeserializeObject<AtsCandidate>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<RemoveAtsCandidateResponse> RemoveAtsCandidateAsync(RemoveAtsCandidateSecurity security, string connectionId, string id)
        {
            var request = new RemoveAtsCandidateRequest()
            {
                ConnectionId = connectionId,
                Id = id,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ats/{connection_id}/candidate/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new RemoveAtsCandidateResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            throw new InvalidOperationException("API returned unexpected status code or content type");
        }

        

        public async Task<UpdateAtsCandidateResponse> UpdateAtsCandidateAsync(UpdateAtsCandidateSecurity security, string connectionId, string id, AtsCandidate? atsCandidate = null)
        {
            var request = new UpdateAtsCandidateRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                AtsCandidate = atsCandidate,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ats/{connection_id}/candidate/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "AtsCandidate", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new UpdateAtsCandidateResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.AtsCandidate = JsonConvert.DeserializeObject<AtsCandidate>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        
    }
}