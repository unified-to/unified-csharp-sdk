
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

    public interface IPayment
    {

        /// <summary>
        /// Create a payment link
        /// </summary>
        Task<CreatePaymentLinkResponse> CreatePaymentLinkAsync(string connectionId, PaymentLink? paymentLink = null);

        /// <summary>
        /// Create a payment
        /// </summary>
        Task<CreatePaymentPaymentResponse> CreatePaymentPaymentAsync(string connectionId, PaymentPayment? paymentPayment = null);

        /// <summary>
        /// Retrieve a payment link
        /// </summary>
        Task<GetPaymentLinkResponse> GetPaymentLinkAsync(string connectionId, string id, List<string>? fields = null);

        /// <summary>
        /// Retrieve a payment
        /// </summary>
        Task<GetPaymentPaymentResponse> GetPaymentPaymentAsync(string connectionId, string id, List<string>? fields = null);

        /// <summary>
        /// Retrieve a payout
        /// </summary>
        Task<GetPaymentPayoutResponse> GetPaymentPayoutAsync(string connectionId, string id, List<string>? fields = null);

        /// <summary>
        /// Retrieve a refund
        /// </summary>
        Task<GetPaymentRefundResponse> GetPaymentRefundAsync(string connectionId, string id, List<string>? fields = null);

        /// <summary>
        /// List all payment links
        /// </summary>
        Task<ListPaymentLinksResponse> ListPaymentLinksAsync(ListPaymentLinksRequest request);

        /// <summary>
        /// List all payments
        /// </summary>
        Task<ListPaymentPaymentsResponse> ListPaymentPaymentsAsync(ListPaymentPaymentsRequest request);

        /// <summary>
        /// List all payouts
        /// </summary>
        Task<ListPaymentPayoutsResponse> ListPaymentPayoutsAsync(ListPaymentPayoutsRequest request);

        /// <summary>
        /// List all refunds
        /// </summary>
        Task<ListPaymentRefundsResponse> ListPaymentRefundsAsync(ListPaymentRefundsRequest request);

        /// <summary>
        /// Update a payment link
        /// </summary>
        Task<PatchPaymentLinkResponse> PatchPaymentLinkAsync(string connectionId, string id, PaymentLink? paymentLink = null);

        /// <summary>
        /// Update a payment
        /// </summary>
        Task<PatchPaymentPaymentResponse> PatchPaymentPaymentAsync(string connectionId, string id, PaymentPayment? paymentPayment = null);

        /// <summary>
        /// Remove a payment link
        /// </summary>
        Task<RemovePaymentLinkResponse> RemovePaymentLinkAsync(string connectionId, string id);

        /// <summary>
        /// Remove a payment
        /// </summary>
        Task<RemovePaymentPaymentResponse> RemovePaymentPaymentAsync(string connectionId, string id);

        /// <summary>
        /// Update a payment link
        /// </summary>
        Task<UpdatePaymentLinkResponse> UpdatePaymentLinkAsync(string connectionId, string id, PaymentLink? paymentLink = null);

        /// <summary>
        /// Update a payment
        /// </summary>
        Task<UpdatePaymentPaymentResponse> UpdatePaymentPaymentAsync(string connectionId, string id, PaymentPayment? paymentPayment = null);
    }

    public class Payment: IPayment
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.13.0";
        private const string _sdkGenVersion = "2.292.0";
        private const string _openapiDocVersion = "1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.13.0 2.292.0 1.0 UnifiedTo";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;

        public Payment(ISpeakeasyHttpClient defaultClient, Func<Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<CreatePaymentLinkResponse> CreatePaymentLinkAsync(string connectionId, PaymentLink? paymentLink = null)
        {
            var request = new CreatePaymentLinkRequest()
            {
                ConnectionId = connectionId,
                PaymentLink = paymentLink,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/payment/{connection_id}/link", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "PaymentLink", "json", false, true);
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

            var response = new CreatePaymentLinkResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.PaymentLink = JsonConvert.DeserializeObject<PaymentLink>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumConverter(), new AnyDeserializer() }});
                }

                return response;
            }
            return response;
        }


        public async Task<CreatePaymentPaymentResponse> CreatePaymentPaymentAsync(string connectionId, PaymentPayment? paymentPayment = null)
        {
            var request = new CreatePaymentPaymentRequest()
            {
                ConnectionId = connectionId,
                PaymentPayment = paymentPayment,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/payment/{connection_id}/payment", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "PaymentPayment", "json", false, true);
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

            var response = new CreatePaymentPaymentResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.PaymentPayment = JsonConvert.DeserializeObject<PaymentPayment>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumConverter(), new AnyDeserializer() }});
                }

                return response;
            }
            return response;
        }


        public async Task<GetPaymentLinkResponse> GetPaymentLinkAsync(string connectionId, string id, List<string>? fields = null)
        {
            var request = new GetPaymentLinkRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                Fields = fields,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/payment/{connection_id}/link/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new GetPaymentLinkResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.PaymentLink = JsonConvert.DeserializeObject<PaymentLink>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumConverter(), new AnyDeserializer() }});
                }

                return response;
            }
            return response;
        }


        public async Task<GetPaymentPaymentResponse> GetPaymentPaymentAsync(string connectionId, string id, List<string>? fields = null)
        {
            var request = new GetPaymentPaymentRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                Fields = fields,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/payment/{connection_id}/payment/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new GetPaymentPaymentResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.PaymentPayment = JsonConvert.DeserializeObject<PaymentPayment>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumConverter(), new AnyDeserializer() }});
                }

                return response;
            }
            return response;
        }


        public async Task<GetPaymentPayoutResponse> GetPaymentPayoutAsync(string connectionId, string id, List<string>? fields = null)
        {
            var request = new GetPaymentPayoutRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                Fields = fields,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/payment/{connection_id}/payout/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new GetPaymentPayoutResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.PaymentPayout = JsonConvert.DeserializeObject<PaymentPayout>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumConverter(), new AnyDeserializer() }});
                }

                return response;
            }
            return response;
        }


        public async Task<GetPaymentRefundResponse> GetPaymentRefundAsync(string connectionId, string id, List<string>? fields = null)
        {
            var request = new GetPaymentRefundRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                Fields = fields,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/payment/{connection_id}/refund/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new GetPaymentRefundResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.PaymentRefund = JsonConvert.DeserializeObject<PaymentRefund>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumConverter(), new AnyDeserializer() }});
                }

                return response;
            }
            return response;
        }


        public async Task<ListPaymentLinksResponse> ListPaymentLinksAsync(ListPaymentLinksRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/payment/{connection_id}/link", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new ListPaymentLinksResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.PaymentLinks = JsonConvert.DeserializeObject<List<PaymentLink>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumConverter(), new AnyDeserializer() }});
                }

                return response;
            }
            return response;
        }


        public async Task<ListPaymentPaymentsResponse> ListPaymentPaymentsAsync(ListPaymentPaymentsRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/payment/{connection_id}/payment", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new ListPaymentPaymentsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.PaymentPayments = JsonConvert.DeserializeObject<List<PaymentPayment>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumConverter(), new AnyDeserializer() }});
                }

                return response;
            }
            return response;
        }


        public async Task<ListPaymentPayoutsResponse> ListPaymentPayoutsAsync(ListPaymentPayoutsRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/payment/{connection_id}/payout", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new ListPaymentPayoutsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.PaymentPayouts = JsonConvert.DeserializeObject<List<PaymentPayout>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumConverter(), new AnyDeserializer() }});
                }

                return response;
            }
            return response;
        }


        public async Task<ListPaymentRefundsResponse> ListPaymentRefundsAsync(ListPaymentRefundsRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/payment/{connection_id}/refund", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new ListPaymentRefundsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.PaymentRefunds = JsonConvert.DeserializeObject<List<PaymentRefund>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumConverter(), new AnyDeserializer() }});
                }

                return response;
            }
            return response;
        }


        public async Task<PatchPaymentLinkResponse> PatchPaymentLinkAsync(string connectionId, string id, PaymentLink? paymentLink = null)
        {
            var request = new PatchPaymentLinkRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                PaymentLink = paymentLink,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/payment/{connection_id}/link/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Patch, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "PaymentLink", "json", false, true);
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

            var response = new PatchPaymentLinkResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.PaymentLink = JsonConvert.DeserializeObject<PaymentLink>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumConverter(), new AnyDeserializer() }});
                }

                return response;
            }
            return response;
        }


        public async Task<PatchPaymentPaymentResponse> PatchPaymentPaymentAsync(string connectionId, string id, PaymentPayment? paymentPayment = null)
        {
            var request = new PatchPaymentPaymentRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                PaymentPayment = paymentPayment,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/payment/{connection_id}/payment/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Patch, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "PaymentPayment", "json", false, true);
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

            var response = new PatchPaymentPaymentResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.PaymentPayment = JsonConvert.DeserializeObject<PaymentPayment>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumConverter(), new AnyDeserializer() }});
                }

                return response;
            }
            return response;
        }


        public async Task<RemovePaymentLinkResponse> RemovePaymentLinkAsync(string connectionId, string id)
        {
            var request = new RemovePaymentLinkRequest()
            {
                ConnectionId = connectionId,
                Id = id,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/payment/{connection_id}/link/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new RemovePaymentLinkResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode >= 200 && response.StatusCode < 300))
            {

                return response;
            }
                    response.String = JsonConvert.DeserializeObject<string>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumConverter(), new AnyDeserializer() }});
            return response;
        }


        public async Task<RemovePaymentPaymentResponse> RemovePaymentPaymentAsync(string connectionId, string id)
        {
            var request = new RemovePaymentPaymentRequest()
            {
                ConnectionId = connectionId,
                Id = id,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/payment/{connection_id}/payment/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new RemovePaymentPaymentResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode >= 200 && response.StatusCode < 300))
            {

                return response;
            }
                    response.String = JsonConvert.DeserializeObject<string>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumConverter(), new AnyDeserializer() }});
            return response;
        }


        public async Task<UpdatePaymentLinkResponse> UpdatePaymentLinkAsync(string connectionId, string id, PaymentLink? paymentLink = null)
        {
            var request = new UpdatePaymentLinkRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                PaymentLink = paymentLink,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/payment/{connection_id}/link/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "PaymentLink", "json", false, true);
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

            var response = new UpdatePaymentLinkResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.PaymentLink = JsonConvert.DeserializeObject<PaymentLink>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumConverter(), new AnyDeserializer() }});
                }

                return response;
            }
            return response;
        }


        public async Task<UpdatePaymentPaymentResponse> UpdatePaymentPaymentAsync(string connectionId, string id, PaymentPayment? paymentPayment = null)
        {
            var request = new UpdatePaymentPaymentRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                PaymentPayment = paymentPayment,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/payment/{connection_id}/payment/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "PaymentPayment", "json", false, true);
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

            var response = new UpdatePaymentPaymentResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.PaymentPayment = JsonConvert.DeserializeObject<PaymentPayment>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumConverter(), new AnyDeserializer() }});
                }

                return response;
            }
            return response;
        }

    }
}