
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

    public interface IWebhook
    {

        /// <summary>
        /// Create webhook subscription
        /// 
        /// <remarks>
        /// The data payload received by your server is described at https://docs.unified.to/unified/overview. The `interval` field can be set as low as 1 minute for paid accounts, and 60 minutes for free accounts.
        /// </remarks>
        /// </summary>
        Task<CreateUnifiedWebhookResponse> CreateUnifiedWebhookAsync(Models.Components.Webhook? webhook = null, bool? includeAll = null);

        /// <summary>
        /// Retrieve webhook by its ID
        /// </summary>
        Task<GetUnifiedWebhookResponse> GetUnifiedWebhookAsync(string id);

        /// <summary>
        /// Returns all registered webhooks
        /// </summary>
        Task<ListUnifiedWebhooksResponse> ListUnifiedWebhooksAsync(ListUnifiedWebhooksRequest request);

        /// <summary>
        /// Trigger webhook
        /// </summary>
        Task<PatchUnifiedWebhookTriggerResponse> PatchUnifiedWebhookTriggerAsync(string id);

        /// <summary>
        /// Remove webhook subscription
        /// </summary>
        Task<RemoveUnifiedWebhookResponse> RemoveUnifiedWebhookAsync(string id);

        /// <summary>
        /// Trigger webhook
        /// </summary>
        Task<UpdateUnifiedWebhookTriggerResponse> UpdateUnifiedWebhookTriggerAsync(string id);
    }

    public class Webhook: IWebhook
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.12.0";
        private const string _sdkGenVersion = "2.272.7";
        private const string _openapiDocVersion = "1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.12.0 2.272.7 1.0 UnifiedTo";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;

        public Webhook(ISpeakeasyHttpClient defaultClient, Func<Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<CreateUnifiedWebhookResponse> CreateUnifiedWebhookAsync(Models.Components.Webhook? webhook = null, bool? includeAll = null)
        {
            var request = new CreateUnifiedWebhookRequest()
            {
                Webhook = webhook,
                IncludeAll = includeAll,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/unified/webhook", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "Webhook", "json", false, true);
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

            var response = new CreateUnifiedWebhookResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Webhook = JsonConvert.DeserializeObject<Models.Components.Webhook>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<GetUnifiedWebhookResponse> GetUnifiedWebhookAsync(string id)
        {
            var request = new GetUnifiedWebhookRequest()
            {
                Id = id,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/unified/webhook/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new GetUnifiedWebhookResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Webhook = JsonConvert.DeserializeObject<Models.Components.Webhook>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<ListUnifiedWebhooksResponse> ListUnifiedWebhooksAsync(ListUnifiedWebhooksRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/unified/webhook", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new ListUnifiedWebhooksResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Webhooks = JsonConvert.DeserializeObject<List<Models.Components.Webhook>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<PatchUnifiedWebhookTriggerResponse> PatchUnifiedWebhookTriggerAsync(string id)
        {
            var request = new PatchUnifiedWebhookTriggerRequest()
            {
                Id = id,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/unified/webhook/{id}/trigger", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Patch, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new PatchUnifiedWebhookTriggerResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            throw new InvalidOperationException("API returned unexpected status code or content type");
        }

        

        public async Task<RemoveUnifiedWebhookResponse> RemoveUnifiedWebhookAsync(string id)
        {
            var request = new RemoveUnifiedWebhookRequest()
            {
                Id = id,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/unified/webhook/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new RemoveUnifiedWebhookResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            throw new InvalidOperationException("API returned unexpected status code or content type");
        }

        

        public async Task<UpdateUnifiedWebhookTriggerResponse> UpdateUnifiedWebhookTriggerAsync(string id)
        {
            var request = new UpdateUnifiedWebhookTriggerRequest()
            {
                Id = id,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/unified/webhook/{id}/trigger", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new UpdateUnifiedWebhookTriggerResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            throw new InvalidOperationException("API returned unexpected status code or content type");
        }

        
    }
}