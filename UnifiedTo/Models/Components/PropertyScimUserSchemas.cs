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
    using System;
    using UnifiedTo.Utils;
    
    public enum PropertyScimUserSchemas
    {
        [JsonProperty("urn:ietf:params:scim:schemas:core:2.0:User")]
        UrnIetfParamsScimSchemasCore20User,
        [JsonProperty("urn:ietf:params:scim:schemas:extension:enterprise:2.0:User")]
        UrnIetfParamsScimSchemasExtensionEnterprise20User,
        [JsonProperty("urn:ietf:params:scim:schemas:extension:lattice:attributes:1.0:User")]
        UrnIetfParamsScimSchemasExtensionLatticeAttributes10User,
        [JsonProperty("urn:ietf:params:scim:schemas:extension:peakon:2.0:User")]
        UrnIetfParamsScimSchemasExtensionPeakon20User,
    }

    public static class PropertyScimUserSchemasExtension
    {
        public static string Value(this PropertyScimUserSchemas value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PropertyScimUserSchemas ToEnum(this string value)
        {
            foreach(var field in typeof(PropertyScimUserSchemas).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is PropertyScimUserSchemas)
                    {
                        return (PropertyScimUserSchemas)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum PropertyScimUserSchemas");
        }
    }

}