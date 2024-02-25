
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

    public interface IMartech
    {

        /// <summary>
        /// Create a list
        /// </summary>
        Task<CreateMartechListResponse> CreateMartechListAsync(CreateMartechListSecurity security, string connectionId, MarketingList? marketingList = null);

        /// <summary>
        /// Create a member
        /// </summary>
        Task<CreateMartechMemberResponse> CreateMartechMemberAsync(CreateMartechMemberSecurity security, string connectionId, MarketingMember? marketingMember = null);

        /// <summary>
        /// Retrieve a list
        /// </summary>
        Task<GetMartechListResponse> GetMartechListAsync(GetMartechListSecurity security, string connectionId, string id, List<string>? fields = null);

        /// <summary>
        /// Retrieve a member
        /// </summary>
        Task<GetMartechMemberResponse> GetMartechMemberAsync(GetMartechMemberSecurity security, string connectionId, string id, List<string>? fields = null);

        /// <summary>
        /// List all lists
        /// </summary>
        Task<ListMartechListsResponse> ListMartechListsAsync(ListMartechListsSecurity security, ListMartechListsRequest request);

        /// <summary>
        /// List all members
        /// </summary>
        Task<ListMartechMembersResponse> ListMartechMembersAsync(ListMartechMembersSecurity security, ListMartechMembersRequest request);

        /// <summary>
        /// Update a list
        /// </summary>
        Task<PatchMartechListResponse> PatchMartechListAsync(PatchMartechListSecurity security, string connectionId, string id, MarketingList? marketingList = null);

        /// <summary>
        /// Update a member
        /// </summary>
        Task<PatchMartechMemberResponse> PatchMartechMemberAsync(PatchMartechMemberSecurity security, string connectionId, string id, MarketingMember? marketingMember = null);

        /// <summary>
        /// Remove a list
        /// </summary>
        Task<RemoveMartechListResponse> RemoveMartechListAsync(RemoveMartechListSecurity security, string connectionId, string id);

        /// <summary>
        /// Remove member
        /// </summary>
        Task<RemoveMartechMemberResponse> RemoveMartechMemberAsync(RemoveMartechMemberSecurity security, string connectionId, string id);

        /// <summary>
        /// Update a list
        /// </summary>
        Task<UpdateMartechListResponse> UpdateMartechListAsync(UpdateMartechListSecurity security, string connectionId, string id, MarketingList? marketingList = null);

        /// <summary>
        /// Update a member
        /// </summary>
        Task<UpdateMartechMemberResponse> UpdateMartechMemberAsync(UpdateMartechMemberSecurity security, string connectionId, string id, MarketingMember? marketingMember = null);
    }

    public class Martech: IMartech
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.11.0";
        private const string _sdkGenVersion = "2.272.4";
        private const string _openapiDocVersion = "1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.11.0 2.272.4 1.0 UnifiedTo";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;

        public Martech(ISpeakeasyHttpClient defaultClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<CreateMartechListResponse> CreateMartechListAsync(CreateMartechListSecurity security, string connectionId, MarketingList? marketingList = null)
        {
            var request = new CreateMartechListRequest()
            {
                ConnectionId = connectionId,
                MarketingList = marketingList,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/martech/{connection_id}/list", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "MarketingList", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new CreateMartechListResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.MarketingList = JsonConvert.DeserializeObject<MarketingList>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<CreateMartechMemberResponse> CreateMartechMemberAsync(CreateMartechMemberSecurity security, string connectionId, MarketingMember? marketingMember = null)
        {
            var request = new CreateMartechMemberRequest()
            {
                ConnectionId = connectionId,
                MarketingMember = marketingMember,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/martech/{connection_id}/member", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "MarketingMember", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new CreateMartechMemberResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.MarketingMember = JsonConvert.DeserializeObject<MarketingMember>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<GetMartechListResponse> GetMartechListAsync(GetMartechListSecurity security, string connectionId, string id, List<string>? fields = null)
        {
            var request = new GetMartechListRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                Fields = fields,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/martech/{connection_id}/list/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new GetMartechListResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.MarketingList = JsonConvert.DeserializeObject<MarketingList>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<GetMartechMemberResponse> GetMartechMemberAsync(GetMartechMemberSecurity security, string connectionId, string id, List<string>? fields = null)
        {
            var request = new GetMartechMemberRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                Fields = fields,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/martech/{connection_id}/member/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new GetMartechMemberResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.MarketingMember = JsonConvert.DeserializeObject<MarketingMember>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<ListMartechListsResponse> ListMartechListsAsync(ListMartechListsSecurity security, ListMartechListsRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/martech/{connection_id}/list", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new ListMartechListsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.MarketingLists = JsonConvert.DeserializeObject<List<MarketingList>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<ListMartechMembersResponse> ListMartechMembersAsync(ListMartechMembersSecurity security, ListMartechMembersRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/martech/{connection_id}/member", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new ListMartechMembersResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.MarketingMembers = JsonConvert.DeserializeObject<List<MarketingMember>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<PatchMartechListResponse> PatchMartechListAsync(PatchMartechListSecurity security, string connectionId, string id, MarketingList? marketingList = null)
        {
            var request = new PatchMartechListRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                MarketingList = marketingList,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/martech/{connection_id}/list/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Patch, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "MarketingList", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new PatchMartechListResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.MarketingList = JsonConvert.DeserializeObject<MarketingList>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<PatchMartechMemberResponse> PatchMartechMemberAsync(PatchMartechMemberSecurity security, string connectionId, string id, MarketingMember? marketingMember = null)
        {
            var request = new PatchMartechMemberRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                MarketingMember = marketingMember,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/martech/{connection_id}/member/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Patch, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "MarketingMember", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new PatchMartechMemberResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.MarketingMember = JsonConvert.DeserializeObject<MarketingMember>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<RemoveMartechListResponse> RemoveMartechListAsync(RemoveMartechListSecurity security, string connectionId, string id)
        {
            var request = new RemoveMartechListRequest()
            {
                ConnectionId = connectionId,
                Id = id,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/martech/{connection_id}/list/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new RemoveMartechListResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            throw new InvalidOperationException("API returned unexpected status code or content type");
        }

        

        public async Task<RemoveMartechMemberResponse> RemoveMartechMemberAsync(RemoveMartechMemberSecurity security, string connectionId, string id)
        {
            var request = new RemoveMartechMemberRequest()
            {
                ConnectionId = connectionId,
                Id = id,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/martech/{connection_id}/member/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new RemoveMartechMemberResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            throw new InvalidOperationException("API returned unexpected status code or content type");
        }

        

        public async Task<UpdateMartechListResponse> UpdateMartechListAsync(UpdateMartechListSecurity security, string connectionId, string id, MarketingList? marketingList = null)
        {
            var request = new UpdateMartechListRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                MarketingList = marketingList,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/martech/{connection_id}/list/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "MarketingList", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new UpdateMartechListResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.MarketingList = JsonConvert.DeserializeObject<MarketingList>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<UpdateMartechMemberResponse> UpdateMartechMemberAsync(UpdateMartechMemberSecurity security, string connectionId, string id, MarketingMember? marketingMember = null)
        {
            var request = new UpdateMartechMemberRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                MarketingMember = marketingMember,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/martech/{connection_id}/member/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "MarketingMember", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new UpdateMartechMemberResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.MarketingMember = JsonConvert.DeserializeObject<MarketingMember>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        
    }
}