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

    public interface IRecording
    {

        /// <summary>
        /// Create a recording
        /// </summary>
        Task<CreateUcRecordingResponse> CreateUcRecordingAsync(UcRecording ucRecording, string connectionId, List<string>? fields = null, string? raw = null);

        /// <summary>
        /// Retrieve a recording
        /// </summary>
        Task<GetCalendarRecordingResponse> GetCalendarRecordingAsync(string connectionId, string id, List<string>? fields = null, string? raw = null);

        /// <summary>
        /// Retrieve a recording
        /// </summary>
        Task<GetUcRecordingResponse> GetUcRecordingAsync(string connectionId, string id, List<string>? fields = null, string? raw = null);

        /// <summary>
        /// List all recordings
        /// </summary>
        Task<ListCalendarRecordingsResponse> ListCalendarRecordingsAsync(ListCalendarRecordingsRequest request);

        /// <summary>
        /// List all recordings
        /// </summary>
        Task<ListUcRecordingsResponse> ListUcRecordingsAsync(ListUcRecordingsRequest request);

        /// <summary>
        /// Update a recording
        /// </summary>
        Task<PatchUcRecordingResponse> PatchUcRecordingAsync(PatchUcRecordingRequest request);

        /// <summary>
        /// Remove a recording
        /// </summary>
        Task<RemoveUcRecordingResponse> RemoveUcRecordingAsync(string connectionId, string id);

        /// <summary>
        /// Update a recording
        /// </summary>
        Task<UpdateUcRecordingResponse> UpdateUcRecordingAsync(UpdateUcRecordingRequest request);
    }

    public class Recording: IRecording
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.38.0";
        private const string _sdkGenVersion = "2.632.2";
        private const string _openapiDocVersion = "1.0";

        public Recording(SDKConfig config)
        {
            SDKConfiguration = config;
        }

        public async Task<CreateUcRecordingResponse> CreateUcRecordingAsync(UcRecording ucRecording, string connectionId, List<string>? fields = null, string? raw = null)
        {
            var request = new CreateUcRecordingRequest()
            {
                UcRecording = ucRecording,
                ConnectionId = connectionId,
                Fields = fields,
                Raw = raw,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/uc/{connection_id}/recording", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", SDKConfiguration.UserAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "UcRecording", "json", false, false);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            if (SDKConfiguration.SecuritySource != null)
            {
                httpRequest = new SecurityMetadata(SDKConfiguration.SecuritySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(SDKConfiguration, baseUrl, "createUcRecording", new List<string> {  }, SDKConfiguration.SecuritySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await SDKConfiguration.Client.SendAsync(httpRequest);
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
                    var obj = ResponseBodyDeserializer.Deserialize<UcRecording>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new CreateUcRecordingResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.UcRecording = obj;
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

        public async Task<GetCalendarRecordingResponse> GetCalendarRecordingAsync(string connectionId, string id, List<string>? fields = null, string? raw = null)
        {
            var request = new GetCalendarRecordingRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                Fields = fields,
                Raw = raw,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/calendar/{connection_id}/recording/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", SDKConfiguration.UserAgent);

            if (SDKConfiguration.SecuritySource != null)
            {
                httpRequest = new SecurityMetadata(SDKConfiguration.SecuritySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(SDKConfiguration, baseUrl, "getCalendarRecording", new List<string> {  }, SDKConfiguration.SecuritySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await SDKConfiguration.Client.SendAsync(httpRequest);
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
                    var obj = ResponseBodyDeserializer.Deserialize<CalendarRecording>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new GetCalendarRecordingResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.CalendarRecording = obj;
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

        public async Task<GetUcRecordingResponse> GetUcRecordingAsync(string connectionId, string id, List<string>? fields = null, string? raw = null)
        {
            var request = new GetUcRecordingRequest()
            {
                ConnectionId = connectionId,
                Id = id,
                Fields = fields,
                Raw = raw,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/uc/{connection_id}/recording/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", SDKConfiguration.UserAgent);

            if (SDKConfiguration.SecuritySource != null)
            {
                httpRequest = new SecurityMetadata(SDKConfiguration.SecuritySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(SDKConfiguration, baseUrl, "getUcRecording", new List<string> {  }, SDKConfiguration.SecuritySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await SDKConfiguration.Client.SendAsync(httpRequest);
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
                    var obj = ResponseBodyDeserializer.Deserialize<UcRecording>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new GetUcRecordingResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.UcRecording = obj;
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

        public async Task<ListCalendarRecordingsResponse> ListCalendarRecordingsAsync(ListCalendarRecordingsRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/calendar/{connection_id}/recording", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", SDKConfiguration.UserAgent);

            if (SDKConfiguration.SecuritySource != null)
            {
                httpRequest = new SecurityMetadata(SDKConfiguration.SecuritySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(SDKConfiguration, baseUrl, "listCalendarRecordings", new List<string> {  }, SDKConfiguration.SecuritySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await SDKConfiguration.Client.SendAsync(httpRequest);
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
                    var obj = ResponseBodyDeserializer.Deserialize<List<CalendarRecording>>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new ListCalendarRecordingsResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.CalendarRecordings = obj;
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

        public async Task<ListUcRecordingsResponse> ListUcRecordingsAsync(ListUcRecordingsRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/uc/{connection_id}/recording", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", SDKConfiguration.UserAgent);

            if (SDKConfiguration.SecuritySource != null)
            {
                httpRequest = new SecurityMetadata(SDKConfiguration.SecuritySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(SDKConfiguration, baseUrl, "listUcRecordings", new List<string> {  }, SDKConfiguration.SecuritySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await SDKConfiguration.Client.SendAsync(httpRequest);
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
                    var obj = ResponseBodyDeserializer.Deserialize<List<UcRecording>>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new ListUcRecordingsResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.UcRecordings = obj;
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

        public async Task<PatchUcRecordingResponse> PatchUcRecordingAsync(PatchUcRecordingRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/uc/{connection_id}/recording/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Patch, urlString);
            httpRequest.Headers.Add("user-agent", SDKConfiguration.UserAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "UcRecording", "json", false, false);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            if (SDKConfiguration.SecuritySource != null)
            {
                httpRequest = new SecurityMetadata(SDKConfiguration.SecuritySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(SDKConfiguration, baseUrl, "patchUcRecording", new List<string> {  }, SDKConfiguration.SecuritySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await SDKConfiguration.Client.SendAsync(httpRequest);
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
                    var obj = ResponseBodyDeserializer.Deserialize<UcRecording>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new PatchUcRecordingResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.UcRecording = obj;
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

        public async Task<RemoveUcRecordingResponse> RemoveUcRecordingAsync(string connectionId, string id)
        {
            var request = new RemoveUcRecordingRequest()
            {
                ConnectionId = connectionId,
                Id = id,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/uc/{connection_id}/recording/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", SDKConfiguration.UserAgent);

            if (SDKConfiguration.SecuritySource != null)
            {
                httpRequest = new SecurityMetadata(SDKConfiguration.SecuritySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(SDKConfiguration, baseUrl, "removeUcRecording", new List<string> {  }, SDKConfiguration.SecuritySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await SDKConfiguration.Client.SendAsync(httpRequest);
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
                return new RemoveUcRecordingResponse()
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
                return new RemoveUcRecordingResponse()
                {
                    StatusCode = responseStatusCode,
                    ContentType = contentType,
                    RawResponse = httpResponse
                };
            }
        }

        public async Task<UpdateUcRecordingResponse> UpdateUcRecordingAsync(UpdateUcRecordingRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/uc/{connection_id}/recording/{id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", SDKConfiguration.UserAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "UcRecording", "json", false, false);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            if (SDKConfiguration.SecuritySource != null)
            {
                httpRequest = new SecurityMetadata(SDKConfiguration.SecuritySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(SDKConfiguration, baseUrl, "updateUcRecording", new List<string> {  }, SDKConfiguration.SecuritySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await SDKConfiguration.Client.SendAsync(httpRequest);
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
                    var obj = ResponseBodyDeserializer.Deserialize<UcRecording>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new UpdateUcRecordingResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.UcRecording = obj;
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