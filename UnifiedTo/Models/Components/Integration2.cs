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
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Reflection;
    using UnifiedTo.Models.Components;
    using UnifiedTo.Utils;
    

    public class Integration2Type
    {
        private Integration2Type(string value) { Value = value; }

        public string Value { get; private set; }
        public static Integration2Type Str { get { return new Integration2Type("str"); } }
        
        public static Integration2Type IntegrationSchemasApi22 { get { return new Integration2Type("Integration_Schemas_api_2_2"); } }
        
        public static Integration2Type Null { get { return new Integration2Type("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(Integration2Type v) { return v.Value; }
        public static Integration2Type FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "Integration_Schemas_api_2_2": return IntegrationSchemasApi22;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for Integration2Type");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((Integration2Type)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(Integration2.Integration2Converter))]
    public class Integration2 {
        public Integration2(Integration2Type type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public IntegrationSchemasApi22? IntegrationSchemasApi22 { get; set; }

        public Integration2Type Type { get; set; }


        public static Integration2 CreateStr(string str) {
            Integration2Type typ = Integration2Type.Str;

            Integration2 res = new Integration2(typ);
            res.Str = str;
            return res;
        }

        public static Integration2 CreateIntegrationSchemasApi22(IntegrationSchemasApi22 integrationSchemasAPI22) {
            Integration2Type typ = Integration2Type.IntegrationSchemasApi22;

            Integration2 res = new Integration2(typ);
            res.IntegrationSchemasApi22 = integrationSchemasAPI22;
            return res;
        }

        public static Integration2 CreateNull() {
            Integration2Type typ = Integration2Type.Null;
            return new Integration2(typ);
        }

        public class Integration2Converter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(Integration2);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            {
                var json = JRaw.Create(reader).ToString();
                if (json == "null")
                {
                    return null;
                }

                var fallbackCandidates = new List<(System.Type, object, string)>();

                try
                {
                    return new Integration2(Integration2Type.IntegrationSchemasApi22)
                    {
                        IntegrationSchemasApi22 = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<IntegrationSchemasApi22>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(IntegrationSchemasApi22), new Integration2(Integration2Type.IntegrationSchemasApi22), "IntegrationSchemasApi22"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
                }

                if (json[0] == '"' && json[^1] == '"'){
                    return new Integration2(Integration2Type.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                if (fallbackCandidates.Count > 0)
                {
                    fallbackCandidates.Sort((a, b) => ResponseBodyDeserializer.CompareFallbackCandidates(a.Item1, b.Item1, json));
                    foreach(var (deserializationType, returnObject, propertyName) in fallbackCandidates)
                    {
                        try
                        {
                            return ResponseBodyDeserializer.DeserializeUndiscriminatedUnionFallback(deserializationType, returnObject, propertyName, json);
                        }
                        catch (ResponseBodyDeserializer.DeserializationException)
                        {
                            // try next fallback option
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }

                throw new InvalidOperationException("Could not deserialize into any supported types.");
            }

            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                if (value == null) {
                    writer.WriteRawValue("null");
                    return;
                }
                Integration2 res = (Integration2)value;
                if (Integration2Type.FromString(res.Type).Equals(Integration2Type.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.Str != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Str));
                    return;
                }
                if (res.IntegrationSchemasApi22 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.IntegrationSchemasApi22));
                    return;
                }

            }

        }

    }
}