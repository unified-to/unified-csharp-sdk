//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace UnifiedTo.Models.Components
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using UnifiedTo.Models.Components;
    using UnifiedTo.Utils;
    
    public class StoragePermission
    {

        [JsonProperty("group_id")]
        public string? GroupId { get; set; }

        [JsonProperty("is_hidden")]
        public bool? IsHidden { get; set; }

        [JsonProperty("is_public")]
        public bool? IsPublic { get; set; }

        [JsonProperty("roles")]
        public List<PropertyStoragePermissionRoles> Roles { get; set; } = default!;

        [JsonProperty("user_id")]
        public string? UserId { get; set; }
    }
}