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
    
    public enum PropertyPropertyUserUrnIetfParamsScimSchemasExtensionEnterprise20UserManagerType
    {
        [JsonProperty("direct")]
        Direct,
        [JsonProperty("indirect")]
        Indirect,
    }

    public static class PropertyPropertyUserUrnIetfParamsScimSchemasExtensionEnterprise20UserManagerTypeExtension
    {
        public static string Value(this PropertyPropertyUserUrnIetfParamsScimSchemasExtensionEnterprise20UserManagerType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PropertyPropertyUserUrnIetfParamsScimSchemasExtensionEnterprise20UserManagerType ToEnum(this string value)
        {
            foreach(var field in typeof(PropertyPropertyUserUrnIetfParamsScimSchemasExtensionEnterprise20UserManagerType).GetFields())
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

                    if (enumVal is PropertyPropertyUserUrnIetfParamsScimSchemasExtensionEnterprise20UserManagerType)
                    {
                        return (PropertyPropertyUserUrnIetfParamsScimSchemasExtensionEnterprise20UserManagerType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum PropertyPropertyUserUrnIetfParamsScimSchemasExtensionEnterprise20UserManagerType");
        }
    }

}