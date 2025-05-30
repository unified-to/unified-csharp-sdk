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
    

    public class CommerceMetadataSchemas5Type
    {
        private CommerceMetadataSchemas5Type(string value) { Value = value; }

        public string Value { get; private set; }
        public static CommerceMetadataSchemas5Type ArrayOfAny { get { return new CommerceMetadataSchemas5Type("arrayOfAny"); } }
        
        public static CommerceMetadataSchemas5Type CommerceMetadataSchemasValue52 { get { return new CommerceMetadataSchemas5Type("CommerceMetadata_Schemas_value_5_2"); } }
        
        public static CommerceMetadataSchemas5Type Null { get { return new CommerceMetadataSchemas5Type("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(CommerceMetadataSchemas5Type v) { return v.Value; }
        public static CommerceMetadataSchemas5Type FromString(string v) {
            switch(v) {
                case "arrayOfAny": return ArrayOfAny;
                case "CommerceMetadata_Schemas_value_5_2": return CommerceMetadataSchemasValue52;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for CommerceMetadataSchemas5Type");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((CommerceMetadataSchemas5Type)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(CommerceMetadataSchemas5.CommerceMetadataSchemas5Converter))]
    public class CommerceMetadataSchemas5 {
        public CommerceMetadataSchemas5(CommerceMetadataSchemas5Type type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public List<object>? ArrayOfAny { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public CommerceMetadataSchemasValue52? CommerceMetadataSchemasValue52 { get; set; }

        public CommerceMetadataSchemas5Type Type { get; set; }


        public static CommerceMetadataSchemas5 CreateArrayOfAny(List<object> arrayOfAny) {
            CommerceMetadataSchemas5Type typ = CommerceMetadataSchemas5Type.ArrayOfAny;

            CommerceMetadataSchemas5 res = new CommerceMetadataSchemas5(typ);
            res.ArrayOfAny = arrayOfAny;
            return res;
        }

        public static CommerceMetadataSchemas5 CreateCommerceMetadataSchemasValue52(CommerceMetadataSchemasValue52 commerceMetadataSchemasValue52) {
            CommerceMetadataSchemas5Type typ = CommerceMetadataSchemas5Type.CommerceMetadataSchemasValue52;

            CommerceMetadataSchemas5 res = new CommerceMetadataSchemas5(typ);
            res.CommerceMetadataSchemasValue52 = commerceMetadataSchemasValue52;
            return res;
        }

        public static CommerceMetadataSchemas5 CreateNull() {
            CommerceMetadataSchemas5Type typ = CommerceMetadataSchemas5Type.Null;
            return new CommerceMetadataSchemas5(typ);
        }

        public class CommerceMetadataSchemas5Converter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(CommerceMetadataSchemas5);

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
                    return new CommerceMetadataSchemas5(CommerceMetadataSchemas5Type.CommerceMetadataSchemasValue52)
                    {
                        CommerceMetadataSchemasValue52 = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<CommerceMetadataSchemasValue52>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(CommerceMetadataSchemasValue52), new CommerceMetadataSchemas5(CommerceMetadataSchemas5Type.CommerceMetadataSchemasValue52), "CommerceMetadataSchemasValue52"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
                }

                try
                {
                    return new CommerceMetadataSchemas5(CommerceMetadataSchemas5Type.ArrayOfAny)
                    {
                        ArrayOfAny = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<object>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<object>), new CommerceMetadataSchemas5(CommerceMetadataSchemas5Type.ArrayOfAny), "ArrayOfAny"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
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
                CommerceMetadataSchemas5 res = (CommerceMetadataSchemas5)value;
                if (CommerceMetadataSchemas5Type.FromString(res.Type).Equals(CommerceMetadataSchemas5Type.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.ArrayOfAny != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ArrayOfAny));
                    return;
                }
                if (res.CommerceMetadataSchemasValue52 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.CommerceMetadataSchemasValue52));
                    return;
                }

            }

        }

    }
}