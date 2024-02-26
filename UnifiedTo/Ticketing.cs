
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

    public interface ITicketing
    {

        /// <summary>
        /// Create a customer
        /// </summary>
        Task<CreateTicketingCustomerResponse> CreateTicketingCustomerAsync(CreateTicketingCustomerSecurity security, string connectionId, TicketingCustomer? ticketingCustomer = null);

        /// <summary>
        /// Create a note
        /// </summary>
        Task<CreateTicketingNoteResponse> CreateTicketingNoteAsync(CreateTicketingNoteSecurity security, string connectionId, TicketingNote? ticketingNote = null);

        /// <summary>
        /// Create a ticket
        /// </summary>
        Task<CreateTicketingTicketResponse> CreateTicketingTicketAsync(CreateTicketingTicketSecurity security, string connectionId, TicketingTicket? ticketingTicket = null);

        /// <summary>
        /// Retrieve a customer
        /// </summary>
        Task<GetTicketingCustomerResponse> GetTicketingCustomerAsync(GetTicketingCustomerSecurity security, string connectionId, string id, List<string>? fields = null);

        /// <summary>
        /// Retrieve a note
        /// </summary>
        Task<GetTicketingNoteResponse> GetTicketingNoteAsync(GetTicketingNoteSecurity security, string connectionId, string id, List<string>? fields = null);

        /// <summary>
        /// Retrieve a ticket
        /// </summary>
        Task<GetTicketingTicketResponse> GetTicketingTicketAsync(GetTicketingTicketSecurity security, string connectionId, string id, List<string>? fields = null);

        /// <summary>
        /// List all customers
        /// </summary>
        Task<ListTicketingCustomersResponse> ListTicketingCustomersAsync(ListTicketingCustomersSecurity security, ListTicketingCustomersRequest request);

        /// <summary>
        /// List all notes
        /// </summary>
        Task<ListTicketingNotesResponse> ListTicketingNotesAsync(ListTicketingNotesSecurity security, ListTicketingNotesRequest request);

        /// <summary>
        /// List all tickets
        /// </summary>
        Task<ListTicketingTicketsResponse> ListTicketingTicketsAsync(ListTicketingTicketsSecurity security, ListTicketingTicketsRequest request);

        /// <summary>
        /// Update a customer
        /// </summary>
        Task<PatchTicketingCustomerResponse> PatchTicketingCustomerAsync(PatchTicketingCustomerSecurity security, string connectionId, string id, TicketingCustomer? ticketingCustomer = null);

        /// <summary>
        /// Update a note
        /// </summary>
        Task<PatchTicketingNoteResponse> PatchTicketingNoteAsync(PatchTicketingNoteSecurity security, string connectionId, string id, TicketingNote? ticketingNote = null);

        /// <summary>
        /// Update a ticket
        /// </summary>
        Task<PatchTicketingTicketResponse> PatchTicketingTicketAsync(PatchTicketingTicketSecurity security, string connectionId, string id, TicketingTicket? ticketingTicket = null);

        /// <summary>
        /// Remove a customer
        /// </summary>
        Task<RemoveTicketingCustomerResponse> RemoveTicketingCustomerAsync(RemoveTicketingCustomerSecurity security, string connectionId, string id);

        /// <summary>
        /// Remove a note
        /// </summary>
        Task<RemoveTicketingNoteResponse> RemoveTicketingNoteAsync(RemoveTicketingNoteSecurity security, string connectionId, string id);

        /// <summary>
        /// Remove a ticket
        /// </summary>
        Task<RemoveTicketingTicketResponse> RemoveTicketingTicketAsync(RemoveTicketingTicketSecurity security, string connectionId, string id);

        /// <summary>
        /// Update a customer
        /// </summary>
        Task<UpdateTicketingCustomerResponse> UpdateTicketingCustomerAsync(UpdateTicketingCustomerSecurity security, string connectionId, string id, TicketingCustomer? ticketingCustomer = null);

        /// <summary>
        /// Update a note
        /// </summary>
        Task<UpdateTicketingNoteResponse> UpdateTicketingNoteAsync(UpdateTicketingNoteSecurity security, string connectionId, string id, TicketingNote? ticketingNote = null);

        /// <summary>
        /// Update a ticket
        /// </summary>
        Task<UpdateTicketingTicketResponse> UpdateTicketingTicketAsync(UpdateTicketingTicketSecurity security, string connectionId, string id, TicketingTicket? ticketingTicket = null);
    }

    public class Ticketing: ITicketing
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.11.1";
        private const string _sdkGenVersion = "2.272.4";
        private const string _openapiDocVersion = "1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.11.1 2.272.4 1.0 UnifiedTo";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;

        public Ticketing(ISpeakeasyHttpClient defaultClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<CreateTicketingCustomerResponse> CreateTicketingCustomerAsync(CreateTicketingCustomerSecurity security, string connectionId, TicketingCustomer? ticketingCustomer = null)
        {
            var request = new CreateTicketingCustomerRequest()
            {
                ConnectionId = connectionId,
                TicketingCustomer = ticketingCustomer,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ticketing/{connection_id}/customer", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "TicketingCustomer", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new CreateTicketingCustomerResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TicketingCustomer = JsonConvert.DeserializeObject<TicketingCustomer>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<CreateTicketingNoteResponse> CreateTicketingNoteAsync(CreateTicketingNoteSecurity security, string connectionId, TicketingNote? ticketingNote = null)
        {
            var request = new CreateTicketingNoteRequest()
            {
                ConnectionId = connectionId,
                TicketingNote = ticketingNote,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ticketing/{connection_id}/note", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "TicketingNote", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new CreateTicketingNoteResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TicketingNote = JsonConvert.DeserializeObject<TicketingNote>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<CreateTicketingTicketResponse> CreateTicketingTicketAsync(CreateTicketingTicketSecurity security, string connectionId, TicketingTicket? ticketingTicket = null)
        {
            var request = new CreateTicketingTicketRequest()
            {
                ConnectionId = connectionId,
                TicketingTicket = ticketingTicket,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ticketing/{connection_id}/ticket", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "TicketingTicket", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new CreateTicketingTicketResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TicketingTicket = JsonConvert.DeserializeObject<TicketingTicket>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<GetTicketingCustomerResponse> GetTicketingCustomerAsync(GetTicketingCustomerSecurity security, string connectionId, string id, List<string>? fields = null)
        {
            var request = new GetTicketingCustomerRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                Fields = fields,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ticketing/{connection_id}/customer/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new GetTicketingCustomerResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TicketingCustomer = JsonConvert.DeserializeObject<TicketingCustomer>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<GetTicketingNoteResponse> GetTicketingNoteAsync(GetTicketingNoteSecurity security, string connectionId, string id, List<string>? fields = null)
        {
            var request = new GetTicketingNoteRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                Fields = fields,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ticketing/{connection_id}/note/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new GetTicketingNoteResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TicketingNote = JsonConvert.DeserializeObject<TicketingNote>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<GetTicketingTicketResponse> GetTicketingTicketAsync(GetTicketingTicketSecurity security, string connectionId, string id, List<string>? fields = null)
        {
            var request = new GetTicketingTicketRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                Fields = fields,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ticketing/{connection_id}/ticket/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new GetTicketingTicketResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TicketingTicket = JsonConvert.DeserializeObject<TicketingTicket>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<ListTicketingCustomersResponse> ListTicketingCustomersAsync(ListTicketingCustomersSecurity security, ListTicketingCustomersRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ticketing/{connection_id}/customer", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new ListTicketingCustomersResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TicketingCustomers = JsonConvert.DeserializeObject<List<TicketingCustomer>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<ListTicketingNotesResponse> ListTicketingNotesAsync(ListTicketingNotesSecurity security, ListTicketingNotesRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ticketing/{connection_id}/note", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new ListTicketingNotesResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TicketingNotes = JsonConvert.DeserializeObject<List<TicketingNote>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<ListTicketingTicketsResponse> ListTicketingTicketsAsync(ListTicketingTicketsSecurity security, ListTicketingTicketsRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ticketing/{connection_id}/ticket", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new ListTicketingTicketsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TicketingTickets = JsonConvert.DeserializeObject<List<TicketingTicket>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<PatchTicketingCustomerResponse> PatchTicketingCustomerAsync(PatchTicketingCustomerSecurity security, string connectionId, string id, TicketingCustomer? ticketingCustomer = null)
        {
            var request = new PatchTicketingCustomerRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                TicketingCustomer = ticketingCustomer,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ticketing/{connection_id}/customer/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Patch, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "TicketingCustomer", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new PatchTicketingCustomerResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TicketingCustomer = JsonConvert.DeserializeObject<TicketingCustomer>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<PatchTicketingNoteResponse> PatchTicketingNoteAsync(PatchTicketingNoteSecurity security, string connectionId, string id, TicketingNote? ticketingNote = null)
        {
            var request = new PatchTicketingNoteRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                TicketingNote = ticketingNote,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ticketing/{connection_id}/note/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Patch, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "TicketingNote", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new PatchTicketingNoteResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TicketingNote = JsonConvert.DeserializeObject<TicketingNote>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<PatchTicketingTicketResponse> PatchTicketingTicketAsync(PatchTicketingTicketSecurity security, string connectionId, string id, TicketingTicket? ticketingTicket = null)
        {
            var request = new PatchTicketingTicketRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                TicketingTicket = ticketingTicket,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ticketing/{connection_id}/ticket/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Patch, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "TicketingTicket", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new PatchTicketingTicketResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TicketingTicket = JsonConvert.DeserializeObject<TicketingTicket>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<RemoveTicketingCustomerResponse> RemoveTicketingCustomerAsync(RemoveTicketingCustomerSecurity security, string connectionId, string id)
        {
            var request = new RemoveTicketingCustomerRequest()
            {
                ConnectionId = connectionId,
                Id = id,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ticketing/{connection_id}/customer/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new RemoveTicketingCustomerResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            throw new InvalidOperationException("API returned unexpected status code or content type");
        }

        

        public async Task<RemoveTicketingNoteResponse> RemoveTicketingNoteAsync(RemoveTicketingNoteSecurity security, string connectionId, string id)
        {
            var request = new RemoveTicketingNoteRequest()
            {
                ConnectionId = connectionId,
                Id = id,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ticketing/{connection_id}/note/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new RemoveTicketingNoteResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            throw new InvalidOperationException("API returned unexpected status code or content type");
        }

        

        public async Task<RemoveTicketingTicketResponse> RemoveTicketingTicketAsync(RemoveTicketingTicketSecurity security, string connectionId, string id)
        {
            var request = new RemoveTicketingTicketRequest()
            {
                ConnectionId = connectionId,
                Id = id,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ticketing/{connection_id}/ticket/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new RemoveTicketingTicketResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            throw new InvalidOperationException("API returned unexpected status code or content type");
        }

        

        public async Task<UpdateTicketingCustomerResponse> UpdateTicketingCustomerAsync(UpdateTicketingCustomerSecurity security, string connectionId, string id, TicketingCustomer? ticketingCustomer = null)
        {
            var request = new UpdateTicketingCustomerRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                TicketingCustomer = ticketingCustomer,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ticketing/{connection_id}/customer/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "TicketingCustomer", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new UpdateTicketingCustomerResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TicketingCustomer = JsonConvert.DeserializeObject<TicketingCustomer>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<UpdateTicketingNoteResponse> UpdateTicketingNoteAsync(UpdateTicketingNoteSecurity security, string connectionId, string id, TicketingNote? ticketingNote = null)
        {
            var request = new UpdateTicketingNoteRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                TicketingNote = ticketingNote,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ticketing/{connection_id}/note/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "TicketingNote", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new UpdateTicketingNoteResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TicketingNote = JsonConvert.DeserializeObject<TicketingNote>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<UpdateTicketingTicketResponse> UpdateTicketingTicketAsync(UpdateTicketingTicketSecurity security, string connectionId, string id, TicketingTicket? ticketingTicket = null)
        {
            var request = new UpdateTicketingTicketRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                TicketingTicket = ticketingTicket,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/ticketing/{connection_id}/ticket/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "TicketingTicket", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = SecuritySerializer.Apply(_defaultClient, () => security);

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new UpdateTicketingTicketResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TicketingTicket = JsonConvert.DeserializeObject<TicketingTicket>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        
    }
}