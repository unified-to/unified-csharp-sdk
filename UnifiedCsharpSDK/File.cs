
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

    public interface IFile
    {

        /// <summary>
        /// Create a file
        /// </summary>
        Task<CreateCrmFileResponse> CreateCrmFileAsync(string connectionId, CrmFile? crmFile = null);

        /// <summary>
        /// Create a file
        /// </summary>
        Task<CreateStorageFileResponse> CreateStorageFileAsync(string connectionId, StorageFile? storageFile = null);

        /// <summary>
        /// Retrieve a file
        /// </summary>
        Task<GetCrmFileResponse> GetCrmFileAsync(string connectionId, string id, List<string>? fields = null);

        /// <summary>
        /// Retrieve a file
        /// </summary>
        Task<GetStorageFileResponse> GetStorageFileAsync(string connectionId, string id, List<string>? fields = null);

        /// <summary>
        /// List all files
        /// </summary>
        Task<ListCrmFilesResponse> ListCrmFilesAsync(ListCrmFilesRequest? request = null);

        /// <summary>
        /// List all files
        /// </summary>
        Task<ListStorageFilesResponse> ListStorageFilesAsync(ListStorageFilesRequest? request = null);

        /// <summary>
        /// Update a file
        /// </summary>
        Task<PatchCrmFileResponse> PatchCrmFileAsync(string connectionId, string id, CrmFile? crmFile = null);

        /// <summary>
        /// Update a file
        /// </summary>
        Task<PatchStorageFileResponse> PatchStorageFileAsync(string connectionId, string id, StorageFile? storageFile = null);

        /// <summary>
        /// Remove a file
        /// </summary>
        Task<RemoveCrmFileResponse> RemoveCrmFileAsync(string connectionId, string id);

        /// <summary>
        /// Remove a file
        /// </summary>
        Task<RemoveStorageFileResponse> RemoveStorageFileAsync(string connectionId, string id);

        /// <summary>
        /// Update a file
        /// </summary>
        Task<UpdateCrmFileResponse> UpdateCrmFileAsync(string connectionId, string id, CrmFile? crmFile = null);

        /// <summary>
        /// Update a file
        /// </summary>
        Task<UpdateStorageFileResponse> UpdateStorageFileAsync(string connectionId, string id, StorageFile? storageFile = null);
    }

    public class File: IFile
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.3.3";
        private const string _sdkGenVersion = "2.225.2";
        private const string _openapiDocVersion = "1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.3.3 2.225.2 1.0 Unified-csharp-sdk";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public File(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<CreateCrmFileResponse> CreateCrmFileAsync(string connectionId, CrmFile? crmFile = null)
        {
            var request = new CreateCrmFileRequest()
            {
                ConnectionId = connectionId,
                CrmFile = crmFile,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/crm/{connection_id}/file", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "CrmFile", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new CreateCrmFileResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CrmFile = JsonConvert.DeserializeObject<CrmFile>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<CreateStorageFileResponse> CreateStorageFileAsync(string connectionId, StorageFile? storageFile = null)
        {
            var request = new CreateStorageFileRequest()
            {
                ConnectionId = connectionId,
                StorageFile = storageFile,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/storage/{connection_id}/file", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "StorageFile", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new CreateStorageFileResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.StorageFile = JsonConvert.DeserializeObject<StorageFile>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetCrmFileResponse> GetCrmFileAsync(string connectionId, string id, List<string>? fields = null)
        {
            var request = new GetCrmFileRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                Fields = fields,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/crm/{connection_id}/file/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetCrmFileResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CrmFile = JsonConvert.DeserializeObject<CrmFile>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetStorageFileResponse> GetStorageFileAsync(string connectionId, string id, List<string>? fields = null)
        {
            var request = new GetStorageFileRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                Fields = fields,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/storage/{connection_id}/file/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetStorageFileResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.StorageFile = JsonConvert.DeserializeObject<StorageFile>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<ListCrmFilesResponse> ListCrmFilesAsync(ListCrmFilesRequest? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/crm/{connection_id}/file", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new ListCrmFilesResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CrmFiles = JsonConvert.DeserializeObject<List<CrmFile>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<ListStorageFilesResponse> ListStorageFilesAsync(ListStorageFilesRequest? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/storage/{connection_id}/file", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new ListStorageFilesResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.StorageFiles = JsonConvert.DeserializeObject<List<StorageFile>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<PatchCrmFileResponse> PatchCrmFileAsync(string connectionId, string id, CrmFile? crmFile = null)
        {
            var request = new PatchCrmFileRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                CrmFile = crmFile,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/crm/{connection_id}/file/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Patch, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "CrmFile", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new PatchCrmFileResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CrmFile = JsonConvert.DeserializeObject<CrmFile>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<PatchStorageFileResponse> PatchStorageFileAsync(string connectionId, string id, StorageFile? storageFile = null)
        {
            var request = new PatchStorageFileRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                StorageFile = storageFile,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/storage/{connection_id}/file/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Patch, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "StorageFile", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new PatchStorageFileResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.StorageFile = JsonConvert.DeserializeObject<StorageFile>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<RemoveCrmFileResponse> RemoveCrmFileAsync(string connectionId, string id)
        {
            var request = new RemoveCrmFileRequest()
            {
                ConnectionId = connectionId,
                Id = id,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/crm/{connection_id}/file/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new RemoveCrmFileResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            throw new InvalidOperationException("API returned unexpected status code or content type");
        }
        

        public async Task<RemoveStorageFileResponse> RemoveStorageFileAsync(string connectionId, string id)
        {
            var request = new RemoveStorageFileRequest()
            {
                ConnectionId = connectionId,
                Id = id,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/storage/{connection_id}/file/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new RemoveStorageFileResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            throw new InvalidOperationException("API returned unexpected status code or content type");
        }
        

        public async Task<UpdateCrmFileResponse> UpdateCrmFileAsync(string connectionId, string id, CrmFile? crmFile = null)
        {
            var request = new UpdateCrmFileRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                CrmFile = crmFile,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/crm/{connection_id}/file/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "CrmFile", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new UpdateCrmFileResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CrmFile = JsonConvert.DeserializeObject<CrmFile>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<UpdateStorageFileResponse> UpdateStorageFileAsync(string connectionId, string id, StorageFile? storageFile = null)
        {
            var request = new UpdateStorageFileRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                StorageFile = storageFile,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/storage/{connection_id}/file/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "StorageFile", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new UpdateStorageFileResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.StorageFile = JsonConvert.DeserializeObject<StorageFile>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        
    }
}