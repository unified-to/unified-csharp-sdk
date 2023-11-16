
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

    public interface IHris
    {

        /// <summary>
        /// Create an employee
        /// </summary>
        Task<CreateHrisEmployeeResponse> CreateHrisEmployeeAsync(string connectionId, HrisEmployee? hrisEmployee = null);

        /// <summary>
        /// Create a group
        /// </summary>
        Task<CreateHrisGroupResponse> CreateHrisGroupAsync(string connectionId, HrisGroup? hrisGroup = null);

        /// <summary>
        /// Retrieve an employee
        /// </summary>
        Task<GetHrisEmployeeResponse> GetHrisEmployeeAsync(string connectionId, string id, List<string>? fields = null);

        /// <summary>
        /// Retrieve a group
        /// </summary>
        Task<GetHrisGroupResponse> GetHrisGroupAsync(string connectionId, string id, List<string>? fields = null);

        /// <summary>
        /// List all employees
        /// </summary>
        Task<ListHrisEmployeesResponse> ListHrisEmployeesAsync(ListHrisEmployeesRequest? request = null);

        /// <summary>
        /// List all groups
        /// </summary>
        Task<ListHrisGroupsResponse> ListHrisGroupsAsync(ListHrisGroupsRequest? request = null);

        /// <summary>
        /// Update an employee
        /// </summary>
        Task<PatchHrisEmployeeResponse> PatchHrisEmployeeAsync(string connectionId, string id, HrisEmployee? hrisEmployee = null);

        /// <summary>
        /// Update a group
        /// </summary>
        Task<PatchHrisGroupResponse> PatchHrisGroupAsync(string connectionId, string id, HrisGroup? hrisGroup = null);

        /// <summary>
        /// Remove an employee
        /// </summary>
        Task<RemoveHrisEmployeeResponse> RemoveHrisEmployeeAsync(string connectionId, string id);

        /// <summary>
        /// Remove a group
        /// </summary>
        Task<RemoveHrisGroupResponse> RemoveHrisGroupAsync(string connectionId, string id);

        /// <summary>
        /// Update an employee
        /// </summary>
        Task<UpdateHrisEmployeeResponse> UpdateHrisEmployeeAsync(string connectionId, string id, HrisEmployee? hrisEmployee = null);

        /// <summary>
        /// Update a group
        /// </summary>
        Task<UpdateHrisGroupResponse> UpdateHrisGroupAsync(string connectionId, string id, HrisGroup? hrisGroup = null);
    }

    public class Hris: IHris
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.1.0";
        private const string _sdkGenVersion = "2.192.1";
        private const string _openapiDocVersion = "1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.1.0 2.192.1 1.0 Unified-csharp-sdk";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public Hris(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
        }
        

        public async Task<CreateHrisEmployeeResponse> CreateHrisEmployeeAsync(string connectionId, HrisEmployee? hrisEmployee = null)
        {
            var request = new CreateHrisEmployeeRequest()
            {
                ConnectionId = connectionId,
                HrisEmployee = hrisEmployee,
            };
            string baseUrl = this.Config.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/hris/{connection_id}/employee", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "HrisEmployee", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new CreateHrisEmployeeResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.HrisEmployee = JsonConvert.DeserializeObject<HrisEmployee>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<CreateHrisGroupResponse> CreateHrisGroupAsync(string connectionId, HrisGroup? hrisGroup = null)
        {
            var request = new CreateHrisGroupRequest()
            {
                ConnectionId = connectionId,
                HrisGroup = hrisGroup,
            };
            string baseUrl = this.Config.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/hris/{connection_id}/group", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "HrisGroup", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new CreateHrisGroupResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.HrisGroup = JsonConvert.DeserializeObject<HrisGroup>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetHrisEmployeeResponse> GetHrisEmployeeAsync(string connectionId, string id, List<string>? fields = null)
        {
            var request = new GetHrisEmployeeRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                Fields = fields,
            };
            string baseUrl = this.Config.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/hris/{connection_id}/employee/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetHrisEmployeeResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.HrisEmployee = JsonConvert.DeserializeObject<HrisEmployee>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetHrisGroupResponse> GetHrisGroupAsync(string connectionId, string id, List<string>? fields = null)
        {
            var request = new GetHrisGroupRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                Fields = fields,
            };
            string baseUrl = this.Config.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/hris/{connection_id}/group/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetHrisGroupResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.HrisGroup = JsonConvert.DeserializeObject<HrisGroup>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<ListHrisEmployeesResponse> ListHrisEmployeesAsync(ListHrisEmployeesRequest? request = null)
        {
            string baseUrl = this.Config.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/hris/{connection_id}/employee", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new ListHrisEmployeesResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.HrisEmployees = JsonConvert.DeserializeObject<List<HrisEmployee>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<ListHrisGroupsResponse> ListHrisGroupsAsync(ListHrisGroupsRequest? request = null)
        {
            string baseUrl = this.Config.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/hris/{connection_id}/group", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new ListHrisGroupsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.HrisGroups = JsonConvert.DeserializeObject<List<HrisGroup>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<PatchHrisEmployeeResponse> PatchHrisEmployeeAsync(string connectionId, string id, HrisEmployee? hrisEmployee = null)
        {
            var request = new PatchHrisEmployeeRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                HrisEmployee = hrisEmployee,
            };
            string baseUrl = this.Config.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/hris/{connection_id}/employee/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Patch, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "HrisEmployee", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new PatchHrisEmployeeResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.HrisEmployee = JsonConvert.DeserializeObject<HrisEmployee>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<PatchHrisGroupResponse> PatchHrisGroupAsync(string connectionId, string id, HrisGroup? hrisGroup = null)
        {
            var request = new PatchHrisGroupRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                HrisGroup = hrisGroup,
            };
            string baseUrl = this.Config.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/hris/{connection_id}/group/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Patch, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "HrisGroup", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new PatchHrisGroupResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.HrisGroup = JsonConvert.DeserializeObject<HrisGroup>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<RemoveHrisEmployeeResponse> RemoveHrisEmployeeAsync(string connectionId, string id)
        {
            var request = new RemoveHrisEmployeeRequest()
            {
                ConnectionId = connectionId,
                Id = id,
            };
            string baseUrl = this.Config.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/hris/{connection_id}/employee/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new RemoveHrisEmployeeResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            throw new InvalidOperationException("API returned unexpected status code or content type");
        }
        

        public async Task<RemoveHrisGroupResponse> RemoveHrisGroupAsync(string connectionId, string id)
        {
            var request = new RemoveHrisGroupRequest()
            {
                ConnectionId = connectionId,
                Id = id,
            };
            string baseUrl = this.Config.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/hris/{connection_id}/group/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new RemoveHrisGroupResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            throw new InvalidOperationException("API returned unexpected status code or content type");
        }
        

        public async Task<UpdateHrisEmployeeResponse> UpdateHrisEmployeeAsync(string connectionId, string id, HrisEmployee? hrisEmployee = null)
        {
            var request = new UpdateHrisEmployeeRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                HrisEmployee = hrisEmployee,
            };
            string baseUrl = this.Config.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/hris/{connection_id}/employee/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "HrisEmployee", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new UpdateHrisEmployeeResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.HrisEmployee = JsonConvert.DeserializeObject<HrisEmployee>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<UpdateHrisGroupResponse> UpdateHrisGroupAsync(string connectionId, string id, HrisGroup? hrisGroup = null)
        {
            var request = new UpdateHrisGroupRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                HrisGroup = hrisGroup,
            };
            string baseUrl = this.Config.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/hris/{connection_id}/group/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "HrisGroup", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new UpdateHrisGroupResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.HrisGroup = JsonConvert.DeserializeObject<HrisGroup>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        
    }
}