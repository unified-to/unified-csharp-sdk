
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

    public interface IInventory
    {

        /// <summary>
        /// Create an inventory
        /// </summary>
        Task<CreateCommerceInventoryResponse> CreateCommerceInventoryAsync(CreateCommerceInventorySecurity security, string connectionId, CommerceInventory? commerceInventory = null);

        /// <summary>
        /// Retrieve an inventory
        /// </summary>
        Task<GetCommerceInventoryResponse> GetCommerceInventoryAsync(GetCommerceInventorySecurity security, string connectionId, string id, List<string>? fields = null);

        /// <summary>
        /// List all inventories
        /// </summary>
        Task<ListCommerceInventoriesResponse> ListCommerceInventoriesAsync(ListCommerceInventoriesSecurity security, ListCommerceInventoriesRequest request);

        /// <summary>
        /// Update an inventory
        /// </summary>
        Task<PatchCommerceInventoryResponse> PatchCommerceInventoryAsync(PatchCommerceInventorySecurity security, string connectionId, string id, CommerceInventory? commerceInventory = null);

        /// <summary>
        /// Remove an inventory
        /// </summary>
        Task<RemoveCommerceInventoryResponse> RemoveCommerceInventoryAsync(RemoveCommerceInventorySecurity security, string connectionId, string id);

        /// <summary>
        /// Update an inventory
        /// </summary>
        Task<UpdateCommerceInventoryResponse> UpdateCommerceInventoryAsync(UpdateCommerceInventorySecurity security, string connectionId, string id, CommerceInventory? commerceInventory = null);
    }

    public class Inventory: IInventory
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.11.0";
        private const string _sdkGenVersion = "2.272.4";
        private const string _openapiDocVersion = "1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.11.0 2.272.4 1.0 UnifiedTo";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;

        public Inventory(ISpeakeasyHttpClient defaultClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<CreateCommerceInventoryResponse> CreateCommerceInventoryAsync(CreateCommerceInventorySecurity security, string connectionId, CommerceInventory? commerceInventory = null)
        {
            var request = new CreateCommerceInventoryRequest()
            {
                ConnectionId = connectionId,
                CommerceInventory = commerceInventory,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/commerce/{connection_id}/inventory", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "CommerceInventory", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new CreateCommerceInventoryResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CommerceInventory = JsonConvert.DeserializeObject<CommerceInventory>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<GetCommerceInventoryResponse> GetCommerceInventoryAsync(GetCommerceInventorySecurity security, string connectionId, string id, List<string>? fields = null)
        {
            var request = new GetCommerceInventoryRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                Fields = fields,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/commerce/{connection_id}/inventory/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new GetCommerceInventoryResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CommerceInventory = JsonConvert.DeserializeObject<CommerceInventory>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<ListCommerceInventoriesResponse> ListCommerceInventoriesAsync(ListCommerceInventoriesSecurity security, ListCommerceInventoriesRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/commerce/{connection_id}/inventory", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new ListCommerceInventoriesResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CommerceInventories = JsonConvert.DeserializeObject<List<CommerceInventory>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<PatchCommerceInventoryResponse> PatchCommerceInventoryAsync(PatchCommerceInventorySecurity security, string connectionId, string id, CommerceInventory? commerceInventory = null)
        {
            var request = new PatchCommerceInventoryRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                CommerceInventory = commerceInventory,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/commerce/{connection_id}/inventory/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Patch, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "CommerceInventory", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new PatchCommerceInventoryResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CommerceInventory = JsonConvert.DeserializeObject<CommerceInventory>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<RemoveCommerceInventoryResponse> RemoveCommerceInventoryAsync(RemoveCommerceInventorySecurity security, string connectionId, string id)
        {
            var request = new RemoveCommerceInventoryRequest()
            {
                ConnectionId = connectionId,
                Id = id,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/commerce/{connection_id}/inventory/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new RemoveCommerceInventoryResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            throw new InvalidOperationException("API returned unexpected status code or content type");
        }

        

        public async Task<UpdateCommerceInventoryResponse> UpdateCommerceInventoryAsync(UpdateCommerceInventorySecurity security, string connectionId, string id, CommerceInventory? commerceInventory = null)
        {
            var request = new UpdateCommerceInventoryRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                CommerceInventory = commerceInventory,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/commerce/{connection_id}/inventory/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "CommerceInventory", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new UpdateCommerceInventoryResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CommerceInventory = JsonConvert.DeserializeObject<CommerceInventory>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        
    }
}