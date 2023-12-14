
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

    public interface IInvoice
    {

        /// <summary>
        /// Create a invoice
        /// </summary>
        Task<CreateAccountingInvoiceResponse> CreateAccountingInvoiceAsync(string connectionId, AccountingInvoice? accountingInvoice = null);

        /// <summary>
        /// Retrieve a invoice
        /// </summary>
        Task<GetAccountingInvoiceResponse> GetAccountingInvoiceAsync(string connectionId, string id, List<string>? fields = null);

        /// <summary>
        /// List all invoices
        /// </summary>
        Task<ListAccountingInvoicesResponse> ListAccountingInvoicesAsync(ListAccountingInvoicesRequest? request = null);

        /// <summary>
        /// Update a invoice
        /// </summary>
        Task<PatchAccountingInvoiceResponse> PatchAccountingInvoiceAsync(string connectionId, string id, AccountingInvoice? accountingInvoice = null);

        /// <summary>
        /// Remove a invoice
        /// </summary>
        Task<RemoveAccountingInvoiceResponse> RemoveAccountingInvoiceAsync(string connectionId, string id);

        /// <summary>
        /// Update a invoice
        /// </summary>
        Task<UpdateAccountingInvoiceResponse> UpdateAccountingInvoiceAsync(string connectionId, string id, AccountingInvoice? accountingInvoice = null);
    }

    public class Invoice: IInvoice
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.2.5";
        private const string _sdkGenVersion = "2.214.3";
        private const string _openapiDocVersion = "1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.2.5 2.214.3 1.0 Unified-csharp-sdk";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public Invoice(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<CreateAccountingInvoiceResponse> CreateAccountingInvoiceAsync(string connectionId, AccountingInvoice? accountingInvoice = null)
        {
            var request = new CreateAccountingInvoiceRequest()
            {
                ConnectionId = connectionId,
                AccountingInvoice = accountingInvoice,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/accounting/{connection_id}/invoice", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "AccountingInvoice", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new CreateAccountingInvoiceResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.AccountingInvoice = JsonConvert.DeserializeObject<AccountingInvoice>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetAccountingInvoiceResponse> GetAccountingInvoiceAsync(string connectionId, string id, List<string>? fields = null)
        {
            var request = new GetAccountingInvoiceRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                Fields = fields,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/accounting/{connection_id}/invoice/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetAccountingInvoiceResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.AccountingInvoice = JsonConvert.DeserializeObject<AccountingInvoice>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<ListAccountingInvoicesResponse> ListAccountingInvoicesAsync(ListAccountingInvoicesRequest? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/accounting/{connection_id}/invoice", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new ListAccountingInvoicesResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.AccountingInvoices = JsonConvert.DeserializeObject<List<AccountingInvoice>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<PatchAccountingInvoiceResponse> PatchAccountingInvoiceAsync(string connectionId, string id, AccountingInvoice? accountingInvoice = null)
        {
            var request = new PatchAccountingInvoiceRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                AccountingInvoice = accountingInvoice,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/accounting/{connection_id}/invoice/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Patch, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "AccountingInvoice", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new PatchAccountingInvoiceResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.AccountingInvoice = JsonConvert.DeserializeObject<AccountingInvoice>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<RemoveAccountingInvoiceResponse> RemoveAccountingInvoiceAsync(string connectionId, string id)
        {
            var request = new RemoveAccountingInvoiceRequest()
            {
                ConnectionId = connectionId,
                Id = id,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/accounting/{connection_id}/invoice/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new RemoveAccountingInvoiceResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            throw new InvalidOperationException("API returned unexpected status code or content type");
        }
        

        public async Task<UpdateAccountingInvoiceResponse> UpdateAccountingInvoiceAsync(string connectionId, string id, AccountingInvoice? accountingInvoice = null)
        {
            var request = new UpdateAccountingInvoiceRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                AccountingInvoice = accountingInvoice,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/accounting/{connection_id}/invoice/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "AccountingInvoice", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new UpdateAccountingInvoiceResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.AccountingInvoice = JsonConvert.DeserializeObject<AccountingInvoice>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        
    }
}