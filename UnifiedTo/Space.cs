//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace UnifiedTo
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using UnifiedTo.Hooks;
    using UnifiedTo.Models.Components;
    using UnifiedTo.Models.Errors;
    using UnifiedTo.Models.Requests;
    using UnifiedTo.Utils;
    using UnifiedTo.Utils.Retries;

    public interface ISpace
    {

        /// <summary>
        /// Create a space
        /// </summary>
        Task<CreateKmsSpaceResponse> CreateKmsSpaceAsync(KmsSpace kmsSpace, string connectionId, List<string>? fields = null);

        /// <summary>
        /// Retrieve a space
        /// </summary>
        Task<GetKmsSpaceResponse> GetKmsSpaceAsync(string connectionId, string id, List<string>? fields = null);

        /// <summary>
        /// List all spaces
        /// </summary>
        Task<ListKmsSpacesResponse> ListKmsSpacesAsync(ListKmsSpacesRequest request);

        /// <summary>
        /// Update a space
        /// </summary>
        Task<PatchKmsSpaceResponse> PatchKmsSpaceAsync(KmsSpace kmsSpace, string connectionId, string id, List<string>? fields = null);

        /// <summary>
        /// Remove a space
        /// </summary>
        Task<RemoveKmsSpaceResponse> RemoveKmsSpaceAsync(string connectionId, string id);

        /// <summary>
        /// Update a space
        /// </summary>
        Task<UpdateKmsSpaceResponse> UpdateKmsSpaceAsync(KmsSpace kmsSpace, string connectionId, string id, List<string>? fields = null);
    }

    public class Space: ISpace
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.22.35";
        private const string _sdkGenVersion = "2.578.0";
        private const string _openapiDocVersion = "1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.22.35 2.578.0 1.0 UnifiedTo";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<UnifiedTo.Models.Components.Security>? _securitySource;

        public Space(ISpeakeasyHttpClient client, Func<UnifiedTo.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<CreateKmsSpaceResponse> CreateKmsSpaceAsync(KmsSpace kmsSpace, string connectionId, List<string>? fields = null)
        {
            var request = new CreateKmsSpaceRequest()
            {
                KmsSpace = kmsSpace,
                ConnectionId = connectionId,
                Fields = fields,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/kms/{connection_id}/space", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "KmsSpace", "json", false, false);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(baseUrl, "createKmsSpace", new List<string> {  }, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _client.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode >= 400 && _statusCode < 500 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<KmsSpace>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new CreateKmsSpaceResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.KmsSpace = obj;
                    return response;
                }

                throw new Models.Errors.SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500)
            {
                throw new Models.Errors.SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new Models.Errors.SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }

            throw new Models.Errors.SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
        }

        public async Task<GetKmsSpaceResponse> GetKmsSpaceAsync(string connectionId, string id, List<string>? fields = null)
        {
            var request = new GetKmsSpaceRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                Fields = fields,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/kms/{connection_id}/space/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(baseUrl, "getKmsSpace", new List<string> {  }, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _client.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode >= 400 && _statusCode < 500 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<KmsSpace>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new GetKmsSpaceResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.KmsSpace = obj;
                    return response;
                }

                throw new Models.Errors.SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500)
            {
                throw new Models.Errors.SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new Models.Errors.SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }

            throw new Models.Errors.SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
        }

        public async Task<ListKmsSpacesResponse> ListKmsSpacesAsync(ListKmsSpacesRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/kms/{connection_id}/space", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(baseUrl, "listKmsSpaces", new List<string> {  }, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _client.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode >= 400 && _statusCode < 500 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<List<KmsSpace>>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new ListKmsSpacesResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.KmsSpaces = obj;
                    return response;
                }

                throw new Models.Errors.SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500)
            {
                throw new Models.Errors.SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new Models.Errors.SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }

            throw new Models.Errors.SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
        }

        public async Task<PatchKmsSpaceResponse> PatchKmsSpaceAsync(KmsSpace kmsSpace, string connectionId, string id, List<string>? fields = null)
        {
            var request = new PatchKmsSpaceRequest()
            {
                KmsSpace = kmsSpace,
                ConnectionId = connectionId,
                Id = id,
                Fields = fields,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/kms/{connection_id}/space/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Patch, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "KmsSpace", "json", false, false);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(baseUrl, "patchKmsSpace", new List<string> {  }, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _client.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode >= 400 && _statusCode < 500 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<KmsSpace>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new PatchKmsSpaceResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.KmsSpace = obj;
                    return response;
                }

                throw new Models.Errors.SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500)
            {
                throw new Models.Errors.SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new Models.Errors.SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }

            throw new Models.Errors.SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
        }

        public async Task<RemoveKmsSpaceResponse> RemoveKmsSpaceAsync(string connectionId, string id)
        {
            var request = new RemoveKmsSpaceRequest()
            {
                ConnectionId = connectionId,
                Id = id,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/kms/{connection_id}/space/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(baseUrl, "removeKmsSpace", new List<string> {  }, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _client.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode >= 400 && _statusCode < 500 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {                
                return new RemoveKmsSpaceResponse()
                {
                    StatusCode = responseStatusCode,
                    ContentType = contentType,
                    RawResponse = httpResponse
                };
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500)
            {
                throw new Models.Errors.SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new Models.Errors.SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else
            {                
                return new RemoveKmsSpaceResponse()
                {
                    StatusCode = responseStatusCode,
                    ContentType = contentType,
                    RawResponse = httpResponse
                };
            }
        }

        public async Task<UpdateKmsSpaceResponse> UpdateKmsSpaceAsync(KmsSpace kmsSpace, string connectionId, string id, List<string>? fields = null)
        {
            var request = new UpdateKmsSpaceRequest()
            {
                KmsSpace = kmsSpace,
                ConnectionId = connectionId,
                Id = id,
                Fields = fields,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/kms/{connection_id}/space/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "KmsSpace", "json", false, false);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(baseUrl, "updateKmsSpace", new List<string> {  }, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _client.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode >= 400 && _statusCode < 500 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<KmsSpace>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new UpdateKmsSpaceResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.KmsSpace = obj;
                    return response;
                }

                throw new Models.Errors.SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500)
            {
                throw new Models.Errors.SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new Models.Errors.SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }

            throw new Models.Errors.SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
        }
    }
}