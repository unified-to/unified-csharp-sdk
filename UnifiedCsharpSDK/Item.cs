
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

    public interface IItem
    {

        /// <summary>
        /// Create an item
        /// </summary>
        Task<CreateAccountingItemResponse> CreateAccountingItemAsync(string connectionId, AccountingItem? accountingItem = null);

        /// <summary>
        /// Retrieve an item
        /// </summary>
        Task<GetAccountingItemResponse> GetAccountingItemAsync(string connectionId, string id, List<string>? fields = null);

        /// <summary>
        /// List all items
        /// </summary>
        Task<ListAccountingItemsResponse> ListAccountingItemsAsync(ListAccountingItemsRequest? request = null);

        /// <summary>
        /// Update an item
        /// </summary>
        Task<PatchAccountingItemResponse> PatchAccountingItemAsync(string connectionId, string id, AccountingItem? accountingItem = null);

        /// <summary>
        /// Remove an item
        /// </summary>
        Task<RemoveAccountingItemResponse> RemoveAccountingItemAsync(string connectionId, string id);

        /// <summary>
        /// Update an item
        /// </summary>
        Task<UpdateAccountingItemResponse> UpdateAccountingItemAsync(string connectionId, string id, AccountingItem? accountingItem = null);
    }

    public class Item: IItem
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.2.13";
        private const string _sdkGenVersion = "2.221.0";
        private const string _openapiDocVersion = "1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.2.13 2.221.0 1.0 Unified-csharp-sdk";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public Item(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<CreateAccountingItemResponse> CreateAccountingItemAsync(string connectionId, AccountingItem? accountingItem = null)
        {
            var request = new CreateAccountingItemRequest()
            {
                ConnectionId = connectionId,
                AccountingItem = accountingItem,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/accounting/{connection_id}/item", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "AccountingItem", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new CreateAccountingItemResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.AccountingItem = JsonConvert.DeserializeObject<AccountingItem>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetAccountingItemResponse> GetAccountingItemAsync(string connectionId, string id, List<string>? fields = null)
        {
            var request = new GetAccountingItemRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                Fields = fields,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/accounting/{connection_id}/item/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetAccountingItemResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.AccountingItem = JsonConvert.DeserializeObject<AccountingItem>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<ListAccountingItemsResponse> ListAccountingItemsAsync(ListAccountingItemsRequest? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/accounting/{connection_id}/item", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new ListAccountingItemsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.AccountingItems = JsonConvert.DeserializeObject<List<AccountingItem>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<PatchAccountingItemResponse> PatchAccountingItemAsync(string connectionId, string id, AccountingItem? accountingItem = null)
        {
            var request = new PatchAccountingItemRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                AccountingItem = accountingItem,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/accounting/{connection_id}/item/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Patch, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "AccountingItem", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new PatchAccountingItemResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.AccountingItem = JsonConvert.DeserializeObject<AccountingItem>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<RemoveAccountingItemResponse> RemoveAccountingItemAsync(string connectionId, string id)
        {
            var request = new RemoveAccountingItemRequest()
            {
                ConnectionId = connectionId,
                Id = id,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/accounting/{connection_id}/item/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new RemoveAccountingItemResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            throw new InvalidOperationException("API returned unexpected status code or content type");
        }
        

        public async Task<UpdateAccountingItemResponse> UpdateAccountingItemAsync(string connectionId, string id, AccountingItem? accountingItem = null)
        {
            var request = new UpdateAccountingItemRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                AccountingItem = accountingItem,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/accounting/{connection_id}/item/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "AccountingItem", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new UpdateAccountingItemResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.AccountingItem = JsonConvert.DeserializeObject<AccountingItem>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        
    }
}