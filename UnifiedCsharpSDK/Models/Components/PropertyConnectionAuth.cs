
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace UnifiedCsharpSDK.Models.Components
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// An authentication object that represents a specific authorized user&apos;s connection to an integration.
    /// </summary>
    public class PropertyConnectionAuth
    {

        [JsonProperty("access_token")]
        public string? AccessToken { get; set; }

        [JsonProperty("api_url")]
        public string? ApiUrl { get; set; }

        [JsonProperty("app_id")]
        public string? AppId { get; set; }

        [JsonProperty("authorize_url")]
        public string? AuthorizeUrl { get; set; }

        [JsonProperty("client_id")]
        public string? ClientId { get; set; }

        [JsonProperty("client_secret")]
        public string? ClientSecret { get; set; }

        [JsonProperty("consumer_key")]
        public string? ConsumerKey { get; set; }

        [JsonProperty("consumer_secret")]
        public string? ConsumerSecret { get; set; }

        [JsonProperty("emails")]
        public List<string>? Emails { get; set; }

        [JsonProperty("expires_in")]
        public double? ExpiresIn { get; set; }

        [JsonProperty("expiry_date")]
        public DateTime? ExpiryDate { get; set; }

        [JsonProperty("key")]
        public string? Key { get; set; }

        [JsonProperty("meta")]
        public PropertyPropertyConnectionAuthMeta? Meta { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// When integration.auth_type = &quot;other&quot;, this field contains the authentication credentials in the same order as token_names
        /// </summary>
        [JsonProperty("other_auth_info")]
        public List<string>? OtherAuthInfo { get; set; }

        [JsonProperty("pem")]
        public string? Pem { get; set; }

        [JsonProperty("refresh_token")]
        public string? RefreshToken { get; set; }

        [JsonProperty("refresh_token_expires_date")]
        public DateTime? RefreshTokenExpiresDate { get; set; }

        [JsonProperty("refresh_token_expires_in")]
        public double? RefreshTokenExpiresIn { get; set; }

        [JsonProperty("state")]
        public string? State { get; set; }

        [JsonProperty("token")]
        public string? Token { get; set; }

        [JsonProperty("token_url")]
        public string? TokenUrl { get; set; }
    }
}