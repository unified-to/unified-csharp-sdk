
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

    public interface IDeal
    {

        /// <summary>
        /// Create a deal
        /// </summary>
        Task<CreateCrmDealResponse> CreateCrmDealAsync(string connectionId, CrmDeal? crmDeal = null);

        /// <summary>
        /// Retrieve a deal
        /// </summary>
        Task<GetCrmDealResponse> GetCrmDealAsync(string connectionId, string id, List<string>? fields = null);

        /// <summary>
        /// List all deals
        /// </summary>
        Task<ListCrmDealsResponse> ListCrmDealsAsync(ListCrmDealsRequest request);

        /// <summary>
        /// Update a deal
        /// </summary>
        Task<PatchCrmDealResponse> PatchCrmDealAsync(string connectionId, string id, CrmDeal? crmDeal = null);

        /// <summary>
        /// Remove a deal
        /// </summary>
        Task<RemoveCrmDealResponse> RemoveCrmDealAsync(string connectionId, string id);

        /// <summary>
        /// Update a deal
        /// </summary>
        Task<UpdateCrmDealResponse> UpdateCrmDealAsync(string connectionId, string id, CrmDeal? crmDeal = null);
    }

    public class Deal: IDeal
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.12.5";
        private const string _sdkGenVersion = "2.281.2";
        private const string _openapiDocVersion = "1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.12.5 2.281.2 1.0 UnifiedTo";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;

        public Deal(ISpeakeasyHttpClient defaultClient, Func<Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<CreateCrmDealResponse> CreateCrmDealAsync(string connectionId, CrmDeal? crmDeal = null)
        {
            var request = new CreateCrmDealRequest()
            {
                ConnectionId = connectionId,
                CrmDeal = crmDeal,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/crm/{connection_id}/deal", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "CrmDeal", "json", false, true);
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

            var response = new CreateCrmDealResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CrmDeal = JsonConvert.DeserializeObject<CrmDeal>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }


        public async Task<GetCrmDealResponse> GetCrmDealAsync(string connectionId, string id, List<string>? fields = null)
        {
            var request = new GetCrmDealRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                Fields = fields,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/crm/{connection_id}/deal/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new GetCrmDealResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CrmDeal = JsonConvert.DeserializeObject<CrmDeal>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }


        public async Task<ListCrmDealsResponse> ListCrmDealsAsync(ListCrmDealsRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/crm/{connection_id}/deal", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new ListCrmDealsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CrmDeals = JsonConvert.DeserializeObject<List<CrmDeal>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }


        public async Task<PatchCrmDealResponse> PatchCrmDealAsync(string connectionId, string id, CrmDeal? crmDeal = null)
        {
            var request = new PatchCrmDealRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                CrmDeal = crmDeal,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/crm/{connection_id}/deal/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Patch, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "CrmDeal", "json", false, true);
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

            var response = new PatchCrmDealResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CrmDeal = JsonConvert.DeserializeObject<CrmDeal>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }


        public async Task<RemoveCrmDealResponse> RemoveCrmDealAsync(string connectionId, string id)
        {
            var request = new RemoveCrmDealRequest()
            {
                ConnectionId = connectionId,
                Id = id,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/crm/{connection_id}/deal/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new RemoveCrmDealResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
                    response.String = JsonConvert.DeserializeObject<string>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
            return response;
        }


        public async Task<UpdateCrmDealResponse> UpdateCrmDealAsync(string connectionId, string id, CrmDeal? crmDeal = null)
        {
            var request = new UpdateCrmDealRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                CrmDeal = crmDeal,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/crm/{connection_id}/deal/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "CrmDeal", "json", false, true);
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

            var response = new UpdateCrmDealResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CrmDeal = JsonConvert.DeserializeObject<CrmDeal>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

    }
}